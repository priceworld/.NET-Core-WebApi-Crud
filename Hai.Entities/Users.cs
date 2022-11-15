using System;
using System.Collections.Generic;
using System.Text;

namespace Hai.Entities
{
    public class Users
    {
        public int UserId { get; set; }
        public int? UserTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime ValidationDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? CreatedDdate { get; set; }
        public int? Status { get; set; }
        public string? Token { get; set; }
    }
}
