using System;
using System.Collections.Generic;
using System.Text;

namespace PApiHelper.Models
{
    public class PGetApiRequestData
    {
        public Dictionary<string, string> ColumnFilterHash { get; } = new Dictionary<string, string>();
        public bool? Incomplete { get; set; }
        public bool? Own { get; set; }
        public bool? NearCompletionTime { get; set; }
        public bool? Delay { get; set; }
        public bool? Overdue { get; set; }
        public Dictionary<string, int> ColumnSorterHash { get; } = new Dictionary<string, int>();
    }
}
