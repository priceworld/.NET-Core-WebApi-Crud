using System;
using System.Collections.Generic;
using System.Text;

namespace Hai.Entities
{
    public class User
    {
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
