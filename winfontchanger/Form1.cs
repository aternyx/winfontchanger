using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace winfontchanger
{
    public partial class mainform : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public mainform()
        {
            InitializeComponent();
        }

        private void toolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void toolbar_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            fontfamily.Text = fontDialog1.Font.Name;
        }

        private void fontfamily_TextChanged(object sender, EventArgs e)
        {
            string selectedFontFamily = fontfamily.Text;
            fontfamily.Font = new Font(selectedFontFamily, fontfamily.Font.Size, fontfamily.Font.Style);
            fontfamilyChange.Height = fontfamily.Height;
        }

        private void execute_Click(object sender, EventArgs e)
        {
            string beforeexMessage = "From this point you should have a restore point created, if anything goes wrong.\nIf you don't, you should go ahead and make one, to prevent some corruption or no font. \nDO YOU STILL WANT TO CONTINUE?";
            string beforeexTitle = "Warning";
            MessageBoxButtons beforeexButtons = MessageBoxButtons.YesNo;
            DialogResult beforeexResult = MessageBox.Show(beforeexMessage, beforeexTitle, beforeexButtons, MessageBoxIcon.Warning);
            if (beforeexResult == DialogResult.Yes)
            {
                using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
                {
                    foreach (FontFamily fontFamily in fontsCollection.Families)
                    {
                        if (fontFamily.Name.Equals(fontfamily.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            string temppath = System.IO.Path.GetTempPath();
                            bool hasBackslash = temppath.EndsWith("\\");
                            if (hasBackslash)
                            {
                                string path = temppath + "newfont.reg";
                                if (File.Exists(path))
                                {
                                    File.Delete(path);
                                }
                                using (FileStream fs = File.Create(path)) ;
                                File.AppendAllText(path, "Windows Registry Editor Version 5.00\n\n" +
                                    "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Fonts]\n" +
                                    "\"Segoe UI (TrueType)\"=\"\"\n" +
                                    "\"Segoe UI Bold (TrueType)\"=\"\"\n" +
                                    "\"Segoe UI Bold Italic (TrueType)\"=\"\"\n" +
                                    "\"Segoe UI Italic (TrueType)\"=\"\"\n" +
                                    "\"Segoe UI Light (TrueType)\"=\"\"\n" +
                                    "\"Segoe UI Semibold (TrueType)\"=\"\"\n" +
                                    "\"Segoe UI Symbol (TrueType)\"=\"\"\n\n" +
                                    "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\FontSubstitutes]\n" +
                                    "\"Segoe UI\"=\"" + fontfamily.Text + "\"");
                                Process regeditProcess = Process.Start("regedit.exe", "/s \"" + path + "\"");
                                regeditProcess.WaitForExit();
                                string message = "The default font was successfully changed to " + fontfamily.Text + ". \nTo apply changes, you should restart your computer. Want to restart now?";
                                MessageBoxButtons msgbuttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, "Success", msgbuttons);
                                if (result == DialogResult.Yes)
                                {
                                    this.Close();
                                    Process.Start("shutdown", "/r /t 0");
                                }
                            }
                            else
                            {
                                //string path = temppath + "\\newfont.reg";
                                //using (FileStream fs = File.Create(path))
                            }

                            return;
                        }
                    }
                }
                string errmessage = "The font family you specified does not exists. Please insert the exact name of the font family that is installed in your PC";
                MessageBox.Show(errmessage);
            }

        }

        private void resetDef_Click(object sender, EventArgs e)
        {
            string temppath = System.IO.Path.GetTempPath();
            bool hasBackslash = temppath.EndsWith("\\");
            if (hasBackslash)
            {
                string path = temppath + "newfont.reg";
                using (FileStream fs = File.Create(path)) ;
                File.AppendAllText(path, "Windows Registry Editor Version 5.00\n\n" +
                    "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Fonts]\n" +
                    "\"Segoe UI (TrueType)\"=\"segoeui.ttf\"\n" +
                    "\"Segoe UI Black (TrueType)\"=\"seguibl.ttf\"\n" +
                    "\"Segoe UI Black Italic (TrueType)\"=\"seguibli.ttf\"\n" +
                    "\"Segoe UI Italic (TrueType)\"=\"\"\n" +
                    "\"Segoe UI Light (TrueType)\"=\"\"\n" +
                    "\"Segoe UI Semibold (TrueType)\"=\"\"\n" +
                    "\"Segoe UI Symbol (TrueType)\"=\"\"\n\n" +
                    "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\FontSubstitutes]\n" +
                    "\"Segoe UI\"=\"" + fontfamily.Text + "\"");
                Process regeditProcess = Process.Start("regedit.exe", "/s \"" + path + "\"");
                regeditProcess.WaitForExit();
                string message = "The font was successfully resetted to default. \nTo apply changes, you should restart your computer. Want to restart now?";
                MessageBoxButtons msgbuttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "Success", msgbuttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    Process.Start("shutdown", "/r /t 0");
                }
            }
            else
            {
                //string path = temppath + "\\newfont.reg";
                //using (FileStream fs = File.Create(path))
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
