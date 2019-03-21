using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchImageCuttor.View
{
    public interface IBatchImageCutterView
    {
        void BeginProcess();

        void PrintCheckError(string errorMsg);

        void PrintErrorMessage(string errorMsg);

        void BatchBegin();

        void BeginFile(string file, int index, int total);

        void FinishFile(string file, int index, int total);

        void FailFile(string file, string cause, int index, int total);

        void BatchFinish();

        void EndProcess();
    }
}
