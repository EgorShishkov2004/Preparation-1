using Microsoft.EntityFrameworkCore;
using Preparation__1.Database;
using Preparation__1.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparation__1.Forms
{
    public partial class Form_Order : Form
    {
        public Form_Order()
        {
            InitializeComponent();

            // Обращение к БД
            DB dB = new DB();

            // Получение заказов с включенными связанными сущностями
            var orders = dB.Orders
                .Include(x => x.PointIssue)
                .Include(x => x.Status)
                .ToList();

            // Вывод заказов
            dataGridView_Order.DataSource = orders;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
