using System;
using System.Collections.Generic;
using System.Text;

namespace PApiHelper.Models
{
    public class PGetApiRequestData
    {
        public Dictionary<string, string> ColumnFilterHash { get; } = new Dictionary<string, string>();
    }
}
