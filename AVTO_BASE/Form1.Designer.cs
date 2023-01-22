namespace AVTO_BASE
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мастераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистУслугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ремонтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнениеУслугЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингУслугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вводToolStripMenuItem,
            this.ремонтToolStripMenuItem,
            this.автомобилиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вводToolStripMenuItem
            // 
            this.вводToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мастераToolStripMenuItem,
            this.прайслистУслугToolStripMenuItem});
            this.вводToolStripMenuItem.Name = "вводToolStripMenuItem";
            this.вводToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.вводToolStripMenuItem.Text = "Ввод";
            // 
            // мастераToolStripMenuItem
            // 
            this.мастераToolStripMenuItem.Name = "мастераToolStripMenuItem";
            this.мастераToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.мастераToolStripMenuItem.Text = "Мастера";
            this.мастераToolStripMenuItem.Click += new System.EventHandler(this.мастераToolStripMenuItem_Click);
            // 
            // прайслистУслугToolStripMenuItem
            // 
            this.прайслистУслугToolStripMenuItem.Name = "прайслистУслугToolStripMenuItem";
            this.прайслистУслугToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.прайслистУслугToolStripMenuItem.Text = "Прайс-лист услуг";
            this.прайслистУслугToolStripMenuItem.Click += new System.EventHandler(this.прайслистУслугToolStripMenuItem_Click);
            // 
            // ремонтToolStripMenuItem
            // 
            this.ремонтToolStripMenuItem.Name = "ремонтToolStripMenuItem";
            this.ремонтToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ремонтToolStripMenuItem.Text = "Ремонт";
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСотрудниковToolStripMenuItem,
            this.выполнениеУслугЗаПериодToolStripMenuItem,
            this.рейтингУслугToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            this.списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            this.списокСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            this.списокСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.списокСотрудниковToolStripMenuItem_Click);
            // 
            // выполнениеУслугЗаПериодToolStripMenuItem
            // 
            this.выполнениеУслугЗаПериодToolStripMenuItem.Name = "выполнениеУслугЗаПериодToolStripMenuItem";
            this.выполнениеУслугЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.выполнениеУслугЗаПериодToolStripMenuItem.Text = "Выполнение услуг за период";
            this.выполнениеУслугЗаПериодToolStripMenuItem.Click += new System.EventHandler(this.выполнениеУслугЗаПериодToolStripMenuItem_Click);
            // 
            // рейтингУслугToolStripMenuItem
            // 
            this.рейтингУслугToolStripMenuItem.Name = "рейтингУслугToolStripMenuItem";
            this.рейтингУслугToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.рейтингУслугToolStripMenuItem.Text = "Рейтинг услуг";
            this.рейтингУслугToolStripMenuItem.Click += new System.EventHandler(this.рейтингУслугToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Автомастерская";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мастераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистУслугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ремонтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнениеУслугЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингУслугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

