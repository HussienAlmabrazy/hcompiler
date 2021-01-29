namespace compilerHUSSIN
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
            this.txtb = new System.Windows.Forms.TextBox();
            this.lexi = new System.Windows.Forms.TextBox();
            this.scan = new System.Windows.Forms.Button();
            this.tok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(12, 87);
            this.txtb.Multiline = true;
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(268, 401);
            this.txtb.TabIndex = 0;
            this.txtb.Text = "int x=3;switch(x){case 1:MessageBox.Show(\"hello\");break;case 2:int x=7;break;defa" +
    "ult :MessageBox.Show(\"hussien\");\r\n};\r\n";
            this.txtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lexi
            // 
            this.lexi.Location = new System.Drawing.Point(286, 87);
            this.lexi.Multiline = true;
            this.lexi.Name = "lexi";
            this.lexi.Size = new System.Drawing.Size(268, 401);
            this.lexi.TabIndex = 1;
            // 
            // scan
            // 
            this.scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan.ForeColor = System.Drawing.Color.Gray;
            this.scan.Location = new System.Drawing.Point(12, 32);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(268, 49);
            this.scan.TabIndex = 3;
            this.scan.Text = "scanner";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // tok
            // 
            this.tok.FormattingEnabled = true;
            this.tok.Location = new System.Drawing.Point(560, 87);
            this.tok.Name = "tok";
            this.tok.Size = new System.Drawing.Size(264, 407);
            this.tok.TabIndex = 4;
            this.tok.SelectedIndexChanged += new System.EventHandler(this.tok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(377, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "lixicalanalyzer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(614, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "token";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(856, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tok);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.lexi);
            this.Controls.Add(this.txtb);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox lexi;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.ListBox tok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

