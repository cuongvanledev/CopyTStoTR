using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateTestReport.Repo.Constant
{
    class WorkSpace
    {
        
        public string wsTP = "";
        public string wsTR = "";
        public WorkSpace(string module)
        {
            this.wsTP = "U:\\internal\\Module\\" + module + "\\07_UT\\01_WorkProduct_T\\plan\\";
            this.wsTR = "U:\\internal\\Module\\" + module + "\\07_UT\\01_WorkProduct_T\\result\\U2A8\\Beta\\test_report\\";
        }

    }
}
