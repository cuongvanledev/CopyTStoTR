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
                Console.WriteLine("Please update module");
                Console.ReadKey();
                return;
            }
           
            string module = args[0].ToLower();
            Console.WriteLine("Module: " + module);
            TestReport ts = new TestReport(module);
            AddResultPF T = new AddResultPF();

            ts.removeOldTestResult(module);
            //T.removeFile(module);
            ts.copyTSToTR(module);
            
            T.addRS(module);
            Console.WriteLine("==================== DONE =================");
            Console.ReadKey();
        }

        
    }
}
