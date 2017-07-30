/*
 * Kyle Dodaro
 * Beta 0.1: 12/11/16 - 1/22/2017
 * Beta 0.2: 1/22/2017 - 1/23/2017
 * Allows for the suspension of processes
 */

using System;
using System.Linq;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace ProcessSuspend
{
    public partial class frmMain : Form
    {
        bool usesConfig = false;
        int pid = 0;
        public string processName = "gta5";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            checkDirectory();
            if (usesConfig != false)
            {
                readConfig();
            }
            updateNameLabel();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            Process[] game = Process.GetProcessesByName(processName);
            if (game.Length > 0)
            {
                pid = game[0].Id;
                SuspendProcess(pid);
            }
            else
            {
                MessageBox.Show("GTA not found");
            }

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            ResumeProcess(pid);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions options = new frmOptions();
            options.Show();
        }

        private void newNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processName = Microsoft.VisualBasic.Interaction.InputBox("Enter a new process name. (is not saved between runs unless selected)").Trim();
            if (processName != null && processName != " " && processName != "")
            {
                saveProcessName(processName);
                updateNameLabel();
            }
        }

        private void processListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcessList processes = new frmProcessList();
            processes.Show();
        }

        #region Suspension and Resuming

        /// The process-specific access rights.
        [Flags]
        public enum ProcessAccess : uint
        {
            // Required to terminate a process using TerminateProcess.
            Terminate = 0x1,

            // Required to create a thread.
            CreateThread = 0x2,

            // Undocumented.
            SetSessionId = 0x4,

            // Required to perform an operation on the address space of a process (see VirtualProtectEx and WriteProcessMemory).
            VmOperation = 0x8,

            // Required to read memory in a process using ReadProcessMemory.
            VmRead = 0x10,

            // Required to write to memory in a process using WriteProcessMemory.
            VmWrite = 0x20,

            // Required to duplicate a handle using DuplicateHandle.
            DupHandle = 0x40,

            // Required to create a process.
            CreateProcess = 0x80,

            // Required to set memory limits using SetProcessWorkingSetSize.
            SetQuota = 0x100,

            // Required to set certain information about a process, such as its priority class (see SetPriorityClass).
            SetInformation = 0x200,

            // Required to retrieve certain information about a process, such as its token, exit code, and priority class (see OpenProcessToken, GetExitCodeProcess, GetPriorityClass, and IsProcessInJob).
            QueryInformation = 0x400,

            // Undocumented.
            SetPort = 0x800,

            // Required to suspend or resume a process.
            SuspendResume = 0x800,

            // Required to retrieve certain information about a process (see QueryFullProcessImageName). A handle that has the PROCESS_QUERY_INFORMATION access right is automatically granted PROCESS_QUERY_LIMITED_INFORMATION.
            QueryLimitedInformation = 0x1000,

            // Required to wait for the process to terminate using the wait functions.
            Synchronize = 0x100000
        }

        [DllImport("ntdll.dll")]
        internal static extern uint NtResumeProcess([In] IntPtr processHandle);

        [DllImport("ntdll.dll")]
        internal static extern uint NtSuspendProcess([In] IntPtr processHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr OpenProcess(
            ProcessAccess desiredAccess,
            bool inheritHandle,
            int processId);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CloseHandle([In] IntPtr handle);

        public static void SuspendProcess(int processId)
        {
            IntPtr hProc = IntPtr.Zero;
            try
            {
                hProc = OpenProcess(ProcessAccess.SuspendResume, false, processId);

                if (hProc != IntPtr.Zero)
                {
                    NtSuspendProcess(hProc);
                }
            }
            finally
            {
                if (hProc != IntPtr.Zero)
                {
                    CloseHandle(hProc);
                }
            }
        }

        public static void ResumeProcess(int processId)
        {
            IntPtr hProc = IntPtr.Zero;
            try
            {
                hProc = OpenProcess(ProcessAccess.SuspendResume, false, processId);

                if (hProc != IntPtr.Zero)
                {
                    NtResumeProcess(hProc);
                }
            }
            finally
            {
                if (hProc != IntPtr.Zero)
                {
                    CloseHandle(hProc);
                }
            }
        }
        #endregion

        #region File IO
        public void checkDirectory()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\KCDev\\ProcessSuspend";
            if (Directory.Exists(path))
            {
                usesConfig = true;
            }
        }
        public void readConfig()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\KCDev\\ProcessSuspend";
            List<string> data = new List<string>();

            using (FileStream fs = new FileStream(path + "\\config.cfg", FileMode.Open, FileAccess.ReadWrite))
            {
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    data.Add(sr.ReadLine());
                }
                sr.Close();
            }
            if (data.Count() > 1)
            {
                processName = data[1];
            }
            updateNameLabel();
        }

        public void saveProcessName(string name)
        {
            checkDirectory();
            if (usesConfig == true)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\KCDev\\ProcessSuspend";
                frmProcessList processList = new frmProcessList();
                saveNewName(path, name);      
            }
        }

        public void saveNewName(string path, string process)
        {
            frmOptions optionsForm = new frmOptions();
            optionsForm.selectAction("deleteDirectory");
            optionsForm.selectAction("createDirectory");
            optionsForm.selectAction("createConfig");
            optionsForm.selectAction("writeSaveStatusToConfigString", process);
        }
        #endregion

        public void updateNameLabel()
        {
            lblProcessName.Text = "Process name: " + processName;
        }


    }
}