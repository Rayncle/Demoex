namespace Доп.задание
{
    partial class Список_материалов
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
            this.материалBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.основнойпоставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.типматериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закупочнаяценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гОСТDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.характеристикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спецификацияматериаловDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.типматериалаDataGridViewTextBoxColumn,
            this.закупочнаяценаDataGridViewTextBoxColumn,
            this.гОСТDataGridViewTextBoxColumn,
            this.длинаDataGridViewTextBoxColumn,
            this.характеристикаDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.спецификацияматериаловDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.материалBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1397, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // материалBindingSource
            // 
            this.материалBindingSource.DataSource = typeof(Доп.задание.Материал);
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
            // типматериалаDataGridViewTextBoxColumn
            // 
            this.типматериалаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.типматериалаDataGridViewTextBoxColumn.DataPropertyName = "Тип_материала";
            this.типматериалаDataGridViewTextBoxColumn.HeaderText = "Тип материала";
            this.типматериалаDataGridViewTextBoxColumn.Name = "типматериалаDataGridViewTextBoxColumn";
            // 
            // закупочнаяценаDataGridViewTextBoxColumn
            // 
            this.закупочнаяценаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.закупочнаяценаDataGridViewTextBoxColumn.DataPropertyName = "Закупочная_цена";
            this.закупочнаяценаDataGridViewTextBoxColumn.HeaderText = "Закупочная цена";
            this.закупочнаяценаDataGridViewTextBoxColumn.Name = "закупочнаяценаDataGridViewTextBoxColumn";
            // 
            // гОСТDataGridViewTextBoxColumn
            // 
            this.гОСТDataGridViewTextBoxColumn.DataPropertyName = "ГОСТ";
            this.гОСТDataGridViewTextBoxColumn.HeaderText = "ГОСТ";
            this.гОСТDataGridViewTextBoxColumn.Name = "гОСТDataGridViewTextBoxColumn";
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            // 
            // характеристикаDataGridViewTextBoxColumn
            // 
            this.характеристикаDataGridViewTextBoxColumn.DataPropertyName = "Характеристика";
            this.характеристикаDataGridViewTextBoxColumn.HeaderText = "Характеристика";
            this.характеристикаDataGridViewTextBoxColumn.Name = "характеристикаDataGridViewTextBoxColumn";
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            // 
            // спецификацияматериаловDataGridViewTextBoxColumn
            // 
            this.спецификацияматериаловDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.спецификацияматериаловDataGridViewTextBoxColumn.DataPropertyName = "Спецификация_материалов";
            this.спецификацияматериаловDataGridViewTextBoxColumn.HeaderText = "Спецификация материалов";
            this.спецификацияматериаловDataGridViewTextBoxColumn.Name = "спецификацияматериаловDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(30, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Список_материалов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Список_материалов";
            this.Text = "Список материалов";
            this.Load += new System.EventHandler(this.Список_материалов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn основнойпоставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn изображениеDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типматериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn закупочнаяценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гОСТDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn характеристикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спецификацияматериаловDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource материалBindingSource;
        private System.Windows.Forms.Button button1;
    }
}