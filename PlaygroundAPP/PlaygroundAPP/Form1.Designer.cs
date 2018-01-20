namespace PaygroundAPP
{
    partial class MyFirstApp
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
            this.Btn_Parse = new System.Windows.Forms.Button();
            this.Btn_IPScan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Txt_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Parse
            // 
            this.Btn_Parse.Location = new System.Drawing.Point(12, 12);
            this.Btn_Parse.Name = "Btn_Parse";
            this.Btn_Parse.Size = new System.Drawing.Size(75, 23);
            this.Btn_Parse.TabIndex = 0;
            this.Btn_Parse.Text = "Parse Text";
            this.Btn_Parse.UseVisualStyleBackColor = true;
            this.Btn_Parse.Click += new System.EventHandler(this.Btn_Parse_Click);
            // 
            // Btn_IPScan
            // 
            this.Btn_IPScan.Location = new System.Drawing.Point(93, 12);
            this.Btn_IPScan.Name = "Btn_IPScan";
            this.Btn_IPScan.Size = new System.Drawing.Size(75, 23);
            this.Btn_IPScan.TabIndex = 1;
            this.Btn_IPScan.Text = "IP Scan";
            this.Btn_IPScan.UseVisualStyleBackColor = true;
            this.Btn_IPScan.Click += new System.EventHandler(this.Btn_IPScan_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(417, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Txt_Result
            // 
            this.Txt_Result.Location = new System.Drawing.Point(12, 80);
            this.Txt_Result.Multiline = true;
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.Size = new System.Drawing.Size(480, 309);
            this.Txt_Result.TabIndex = 7;
            // 
            // MyFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 401);
            this.Controls.Add(this.Txt_Result);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_IPScan);
            this.Controls.Add(this.Btn_Parse);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "MyFirstApp";
            this.Text = "My First Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Parse;
        private System.Windows.Forms.Button Btn_IPScan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Txt_Result;
    }
}

