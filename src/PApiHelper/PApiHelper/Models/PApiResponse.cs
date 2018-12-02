using System;
using System.Collections.Generic;
using System.Text;

namespace PApiHelper.Models
{
    public class PApiResponse
    {
        public decimal? Id { get; set; }
        public decimal? StatusCode { get; set; }
        public string Message { get; set; }
    }

    public class PApiResponse<T> : PApiResponse
    {
        public PApiResponseData<T> Response { get; set; }
    }
}
