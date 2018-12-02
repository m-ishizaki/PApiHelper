using System;
using System.Collections.Generic;
using System.Text;

namespace PApiHelper.Models
{
    public class PGetApiRequest
    {
        public string ApiKey { get; set; }
        public long Offset { get; set; }
        public PGetApiRequestData View { get; } = new PGetApiRequestData();
    }
}
