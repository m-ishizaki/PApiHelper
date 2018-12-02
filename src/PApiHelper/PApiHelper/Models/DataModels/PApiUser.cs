using System;
using System.Collections.Generic;
using System.Text;

namespace PApiHelper.Models.DataModels
{
    public class PApiUser
    {
        public int UserId { get; set; }
        public string LoginId { get; set; }
        public string Name { get; set; }
        public string UserCode { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public string DeptCode { get; set; }
        public string Body { get; set; }
        public DateTime LastLoginTime { get; set; }
        public DateTime PasswordExpirationTime { get; set; }
        public DateTime PasswordChangeTime { get; set; }
        public int NumberOfLogins { get; set; }
        public int NumberOfDenial { get; set; }
        public bool TenantManager { get; set; }
        public bool Disabled { get; set; }
        public string Comments { get; set; }
        public int Updator { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
