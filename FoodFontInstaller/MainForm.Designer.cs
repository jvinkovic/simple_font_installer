namespace FoodFontInstaller
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label = new System.Windows.Forms.Label();
            this.labelInstalling = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(34, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(175, 31);
            this.label.TabIndex = 0;
            this.label.Text = "Install fonts!";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // labelInstalling
            // 
            this.labelInstalling.AutoSize = true;
            this.labelInstalling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstalling.Location = new System.Drawing.Point(12, 9);
            this.labelInstalling.Name = "labelInstalling";
            this.labelInstalling.Size = new System.Drawing.Size(232, 31);
            this.labelInstalling.TabIndex = 1;
            this.labelInstalling.Text = "Installing fonts...";
            this.labelInstalling.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 51);
            this.Controls.Add(this.labelInstalling);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 90);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 90);
            this.Name = "MainForm";
            this.Text = "FoodFontInstaller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelInstalling;
    }
}

