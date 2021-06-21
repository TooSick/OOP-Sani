namespace OOP
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
            this.outline_color = new System.Windows.Forms.Button();
            this.fill_color = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Line = new System.Windows.Forms.Button();
            this.Lines = new System.Windows.Forms.Button();
            this.Polygon_Idel = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outline_color
            // 
            this.outline_color.BackColor = System.Drawing.Color.Black;
            this.outline_color.Location = new System.Drawing.Point(589, 231);
            this.outline_color.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outline_color.Name = "outline_color";
            this.outline_color.Size = new System.Drawing.Size(27, 26);
            this.outline_color.TabIndex = 6;
            this.outline_color.UseVisualStyleBackColor = false;
            this.outline_color.Click += new System.EventHandler(this.outline_color_Click);
            // 
            // fill_color
            // 
            this.fill_color.Location = new System.Drawing.Point(589, 263);
            this.fill_color.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fill_color.Name = "fill_color";
            this.fill_color.Size = new System.Drawing.Size(27, 26);
            this.fill_color.TabIndex = 7;
            this.fill_color.UseVisualStyleBackColor = true;
            this.fill_color.Click += new System.EventHandler(this.fill_color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Цвет заливки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Цвет линии";
            // 
            // WidthUpDown
            // 
            this.WidthUpDown.Location = new System.Drawing.Point(583, 300);
            this.WidthUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthUpDown.Name = "WidthUpDown";
            this.WidthUpDown.Size = new System.Drawing.Size(33, 20);
            this.WidthUpDown.TabIndex = 10;
            this.WidthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthUpDown.ValueChanged += new System.EventHandler(this.WidthUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Толщина линии";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.UndoMenuItem,
            this.RedoMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // UndoMenuItem
            // 
            this.UndoMenuItem.Name = "UndoMenuItem";
            this.UndoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoMenuItem.Size = new System.Drawing.Size(173, 22);
            this.UndoMenuItem.Text = "Отменить";
            this.UndoMenuItem.Click += new System.EventHandler(this.UndoMenuItem_Click);
            // 
            // RedoMenuItem
            // 
            this.RedoMenuItem.Name = "RedoMenuItem";
            this.RedoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoMenuItem.Size = new System.Drawing.Size(173, 22);
            this.RedoMenuItem.Text = "Вернуть";
            this.RedoMenuItem.Click += new System.EventHandler(this.RedoMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 392);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Line.BackgroundImage = global::lab_1.Properties.Resources.hello_html_m6eadf509;
            this.Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Line.Location = new System.Drawing.Point(645, 26);
            this.Line.Margin = new System.Windows.Forms.Padding(2);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(74, 62);
            this.Line.TabIndex = 5;
            this.Line.UseVisualStyleBackColor = false;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Lines
            // 
            this.Lines.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Lines.BackgroundImage = global::lab_1.Properties.Resources.BrokenLineImg;
            this.Lines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lines.Location = new System.Drawing.Point(578, 163);
            this.Lines.Margin = new System.Windows.Forms.Padding(2);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(72, 64);
            this.Lines.TabIndex = 4;
            this.Lines.UseVisualStyleBackColor = false;
            this.Lines.Click += new System.EventHandler(this.Lines_Click);
            // 
            // Polygon_Idel
            // 
            this.Polygon_Idel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Polygon_Idel.BackgroundImage = global::lab_1.Properties.Resources.png_transparent_regular_polygon_pentagon_shape_regular_polytope_file_angle_rectangle_triangle;
            this.Polygon_Idel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Polygon_Idel.Location = new System.Drawing.Point(646, 92);
            this.Polygon_Idel.Margin = new System.Windows.Forms.Padding(2);
            this.Polygon_Idel.Name = "Polygon_Idel";
            this.Polygon_Idel.Size = new System.Drawing.Size(73, 67);
            this.Polygon_Idel.TabIndex = 3;
            this.Polygon_Idel.UseVisualStyleBackColor = false;
            this.Polygon_Idel.Click += new System.EventHandler(this.Polygon_Idel_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rectangle.BackgroundImage = global::lab_1.Properties.Resources.gin_sym_dry1;
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangle.Location = new System.Drawing.Point(578, 92);
            this.rectangle.Margin = new System.Windows.Forms.Padding(2);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(72, 67);
            this.rectangle.TabIndex = 2;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // ellipse
            // 
            this.ellipse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ellipse.BackgroundImage = global::lab_1.Properties.Resources.imgonline_com_ua_Resize_VNdXcq9e1HYR853;
            this.ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipse.Location = new System.Drawing.Point(578, 26);
            this.ellipse.Margin = new System.Windows.Forms.Padding(2);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(72, 62);
            this.ellipse.TabIndex = 0;
            this.ellipse.UseVisualStyleBackColor = false;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(719, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WidthUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fill_color);
            this.Controls.Add(this.outline_color);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.Polygon_Idel);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.ellipse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button Polygon_Idel;
        private System.Windows.Forms.Button Lines;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button outline_color;
        private System.Windows.Forms.Button fill_color;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown WidthUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

