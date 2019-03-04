using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSWM
{
    public partial class TaskManagerViewer : Form
    {
        public TaskManagerViewer()
        {
            InitializeComponent();
            Process[] MyProcess = Process.GetProcesses();
            for (int i = 0; i < MyProcess.Length; i++)
                dataGridView1.Rows.Add(string.Format(MyProcess[i].ProcessName), MyProcess[i].Id, FormatBytes(MyProcess[i].PagedMemorySize, 1, true));
        }

        private string FormatBytes(long bytes, int decimalPlaces, bool showByteType)
        {
            double num = bytes;
            string format = "{0";
            string str2 = "B";
            if ((num > 1024.0) && (num < 1048576.0))
            {
                num /= 1024.0;
                str2 = "Ko";
            }
            else if ((num > 1048576.0) && (num < 1073741824.0))
            {
                num /= 1048576.0;
                str2 = "Mo";
            }
            else
            {
                num /= 1073741824.0;
                str2 = "Go";
            }
            if (decimalPlaces > 0)
            {
                format = format + ":0.";
            }
            for (int i = 0; i < decimalPlaces; i++)
            {
                format = format + "0";
            }
            format = format + "}";
            if (showByteType)
            {
                format = format + str2;
            }
            return string.Format(format, num);
        }

        private void TaskManagerTimer_Tick(object sender, EventArgs e)
        {

            dataGridView1.Refresh();
            dataGridView1.Update();


            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            ProcessNameLbl.Text = dataGridView1.Rows[i].Cells["ProcessName"].Value.ToString() +".exe";
            dataGridView1.Refresh();
            dataGridView1.Update();



        }

        private void KillProcess_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /F /IM "+ProcessNameLbl.Text+" /T");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " +ex.Message);
            }
           
        }
    }
}
