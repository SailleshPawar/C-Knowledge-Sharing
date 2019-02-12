using ReusableLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConsoleApp
{

    /// <summary>
    /// This app uses the ReUsable Library for Delegate example in Console application
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            DataProgress csvFileProgress = new DataProgress();
            csvFileProgress.updateUi += ShowProgress;
            csvFileProgress.Upload();
        }
        public  static void ShowProgress(string message)
        {
            Console.WriteLine(message);

        }
    }
}
