namespace SpecialCourse
{
    partial class BaseForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fileWayText = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbBaseFile = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Generate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1717, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь";
            // 
            // fileWayText
            // 
            this.fileWayText.Location = new System.Drawing.Point(75, 37);
            this.fileWayText.Name = "fileWayText";
            this.fileWayText.Size = new System.Drawing.Size(309, 22);
            this.fileWayText.TabIndex = 3;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(390, 32);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(116, 27);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbBaseFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fileWayText);
            this.groupBox1.Controls.Add(this.OpenButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 553);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rtbBaseFile
            // 
            this.rtbBaseFile.Location = new System.Drawing.Point(24, 76);
            this.rtbBaseFile.Name = "rtbBaseFile";
            this.rtbBaseFile.Size = new System.Drawing.Size(482, 477);
            this.rtbBaseFile.TabIndex = 5;
            this.rtbBaseFile.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Generate);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(536, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1181, 553);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(25, 32);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(117, 27);
            this.Generate.TabIndex = 7;
            this.Generate.Text = "Построить";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1155, 471);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileWayText;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbBaseFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Generate;
    }
}

