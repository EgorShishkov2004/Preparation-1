using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation__1.Table
{
    public class User
    {
        public int Id { get; set; }
        public string FIO { get; set; } = string.Empty;
        public int RoleId { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public Role? Role { get; set; }
    }
}
