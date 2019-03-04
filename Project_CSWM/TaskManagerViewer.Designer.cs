namespace Project_CSWM
{
    partial class TaskManagerViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KillProcess = new System.Windows.Forms.Button();
            this.TaskManagerTimer = new System.Windows.Forms.Timer(this.components);
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessNameIsLbl = new System.Windows.Forms.Label();
            this.ProcessNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.pID,
            this.Memory});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(514, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // KillProcess
            // 
            this.KillProcess.Location = new System.Drawing.Point(13, 252);
            this.KillProcess.Name = "KillProcess";
            this.KillProcess.Size = new System.Drawing.Size(513, 23);
            this.KillProcess.TabIndex = 1;
            this.KillProcess.Text = "Kill Process";
            this.KillProcess.UseVisualStyleBackColor = true;
            this.KillProcess.Click += new System.EventHandler(this.KillProcess_Click);
            // 
            // TaskManagerTimer
            // 
            this.TaskManagerTimer.Enabled = true;
            this.TaskManagerTimer.Tick += new System.EventHandler(this.TaskManagerTimer_Tick);
            // 
            // ProcessName
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ProcessName.DefaultCellStyle = dataGridViewCellStyle7;
            this.ProcessName.HeaderText = "Process name";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            // 
            // pID
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.pID.DefaultCellStyle = dataGridViewCellStyle8;
            this.pID.HeaderText = "pID";
            this.pID.Name = "pID";
            this.pID.ReadOnly = true;
            // 
            // Memory
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Memory.DefaultCellStyle = dataGridViewCellStyle9;
            this.Memory.HeaderText = "Memory";
            this.Memory.Name = "Memory";
            this.Memory.ReadOnly = true;
            // 
            // ProcessNameIsLbl
            // 
            this.ProcessNameIsLbl.AutoSize = true;
            this.ProcessNameIsLbl.Location = new System.Drawing.Point(12, 291);
            this.ProcessNameIsLbl.Name = "ProcessNameIsLbl";
            this.ProcessNameIsLbl.Size = new System.Drawing.Size(80, 13);
            this.ProcessNameIsLbl.TabIndex = 2;
            this.ProcessNameIsLbl.Text = "Process name :";
            // 
            // ProcessNameLbl
            // 
            this.ProcessNameLbl.AutoSize = true;
            this.ProcessNameLbl.Location = new System.Drawing.Point(91, 278);
            this.ProcessNameLbl.Name = "ProcessNameLbl";
            this.ProcessNameLbl.Size = new System.Drawing.Size(0, 13);
            this.ProcessNameLbl.TabIndex = 3;
            // 
            // TaskManagerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 338);
            this.Controls.Add(this.ProcessNameLbl);
            this.Controls.Add(this.ProcessNameIsLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.KillProcess);
            this.Name = "TaskManagerViewer";
            this.Text = "TaskManagerViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button KillProcess;
        private System.Windows.Forms.Timer TaskManagerTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.Label ProcessNameIsLbl;
        private System.Windows.Forms.Label ProcessNameLbl;
    }
}