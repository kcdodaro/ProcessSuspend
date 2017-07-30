using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ProcessSuspend
{
    public partial class frmProcessList : Form
    {
        public frmProcessList()
        {
            InitializeComponent();
        }

        Process[] processes;

        private void frmProcessList_Load(object sender, EventArgs e)
        {
            getProcesses();
            updateList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getProcesses();
            updateList();
        }

        #region Methods
        public void getProcesses()
        {
            processes = Process.GetProcesses();
        }

        public void updateList()
        {
            for(int i = 0; i < processes.Length; i++)
            {
                lstProcesses.Items.Add(processes[i].ToString());
            }
        }
        #endregion

        #region File IO 
        public bool checkDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion 
    }
}
