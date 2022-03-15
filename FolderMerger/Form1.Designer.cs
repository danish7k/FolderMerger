namespace FolderMerger
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
            this.SelectSrc1 = new System.Windows.Forms.Button();
            this.SelectSrc2 = new System.Windows.Forms.Button();
            this.Source1Path = new System.Windows.Forms.TextBox();
            this.Source2Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DestPath = new System.Windows.Forms.TextBox();
            this.Merge = new System.Windows.Forms.Button();
            this.SelectDestBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // SelectSrc1
            // 
            this.SelectSrc1.Location = new System.Drawing.Point(670, 56);
            this.SelectSrc1.Name = "SelectSrc1";
            this.SelectSrc1.Size = new System.Drawing.Size(101, 23);
            this.SelectSrc1.TabIndex = 0;
            this.SelectSrc1.Text = "Select Folder";
            this.SelectSrc1.UseVisualStyleBackColor = true;
            this.SelectSrc1.Click += new System.EventHandler(this.SelectSrc1_Click);
            // 
            // SelectSrc2
            // 
            this.SelectSrc2.Location = new System.Drawing.Point(670, 92);
            this.SelectSrc2.Name = "SelectSrc2";
            this.SelectSrc2.Size = new System.Drawing.Size(101, 23);
            this.SelectSrc2.TabIndex = 1;
            this.SelectSrc2.Text = "Select Folder";
            this.SelectSrc2.UseVisualStyleBackColor = true;
            this.SelectSrc2.Click += new System.EventHandler(this.SelectSrc2_Click);
            // 
            // Source1Path
            // 
            this.Source1Path.Location = new System.Drawing.Point(121, 60);
            this.Source1Path.Name = "Source1Path";
            this.Source1Path.ReadOnly = true;
            this.Source1Path.Size = new System.Drawing.Size(478, 23);
            this.Source1Path.TabIndex = 2;
            // 
            // Source2Path
            // 
            this.Source2Path.Location = new System.Drawing.Point(121, 89);
            this.Source2Path.Name = "Source2Path";
            this.Source2Path.ReadOnly = true;
            this.Source2Path.Size = new System.Drawing.Size(478, 23);
            this.Source2Path.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destination";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DestPath
            // 
            this.DestPath.Location = new System.Drawing.Point(121, 133);
            this.DestPath.Name = "DestPath";
            this.DestPath.ReadOnly = true;
            this.DestPath.Size = new System.Drawing.Size(478, 23);
            this.DestPath.TabIndex = 7;
            // 
            // Merge
            // 
            this.Merge.Location = new System.Drawing.Point(121, 179);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(75, 23);
            this.Merge.TabIndex = 9;
            this.Merge.Text = "Merge";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.Merge_Click);
            // 
            // SelectDestBtn
            // 
            this.SelectDestBtn.Location = new System.Drawing.Point(622, 128);
            this.SelectDestBtn.Name = "SelectDestBtn";
            this.SelectDestBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SelectDestBtn.Size = new System.Drawing.Size(149, 23);
            this.SelectDestBtn.TabIndex = 10;
            this.SelectDestBtn.Text = "Select Destination";
            this.SelectDestBtn.UseVisualStyleBackColor = true;
            this.SelectDestBtn.Click += new System.EventHandler(this.SelectDestBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "O-Merger Tool";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(48, 221);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(723, 193);
            this.LogBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(222, 179);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(377, 23);
            this.progressBar.TabIndex = 15;
            this.progressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectDestBtn);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.DestPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Source2Path);
            this.Controls.Add(this.Source1Path);
            this.Controls.Add(this.SelectSrc2);
            this.Controls.Add(this.SelectSrc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectDestBtn;
        private Button SelectSrc2;
        private TextBox Source1Path;
        private TextBox Source2Path;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox DestPath;
        private Button Merge;
        private Button SelectSrc1;
        private Label label4;
        private TextBox LogBox;
        private Button button1;
        private ProgressBar progressBar;
    }
}