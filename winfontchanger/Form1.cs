using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                foreach (FontFamily fontFamily in fontsCollection.Families)
                {
                    if (fontFamily.Name.Equals(fontfamily.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        string message = "existent";
                        MessageBox.Show(message);
                        return;
                    }
                }
            }
            string errmessage = "unexistent";
            MessageBox.Show(errmessage);
        }
    }
}
