namespace ЦентральныйСклад
{
    partial class Основное_окно
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Основное_окно));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ПриходButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.РасходButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ОтчётButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ПросмотрDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.топливоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тараИТарныеМатериалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запасныеЧастиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочиеМатериалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыПереданныеВПереработкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строительныеМатериалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спецоснасткаИСпецодеждаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инвентарьИХозпринадлежностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ПриходButton,
            this.toolStripSeparator1,
            this.РасходButton,
            this.toolStripSeparator2,
            this.ОтчётButton,
            this.toolStripSeparator3,
            this.ПросмотрDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ПриходButton
            // 
            this.ПриходButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ПриходButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПриходButton.Image = ((System.Drawing.Image)(resources.GetObject("ПриходButton.Image")));
            this.ПриходButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ПриходButton.Name = "ПриходButton";
            this.ПриходButton.Size = new System.Drawing.Size(74, 25);
            this.ПриходButton.Text = "Приход";
            this.ПриходButton.Click += new System.EventHandler(this.ПриходButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // РасходButton
            // 
            this.РасходButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.РасходButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.РасходButton.Image = ((System.Drawing.Image)(resources.GetObject("РасходButton.Image")));
            this.РасходButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.РасходButton.Name = "РасходButton";
            this.РасходButton.Size = new System.Drawing.Size(69, 25);
            this.РасходButton.Text = "Расход";
            this.РасходButton.Click += new System.EventHandler(this.РасходButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // ОтчётButton
            // 
            this.ОтчётButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ОтчётButton.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ОтчётButton.Image = ((System.Drawing.Image)(resources.GetObject("ОтчётButton.Image")));
            this.ОтчётButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ОтчётButton.Name = "ОтчётButton";
            this.ОтчётButton.Size = new System.Drawing.Size(62, 25);
            this.ОтчётButton.Text = "Отчёт";
            this.ОтчётButton.Click += new System.EventHandler(this.ОтчётButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // ПросмотрDropDownButton
            // 
            this.ПросмотрDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ПросмотрDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem,
            this.топливоToolStripMenuItem,
            this.тараИТарныеМатериалыToolStripMenuItem,
            this.запасныеЧастиToolStripMenuItem,
            this.прочиеМатериалыToolStripMenuItem,
            this.материалыПереданныеВПереработкуToolStripMenuItem,
            this.строительныеМатериалыToolStripMenuItem,
            this.спецоснасткаИСпецодеждаToolStripMenuItem,
            this.инвентарьИХозпринадлежностиToolStripMenuItem});
            this.ПросмотрDropDownButton.Enabled = false;
            this.ПросмотрDropDownButton.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ПросмотрDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ПросмотрDropDownButton.Image")));
            this.ПросмотрDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ПросмотрDropDownButton.Name = "ПросмотрDropDownButton";
            this.ПросмотрDropDownButton.Size = new System.Drawing.Size(105, 25);
            this.ПросмотрDropDownButton.Text = "Просмотр";
            this.ПросмотрDropDownButton.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(603, 26);
            this.toolStripMenuItem1.Text = "Сырьё и материалы";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem
            // 
            this.полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem.Name = "полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem";
            this.полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem.Size = new System.Drawing.Size(603, 26);
            this.полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem.Text = "Полуфабрикаты, комплектующие изделия, конструкции и детали";
            this.полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem.Click += new System.EventHandler(this.полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem_Click);
            // 
            // топливоToolStripMenuItem
            // 
            this.топливоToolStripMenuItem.Name = "топливоToolStripMenuItem";
            this.топливоToolStripMenuItem.Size = new System.Drawing.Size(603, 26);
            this.топливоToolStripMenuItem.Text = "Топливо";
            this.топливоToolStripMenuItem.Click += new System.EventHandler(this.топливоToolStripMenuItem_Click);
            // 
            // тараИТарныеМатериалыToolStripMenuItem
            // 
            this.тараИТарныеМатериалыToolStripMenuItem.Name = "тараИТарныеМатериалыToolStripMenuItem";
            this.тараИТарныеМатериалыToolStripMenuItem.Size = new System.Drawing.Size(603, 26);
            this.тараИТарныеМатериалыToolStripMenuItem.Text = "Тара и тарные материалы";
            this.тараИТарныеМатериалыToolStripMenuItem.Click += new System.EventHandler(this.тараИТарныеМатериалыToolStripMenuItem_Click);
            // 
            // запасныеЧастиToolStripMenuItem
            // 
            this.запасныеЧастиToolStripMenuItem.Name = "запасныеЧастиToolStripMenuItem";
            this.запасныеЧастиToolStripMenuItem.Size = new System.Drawing.Size(603, 26);
            this.запасныеЧастиToolStripMenuItem.Text = "Запасные части";
            this.запасныеЧастиToolStripMenuItem.Click += new System.EventHandler(this.запасныеЧастиToolStripMenuItem_Click);
            // 
            // прочиеМатериалыToolStripMenuItem
            // 
            this.прочиеМатериалыToolStripMenuItem.Name = "прочиеМатериалыToolStripMenuItem";
            this.прочиеМатериалыToolStripMenuItem.Size = new System.Drawing.Size(603, 26);
            this.прочиеМатериалыToolStripMenuItem.Text = "Прочие материалы";
            this.прочиеМатериалыToolStripMenuItem.Click += new System.EventHandler(this.прочиеМатериалыToolStripMenuItem_Click);
            // 
            // материалыПереданныеВПереработкуToolStripMenuItem
            // 
            this.материалыПереданныеВПереработкуToolStripMenuItem.Name = "материалыПереданныеВПереработкуToolStripMenuItem";
            this.материалыПереданныеВПереработкуToolStripMenuItem.Size = new System.Drawing.Size(603, 26);
            this.материалыПереданныеВПереработкуToolStripMenuItem.Text = "Материалы, переданные в переработку";
            this.материалыПереданныеВПереработкуToolStripMenuItem.Click += new System.EventHandler(this.материалыПереданныеВПереработкуToolStripMenuItem_Click);
            // 
            // строительныеМатериалыToolStripMenuItem
            // 
            this.строительныеМатериалыToolStripMenuItem.Name = "строительныеМатериалыToolStripMenuItem";
            this.строительныеМатериалыToolStripMenuItem.Size = new System.Drawing.Size(603, 26);
            this.строительныеМатериалыToolStripMenuItem.Text = "Строительные материалы";
            this.строительныеМатериалыToolStripMenuItem.Click += new System.EventHandler(this.строительныеМатериалыToolStripMenuItem_Click);
            // 
            // спецоснасткаИСпецодеждаToolStripMenuItem
            // 
            this.спецоснасткаИСпецодеждаToolStripMenuItem.Name = "спецоснасткаИСпецодеждаToolStripMenuItem";
            this.спецоснасткаИСпецодеждаToolStripMenuItem.Size = new System.Drawing.Size(603, 26);
            this.спецоснасткаИСпецодеждаToolStripMenuItem.Text = "Спецоснастка и спецодежда";
            this.спецоснасткаИСпецодеждаToolStripMenuItem.Click += new System.EventHandler(this.спецоснасткаИСпецодеждаToolStripMenuItem_Click);
            // 
            // инвентарьИХозпринадлежностиToolStripMenuItem
            // 
            this.инвентарьИХозпринадлежностиToolStripMenuItem.Name = "инвентарьИХозпринадлежностиToolStripMenuItem";
            this.инвентарьИХозпринадлежностиToolStripMenuItem.Size = new System.Drawing.Size(603, 26);
            this.инвентарьИХозпринадлежностиToolStripMenuItem.Text = "Инвентарь и хозпринадлежности";
            this.инвентарьИХозпринадлежностиToolStripMenuItem.Click += new System.EventHandler(this.инвентарьИХозпринадлежностиToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 530);
            this.dataGridView1.TabIndex = 1;
            // 
            // Основное_окно
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Основное_окно";
            this.Text = "Основное окно";
            this.Load += new System.EventHandler(this.Основное_окно_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ПриходButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton РасходButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ОтчётButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton ПросмотрDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem полуфабрикатыКомплектующиеИзделияКонструкцииИДеталиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem топливоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тараИТарныеМатериалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запасныеЧастиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочиеМатериалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыПереданныеВПереработкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строительныеМатериалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спецоснасткаИСпецодеждаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инвентарьИХозпринадлежностиToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

