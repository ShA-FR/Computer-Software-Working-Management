using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSWM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        static readonly string[] SizeSuffixes = { "bytes", "Ko", "Mo", "Go", "To", "PB", "EB", "ZB", "YB" };

        private void TaskManagerChk_CheckedChanged(object sender, EventArgs e)
        {
            if (TaskManagerChk.Checked == true)
            {
                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
             @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                if (objRegistryKey.GetValue("DisableTaskMgr") == null)
                {
                    objRegistryKey.SetValue("DisableTaskMgr", "1");

                }
                else
                {
                    objRegistryKey.DeleteValue("DisableTaskMgr");
                    objRegistryKey.Close();
                }

            }
            else if (TaskManagerChk.Checked == false)
            {
                RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
            @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                if (objRegistryKey.GetValue("DisableTaskMgr") == null)
                {
                    objRegistryKey.SetValue("DisableTaskMgr", "0");

                }
                else
                {
                    objRegistryKey.DeleteValue("DisableTaskMgr");
                    objRegistryKey.Close();
                }

            }
        }

        private void CreateRestorePointBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RestorePointNty.Icon = SystemIcons.Application;
                RestorePointNty.BalloonTipTitle = "CSWM - Restore";
                RestorePointNty.BalloonTipText = "Creating restore point..";
                RestorePointNty.ShowBalloonTip(100);

                var restorePointName = "CSWM - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
                var managementPath = new ManagementPath(@"\\.\ROOT\DEFAULT:SystemRestore");
                var systemRestoreClass = new ManagementClass(managementPath);
                var methodParameters = systemRestoreClass.Methods["CreateRestorePoint"].InParameters;

                methodParameters.Properties["Description"].Value = "CSWM - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
                methodParameters.Properties["EventType"].Value = 100u;
                methodParameters.Properties["Description"].Value = "CSWM - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();

                var outParameters = systemRestoreClass.InvokeMethod("CreateRestorePoint", methodParameters, null);
                var hresult = unchecked((int)(uint)outParameters["ReturnValue"]);

                RestorePointNty.Icon = SystemIcons.Application;
                RestorePointNty.BalloonTipTitle = "CSWM - Restore";
                RestorePointNty.BalloonTipText = "Restore point created!";
                RestorePointNty.ShowBalloonTip(100);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TaskManagerViewer F1 = new TaskManagerViewer();
            F1.Show();
            this.Hide();
        }

    }
}

