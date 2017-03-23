//  Copyright 2015 Stefan Negritoiu (FreeBusy). See LICENSE file for more information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using AlexaSkillsKit;
using System.Web.Http;

namespace Sample.Controllers
{
    [Route("alexa/sample-session")]
    public class AlexaController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage SampleSession() {
            var speechlet = new SampleSessionSpeechlet();
            return speechlet.GetResponse(Request);
        }
    }
}
