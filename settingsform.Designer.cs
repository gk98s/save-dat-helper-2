namespace save_dat_helper_2
{
    partial class settingsform
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
            this.components = new System.ComponentModel.Container();
            this.manualPath = new System.Windows.Forms.CheckBox();
            this.button_browseGtLoc = new System.Windows.Forms.Button();
            this.textBox_gtPath = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // manualPath
            // 
            this.manualPath.AutoSize = true;
            this.manualPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualPath.ForeColor = System.Drawing.Color.White;
            this.manualPath.Location = new System.Drawing.Point(12, 12);
            this.manualPath.Name = "manualPath";
            this.manualPath.Size = new System.Drawing.Size(117, 24);
            this.manualPath.TabIndex = 0;
            this.manualPath.Text = "Manual Path";
            this.manualPath.UseVisualStyleBackColor = true;
            this.manualPath.CheckedChanged += new System.EventHandler(this.manualPath_CheckedChanged);
            this.manualPath.MouseHover += new System.EventHandler(this.eManualPath_mouseHover);
            // 
            // button_browseGtLoc
            // 
            this.button_browseGtLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.button_browseGtLoc.FlatAppearance.BorderSize = 0;
            this.button_browseGtLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browseGtLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_browseGtLoc.ForeColor = System.Drawing.Color.White;
            this.button_browseGtLoc.Location = new System.Drawing.Point(135, 42);
            this.button_browseGtLoc.Name = "button_browseGtLoc";
            this.button_browseGtLoc.Size = new System.Drawing.Size(117, 28);
            this.button_browseGtLoc.TabIndex = 2;
            this.button_browseGtLoc.Text = "Browse";
            this.button_browseGtLoc.UseVisualStyleBackColor = false;
            this.button_browseGtLoc.Visible = false;
            this.button_browseGtLoc.Click += new System.EventHandler(this.button_browseGtLoc_Click);
            // 
            // textBox_gtPath
            // 
            this.textBox_gtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.textBox_gtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_gtPath.ForeColor = System.Drawing.Color.White;
            this.textBox_gtPath.Location = new System.Drawing.Point(135, 13);
            this.textBox_gtPath.Name = "textBox_gtPath";
            this.textBox_gtPath.Size = new System.Drawing.Size(117, 19);
            this.textBox_gtPath.TabIndex = 3;
            this.textBox_gtPath.Visible = false;
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            // 
            // settingsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1167, 595);
            this.Controls.Add(this.textBox_gtPath);
            this.Controls.Add(this.button_browseGtLoc);
            this.Controls.Add(this.manualPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settingsform";
            this.Text = "settingsform";
            this.Load += new System.EventHandler(this.settingsform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox manualPath;
        private System.Windows.Forms.Button button_browseGtLoc;
        private System.Windows.Forms.TextBox textBox_gtPath;
        private System.Windows.Forms.ToolTip toolTip;
    }
}