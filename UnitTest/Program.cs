using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Process commandProcess = new Process();
            commandProcess.StartInfo.FileName = "cmd";
            commandProcess.Start();
        }
    }
}
