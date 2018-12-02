using System;
using System.Collections.Generic;
using System.Text;

namespace PApiHelper.Models.DataModels
{
    public class PApiGroup
    {
        public int GroupId { get; set; }
        public int Ver { get; set; }
        public string GroupName { get; set; }
        public string Body { get; set; }
        public string Comments { get; set; }
        public int Updator { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
