using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResponse
    {
        public Guid RequestID { get;}
        public Guid ResponseID { get; }
        public String Output { get; set; }
        public ActionResponse()
        {
            Output = String.Empty;
            ResponseID = Guid.NewGuid();
            RequestID = Guid.NewGuid();

        }
    }
}
