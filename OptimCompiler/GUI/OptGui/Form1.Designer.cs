﻿namespace OptGui
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox62 = new System.Windows.Forms.CheckBox();
            this.checkBox61 = new System.Windows.Forms.CheckBox();
            this.checkBox60 = new System.Windows.Forms.CheckBox();
            this.checkBox59 = new System.Windows.Forms.CheckBox();
            this.checkBox58 = new System.Windows.Forms.CheckBox();
            this.checkBox57 = new System.Windows.Forms.CheckBox();
            this.checkBox56 = new System.Windows.Forms.CheckBox();
            this.checkBox55 = new System.Windows.Forms.CheckBox();
            this.checkBox54 = new System.Windows.Forms.CheckBox();
            this.checkBox53 = new System.Windows.Forms.CheckBox();
            this.checkBox52 = new System.Windows.Forms.CheckBox();
            this.checkBox51 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(501, 359);
            this.textBox2.TabIndex = 1;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Исходный код",
            "Трехадресный код",
            "Блоки трехадресного кода",
            "Граф потока управления",
            "Запуск",
            "Оптимизации по дереву",
            "Полученный трехадресный код",
            "Блоки трехадресного кода",
            "Граф потока управления",
            "Запуск"});
            this.comboBox2.Location = new System.Drawing.Point(0, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(501, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 359);
            this.textBox1.TabIndex = 1;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Исходный код",
            "Трехадресный код",
            "Блоки трехадресного кода",
            "Граф потока управления",
            "Запуск",
            "Оптимизации по дереву",
            "Полученный трехадресный код",
            "Блоки трехадресного кода",
            "Граф потока управления",
            "Запуск"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(505, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox62);
            this.tabPage2.Controls.Add(this.checkBox61);
            this.tabPage2.Controls.Add(this.checkBox60);
            this.tabPage2.Controls.Add(this.checkBox59);
            this.tabPage2.Controls.Add(this.checkBox58);
            this.tabPage2.Controls.Add(this.checkBox57);
            this.tabPage2.Controls.Add(this.checkBox56);
            this.tabPage2.Controls.Add(this.checkBox55);
            this.tabPage2.Controls.Add(this.checkBox54);
            this.tabPage2.Controls.Add(this.checkBox53);
            this.tabPage2.Controls.Add(this.checkBox52);
            this.tabPage2.Controls.Add(this.checkBox51);
            this.tabPage2.Controls.Add(this.checkBox10);
            this.tabPage2.Controls.Add(this.checkBox9);
            this.tabPage2.Controls.Add(this.checkBox8);
            this.tabPage2.Controls.Add(this.checkBox7);
            this.tabPage2.Controls.Add(this.checkBox6);
            this.tabPage2.Controls.Add(this.checkBox5);
            this.tabPage2.Controls.Add(this.checkBox4);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Optimizations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox62
            // 
            this.checkBox62.AutoSize = true;
            this.checkBox62.Location = new System.Drawing.Point(300, 259);
            this.checkBox62.Name = "checkBox62";
            this.checkBox62.Size = new System.Drawing.Size(89, 17);
            this.checkBox62.TabIndex = 3;
            this.checkBox62.Text = "2 * 3 (3)";
            this.checkBox62.UseVisualStyleBackColor = true;
            this.checkBox62.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox61
            // 
            this.checkBox61.AutoSize = true;
            this.checkBox61.Location = new System.Drawing.Point(300, 236);
            this.checkBox61.Name = "checkBox61";
            this.checkBox61.Size = new System.Drawing.Size(89, 17);
            this.checkBox61.TabIndex = 3;
            this.checkBox61.Text = "2 < 3 (6)";
            this.checkBox61.UseVisualStyleBackColor = true;
            this.checkBox61.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox60
            // 
            this.checkBox60.AutoSize = true;
            this.checkBox60.Location = new System.Drawing.Point(300, 213);
            this.checkBox60.Name = "checkBox60";
            this.checkBox60.Size = new System.Drawing.Size(89, 17);
            this.checkBox60.TabIndex = 3;
            this.checkBox60.Text = "if (false) (12)";
            this.checkBox60.UseVisualStyleBackColor = true;
            this.checkBox60.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox59
            // 
            this.checkBox59.AutoSize = true;
            this.checkBox59.Location = new System.Drawing.Point(300, 190);
            this.checkBox59.Name = "checkBox59";
            this.checkBox59.Size = new System.Drawing.Size(89, 17);
            this.checkBox59.TabIndex = 3;
            this.checkBox59.Text = "0+a (4)";
            this.checkBox59.UseVisualStyleBackColor = true;
            this.checkBox59.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox58
            // 
            this.checkBox58.AutoSize = true;
            this.checkBox58.Location = new System.Drawing.Point(300, 167);
            this.checkBox58.Name = "checkBox58";
            this.checkBox58.Size = new System.Drawing.Size(89, 17);
            this.checkBox58.TabIndex = 3;
            this.checkBox58.Text = "while (false) st; (14)";
            this.checkBox58.UseVisualStyleBackColor = true;
            this.checkBox58.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox57
            // 
            this.checkBox57.AutoSize = true;
            this.checkBox57.Location = new System.Drawing.Point(300, 144);
            this.checkBox57.Name = "checkBox57";
            this.checkBox57.Size = new System.Drawing.Size(89, 17);
            this.checkBox57.TabIndex = 3;
            this.checkBox57.Text = "1 * ex, ex * 1, ex / 1 (1)";
            this.checkBox57.UseVisualStyleBackColor = true;
            this.checkBox57.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);

            // 
            // checkBox56
            // 
            this.checkBox56.AutoSize = true;
            this.checkBox56.Location = new System.Drawing.Point(300, 121);
            this.checkBox56.Name = "checkBox56";
            this.checkBox56.Size = new System.Drawing.Size(89, 17);
            this.checkBox56.TabIndex = 3;
            this.checkBox56.Text = "x = x (10)";
            this.checkBox56.UseVisualStyleBackColor = true;
            this.checkBox56.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox55
            // 
            this.checkBox55.AutoSize = true;
            this.checkBox55.Location = new System.Drawing.Point(300, 98);
            this.checkBox55.Name = "checkBox55";
            this.checkBox55.Size = new System.Drawing.Size(89, 17);
            this.checkBox55.TabIndex = 3;
            this.checkBox55.Text = "a – a (5)";
            this.checkBox55.UseVisualStyleBackColor = true;
            this.checkBox55.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox54
            // 
            this.checkBox54.AutoSize = true;
            this.checkBox54.Location = new System.Drawing.Point(300, 75);
            this.checkBox54.Name = "checkBox54";
            this.checkBox54.Size = new System.Drawing.Size(89, 17);
            this.checkBox54.TabIndex = 3;
            this.checkBox54.Text = "if (ex) null; else null; (13)";
            this.checkBox54.UseVisualStyleBackColor = true;
            this.checkBox54.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox53
            // 
            this.checkBox53.AutoSize = true;
            this.checkBox53.Location = new System.Drawing.Point(300, 52);
            this.checkBox53.Name = "checkBox53";
            this.checkBox53.Size = new System.Drawing.Size(89, 17);
            this.checkBox53.TabIndex = 3;
            this.checkBox53.Text = "a == a, a >= a (8)";
            this.checkBox53.UseVisualStyleBackColor = true;
            this.checkBox53.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox52
            // 
            this.checkBox52.AutoSize = true;
            this.checkBox52.Location = new System.Drawing.Point(300, 29);
            this.checkBox52.Name = "checkBox52";
            this.checkBox52.Size = new System.Drawing.Size(89, 17);
            this.checkBox52.TabIndex = 3;
            this.checkBox52.Text = "If True (11)";
            this.checkBox52.UseVisualStyleBackColor = true;
            this.checkBox52.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox51
            // 
            this.checkBox51.AutoSize = true;
            this.checkBox51.Location = new System.Drawing.Point(300, 6);
            this.checkBox51.Name = "checkBox51";
            this.checkBox51.Size = new System.Drawing.Size(89, 17);
            this.checkBox51.TabIndex = 3;
            this.checkBox51.Text = "Mull on Null (2)";
            this.checkBox51.UseVisualStyleBackColor = true;
            this.checkBox51.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(4, 214);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(89, 17);
            this.checkBox10.TabIndex = 3;
            this.checkBox10.Text = "Unreachable Code";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(4, 191);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(89, 17);
            this.checkBox9.TabIndex = 3;
            this.checkBox9.Text = "Pull Of Copies";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(4, 168);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(89, 17);
            this.checkBox8.TabIndex = 3;
            this.checkBox8.Text = "Delete Of Dead Code";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(4, 145);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(89, 17);
            this.checkBox7.TabIndex = 3;
            this.checkBox7.Text = "Def Use Dead Code";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(4, 122);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(89, 17);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "Def Use Const";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(4, 99);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(89, 17);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Non Zero JTJ";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(4, 76);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Dead or alive";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(4, 53);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(142, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Apply algebraic identities";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Eval const expr";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Distribution of Constant";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox2);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1010, 380);
            this.splitContainer2.SplitterDistance = 505;
            this.splitContainer2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "FIIT19";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox62;
        private System.Windows.Forms.CheckBox checkBox61;
        private System.Windows.Forms.CheckBox checkBox60;
        private System.Windows.Forms.CheckBox checkBox59;
        private System.Windows.Forms.CheckBox checkBox58;
        private System.Windows.Forms.CheckBox checkBox57;
        private System.Windows.Forms.CheckBox checkBox56;
        private System.Windows.Forms.CheckBox checkBox55;
        private System.Windows.Forms.CheckBox checkBox54;
        private System.Windows.Forms.CheckBox checkBox53;
        private System.Windows.Forms.CheckBox checkBox52;
        private System.Windows.Forms.CheckBox checkBox51;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

