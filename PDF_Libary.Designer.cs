namespace My_Pdf_Reader
{
    partial class PDF_Libary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_Libary));
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanToAdds = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.UploadButton = new Guna.UI.WinForms.GunaButton();
            this.AddToLibaryButton = new Guna.UI.WinForms.GunaButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.PdflistView = new System.Windows.Forms.ListView();
            this.ChooseFileToOpen = new System.Windows.Forms.OpenFileDialog();
            this.guna2MouseStateHandler1 = new Guna.UI2.WinForms.Guna2MouseStateHandler(this.components);
            this.guna2MouseStateHandler2 = new Guna.UI2.WinForms.Guna2MouseStateHandler(this.components);
            this.panel2.SuspendLayout();
            this.PanToAdds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PanToAdds);
            this.panel2.Controls.Add(this.UploadButton);
            this.panel2.Controls.Add(this.AddToLibaryButton);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.PdflistView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 468);
            this.panel2.TabIndex = 5;
            // 
            // PanToAdds
            // 
            this.PanToAdds.BackColor = System.Drawing.Color.White;
            this.PanToAdds.BorderColor = System.Drawing.Color.Black;
            this.PanToAdds.BorderRadius = 10;
            this.PanToAdds.BorderThickness = 3;
            this.PanToAdds.Controls.Add(this.label1);
            this.PanToAdds.Controls.Add(this.pictureBox1);
            this.PanToAdds.Controls.Add(this.guna2CirclePictureBox1);
            this.PanToAdds.ForeColor = System.Drawing.Color.Blue;
            this.PanToAdds.Location = new System.Drawing.Point(20, 14);
            this.PanToAdds.Name = "PanToAdds";
            this.PanToAdds.ShadowDecoration.Parent = this.PanToAdds;
            this.PanToAdds.Size = new System.Drawing.Size(770, 51);
            this.PanToAdds.TabIndex = 15;
            this.PanToAdds.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 14);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(55, 52);
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UploadButton
            // 
            this.UploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UploadButton.AnimationHoverSpeed = 0.07F;
            this.UploadButton.AnimationSpeed = 0.03F;
            this.UploadButton.BackColor = System.Drawing.Color.Transparent;
            this.UploadButton.BaseColor = System.Drawing.Color.Blue;
            this.UploadButton.BorderColor = System.Drawing.Color.Black;
            this.UploadButton.BorderSize = 3;
            this.UploadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UploadButton.FocusedColor = System.Drawing.Color.Empty;
            this.UploadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UploadButton.ForeColor = System.Drawing.Color.White;
            this.UploadButton.Image = ((System.Drawing.Image)(resources.GetObject("UploadButton.Image")));
            this.UploadButton.ImageSize = new System.Drawing.Size(20, 20);
            this.UploadButton.Location = new System.Drawing.Point(15, 406);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.UploadButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UploadButton.OnHoverForeColor = System.Drawing.Color.White;
            this.UploadButton.OnHoverImage = null;
            this.UploadButton.OnPressedColor = System.Drawing.Color.Black;
            this.UploadButton.Radius = 10;
            this.UploadButton.Size = new System.Drawing.Size(96, 44);
            this.UploadButton.TabIndex = 12;
            this.UploadButton.Text = "Upload";
            // 
            // AddToLibaryButton
            // 
            this.AddToLibaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToLibaryButton.AnimationHoverSpeed = 0.07F;
            this.AddToLibaryButton.AnimationSpeed = 0.03F;
            this.AddToLibaryButton.BackColor = System.Drawing.Color.Transparent;
            this.AddToLibaryButton.BaseColor = System.Drawing.Color.Blue;
            this.AddToLibaryButton.BorderColor = System.Drawing.Color.Black;
            this.AddToLibaryButton.BorderSize = 3;
            this.AddToLibaryButton.CausesValidation = false;
            this.AddToLibaryButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddToLibaryButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddToLibaryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddToLibaryButton.ForeColor = System.Drawing.Color.White;
            this.AddToLibaryButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToLibaryButton.Image")));
            this.AddToLibaryButton.ImageSize = new System.Drawing.Size(25, 25);
            this.AddToLibaryButton.Location = new System.Drawing.Point(725, 406);
            this.AddToLibaryButton.Name = "AddToLibaryButton";
            this.AddToLibaryButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddToLibaryButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddToLibaryButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddToLibaryButton.OnHoverImage = null;
            this.AddToLibaryButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddToLibaryButton.Radius = 10;
            this.AddToLibaryButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddToLibaryButton.Size = new System.Drawing.Size(123, 44);
            this.AddToLibaryButton.TabIndex = 14;
            this.AddToLibaryButton.Text = "Add To Libary";
            this.AddToLibaryButton.Click += new System.EventHandler(this.AddToLibaryButton_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 393);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(878, 22);
            this.guna2Separator1.TabIndex = 3;
            // 
            // PdflistView
            // 
            this.PdflistView.AutoArrange = false;
            this.PdflistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PdflistView.HideSelection = false;
            this.PdflistView.Location = new System.Drawing.Point(0, 0);
            this.PdflistView.MultiSelect = false;
            this.PdflistView.Name = "PdflistView";
            this.PdflistView.Size = new System.Drawing.Size(878, 468);
            this.PdflistView.TabIndex = 13;
            this.PdflistView.UseCompatibleStateImageBehavior = false;
            // 
            // ChooseFileToOpen
            // 
            this.ChooseFileToOpen.FileName = "Choose a Pdf";
            // 
            // PDF_Libary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.panel2);
            this.Name = "PDF_Libary";
            this.Size = new System.Drawing.Size(878, 468);
            this.panel2.ResumeLayout(false);
            this.PanToAdds.ResumeLayout(false);
            this.PanToAdds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.OpenFileDialog ChooseFileToOpen;
        public System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2MouseStateHandler guna2MouseStateHandler1;
        private Guna.UI2.WinForms.Guna2MouseStateHandler guna2MouseStateHandler2;
        private Guna.UI2.WinForms.Guna2Panel PanToAdds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.ListView PdflistView;
        private Guna.UI.WinForms.GunaButton UploadButton;
        private Guna.UI.WinForms.GunaButton AddToLibaryButton;
    }
}
