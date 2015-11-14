using System;
using System.Collections.Generic;
using Base32;
using Microsoft.AspNet.Mvc;
using OtpSharp;

namespace StrongNameErrorBase32Package.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values/fails
        [HttpGet("fails")]
        public IEnumerable<string> GetFails()
        {
            var key = KeyGeneration.GenerateRandomKey(20);
            var qrData = KeyUrl.GetTotpUrl(key, "me");
            return new string[] { "value1", "value2", qrData };
        }

        // GET: api/values/works
        [HttpGet("works")]
        public IEnumerable<string> GetWorks()
        {
            var key = KeyGeneration.GenerateRandomKey(20);
            var b32String = Base32Encoder.Encode(key);
            return new string[] { "value1", "value2", b32String };
        }
    }
}
