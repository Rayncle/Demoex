namespace Доп.задание
{
    partial class Список_материалов_закрытый_
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
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типматериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.характеристикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закупочнаценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гОСТDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.основнойпоставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.спецификацияматериаловDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(24, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 29;
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
            this.длинаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.типматериалаDataGridViewTextBoxColumn,
            this.характеристикаDataGridViewTextBoxColumn,
            this.закупочнаценаDataGridViewTextBoxColumn,
            this.гОСТDataGridViewTextBoxColumn,
            this.основнойпоставщикDataGridViewTextBoxColumn,
            this.изображениеDataGridViewImageColumn,
            this.спецификацияматериаловDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.материалBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1428, 458);
            this.dataGridView1.TabIndex = 30;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            this.артикулDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // единицаизмеренияDataGridViewTextBoxColumn
            // 
            this.единицаизмеренияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.единицаизмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.Name = "единицаизмеренияDataGridViewTextBoxColumn";
            this.единицаизмеренияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            this.длинаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типматериалаDataGridViewTextBoxColumn
            // 
            this.типматериалаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.типматериалаDataGridViewTextBoxColumn.DataPropertyName = "Тип_материала";
            this.типматериалаDataGridViewTextBoxColumn.HeaderText = "Тип материала";
            this.типматериалаDataGridViewTextBoxColumn.Name = "типматериалаDataGridViewTextBoxColumn";
            this.типматериалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // характеристикаDataGridViewTextBoxColumn
            // 
            this.характеристикаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.характеристикаDataGridViewTextBoxColumn.DataPropertyName = "Характеристика";
            this.характеристикаDataGridViewTextBoxColumn.HeaderText = "Характеристика";
            this.характеристикаDataGridViewTextBoxColumn.Name = "характеристикаDataGridViewTextBoxColumn";
            this.характеристикаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // закупочнаценаDataGridViewTextBoxColumn
            // 
            this.закупочнаценаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.закупочнаценаDataGridViewTextBoxColumn.DataPropertyName = "Закупочна_цена";
            this.закупочнаценаDataGridViewTextBoxColumn.HeaderText = "Закупочная цена";
            this.закупочнаценаDataGridViewTextBoxColumn.Name = "закупочнаценаDataGridViewTextBoxColumn";
            this.закупочнаценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // гОСТDataGridViewTextBoxColumn
            // 
            this.гОСТDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.гОСТDataGridViewTextBoxColumn.DataPropertyName = "ГОСТ";
            this.гОСТDataGridViewTextBoxColumn.HeaderText = "ГОСТ";
            this.гОСТDataGridViewTextBoxColumn.Name = "гОСТDataGridViewTextBoxColumn";
            this.гОСТDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // основнойпоставщикDataGridViewTextBoxColumn
            // 
            this.основнойпоставщикDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.основнойпоставщикDataGridViewTextBoxColumn.DataPropertyName = "Основной_поставщик";
            this.основнойпоставщикDataGridViewTextBoxColumn.HeaderText = "Основной_поставщик";
            this.основнойпоставщикDataGridViewTextBoxColumn.Name = "основнойпоставщикDataGridViewTextBoxColumn";
            this.основнойпоставщикDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // изображениеDataGridViewImageColumn
            // 
            this.изображениеDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.изображениеDataGridViewImageColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewImageColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewImageColumn.Name = "изображениеDataGridViewImageColumn";
            this.изображениеDataGridViewImageColumn.ReadOnly = true;
            // 
            // спецификацияматериаловDataGridViewTextBoxColumn
            // 
            this.спецификацияматериаловDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.спецификацияматериаловDataGridViewTextBoxColumn.DataPropertyName = "Спецификация_материалов";
            this.спецификацияматериаловDataGridViewTextBoxColumn.HeaderText = "Спецификация материалов";
            this.спецификацияматериаловDataGridViewTextBoxColumn.Name = "спецификацияматериаловDataGridViewTextBoxColumn";
            this.спецификацияматериаловDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // материалBindingSource
            // 
            this.материалBindingSource.DataSource = typeof(Доп.задание.Материал);
            // 
            // Список_материалов_закрытый_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Список_материалов_закрытый_";
            this.Text = "Список_материалов_закрытый_";
            this.Load += new System.EventHandler(this.Список_материалов_закрытый__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типматериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn характеристикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn закупочнаценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гОСТDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn основнойпоставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn изображениеDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спецификацияматериаловDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource материалBindingSource;
    }
}