using Microsoft.EntityFrameworkCore;
using Preparation__1.Database;
using Preparation__1.Forms;
using System.Diagnostics;

namespace Preparation__1
{
    public partial class Form_Authorization : Form
    {
        public Form_Authorization()
        {
            InitializeComponent();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            DB dB = new DB();

            var user = dB.Users.Include(x => x.Role)
                .Where(x => x.Login == textBox_Login.Text && x.Password == textBox_Password.Text).FirstOrDefault();

            if (user != null)
            {
                if(user.Role!.Name == "Администратор")
                {
                    MessageBox.Show("Вы администратор");
                    Form_Order form_Order = new Form_Order();
                    form_Order.ShowDialog();
                    this.Close();
                }

                else if (user.Role!.Name == "Клиент")
                {
                    MessageBox.Show("Вы Клиент! \n" +
                        "Отказано в доступе");
                }

                else if (user.Role!.Name == "Менеджер")
                {
                    MessageBox.Show("Вы Менеджер! \n" +
                        "Отказано в доступе");
                }
            }
        }
    }
}