namespace Доп.задание
{
    partial class Заказы
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиезаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Статус = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ответственныйменеджерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.плановаядатазавершенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.заказBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(24, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.наименованиезаказаDataGridViewTextBoxColumn,
            this.Статус,
            this.заказчикDataGridViewTextBoxColumn,
            this.ответственныйменеджерDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.плановаядатазавершенияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 371);
            this.dataGridView1.TabIndex = 31;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            this.номерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиезаказаDataGridViewTextBoxColumn
            // 
            this.наименованиезаказаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.наименованиезаказаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_заказа";
            this.наименованиезаказаDataGridViewTextBoxColumn.HeaderText = "Наименование заказа";
            this.наименованиезаказаDataGridViewTextBoxColumn.Name = "наименованиезаказаDataGridViewTextBoxColumn";
            this.наименованиезаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Статус
            // 
            this.Статус.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Статус.HeaderText = "Статус";
            this.Статус.Items.AddRange(new object[] {
            "Новый",
            "Отменён",
            "Составление спецификации",
            "Подтверждение",
            "Закупка",
            "Производство",
            "Контроль",
            "Готов",
            "Закрыт"});
            this.Статус.Name = "Статус";
            this.Статус.ReadOnly = true;
            // 
            // заказчикDataGridViewTextBoxColumn
            // 
            this.заказчикDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.заказчикDataGridViewTextBoxColumn.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.Name = "заказчикDataGridViewTextBoxColumn";
            this.заказчикDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ответственныйменеджерDataGridViewTextBoxColumn
            // 
            this.ответственныйменеджерDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ответственныйменеджерDataGridViewTextBoxColumn.DataPropertyName = "Ответственный_менеджер";
            this.ответственныйменеджерDataGridViewTextBoxColumn.HeaderText = "Ответственный менеджер";
            this.ответственныйменеджерDataGridViewTextBoxColumn.Name = "ответственныйменеджерDataGridViewTextBoxColumn";
            this.ответственныйменеджерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // плановаядатазавершенияDataGridViewTextBoxColumn
            // 
            this.плановаядатазавершенияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.плановаядатазавершенияDataGridViewTextBoxColumn.DataPropertyName = "Плановая_дата_завершения";
            this.плановаядатазавершенияDataGridViewTextBoxColumn.HeaderText = "Плановая дата завершения";
            this.плановаядатазавершенияDataGridViewTextBoxColumn.Name = "плановаядатазавершенияDataGridViewTextBoxColumn";
            this.плановаядатазавершенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataSource = typeof(Доп.задание.Заказ);
            // 
            // заказBindingSource1
            // 
            this.заказBindingSource1.DataSource = typeof(Доп.задание.Заказ);
            // 
            // заказBindingSource2
            // 
            this.заказBindingSource2.DataSource = typeof(Доп.задание.Заказ);
            // 
            // Заказы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Заказы";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Заказы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private System.Windows.Forms.BindingSource заказBindingSource1;
        private System.Windows.Forms.BindingSource заказBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиезаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Статус;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответственныйменеджерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn плановаядатазавершенияDataGridViewTextBoxColumn;
    }
}