using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Workflow.Methods;
using WAF.Engine.Workflow.Runtime;

namespace FrameworkMVCRazor.Helpers
{
    public class SendEmailTestWorkflow : WorkflowMethod
    {
        public override NextCall Invoke(WorkflowMethod invoker)
        {
            WFContext.Session.SendEmail(false, "Quick brown fox jumps over the lay dog", "jonas.stromstad@creuna.no", "jonas.stromstad@creuna.no", "Test email");

            return null;
        }
    }
}