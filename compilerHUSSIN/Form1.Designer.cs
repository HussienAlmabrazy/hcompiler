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
            this.tok = new System.Windows.Forms.TextBox();
            this.scan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(12, 87);
            this.txtb.Multiline = true;
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(268, 401);
            this.txtb.TabIndex = 0;
            this.txtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lexi
            // 
            this.lexi.Location = new System.Drawing.Point(299, 87);
            this.lexi.Multiline = true;
            this.lexi.Name = "lexi";
            this.lexi.Size = new System.Drawing.Size(268, 401);
            this.lexi.TabIndex = 1;
            // 
            // tok
            // 
            this.tok.Location = new System.Drawing.Point(584, 87);
            this.tok.Multiline = true;
            this.tok.Name = "tok";
            this.tok.Size = new System.Drawing.Size(268, 401);
            this.tok.TabIndex = 2;
            this.tok.TextChanged += new System.EventHandler(this.tok_TextChanged);
            // 
            // scan
            // 
            this.scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan.ForeColor = System.Drawing.Color.Maroon;
            this.scan.Location = new System.Drawing.Point(153, 12);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(127, 49);
            this.scan.TabIndex = 3;
            this.scan.Text = "scanner";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 500);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.tok);
            this.Controls.Add(this.lexi);
            this.Controls.Add(this.txtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox lexi;
        private System.Windows.Forms.TextBox tok;
        private System.Windows.Forms.Button scan;
    }
}

