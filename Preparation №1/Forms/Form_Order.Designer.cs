namespace Preparation__1.Forms
{
    partial class Form_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel_Order = new Panel();
            label_Order = new Label();
            pictureBox_Order = new PictureBox();
            dataGridView_Order = new DataGridView();
            contentOrderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PointIssue = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            dateOrderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDeliveryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientFIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeGetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            button_Back = new Button();
            button_Change = new Button();
            button_Arrange = new Button();
            panel_Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_Order
            // 
            panel_Order.BackColor = Color.FromArgb(118, 227, 131);
            panel_Order.Controls.Add(label_Order);
            panel_Order.Controls.Add(pictureBox_Order);
            panel_Order.Location = new Point(-3, -9);
            panel_Order.Name = "panel_Order";
            panel_Order.Size = new Size(810, 105);
            panel_Order.TabIndex = 0;
            // 
            // label_Order
            // 
            label_Order.AutoSize = true;
            label_Order.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Order.Location = new Point(293, 47);
            label_Order.Name = "label_Order";
            label_Order.Size = new Size(141, 24);
            label_Order.TabIndex = 2;
            label_Order.Text = "Список заказов";
            // 
            // pictureBox_Order
            // 
            pictureBox_Order.Image = Properties.Resources.logo;
            pictureBox_Order.Location = new Point(227, 31);
            pictureBox_Order.Name = "pictureBox_Order";
            pictureBox_Order.Size = new Size(60, 60);
            pictureBox_Order.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Order.TabIndex = 1;
            pictureBox_Order.TabStop = false;
            // 
            // dataGridView_Order
            // 
            dataGridView_Order.AutoGenerateColumns = false;
            dataGridView_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Order.Columns.AddRange(new DataGridViewColumn[] { contentOrderDataGridViewTextBoxColumn, PointIssue, Status, dateOrderDataGridViewTextBoxColumn, dateDeliveryDataGridViewTextBoxColumn, clientFIODataGridViewTextBoxColumn, codeGetDataGridViewTextBoxColumn });
            dataGridView_Order.DataSource = orderBindingSource;
            dataGridView_Order.Location = new Point(12, 117);
            dataGridView_Order.Name = "dataGridView_Order";
            dataGridView_Order.RowHeadersWidth = 62;
            dataGridView_Order.RowTemplate.Height = 33;
            dataGridView_Order.Size = new Size(776, 258);
            dataGridView_Order.TabIndex = 1;
            // 
            // contentOrderDataGridViewTextBoxColumn
            // 
            contentOrderDataGridViewTextBoxColumn.DataPropertyName = "ContentOrder";
            contentOrderDataGridViewTextBoxColumn.HeaderText = "Содержимое заказа";
            contentOrderDataGridViewTextBoxColumn.MinimumWidth = 8;
            contentOrderDataGridViewTextBoxColumn.Name = "contentOrderDataGridViewTextBoxColumn";
            contentOrderDataGridViewTextBoxColumn.Width = 150;
            // 
            // PointIssue
            // 
            PointIssue.DataPropertyName = "PointIssue";
            PointIssue.HeaderText = "Пункт выдачи";
            PointIssue.MinimumWidth = 8;
            PointIssue.Name = "PointIssue";
            PointIssue.Width = 150;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Статус заказа";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            dateOrderDataGridViewTextBoxColumn.DataPropertyName = "DateOrder";
            dateOrderDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            dateOrderDataGridViewTextBoxColumn.MinimumWidth = 8;
            dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            dateOrderDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDeliveryDataGridViewTextBoxColumn
            // 
            dateDeliveryDataGridViewTextBoxColumn.DataPropertyName = "DateDelivery";
            dateDeliveryDataGridViewTextBoxColumn.HeaderText = "Дата доставки";
            dateDeliveryDataGridViewTextBoxColumn.MinimumWidth = 8;
            dateDeliveryDataGridViewTextBoxColumn.Name = "dateDeliveryDataGridViewTextBoxColumn";
            dateDeliveryDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientFIODataGridViewTextBoxColumn
            // 
            clientFIODataGridViewTextBoxColumn.DataPropertyName = "ClientFIO";
            clientFIODataGridViewTextBoxColumn.HeaderText = "ФИО клиента";
            clientFIODataGridViewTextBoxColumn.MinimumWidth = 8;
            clientFIODataGridViewTextBoxColumn.Name = "clientFIODataGridViewTextBoxColumn";
            clientFIODataGridViewTextBoxColumn.Width = 150;
            // 
            // codeGetDataGridViewTextBoxColumn
            // 
            codeGetDataGridViewTextBoxColumn.DataPropertyName = "CodeGet";
            codeGetDataGridViewTextBoxColumn.HeaderText = "Код получения";
            codeGetDataGridViewTextBoxColumn.MinimumWidth = 8;
            codeGetDataGridViewTextBoxColumn.Name = "codeGetDataGridViewTextBoxColumn";
            codeGetDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Table.Order);
            // 
            // button_Back
            // 
            button_Back.BackColor = Color.FromArgb(73, 140, 81);
            button_Back.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Back.Location = new Point(12, 393);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(140, 44);
            button_Back.TabIndex = 2;
            button_Back.Text = "Назад";
            button_Back.UseVisualStyleBackColor = false;
            button_Back.Click += button_Back_Click;
            // 
            // button_Change
            // 
            button_Change.BackColor = Color.FromArgb(73, 140, 81);
            button_Change.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Change.Location = new Point(317, 393);
            button_Change.Name = "button_Change";
            button_Change.Size = new Size(140, 44);
            button_Change.TabIndex = 3;
            button_Change.Text = "Изменить";
            button_Change.UseVisualStyleBackColor = false;
            // 
            // button_Arrange
            // 
            button_Arrange.BackColor = Color.FromArgb(73, 140, 81);
            button_Arrange.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Arrange.Location = new Point(571, 393);
            button_Arrange.Name = "button_Arrange";
            button_Arrange.Size = new Size(217, 44);
            button_Arrange.TabIndex = 4;
            button_Arrange.Text = "Сформировать заказ";
            button_Arrange.UseVisualStyleBackColor = false;
            // 
            // Form_Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(button_Arrange);
            Controls.Add(button_Change);
            Controls.Add(button_Back);
            Controls.Add(dataGridView_Order);
            Controls.Add(panel_Order);
            Name = "Form_Order";
            Text = "Каталог";
            panel_Order.ResumeLayout(false);
            panel_Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Order).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Order;
        private PictureBox pictureBox_Order;
        private Label label_Order;
        private DataGridView dataGridView_Order;
        private Button button_Back;
        private Button button_Change;
        private Button button_Arrange;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn contentOrderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PointIssue;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDeliveryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientFIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeGetDataGridViewTextBoxColumn;
    }
}