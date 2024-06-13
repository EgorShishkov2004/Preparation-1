using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation__1.Table
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string ContentOrder { get; set; } = string.Empty;
        public DateTime DateOrder { get; set; }
        public DateTime DateDelivery { get; set; }
        public int PointIssueId { get; set; }
        public string ClientFIO { get; set; } = string.Empty;
        public string CodeGet { get; set; } = string.Empty;
        public int StatusId { get; set; }

        public Status? Status { get; set; }
        public PointIssue? PointIssue { get; set; }


        // Вывод данных в DataGridView

        // Status
        public string? StatusString
        {
            get => $"{Status!.Name}";
        }

        // PointIssue
        public string? PointIssueString
        {
            get => $"{PointIssue!.Adress}";
        }
    }
}
