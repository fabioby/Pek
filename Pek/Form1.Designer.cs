namespace Pek
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.listBox_termekek = new System.Windows.Forms.ListBox();
            this.listBox_pekseg = new System.Windows.Forms.ListBox();
            this.button_pekseg = new System.Windows.Forms.Button();
            this.textBox_pekseg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.listBox_pekaru = new System.Windows.Forms.ListBox();
            this.button_pekaru = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_date = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.listBox_statistic = new System.Windows.Forms.ListBox();
            this.label_count = new System.Windows.Forms.Label();
            this.label_avg = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_bool = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(670, 417);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adatok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.listBox_termekek);
            this.groupBox2.Controls.Add(this.listBox_pekseg);
            this.groupBox2.Controls.Add(this.button_pekseg);
            this.groupBox2.Controls.Add(this.textBox_pekseg);
            this.groupBox2.Location = new System.Drawing.Point(6, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 235);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pékségek";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(506, 184);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(61, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // listBox_termekek
            // 
            this.listBox_termekek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_termekek.FormattingEnabled = true;
            this.listBox_termekek.ItemHeight = 16;
            this.listBox_termekek.Location = new System.Drawing.Point(429, 21);
            this.listBox_termekek.Name = "listBox_termekek";
            this.listBox_termekek.Size = new System.Drawing.Size(209, 148);
            this.listBox_termekek.TabIndex = 7;
            // 
            // listBox_pekseg
            // 
            this.listBox_pekseg.FormattingEnabled = true;
            this.listBox_pekseg.ItemHeight = 16;
            this.listBox_pekseg.Location = new System.Drawing.Point(213, 21);
            this.listBox_pekseg.Name = "listBox_pekseg";
            this.listBox_pekseg.Size = new System.Drawing.Size(210, 196);
            this.listBox_pekseg.TabIndex = 6;
            this.listBox_pekseg.SelectedValueChanged += new System.EventHandler(this.listBox_pekseg_SelectedValueChanged);
            // 
            // button_pekseg
            // 
            this.button_pekseg.Location = new System.Drawing.Point(7, 49);
            this.button_pekseg.Name = "button_pekseg";
            this.button_pekseg.Size = new System.Drawing.Size(118, 23);
            this.button_pekseg.TabIndex = 3;
            this.button_pekseg.Text = "hozzáadás";
            this.button_pekseg.UseVisualStyleBackColor = true;
            this.button_pekseg.Click += new System.EventHandler(this.button_pekseg_Click);
            // 
            // textBox_pekseg
            // 
            this.textBox_pekseg.Location = new System.Drawing.Point(7, 21);
            this.textBox_pekseg.Name = "textBox_pekseg";
            this.textBox_pekseg.Size = new System.Drawing.Size(182, 22);
            this.textBox_pekseg.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox_price);
            this.groupBox1.Controls.Add(this.listBox_pekaru);
            this.groupBox1.Controls.Add(this.button_pekaru);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pékárúk";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(7, 50);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(182, 22);
            this.textBox_price.TabIndex = 4;
            // 
            // listBox_pekaru
            // 
            this.listBox_pekaru.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_pekaru.FormattingEnabled = true;
            this.listBox_pekaru.ItemHeight = 16;
            this.listBox_pekaru.Location = new System.Drawing.Point(213, 21);
            this.listBox_pekaru.Name = "listBox_pekaru";
            this.listBox_pekaru.Size = new System.Drawing.Size(425, 100);
            this.listBox_pekaru.TabIndex = 3;
            // 
            // button_pekaru
            // 
            this.button_pekaru.Location = new System.Drawing.Point(6, 105);
            this.button_pekaru.Name = "button_pekaru";
            this.button_pekaru.Size = new System.Drawing.Size(118, 23);
            this.button_pekaru.TabIndex = 2;
            this.button_pekaru.Text = "hozzáadás";
            this.button_pekaru.UseVisualStyleBackColor = true;
            this.button_pekaru.Click += new System.EventHandler(this.button_pekaru_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "laktózmentes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(7, 22);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(182, 22);
            this.textBox_name.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_bool);
            this.tabPage2.Controls.Add(this.label_max);
            this.tabPage2.Controls.Add(this.label_min);
            this.tabPage2.Controls.Add(this.label_avg);
            this.tabPage2.Controls.Add(this.label_count);
            this.tabPage2.Controls.Add(this.label_date);
            this.tabPage2.Controls.Add(this.label_name);
            this.tabPage2.Controls.Add(this.listBox_statistic);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statisztikák";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(232, 42);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(62, 17);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Alapítva:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(232, 16);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(37, 17);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Név:";
            // 
            // listBox_statistic
            // 
            this.listBox_statistic.FormattingEnabled = true;
            this.listBox_statistic.ItemHeight = 16;
            this.listBox_statistic.Location = new System.Drawing.Point(6, 6);
            this.listBox_statistic.Name = "listBox_statistic";
            this.listBox_statistic.Size = new System.Drawing.Size(219, 244);
            this.listBox_statistic.TabIndex = 0;
            this.listBox_statistic.SelectedValueChanged += new System.EventHandler(this.listBox_statistic_SelectedValueChanged);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(232, 87);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(64, 17);
            this.label_count.TabIndex = 3;
            this.label_count.Text = "Pékáruk:";
            // 
            // label_avg
            // 
            this.label_avg.AutoSize = true;
            this.label_avg.Location = new System.Drawing.Point(232, 117);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(76, 17);
            this.label_avg.TabIndex = 4;
            this.label_avg.Text = "Átlagos ár:";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(232, 144);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(85, 17);
            this.label_min.TabIndex = 5;
            this.label_min.Text = "Legolcsobb:";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(232, 172);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(89, 17);
            this.label_max.TabIndex = 6;
            this.label_max.Text = "Legdrágább:";
            // 
            // label_bool
            // 
            this.label_bool.AutoSize = true;
            this.label_bool.Location = new System.Drawing.Point(233, 201);
            this.label_bool.Name = "label_bool";
            this.label_bool.Size = new System.Drawing.Size(162, 17);
            this.label_bool.TabIndex = 7;
            this.label_bool.Text = "Laktózmentes termékek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 441);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_pekaru;
        private System.Windows.Forms.Button button_pekaru;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListBox listBox_termekek;
        private System.Windows.Forms.ListBox listBox_pekseg;
        private System.Windows.Forms.Button button_pekseg;
        private System.Windows.Forms.TextBox textBox_pekseg;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ListBox listBox_statistic;
        private System.Windows.Forms.Label label_bool;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_avg;
        private System.Windows.Forms.Label label_count;
    }
}

