namespace PrototypeApp
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Settings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Correspondence = new System.Windows.Forms.Button();
            this.Media = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Server = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-circled-play-100.png");
            this.imageList1.Images.SetKeyName(1, "icons8-circled-play-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-play-record-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-play-record-50.png");
            this.imageList1.Images.SetKeyName(4, "play-button.png");
            this.imageList1.Images.SetKeyName(5, "download.png");
            this.imageList1.Images.SetKeyName(6, "gallery.png");
            this.imageList1.Images.SetKeyName(7, "envelope.png");
            this.imageList1.Images.SetKeyName(8, "play-button.png");
            this.imageList1.Images.SetKeyName(9, "paper-plane.png");
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.ImageIndex = 1;
            this.Settings.ImageList = this.imageList2;
            this.Settings.Location = new System.Drawing.Point(277, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(37, 40);
            this.Settings.TabIndex = 3;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrototypeApp.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Correspondence
            // 
            this.Correspondence.BackColor = System.Drawing.Color.Transparent;
            this.Correspondence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Correspondence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correspondence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Correspondence.ImageIndex = 9;
            this.Correspondence.ImageList = this.imageList1;
            this.Correspondence.Location = new System.Drawing.Point(12, 259);
            this.Correspondence.Name = "Correspondence";
            this.Correspondence.Size = new System.Drawing.Size(86, 84);
            this.Correspondence.TabIndex = 1;
            this.Correspondence.UseVisualStyleBackColor = false;
            this.Correspondence.Click += new System.EventHandler(this.Correspondence_Click);
            // 
            // Media
            // 
            this.Media.BackColor = System.Drawing.Color.Transparent;
            this.Media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Media.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Media.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Media.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Media.ImageIndex = 8;
            this.Media.ImageList = this.imageList1;
            this.Media.Location = new System.Drawing.Point(12, 169);
            this.Media.Name = "Media";
            this.Media.Size = new System.Drawing.Size(86, 84);
            this.Media.TabIndex = 0;
            this.Media.UseVisualStyleBackColor = false;
            this.Media.Click += new System.EventHandler(this.Media_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "State :";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.BackColor = System.Drawing.Color.White;
            this.State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(71, 346);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(0, 15);
            this.State.TabIndex = 5;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "settings.png");
            this.imageList2.Images.SetKeyName(1, "settings2.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Database :";
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.BackColor = System.Drawing.Color.White;
            this.Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server.Location = new System.Drawing.Point(71, 361);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(0, 15);
            this.Server.TabIndex = 8;
            // 
            // Database
            // 
            this.Database.AutoSize = true;
            this.Database.BackColor = System.Drawing.Color.White;
            this.Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Database.Location = new System.Drawing.Point(71, 376);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(0, 15);
            this.Database.TabIndex = 9;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(326, 397);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.State);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Correspondence);
            this.Controls.Add(this.Media);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Apex";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Media;
        private System.Windows.Forms.Button Correspondence;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Label Database;
    }
}

