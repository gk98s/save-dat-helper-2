namespace save_dat_helper_2
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.display = new System.Windows.Forms.Panel();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_X = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_X)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_settings);
            this.panel1.Controls.Add(this.button_X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 40);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.e_mousedown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.e_mousemove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.e_mouseup);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(0, 43);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(1167, 595);
            this.display.TabIndex = 3;
            // 
            // button_settings
            // 
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Image = global::save_dat_helper_2.Properties.Resources.button_settings;
            this.button_settings.Location = new System.Drawing.Point(13, 12);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(25, 25);
            this.button_settings.TabIndex = 4;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_X
            // 
            this.button_X.Image = global::save_dat_helper_2.Properties.Resources.button_close;
            this.button_X.Location = new System.Drawing.Point(1130, 12);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(25, 25);
            this.button_X.TabIndex = 3;
            this.button_X.TabStop = false;
            this.button_X.Click += new System.EventHandler(this.button_X_Click);
            this.button_X.MouseEnter += new System.EventHandler(this.eX_mouseEnter);
            this.button_X.MouseLeave += new System.EventHandler(this.eX_mouseLeave);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1167, 640);
            this.Controls.Add(this.display);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.Text = "Save Dat Helper 2";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_X)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel display;
        private System.Windows.Forms.PictureBox button_X;
        private System.Windows.Forms.Button button_settings;
    }
}

