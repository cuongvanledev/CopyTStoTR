using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateTestReport.CopyTSToTR;


namespace UpdateTestReport
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please update Path");
                //return;
            }

            TestReport ts = new TestReport("spi");
            ts.removeOldTestResult("spi");
            ts.copyTSToTR("spi");
            AddResultPF T = new AddResultPF();
            T.addRS("spi");
            //Console.ReadKey();
        }

        
    }
}
