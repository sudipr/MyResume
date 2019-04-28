using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyResume.Controllers
{
    public class AgentyJobApplicationController : ApiController
    {
        static readonly IAgentyJobApplication agentyJobApplication = new AgentyJobApplicationActivity();

        public AgentyJobApplicationController()
        {

        }

        public MyResume.Models.MyResume GetResume(string id)
        {
            return agentyJobApplication.GetResume(id);
        }

        public int InsertResume(MyResume.Models.MyResume resume)
        {
            return agentyJobApplication.InsertResume(resume);
        }
    }
}
