namespace PlayGround
{
    partial class MyC_PlayGround
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
            this.Btn_FileOpen = new System.Windows.Forms.Button();
            this.TxtB_Input = new System.Windows.Forms.TextBox();
            this.TxtB_Output = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Lbl_FileName = new System.Windows.Forms.Label();
            this.Lbl_Exit = new System.Windows.Forms.Button();
            this.Lbl_Input = new System.Windows.Forms.Label();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.Btn_Process = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_FileOpen
            // 
            this.Btn_FileOpen.Location = new System.Drawing.Point(12, 12);
            this.Btn_FileOpen.Name = "Btn_FileOpen";
            this.Btn_FileOpen.Size = new System.Drawing.Size(75, 23);
            this.Btn_FileOpen.TabIndex = 0;
            this.Btn_FileOpen.Text = "File Open";
            this.Btn_FileOpen.UseVisualStyleBackColor = true;
            this.Btn_FileOpen.Click += new System.EventHandler(this.Btn_FileOpen_Click);
            // 
            // TxtB_Input
            // 
            this.TxtB_Input.Location = new System.Drawing.Point(12, 109);
            this.TxtB_Input.Multiline = true;
            this.TxtB_Input.Name = "TxtB_Input";
            this.TxtB_Input.Size = new System.Drawing.Size(393, 461);
            this.TxtB_Input.TabIndex = 1;
            this.TxtB_Input.TextChanged += new System.EventHandler(this.TxtB_Input_TextChanged);
            // 
            // TxtB_Output
            // 
            this.TxtB_Output.Location = new System.Drawing.Point(411, 109);
            this.TxtB_Output.Multiline = true;
            this.TxtB_Output.Name = "TxtB_Output";
            this.TxtB_Output.Size = new System.Drawing.Size(393, 461);
            this.TxtB_Output.TabIndex = 2;
            this.TxtB_Output.TextChanged += new System.EventHandler(this.TxtB_Output_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Lbl_FileName
            // 
            this.Lbl_FileName.AutoSize = true;
            this.Lbl_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FileName.Location = new System.Drawing.Point(93, 22);
            this.Lbl_FileName.Name = "Lbl_FileName";
            this.Lbl_FileName.Size = new System.Drawing.Size(96, 13);
            this.Lbl_FileName.TabIndex = 5;
            this.Lbl_FileName.Text = "No file selected";
            // 
            // Lbl_Exit
            // 
            this.Lbl_Exit.Location = new System.Drawing.Point(715, 12);
            this.Lbl_Exit.Name = "Lbl_Exit";
            this.Lbl_Exit.Size = new System.Drawing.Size(75, 23);
            this.Lbl_Exit.TabIndex = 6;
            this.Lbl_Exit.Text = "Exit";
            this.Lbl_Exit.UseVisualStyleBackColor = true;
            this.Lbl_Exit.Click += new System.EventHandler(this.Lbl_Exit_Click);
            // 
            // Lbl_Input
            // 
            this.Lbl_Input.AutoSize = true;
            this.Lbl_Input.Location = new System.Drawing.Point(13, 90);
            this.Lbl_Input.Name = "Lbl_Input";
            this.Lbl_Input.Size = new System.Drawing.Size(184, 13);
            this.Lbl_Input.TabIndex = 7;
            this.Lbl_Input.Text = "Enter text or slect text file from above.";
            this.Lbl_Input.Click += new System.EventHandler(this.Lbl_Input_Click);
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.AutoSize = true;
            this.Lbl_Output.Location = new System.Drawing.Point(411, 89);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(75, 13);
            this.Lbl_Output.TabIndex = 8;
            this.Lbl_Output.Text = "Parsed Output";
            this.Lbl_Output.Click += new System.EventHandler(this.Lbl_Output_Click);
            // 
            // Btn_Process
            // 
            this.Btn_Process.Location = new System.Drawing.Point(339, 579);
            this.Btn_Process.Name = "Btn_Process";
            this.Btn_Process.Size = new System.Drawing.Size(147, 23);
            this.Btn_Process.TabIndex = 9;
            this.Btn_Process.Text = "Process";
            this.Btn_Process.UseVisualStyleBackColor = true;
            this.Btn_Process.Click += new System.EventHandler(this.Btn_Process_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(13, 577);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reset.TabIndex = 10;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // MyC_PlayGround
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 614);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_Process);
            this.Controls.Add(this.Lbl_Output);
            this.Controls.Add(this.Lbl_Input);
            this.Controls.Add(this.Lbl_Exit);
            this.Controls.Add(this.Lbl_FileName);
            this.Controls.Add(this.TxtB_Output);
            this.Controls.Add(this.TxtB_Input);
            this.Controls.Add(this.Btn_FileOpen);
            this.Name = "MyC_PlayGround";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "My C Sharp Playground";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_FileOpen;
        private System.Windows.Forms.TextBox TxtB_Input;
        private System.Windows.Forms.TextBox TxtB_Output;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Lbl_FileName;
        private System.Windows.Forms.Button Lbl_Exit;
        private System.Windows.Forms.Label Lbl_Input;
        private System.Windows.Forms.Label Lbl_Output;
        private System.Windows.Forms.Button Btn_Process;
        private System.Windows.Forms.Button Btn_Reset;
    }
}