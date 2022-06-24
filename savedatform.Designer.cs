namespace save_dat_helper_2
{
    partial class savedatform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(savedatform));
            this.listBox_saveDatList = new System.Windows.Forms.ListBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_saveCurrent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_saveDatList
            // 
            this.listBox_saveDatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.listBox_saveDatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_saveDatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_saveDatList.ForeColor = System.Drawing.Color.White;
            this.listBox_saveDatList.FormattingEnabled = true;
            this.listBox_saveDatList.ItemHeight = 20;
            this.listBox_saveDatList.Location = new System.Drawing.Point(12, 12);
            this.listBox_saveDatList.Name = "listBox_saveDatList";
            this.listBox_saveDatList.Size = new System.Drawing.Size(225, 520);
            this.listBox_saveDatList.TabIndex = 0;
            // 
            // button_refresh
            // 
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.button_refresh.Image = global::save_dat_helper_2.Properties.Resources.button_refresh;
            this.button_refresh.Location = new System.Drawing.Point(243, 12);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(30, 30);
            this.button_refresh.TabIndex = 1;
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_load
            // 
            this.button_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.button_load.FlatAppearance.BorderSize = 0;
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.ForeColor = System.Drawing.Color.White;
            this.button_load.Location = new System.Drawing.Point(12, 538);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(109, 45);
            this.button_load.TabIndex = 5;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = false;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_saveCurrent
            // 
            this.button_saveCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.button_saveCurrent.FlatAppearance.BorderSize = 0;
            this.button_saveCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_saveCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveCurrent.ForeColor = System.Drawing.Color.White;
            this.button_saveCurrent.Location = new System.Drawing.Point(128, 538);
            this.button_saveCurrent.Name = "button_saveCurrent";
            this.button_saveCurrent.Size = new System.Drawing.Size(109, 45);
            this.button_saveCurrent.TabIndex = 6;
            this.button_saveCurrent.Text = "Save Current";
            this.button_saveCurrent.UseVisualStyleBackColor = false;
            this.button_saveCurrent.Click += new System.EventHandler(this.button_saveCurrent_Click);
            // 
            // savedatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.button_saveCurrent);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.listBox_saveDatList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "savedatform";
            this.Text = "savedatform";
            this.Load += new System.EventHandler(this.savedatform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_saveDatList;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_saveCurrent;
    }
}