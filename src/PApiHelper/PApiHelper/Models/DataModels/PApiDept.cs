using System;
using System.Collections.Generic;
using System.Text;

namespace PApiHelper.Models.DataModels
{
    public class PApiDept
    {
        public int DeptId { get; set; }
        public int Ver { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string Body { get; set; }
        public string Comments { get; set; }
        public int Updator { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
