using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hai.Entities
{
    public class UserDto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public int? UserTypeId { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        public DateTime ValidationDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? CreatedDdate { get; set; }
        public int? Status { get; set; }
        public string? Token { get; set; }
    }
}
