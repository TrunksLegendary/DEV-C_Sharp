namespace PlayGround
{
    partial class MainWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtB_Output = new System.Windows.Forms.TextBox();
            this.TxtB_Input = new System.Windows.Forms.TextBox();
            this.Lbl_Input = new System.Windows.Forms.Label();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtB_Output
            // 
            this.TxtB_Output.Location = new System.Drawing.Point(379, 156);
            this.TxtB_Output.Multiline = true;
            this.TxtB_Output.Name = "TxtB_Output";
            this.TxtB_Output.Size = new System.Drawing.Size(356, 372);
            this.TxtB_Output.TabIndex = 2;
            // 
            // TxtB_Input
            // 
            this.TxtB_Input.Location = new System.Drawing.Point(12, 156);
            this.TxtB_Input.Multiline = true;
            this.TxtB_Input.Name = "TxtB_Input";
            this.TxtB_Input.Size = new System.Drawing.Size(356, 372);
            this.TxtB_Input.TabIndex = 3;
            // 
            // Lbl_Input
            // 
            this.Lbl_Input.AutoSize = true;
            this.Lbl_Input.Location = new System.Drawing.Point(9, 140);
            this.Lbl_Input.Name = "Lbl_Input";
            this.Lbl_Input.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Input.TabIndex = 4;
            this.Lbl_Input.Text = "Input Text";
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.AutoSize = true;
            this.Lbl_Output.Location = new System.Drawing.Point(376, 140);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(63, 13);
            this.Lbl_Output.TabIndex = 5;
            this.Lbl_Output.Text = "Output Text";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 609);
            this.Controls.Add(this.Lbl_Output);
            this.Controls.Add(this.Lbl_Input);
            this.Controls.Add(this.TxtB_Input);
            this.Controls.Add(this.TxtB_Output);
            this.Controls.Add(this.button1);
            this.Name = "MainWindow";
            this.Text = "My PlayGround App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtB_Output;
        private System.Windows.Forms.TextBox TxtB_Input;
        private System.Windows.Forms.Label Lbl_Input;
        private System.Windows.Forms.Label Lbl_Output;
    }
}