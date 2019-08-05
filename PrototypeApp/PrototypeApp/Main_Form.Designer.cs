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
            this.Correspondence = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Media = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Correspondence
            // 
            this.Correspondence.BackColor = System.Drawing.Color.Transparent;
            this.Correspondence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Correspondence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correspondence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Correspondence.ImageIndex = 9;
            this.Correspondence.ImageList = this.imageList1;
            this.Correspondence.Location = new System.Drawing.Point(0, 168);
            this.Correspondence.Name = "Correspondence";
            this.Correspondence.Size = new System.Drawing.Size(86, 84);
            this.Correspondence.TabIndex = 1;
            this.Correspondence.UseVisualStyleBackColor = false;
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
            // Media
            // 
            this.Media.BackColor = System.Drawing.Color.Transparent;
            this.Media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Media.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Media.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Media.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Media.ImageIndex = 8;
            this.Media.ImageList = this.imageList1;
            this.Media.Location = new System.Drawing.Point(0, 78);
            this.Media.Name = "Media";
            this.Media.Size = new System.Drawing.Size(86, 84);
            this.Media.TabIndex = 0;
            this.Media.UseVisualStyleBackColor = false;
            this.Media.Click += new System.EventHandler(this.Media_Click);
            this.Media.MouseHover += new System.EventHandler(this.Media_MouseHover);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(387, 414);
            this.Controls.Add(this.Correspondence);
            this.Controls.Add(this.Media);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "(Company name)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Media;
        private System.Windows.Forms.Button Correspondence;
        private System.Windows.Forms.ImageList imageList1;
    }
}

