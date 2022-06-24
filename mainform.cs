using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace save_dat_helper_2
{
    public partial class mainform : Form
    {
        bool mouseDown;
        private Point offset;
        bool settings;

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


        public mainform()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public void formInPanel(object Form)
        {
            if (this.display.Controls.Count > 0)
            {
                this.display.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            this.display.Controls.Add(form);
            form.Show();
        }

        public void mainform_Load(object sender, EventArgs e)
        {
            formInPanel(new savedatform());
        }

        //events

        private void e_mousedown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void e_mousemove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currrentScreenPos =  PointToScreen(e.Location);
                Location = new Point(currrentScreenPos.X - offset.X, currrentScreenPos.Y - offset.Y);
            }
        }

        private void e_mouseup(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void eX_mouseLeave(object sender, EventArgs e)
        {
            button_X.Image = save_dat_helper_2.Properties.Resources.button_close;
        }

        private void eX_mouseEnter(object sender, EventArgs e)
        {
            button_X.Image = save_dat_helper_2.Properties.Resources.button_closehover;
        }

        //buttons

        private void button_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            
            if (settings == false)
            {
                formInPanel(new settingsform());
                button_settings.Image = save_dat_helper_2.Properties.Resources.button_back;
                settings = true;
            }
            else
            {
                formInPanel(new savedatform());
                button_settings.Image = save_dat_helper_2.Properties.Resources.button_settings;
                settings = false;
            }
        }
    }
}
