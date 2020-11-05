using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UpdateTestReport.Repo.Constant;

namespace UpdateTestReport.CopyTSToTR
{
    class AddResultPF
    {
        public void addRS(string module)
        {
            
            WorkSpace ws = new WorkSpace(module);
            TestPlan ts = new TestPlan();
            Application excel = new Application();
            TestResult tr = new TestResult();

            foreach (string file in ts.TestSpec[module])
            {
                Console.WriteLine("===================================");
                Workbook wb = excel.Workbooks.Open(ws.wsTR + file);
                string newFile = file.Replace("TS", "TR").Replace(".xlsm", "_U2A8_Beta.xlsm");
                Console.WriteLine("DANG LAM O FILE: " + newFile);
                //Worksheet sheetNames = wb.Worksheets;
                foreach (Worksheet sheetName in wb.Worksheets)
                {
                    if("Cover" == sheetName.Name)
                    {
                        // Fill documnet number in Cover sheet
                        sheetName.Cells[3, 8] = tr.TestRe[module][newFile];
                        for (int i = 4; i < 10; i++)
                        {
                            // Fill documnet name in Cover sheet
                            string documentName = sheetName.Cells[i, 5].Value;
                            if(null != documentName)
                            {
                                sheetName.Cells[i, 5] = tr.DocumentNameStart + module.ToUpper() + tr.DocumentNameEnd;
                                break;
                            }
                        }
                    }
                    else if (Regex.Match(sheetName.Name, @"^\d+").Success)
                    {
                        Console.WriteLine("Sheet: " + sheetName.Name);
                        //find Test Result collum
                        for (int i = 7; i <= 15; i++)
                        {
                            string valueColumn = sheetName.Cells[10, i].Value;
                            
                            if(Regex.Match(valueColumn, @"Test Result").Success)
                            {
                                int index = 12;
                                while(true)
                                {
                                    string TCID = sheetName.Cells[index, 2].Value;
                                    if(!String.IsNullOrEmpty(TCID))
                                    {
                                        sheetName.Cells[index, i] = "PASSED";
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    index++;
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                       
                    }

                }
                wb.Close(true, ws.wsTR + newFile, true);
                
            }
            excel.Quit();
            removeFile(module);

        }

        public void removeFile(string module)
        {
            TestPlan ts = new TestPlan();
            WorkSpace ws = new WorkSpace(module);
            foreach (string file in ts.TestSpec[module])
            {
                File.Delete( ws.wsTR + file);
            }
            
        }
    }
}
