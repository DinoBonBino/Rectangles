namespace Rectangles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(56, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(125, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Рисуем";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(217, 38);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(157, 36);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Выделяем";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(6, 67);
            label1.Name = "label1";
            label1.Size = new Size(388, 53);
            label1.TabIndex = 2;
            label1.Text = "Каким цветом рисуем?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.BackColor = Color.FromArgb(128, 255, 128);
            checkBox1.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(79, 124);
            checkBox1.Margin = new Padding(6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 50);
            checkBox1.TabIndex = 7;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.Click += CheckBox_Clicked;
            // 
            // checkBox2
            // 
            checkBox2.BackColor = Color.FromArgb(255, 128, 128);
            checkBox2.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.ForeColor = Color.Black;
            checkBox2.Location = new Point(141, 124);
            checkBox2.Margin = new Padding(6);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(50, 50);
            checkBox2.TabIndex = 8;
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.Click += CheckBox_Clicked;
            // 
            // checkBox3
            // 
            checkBox3.BackColor = Color.FromArgb(128, 255, 255);
            checkBox3.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.ForeColor = Color.Black;
            checkBox3.Location = new Point(203, 124);
            checkBox3.Margin = new Padding(6);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(50, 50);
            checkBox3.TabIndex = 9;
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.Click += CheckBox_Clicked;
            // 
            // checkBox4
            // 
            checkBox4.BackColor = Color.FromArgb(255, 128, 255);
            checkBox4.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.ForeColor = Color.Black;
            checkBox4.Location = new Point(265, 124);
            checkBox4.Margin = new Padding(6);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(50, 50);
            checkBox4.TabIndex = 10;
            checkBox4.UseVisualStyleBackColor = false;
            checkBox4.Click += CheckBox_Clicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1600, 900);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += PictureBox1_Paint;
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(1188, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 509);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(56, 197);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 294);
            textBox1.TabIndex = 13;
            textBox1.Text = "Левая кнопка мыши для выделения прямоугольников, которые полностью попали в рамку. Правая кнопка мыши для выделения прямоугольников, которые полностью или частично попали в рамку.\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Rectangles";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}
