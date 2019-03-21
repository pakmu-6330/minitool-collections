using BatchImageCuttor.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BatchImageCuttor.Presentor
{
    public class BatchImageCutterPresentor
    {
        private static readonly HashSet<string> SUPPORTED_FORMAT = new HashSet<string>
        {
            "jpg",
            "png"
        };

        public string InputDirectory { get; set; }
        public string OutputDirectory { get; set; }
        public int OutputWidth { get; set; } = 250;
        public int OutputHeight { get; set; } = 250;
        public ImageFormat OutputFormat { get; set; } = ImageFormat.Jpeg;

        private readonly IBatchImageCutterView _view;

        public BatchImageCutterPresentor(IBatchImageCutterView view)
        {
            _view = view;
        }

        public bool Check()
        {
            bool success = true;

            if (string.IsNullOrWhiteSpace(InputDirectory))
            {
                _view.PrintCheckError("输入目录不能为空");
                success = false;
            }

            if (string.IsNullOrWhiteSpace(OutputDirectory))
            {
                _view.PrintCheckError("输出目录不能为空");
                success = false;
            }

            return success;
        }

        public void Begin()
        {
            Thread workThread = new Thread(new ThreadStart(ThreadEntry));
            workThread.Start();
        }

        private void ThreadEntry()
        {
            _view.BeginProcess();

            // 读取所有的图片列表
            DirectoryInfo inputDirInfo = new DirectoryInfo(InputDirectory);
            if (!inputDirInfo.Exists)
            {
                _view.PrintErrorMessage("输入目录：" + InputDirectory + " 不存在！");
                return;
            }

            DirectoryInfo outputDirInfo = new DirectoryInfo(OutputDirectory);
            if (!outputDirInfo.Exists)
            {
                try
                {
                    outputDirInfo.Create();
                }
                catch (Exception e)
                {
                    _view.PrintErrorMessage("创建输出目录：" + OutputDirectory + " 失败：" + e.Message);
                    return;
                }
            }

            List<FileInfo> imageFiles = new List<FileInfo>();
            FileInfo[] files = inputDirInfo.GetFiles();
            if (files == null)
            {
                files = new FileInfo[0];
            }

            foreach (FileInfo fileInfo in files)
            {
                string filename = fileInfo.Name;
                string extName = filename.Substring(filename.LastIndexOf('.') + 1).ToLower();
                if (SUPPORTED_FORMAT.Contains(extName))
                {
                    imageFiles.Add(fileInfo);
                }
            }

            // 逐个图片进行处理
            _view.BatchBegin();
            int totalSize = imageFiles.Count;
            for (int i = 0; i < totalSize; i++)
            {
                FileInfo fileInfo = imageFiles[i];
                _view.BeginFile(fileInfo.FullName, i, totalSize);

                // 读取图片
                Image rawImage;
                try
                {
                    using (FileStream fileStream = File.OpenRead(fileInfo.FullName))
                    {
                        rawImage = Image.FromStream(fileStream);
                    }
                }
                catch (Exception e)
                {
                    _view.FailFile(fileInfo.FullName, e.Message, i, totalSize);
                    continue;
                }

                // 处理图片，保存到新的图片当中
                Bitmap targetImage = new Bitmap(OutputWidth, OutputHeight);
                Graphics graphics = Graphics.FromImage(targetImage);

                // 计算图片的缩放比
                float xScale = rawImage.Width * 1.0f / OutputWidth;
                float yScale = rawImage.Height * 1.0f / OutputHeight;
                float minScale = xScale < yScale ? xScale : yScale;
                bool cutX = xScale > yScale;

                int targetWidth = (int)(rawImage.Width / minScale);
                int targetHeight = (int)(rawImage.Height / minScale);

                // 执行实际的画图逻辑
                Rectangle destRect = new Rectangle(0, 0, OutputWidth, OutputHeight);

                if (cutX)
                {
                    int offsetX = (targetWidth - OutputWidth) >> 1;
                    Rectangle srcRect = new Rectangle(offsetX, 0, (int)(OutputWidth * minScale), (int)(OutputHeight * minScale));
                    graphics.DrawImage(rawImage, destRect, srcRect, GraphicsUnit.Pixel);
                }
                else
                {
                    int offsetY = (targetHeight - OutputHeight) >> 1;
                    Rectangle srcRect = new Rectangle(0, offsetY, (int)(OutputWidth * minScale), (int)(OutputHeight * minScale));
                    graphics.DrawImage(rawImage, destRect, srcRect, GraphicsUnit.Pixel);
                }

                // 写入到目标文件
                string url = Path.Combine(OutputDirectory, "out_" + fileInfo.Name);
                try
                {
                    using (FileStream fs = File.OpenWrite(url))
                    {
                        targetImage.Save(fs, OutputFormat);
                    }
                    _view.FinishFile(fileInfo.FullName, i, totalSize);
                }
                catch (Exception e)
                {
                    _view.FailFile(fileInfo.FullName, e.Message, i, totalSize);
                }
            }

            _view.BatchFinish();
            _view.EndProcess();
        }
    }
}
