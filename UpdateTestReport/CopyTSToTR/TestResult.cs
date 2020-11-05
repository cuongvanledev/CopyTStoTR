using System;
using System.Collections.Generic;
using System.IO;
using UpdateTestReport.Repo.Constant;
using System.Text.RegularExpressions;

namespace UpdateTestReport.CopyTSToTR
{
    class TestReport
    {
        string module = "";
        private WorkSpace ws = null;
        private TestPlan tp = new TestPlan();
        private TestResult tr = new TestResult();
        public TestReport(string module)
        {
            ws = new WorkSpace(module);
        }

        // Copy all file in Test Plan to Test Report
        public void copyTSToTR(string module)
        {
            List<string> TestPL = tp.TestSpec[module];

            foreach (string file in TestPL)
            {
                //string newFile = file.Replace("TS", "TR").Replace(".xlsm", "_U2A8_Beta.xlsm");
                if (Regex.Match(file, @"Common").Success)
                {
                    File.Copy(ws.wsTP + "Common\\" + file, ws.wsTR + file, true);
                } else if(Regex.Match(file, @"E2x").Success)
                {
                    File.Copy(ws.wsTP + "E2x\\" + file, ws.wsTR + file, true);
                } else if(Regex.Match(file, @"U2x").Success)
                {
                    File.Copy(ws.wsTP + "U2x\\" + file, ws.wsTR + file, true);
                }
                Console.WriteLine("New File: " + file);
                
            }
        }

        public int removeOldTestResult(string module)
        {
            Dictionary<string, string> TestRe = tr.TestRe[module];

            foreach (string file in TestRe.Keys)
            {
                File.Delete(ws.wsTR + file);
            }
            return 0;
        }


    }
}
