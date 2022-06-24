using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace save_dat_helper_2
{
    public partial class settingsform : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

        public settingsform()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void settingsform_Load(object sender, EventArgs e)
        {
            //manualPath
            if (save_dat_helper_2.Properties.Settings.Default.manualPath == true)
            {
                manualPath.Checked = true;
            }
            else
            {
                manualPath.Checked = false;
            }

            //showManualPath
            if (save_dat_helper_2.Properties.Settings.Default.manualPath == true)
            {
                button_browseGtLoc.Visible = true;
                textBox_gtPath.Visible = true;
            }
            else
            {
                button_browseGtLoc.Visible = false;
                textBox_gtPath.Visible = false;
            }

            textBox_gtPath.Text = Properties.Settings.Default.gtPath;

            //rounded buttons
            button_browseGtLoc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button_browseGtLoc.Width, button_browseGtLoc.Height, 15, 15));
        }

        //checkboxes

        private void manualPath_CheckedChanged(object sender, EventArgs e)
        {
            if (manualPath.Checked == true)
            {
                save_dat_helper_2.Properties.Settings.Default.manualPath = true;
                button_browseGtLoc.Visible = true;
                textBox_gtPath.Visible = true;
            }
            else
            {
                save_dat_helper_2.Properties.Settings.Default.manualPath = false;
                button_browseGtLoc.Visible = false;
                textBox_gtPath.Visible = false;
            }
            save_dat_helper_2.Properties.Settings.Default.Save();
        }

        //buttons

        private void button_browseGtLoc_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    textBox_gtPath.Text = fbd.SelectedPath;
            }
        }

        //events

        private void eManualPath_mouseHover(object sender, EventArgs e)
        {
            toolTip.Show("If you dont see any save.dats, then you might wanna set your growtopia path manually.",manualPath);
        }
    }
}
