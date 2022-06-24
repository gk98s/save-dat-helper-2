using System;
using System.Windows.Forms;
using System.IO;


namespace save_dat_helper_2
{
    public partial class savedatform : Form
    {
        string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        DirectoryInfo dinfo;


        public savedatform()
        {
            InitializeComponent();

            if (save_dat_helper_2.Properties.Settings.Default.manualPath == false)
            {
                dinfo = new DirectoryInfo(userPath + @"\AppData\Local\Growtopia");
            }
            else
            {
                if (save_dat_helper_2.Properties.Settings.Default.gtPath != null)
                {
                    if (File.Exists(save_dat_helper_2.Properties.Settings.Default.gtPath))
                    {
                        dinfo = new DirectoryInfo(save_dat_helper_2.Properties.Settings.Default.gtPath);
                    }
                    else
                    {
                        dinfo = new DirectoryInfo(userPath + @"\AppData\Local\Growtopia");
                        
                    }
                }
                else
                {
                    dinfo = new DirectoryInfo(userPath + @"\AppData\Local\Growtopia");
                }
                
            }


            FileInfo[] Files = dinfo.GetFiles("*.dat");


            foreach (FileInfo file in Files)
            {
                listBox_saveDatList.Items.Add(file.Name);
            }
            listBox_saveDatList.Items.Remove("save.dat");

        }

        private void savedatform_Load(object sender, EventArgs e)
        {

        }

        //buttons

        private void button_refresh_Click(object sender, EventArgs e)
        {
            listBox_saveDatList.Items.Clear();
            
            FileInfo[] Files = dinfo.GetFiles("*.dat");
            foreach (FileInfo file in Files)
            {
                listBox_saveDatList.Items.Add(file.Name);
            }
            listBox_saveDatList.Items.Remove("save.dat");
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            mainform mainform = new mainform();
            mainform.formInPanel(new settingsform());
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            string gtPath;

            if (Properties.Settings.Default.manualPath == true)
            {
                gtPath = Properties.Settings.Default.gtPath;
            }
            else
            {
                gtPath = userPath + @"\AppData\Local\Growtopia";
            }

            if (listBox_saveDatList.SelectedItem == null)
            {
                MessageBox.Show("You need to select a save.dat before you do this.", "Error!");
            } //no selected item exception handler
            else
            {
                string selectedSaveDat = listBox_saveDatList.GetItemText(listBox_saveDatList.SelectedItem);
                string selectedPath = gtPath + "\\" +selectedSaveDat;

                if (File.Exists(selectedPath))
                {
                    File.Delete(gtPath + @"\save.dat");
                    File.Copy(selectedPath, gtPath + @"\save.dat");

                    Properties.Settings.Default.lastLoaded = selectedSaveDat;
                    listBox_saveDatList.Items.Clear();

                    //refresh
                    FileInfo[] Files = dinfo.GetFiles("*.dat");
                    foreach (FileInfo file in Files)
                    {
                        listBox_saveDatList.Items.Add(file.Name);
                    }
                    listBox_saveDatList.Items.Remove("save.dat");
                }
                else
                {
                    MessageBox.Show("The selected save.dat doesn't exist. Try refreshing or contact GK98.", "Error!");
                }
            }
        }

        private void button_saveCurrent_Click(object sender, EventArgs e)
        {
            string currentSaveDat;
            
            if (Properties.Settings.Default.lastLoaded != null)
            {
                currentSaveDat = Properties.Settings.Default.lastLoaded;
            }
            else
            {
                currentSaveDat = "a4123578768176437";
            }

            if (currentSaveDat == "a4123578768176437")
            {
                MessageBox.Show("You must rename your save.dat file to: \"[name].dat\". and load it atleast once.", "Error!");
            }
            else
            {
                MessageBox.Show("asas", "asas");
            }
        }
    }
}