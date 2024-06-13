namespace Preparation__1
{
    partial class Form_Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Autoriz = new Panel();
            label_Autoriz = new Label();
            pictureBox_Autoriz = new PictureBox();
            label_Login = new Label();
            label_Password = new Label();
            button_SignIn = new Button();
            textBox_Login = new TextBox();
            textBox_Password = new TextBox();
            panel_Autoriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Autoriz).BeginInit();
            SuspendLayout();
            // 
            // panel_Autoriz
            // 
            panel_Autoriz.BackColor = Color.FromArgb(118, 227, 131);
            panel_Autoriz.Controls.Add(label_Autoriz);
            panel_Autoriz.Controls.Add(pictureBox_Autoriz);
            panel_Autoriz.Location = new Point(-5, -3);
            panel_Autoriz.Name = "panel_Autoriz";
            panel_Autoriz.Size = new Size(456, 102);
            panel_Autoriz.TabIndex = 0;
            // 
            // label_Autoriz
            // 
            label_Autoriz.AutoSize = true;
            label_Autoriz.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Autoriz.Location = new Point(186, 44);
            label_Autoriz.Name = "label_Autoriz";
            label_Autoriz.Size = new Size(120, 24);
            label_Autoriz.TabIndex = 1;
            label_Autoriz.Text = "Авторизация";
            // 
            // pictureBox_Autoriz
            // 
            pictureBox_Autoriz.Image = Properties.Resources.logo;
            pictureBox_Autoriz.Location = new Point(120, 26);
            pictureBox_Autoriz.Name = "pictureBox_Autoriz";
            pictureBox_Autoriz.Size = new Size(60, 60);
            pictureBox_Autoriz.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Autoriz.TabIndex = 1;
            pictureBox_Autoriz.TabStop = false;
            // 
            // label_Login
            // 
            label_Login.AutoSize = true;
            label_Login.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Login.Location = new Point(115, 168);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(68, 24);
            label_Login.TabIndex = 2;
            label_Login.Text = "Логин:";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Password.Location = new Point(115, 267);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(82, 24);
            label_Password.TabIndex = 3;
            label_Password.Text = "Пароль:";
            // 
            // button_SignIn
            // 
            button_SignIn.BackColor = Color.FromArgb(73, 140, 81);
            button_SignIn.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_SignIn.Location = new Point(148, 347);
            button_SignIn.Name = "button_SignIn";
            button_SignIn.Size = new Size(120, 45);
            button_SignIn.TabIndex = 3;
            button_SignIn.Text = "Войти";
            button_SignIn.UseVisualStyleBackColor = false;
            button_SignIn.Click += button_SignIn_Click;
            // 
            // textBox_Login
            // 
            textBox_Login.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Login.Location = new Point(115, 195);
            textBox_Login.Name = "textBox_Login";
            textBox_Login.Size = new Size(186, 33);
            textBox_Login.TabIndex = 1;
            textBox_Login.Text = "o@outlook.com";
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Password.Location = new Point(115, 294);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(186, 33);
            textBox_Password.TabIndex = 2;
            textBox_Password.Text = "2L6KZG";
            // 
            // Form_Authorization
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 450);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Login);
            Controls.Add(button_SignIn);
            Controls.Add(label_Password);
            Controls.Add(label_Login);
            Controls.Add(panel_Autoriz);
            Name = "Form_Authorization";
            Text = "ООО \"Посуда\"";
            panel_Autoriz.ResumeLayout(false);
            panel_Autoriz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Autoriz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Autoriz;
        private Label label_Autoriz;
        private PictureBox pictureBox_Autoriz;
        private Label label_Login;
        private Label label_Password;
        private Button button_SignIn;
        private TextBox textBox_Login;
        private TextBox textBox_Password;
    }
}