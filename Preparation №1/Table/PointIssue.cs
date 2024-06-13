using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation__1.Table
{
    public class PointIssue
    {
        public int Id { get; set; }
        public string Adress { get; set; } = string.Empty;

        public override string ToString()
        {
            return Adress;
        }
    }
}
