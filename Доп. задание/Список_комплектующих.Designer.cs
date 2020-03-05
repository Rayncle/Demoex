namespace Доп.задание
{
    partial class Список_комплектующих
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
            this.комплектующийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.основнойпоставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.типкомплектующихDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закупочнаяценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спецификациякомплектующихDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующийBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(26, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикулDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.основнойпоставщикDataGridViewTextBoxColumn,
            this.изображениеDataGridViewImageColumn,
            this.типкомплектующихDataGridViewTextBoxColumn,
            this.закупочнаяценаDataGridViewTextBoxColumn,
            this.весDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.спецификациякомплектующихDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.комплектующийBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1466, 526);
            this.dataGridView1.TabIndex = 29;
            // 
            // комплектующийBindingSource
            // 
            this.комплектующийBindingSource.DataSource = typeof(Доп.задание.Комплектующий);
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // единицаизмеренияDataGridViewTextBoxColumn
            // 
            this.единицаизмеренияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.единицаизмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.Name = "единицаизмеренияDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // основнойпоставщикDataGridViewTextBoxColumn
            // 
            this.основнойпоставщикDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.основнойпоставщикDataGridViewTextBoxColumn.DataPropertyName = "Основной_поставщик";
            this.основнойпоставщикDataGridViewTextBoxColumn.HeaderText = "Основной поставщик";
            this.основнойпоставщикDataGridViewTextBoxColumn.Name = "основнойпоставщикDataGridViewTextBoxColumn";
            // 
            // изображениеDataGridViewImageColumn
            // 
            this.изображениеDataGridViewImageColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewImageColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewImageColumn.Name = "изображениеDataGridViewImageColumn";
            // 
            // типкомплектующихDataGridViewTextBoxColumn
            // 
            this.типкомплектующихDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.типкомплектующихDataGridViewTextBoxColumn.DataPropertyName = "Тип_комплектующих";
            this.типкомплектующихDataGridViewTextBoxColumn.HeaderText = "Тип комплектующих";
            this.типкомплектующихDataGridViewTextBoxColumn.Name = "типкомплектующихDataGridViewTextBoxColumn";
            // 
            // закупочнаяценаDataGridViewTextBoxColumn
            // 
            this.закупочнаяценаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.закупочнаяценаDataGridViewTextBoxColumn.DataPropertyName = "Закупочная_цена";
            this.закупочнаяценаDataGridViewTextBoxColumn.HeaderText = "Закупочная цена";
            this.закупочнаяценаDataGridViewTextBoxColumn.Name = "закупочнаяценаDataGridViewTextBoxColumn";
            // 
            // весDataGridViewTextBoxColumn
            // 
            this.весDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.весDataGridViewTextBoxColumn.DataPropertyName = "Вес";
            this.весDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.весDataGridViewTextBoxColumn.Name = "весDataGridViewTextBoxColumn";
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            // 
            // спецификациякомплектующихDataGridViewTextBoxColumn
            // 
            this.спецификациякомплектующихDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.спецификациякомплектующихDataGridViewTextBoxColumn.DataPropertyName = "Спецификация_комплектующих";
            this.спецификациякомплектующихDataGridViewTextBoxColumn.HeaderText = "Спецификация комплектующих";
            this.спецификациякомплектующихDataGridViewTextBoxColumn.Name = "спецификациякомплектующихDataGridViewTextBoxColumn";
            // 
            // Список_комплектующих
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 676);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Список_комплектующих";
            this.Text = "Список комплектующих";
            this.Load += new System.EventHandler(this.Список_комплектующих_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующийBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource комплектующийBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn основнойпоставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn изображениеDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типкомплектующихDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn закупочнаяценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спецификациякомплектующихDataGridViewTextBoxColumn;
    }
}