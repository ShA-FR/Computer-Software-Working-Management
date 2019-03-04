namespace Project_CSWM
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
            this.components = new System.ComponentModel.Container();
            this.TaskManagerChk = new System.Windows.Forms.CheckBox();
            this.CreditsLbl = new System.Windows.Forms.Label();
            this.CreateRestorePointBtn = new System.Windows.Forms.Button();
            this.RestorePointNty = new System.Windows.Forms.NotifyIcon(this.components);
            this.TaskManagerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskManagerChk
            // 
            this.TaskManagerChk.AutoSize = true;
            this.TaskManagerChk.Location = new System.Drawing.Point(12, 86);
            this.TaskManagerChk.Name = "TaskManagerChk";
            this.TaskManagerChk.Size = new System.Drawing.Size(183, 17);
            this.TaskManagerChk.TabIndex = 0;
            this.TaskManagerChk.Text = "[Enable/Disable] - Task Manager";
            this.TaskManagerChk.UseVisualStyleBackColor = true;
            this.TaskManagerChk.CheckedChanged += new System.EventHandler(this.TaskManagerChk_CheckedChanged);
            // 
            // CreditsLbl
            // 
            this.CreditsLbl.AutoSize = true;
            this.CreditsLbl.Location = new System.Drawing.Point(9, 118);
            this.CreditsLbl.Name = "CreditsLbl";
            this.CreditsLbl.Size = new System.Drawing.Size(238, 13);
            this.CreditsLbl.TabIndex = 1;
            this.CreditsLbl.Text = "Computer Software Working Management - 2019";
            // 
            // CreateRestorePointBtn
            // 
            this.CreateRestorePointBtn.Location = new System.Drawing.Point(12, 12);
            this.CreateRestorePointBtn.Name = "CreateRestorePointBtn";
            this.CreateRestorePointBtn.Size = new System.Drawing.Size(238, 23);
            this.CreateRestorePointBtn.TabIndex = 2;
            this.CreateRestorePointBtn.Text = "Create Restore Point";
            this.CreateRestorePointBtn.UseVisualStyleBackColor = true;
            this.CreateRestorePointBtn.Click += new System.EventHandler(this.CreateRestorePointBtn_Click);
            // 
            // RestorePointNty
            // 
            this.RestorePointNty.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.RestorePointNty.BalloonTipText = "Creating restore point..";
            this.RestorePointNty.BalloonTipTitle = "Restore Point";
            this.RestorePointNty.Text = "CSWM - Restore Point";
            this.RestorePointNty.Visible = true;
            // 
            // TaskManagerBtn
            // 
            this.TaskManagerBtn.Location = new System.Drawing.Point(12, 41);
            this.TaskManagerBtn.Name = "TaskManagerBtn";
            this.TaskManagerBtn.Size = new System.Drawing.Size(238, 23);
            this.TaskManagerBtn.TabIndex = 3;
            this.TaskManagerBtn.Text = "Task Manager";
            this.TaskManagerBtn.UseVisualStyleBackColor = true;
            this.TaskManagerBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 142);
            this.Controls.Add(this.TaskManagerBtn);
            this.Controls.Add(this.CreateRestorePointBtn);
            this.Controls.Add(this.CreditsLbl);
            this.Controls.Add(this.TaskManagerChk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CSWM - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TaskManagerChk;
        private System.Windows.Forms.Label CreditsLbl;
        private System.Windows.Forms.Button CreateRestorePointBtn;
        private System.Windows.Forms.NotifyIcon RestorePointNty;
        private System.Windows.Forms.Button TaskManagerBtn;
    }
}

