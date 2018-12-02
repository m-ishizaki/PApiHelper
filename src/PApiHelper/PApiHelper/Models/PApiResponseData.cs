using System;
using System.Collections.Generic;
using System.Text;

namespace PApiHelper.Models
{
    public class PApiResponseData<T>
    {
        public decimal? Offset { get; set; }
        public decimal? PageSize { get; set; }
        public decimal? TotalCount { get; set; }
        public T[] Data { get; set; }
    }
}
