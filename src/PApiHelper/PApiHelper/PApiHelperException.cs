using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PApiHelper
{
    public class PApiHelperException : Exception
    {
        public HttpResponseMessage HttpResponseMessage { get; }

        public PApiHelperException(string message, Exception innerException, HttpResponseMessage response) : base(message, innerException)
        {
            HttpResponseMessage = response;
        }
    }
}
