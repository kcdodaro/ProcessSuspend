using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ProcessSuspend
{
    public partial class frmOptions : Form
    {
        bool savesName = false;

        public frmOptions()
        {
            InitializeComponent();
        }

        private void radNewNo_CheckedChanged(object sender, EventArgs e)
        {
            selectAction("deleteDirectory");
            frmMain main = new frmMain();
            main.processName = "gta5";
            main.updateNameLabel();            
        }

        private void radNewYes_CheckedChanged(object sender, EventArgs e)
        {
            selectAction("createDirectory");
            selectAction("createConfig");
            selectAction("writeSaveStatusToConfig");
        }

        private void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check to see if the version here is higher than what you have installed (Release 1.0)");
            Process.Start("https://drive.google.com/open?id=0B8Or6LrXA_jtVVYyUHd5SjNHVU0");
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            selectAction("checkSaveStatus");
            if (savesName)
            {
                radNewYes.Checked = true;
            }
        }

        private void btnOpenSave_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\KCDev\\ProcessSuspend"))
            {
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\KCDev\\ProcessSuspend");
            }
            else
            {
                MessageBox.Show("Not using save data.");
            }
        }

        #region FileIO
        //this is a really nasty action tree
        //fix this and make it less nasty pls
        public void selectAction(string strAction)
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = basePath + "\\KCDev\\ProcessSuspend";
            string configPath = basePath + "\\KCDev\\ProcessSuspend\\config.cfg";

            if (strAction == "createDirectory" || strAction == "deleteDirectory" || strAction == "checkDirectory")
            {
                switch (strAction)
                {
                    case "createDirectory":
                        createDirectory(folderPath);
                        break;
                    case "deleteDirectory":
                        deleteDirectory(folderPath);
                        break;
                    case "checkDirectory":
                        checkDirectory(folderPath);
                        break;
                }
            }
            else if (strAction == "createConfig" || strAction == "writeSaveStatusToConfig" || strAction == "checkSaveStatus" || strAction == "writeSaveStatusToConfigProcess" || strAction == "writeSaveStatusToConfigString")
            {
                switch (strAction)
                {
                    case "createConfig":
                        createConfig(configPath);
                        break;
                    case "writeSaveStatusToConfig":
                        writeSaveStatusToConfig(configPath);
                        break;
                    case "writeSaveStatusToConfigProcess":
                        writeSaveStatusToConfig(configPath);
                        break;
                    case "writeSaveStatusToConfigString":
                        writeSaveStatusToConfig(configPath);
                        break;
                    case "checkSaveStatus":
                        checkSaveStatus(configPath);
                        break;
                }
            }
        }

        public void selectAction(string strAction, string process)
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderPath = basePath + "\\KCDev\\ProcessSuspend";
            string configPath = basePath + "\\KCDev\\ProcessSuspend\\config.cfg";

            if (strAction == "createDirectory" || strAction == "deleteDirectory" || strAction == "checkDirectory")
            {
                switch (strAction)
                {
                    case "createDirectory":
                        createDirectory(folderPath);
                        break;
                    case "deleteDirectory":
                        deleteDirectory(folderPath);
                        break;
                    case "checkDirectory":
                        checkDirectory(folderPath);
                        break;
                }
            }
            else if (strAction == "createConfig" || strAction == "writeSaveStatusToConfig" || strAction == "checkSaveStatus" || strAction == "writeSaveStatusToConfigString")
            {
                switch (strAction)
                {
                    case "createConfig":
                        createConfig(configPath);
                        break;
                    case "writeSaveStatusToConfig":
                        writeSaveStatusToConfig(configPath);
                        break;
                    case "writeSaveStatusToConfigString":
                        writeSaveStatusToConfig(configPath, process);
                        break;
                    case "checkSaveStatus":
                        checkSaveStatus(configPath);
                        break;
                }
            }
        }
        //Directory pathed methods
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

        public void createDirectory(string path)
        {
                Directory.CreateDirectory(path);
        }

        public void deleteDirectory(string path)
        {
                selectAction("createDirectory");
               Directory.Delete(path, true);
        }

        //Config pathed methods
        public void createConfig(string path)
        {
                selectAction("createDirectory");
                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path))
                    {
                        
                    }
                }
        }

        public void writeSaveStatusToConfig(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("true");
                sw.Close();
            }
        }

        public void writeSaveStatusToConfig(string path, string process)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("true");
                sw.WriteLine(process);
                sw.Close();
            }
        }

        public void checkSaveStatus(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
                {

                    StreamReader sr = new StreamReader(fs);
                    savesName = Convert.ToBoolean(sr.ReadLine());
                    sr.Close();
                }
            }
            catch
            {
                savesName = false;
            }
        }

        
    }
    #endregion
}