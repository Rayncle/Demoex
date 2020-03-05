namespace Доп.задание
{
    partial class Список_сотрудников
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списоквыполняемыхоперацийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.списоквыполняемыхоперацийDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataSource = typeof(Доп.задание.Сотрудники);
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата Рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // списоквыполняемыхоперацийDataGridViewTextBoxColumn
            // 
            this.списоквыполняемыхоперацийDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.списоквыполняемыхоперацийDataGridViewTextBoxColumn.DataPropertyName = "Список_выполняемых_операций";
            this.списоквыполняемыхоперацийDataGridViewTextBoxColumn.HeaderText = "Список выполняемых операций";
            this.списоквыполняемыхоперацийDataGridViewTextBoxColumn.Name = "списоквыполняемыхоперацийDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(26, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Список_сотрудников
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Список_сотрудников";
            this.Text = "Список сотрудников";
            this.Load += new System.EventHandler(this.Список_сотрудников_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn списоквыполняемыхоперацийDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.Button button2;
    }
}