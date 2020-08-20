namespace text_data_compactor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputFiles_lb = new System.Windows.Forms.ListBox();
            this.Output_tb = new System.Windows.Forms.TextBox();
            this.convert_bt = new System.Windows.Forms.Button();
            this.Remove_bt = new System.Windows.Forms.Button();
            this.log_tb = new System.Windows.Forms.TextBox();
            this.add_bt = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Label();
            this.Create_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.excluding_tb = new System.Windows.Forms.TextBox();
            this.adHeader_tb = new System.Windows.Forms.TextBox();
            this.excluding_Yes_rb = new System.Windows.Forms.RadioButton();
            this.excluding_No_rb = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adHeader_Yes_rd = new System.Windows.Forms.RadioButton();
            this.adHeader_No_rd = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.autosort_Yes_rb = new System.Windows.Forms.RadioButton();
            this.autosort_No_rb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputFiles_lb
            // 
            this.InputFiles_lb.AllowDrop = true;
            this.InputFiles_lb.FormattingEnabled = true;
            this.InputFiles_lb.ItemHeight = 25;
            this.InputFiles_lb.Location = new System.Drawing.Point(24, 23);
            this.InputFiles_lb.Margin = new System.Windows.Forms.Padding(6);
            this.InputFiles_lb.Name = "InputFiles_lb";
            this.InputFiles_lb.Size = new System.Drawing.Size(892, 104);
            this.InputFiles_lb.TabIndex = 0;
            this.InputFiles_lb.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputFiles_lb_DragDrop);
            this.InputFiles_lb.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputFiles_lb_DragEnter);
            // 
            // Output_tb
            // 
            this.Output_tb.Location = new System.Drawing.Point(24, 142);
            this.Output_tb.Margin = new System.Windows.Forms.Padding(6);
            this.Output_tb.Name = "Output_tb";
            this.Output_tb.Size = new System.Drawing.Size(440, 31);
            this.Output_tb.TabIndex = 1;
            this.Output_tb.Text = "Output";
            // 
            // convert_bt
            // 
            this.convert_bt.Location = new System.Drawing.Point(932, 253);
            this.convert_bt.Margin = new System.Windows.Forms.Padding(6);
            this.convert_bt.Name = "convert_bt";
            this.convert_bt.Size = new System.Drawing.Size(234, 90);
            this.convert_bt.TabIndex = 2;
            this.convert_bt.Text = "Append";
            this.convert_bt.UseVisualStyleBackColor = true;
            this.convert_bt.Click += new System.EventHandler(this.convert_bt_Click);
            // 
            // Remove_bt
            // 
            this.Remove_bt.Location = new System.Drawing.Point(932, 81);
            this.Remove_bt.Margin = new System.Windows.Forms.Padding(6);
            this.Remove_bt.Name = "Remove_bt";
            this.Remove_bt.Size = new System.Drawing.Size(234, 44);
            this.Remove_bt.TabIndex = 3;
            this.Remove_bt.Text = "Remove Selected File";
            this.Remove_bt.UseVisualStyleBackColor = true;
            this.Remove_bt.Click += new System.EventHandler(this.Delete_bt_Click);
            // 
            // log_tb
            // 
            this.log_tb.Location = new System.Drawing.Point(24, 416);
            this.log_tb.Margin = new System.Windows.Forms.Padding(6);
            this.log_tb.Multiline = true;
            this.log_tb.Name = "log_tb";
            this.log_tb.ReadOnly = true;
            this.log_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_tb.Size = new System.Drawing.Size(1132, 146);
            this.log_tb.TabIndex = 21;
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(932, 25);
            this.add_bt.Margin = new System.Windows.Forms.Padding(6);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(234, 44);
            this.add_bt.TabIndex = 22;
            this.add_bt.Text = "Add File";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(18, 368);
            this.Log.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(54, 25);
            this.Log.TabIndex = 23;
            this.Log.Text = "Log:";
            // 
            // Create_bt
            // 
            this.Create_bt.Location = new System.Drawing.Point(480, 142);
            this.Create_bt.Margin = new System.Windows.Forms.Padding(6);
            this.Create_bt.Name = "Create_bt";
            this.Create_bt.Size = new System.Drawing.Size(204, 44);
            this.Create_bt.TabIndex = 24;
            this.Create_bt.Text = "Select Output File";
            this.Create_bt.UseVisualStyleBackColor = true;
            this.Create_bt.Click += new System.EventHandler(this.Create_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Excluding Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 50);
            this.label2.TabIndex = 26;
            this.label2.Text = "Add Header at the top \r\nwhich is not excluded";
            // 
            // excluding_tb
            // 
            this.excluding_tb.Location = new System.Drawing.Point(720, 253);
            this.excluding_tb.Margin = new System.Windows.Forms.Padding(6);
            this.excluding_tb.Name = "excluding_tb";
            this.excluding_tb.Size = new System.Drawing.Size(196, 31);
            this.excluding_tb.TabIndex = 31;
            this.excluding_tb.Text = ",Dew,Hum,Temp";
            // 
            // adHeader_tb
            // 
            this.adHeader_tb.Location = new System.Drawing.Point(720, 301);
            this.adHeader_tb.Margin = new System.Windows.Forms.Padding(6);
            this.adHeader_tb.Name = "adHeader_tb";
            this.adHeader_tb.Size = new System.Drawing.Size(196, 31);
            this.adHeader_tb.TabIndex = 32;
            this.adHeader_tb.Text = ",Dew,Hum,Temp";
            // 
            // excluding_Yes_rb
            // 
            this.excluding_Yes_rb.AutoSize = true;
            this.excluding_Yes_rb.Checked = true;
            this.excluding_Yes_rb.Location = new System.Drawing.Point(216, 2);
            this.excluding_Yes_rb.Margin = new System.Windows.Forms.Padding(6);
            this.excluding_Yes_rb.Name = "excluding_Yes_rb";
            this.excluding_Yes_rb.Size = new System.Drawing.Size(81, 29);
            this.excluding_Yes_rb.TabIndex = 30;
            this.excluding_Yes_rb.TabStop = true;
            this.excluding_Yes_rb.Text = "Yes";
            this.excluding_Yes_rb.UseVisualStyleBackColor = true;
            this.excluding_Yes_rb.CheckedChanged += new System.EventHandler(this.excluding_Yes_rb_CheckedChanged);
            // 
            // excluding_No_rb
            // 
            this.excluding_No_rb.AutoSize = true;
            this.excluding_No_rb.Location = new System.Drawing.Point(94, 2);
            this.excluding_No_rb.Margin = new System.Windows.Forms.Padding(6);
            this.excluding_No_rb.Name = "excluding_No_rb";
            this.excluding_No_rb.Size = new System.Drawing.Size(70, 29);
            this.excluding_No_rb.TabIndex = 29;
            this.excluding_No_rb.Text = "No";
            this.excluding_No_rb.UseVisualStyleBackColor = true;
            this.excluding_No_rb.CheckedChanged += new System.EventHandler(this.excluding_No_rb_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.excluding_Yes_rb);
            this.panel1.Controls.Add(this.excluding_No_rb);
            this.panel1.Location = new System.Drawing.Point(382, 257);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 37);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adHeader_Yes_rd);
            this.panel2.Controls.Add(this.adHeader_No_rd);
            this.panel2.Location = new System.Drawing.Point(382, 307);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 37);
            this.panel2.TabIndex = 34;
            // 
            // adHeader_Yes_rd
            // 
            this.adHeader_Yes_rd.AutoSize = true;
            this.adHeader_Yes_rd.Checked = true;
            this.adHeader_Yes_rd.Location = new System.Drawing.Point(216, 2);
            this.adHeader_Yes_rd.Margin = new System.Windows.Forms.Padding(6);
            this.adHeader_Yes_rd.Name = "adHeader_Yes_rd";
            this.adHeader_Yes_rd.Size = new System.Drawing.Size(81, 29);
            this.adHeader_Yes_rd.TabIndex = 30;
            this.adHeader_Yes_rd.TabStop = true;
            this.adHeader_Yes_rd.Text = "Yes";
            this.adHeader_Yes_rd.UseVisualStyleBackColor = true;
            this.adHeader_Yes_rd.CheckedChanged += new System.EventHandler(this.adHeader_Yes_rd_CheckedChanged);
            // 
            // adHeader_No_rd
            // 
            this.adHeader_No_rd.AutoSize = true;
            this.adHeader_No_rd.Location = new System.Drawing.Point(94, 2);
            this.adHeader_No_rd.Margin = new System.Windows.Forms.Padding(6);
            this.adHeader_No_rd.Name = "adHeader_No_rd";
            this.adHeader_No_rd.Size = new System.Drawing.Size(70, 29);
            this.adHeader_No_rd.TabIndex = 29;
            this.adHeader_No_rd.Text = "No";
            this.adHeader_No_rd.UseVisualStyleBackColor = true;
            this.adHeader_No_rd.CheckedChanged += new System.EventHandler(this.adHeader_No_rd_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.autosort_Yes_rb);
            this.panel3.Controls.Add(this.autosort_No_rb);
            this.panel3.Location = new System.Drawing.Point(381, 206);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 37);
            this.panel3.TabIndex = 35;
            // 
            // autosort_Yes_rb
            // 
            this.autosort_Yes_rb.AutoSize = true;
            this.autosort_Yes_rb.Checked = true;
            this.autosort_Yes_rb.Location = new System.Drawing.Point(216, 2);
            this.autosort_Yes_rb.Margin = new System.Windows.Forms.Padding(6);
            this.autosort_Yes_rb.Name = "autosort_Yes_rb";
            this.autosort_Yes_rb.Size = new System.Drawing.Size(81, 29);
            this.autosort_Yes_rb.TabIndex = 30;
            this.autosort_Yes_rb.TabStop = true;
            this.autosort_Yes_rb.Text = "Yes";
            this.autosort_Yes_rb.UseVisualStyleBackColor = true;
            this.autosort_Yes_rb.CheckedChanged += new System.EventHandler(this.autosort_Yes_rb_CheckedChanged);
            // 
            // autosort_No_rb
            // 
            this.autosort_No_rb.AutoSize = true;
            this.autosort_No_rb.Location = new System.Drawing.Point(94, 2);
            this.autosort_No_rb.Margin = new System.Windows.Forms.Padding(6);
            this.autosort_No_rb.Name = "autosort_No_rb";
            this.autosort_No_rb.Size = new System.Drawing.Size(70, 29);
            this.autosort_No_rb.TabIndex = 29;
            this.autosort_No_rb.Text = "No";
            this.autosort_No_rb.UseVisualStyleBackColor = true;
            this.autosort_No_rb.CheckedChanged += new System.EventHandler(this.autosort_No_rb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Autosort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 632);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adHeader_tb);
            this.Controls.Add(this.excluding_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_bt);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.log_tb);
            this.Controls.Add(this.Remove_bt);
            this.Controls.Add(this.convert_bt);
            this.Controls.Add(this.Output_tb);
            this.Controls.Add(this.InputFiles_lb);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "text_data_compactor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InputFiles_lb;
        private System.Windows.Forms.TextBox Output_tb;
        private System.Windows.Forms.Button convert_bt;
        private System.Windows.Forms.Button Remove_bt;
        private System.Windows.Forms.TextBox log_tb;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Button Create_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox excluding_tb;
        private System.Windows.Forms.TextBox adHeader_tb;
        private System.Windows.Forms.RadioButton excluding_Yes_rb;
        private System.Windows.Forms.RadioButton excluding_No_rb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton adHeader_Yes_rd;
        private System.Windows.Forms.RadioButton adHeader_No_rd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton autosort_Yes_rb;
        private System.Windows.Forms.RadioButton autosort_No_rb;
        private System.Windows.Forms.Label label3;
    }
}

