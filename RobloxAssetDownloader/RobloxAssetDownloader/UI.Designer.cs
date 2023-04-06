
namespace RobloxAssetDownloader {
    partial class UI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.URLBox = new System.Windows.Forms.TextBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.ImageOutput = new System.Windows.Forms.PictureBox();
            this.Shirt = new System.Windows.Forms.RadioButton();
            this.Pants = new System.Windows.Forms.RadioButton();
            this.noOverlay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubLink)).BeginInit();
            this.SuspendLayout();
            // 
            // URLBox
            // 
            this.URLBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.URLBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URLBox.Font = new System.Drawing.Font("LEMON MILK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.URLBox.Location = new System.Drawing.Point(434, 619);
            this.URLBox.Margin = new System.Windows.Forms.Padding(7);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(209, 29);
            this.URLBox.TabIndex = 0;
            this.URLBox.Text = "Enter asset id...";
            this.URLBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.URLBox.TextChanged += new System.EventHandler(this.TextFocus);
            this.URLBox.Enter += new System.EventHandler(this.TextFocus);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DownloadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Font = new System.Drawing.Font("LEMON MILK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DownloadButton.Location = new System.Drawing.Point(434, 658);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(209, 43);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.Download);
            // 
            // ImageOutput
            // 
            this.ImageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageOutput.Location = new System.Drawing.Point(226, 39);
            this.ImageOutput.Name = "ImageOutput";
            this.ImageOutput.Size = new System.Drawing.Size(585, 559);
            this.ImageOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageOutput.TabIndex = 2;
            this.ImageOutput.TabStop = false;
            // 
            // Shirt
            // 
            this.Shirt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shirt.Appearance = System.Windows.Forms.Appearance.Button;
            this.Shirt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(91)))));
            this.Shirt.Checked = true;
            this.Shirt.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Shirt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Shirt.FlatAppearance.BorderSize = 5;
            this.Shirt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.Shirt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shirt.Font = new System.Drawing.Font("LEMON MILK Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shirt.ForeColor = System.Drawing.Color.White;
            this.Shirt.Location = new System.Drawing.Point(849, 39);
            this.Shirt.Name = "Shirt";
            this.Shirt.Size = new System.Drawing.Size(130, 142);
            this.Shirt.TabIndex = 3;
            this.Shirt.TabStop = true;
            this.Shirt.Text = "Shirt";
            this.Shirt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Shirt.UseVisualStyleBackColor = false;
            this.Shirt.CheckedChanged += new System.EventHandler(this.Shirt_CheckedChanged);
            // 
            // Pants
            // 
            this.Pants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pants.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(91)))));
            this.Pants.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Pants.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Pants.FlatAppearance.BorderSize = 5;
            this.Pants.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.Pants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pants.Font = new System.Drawing.Font("LEMON MILK Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pants.ForeColor = System.Drawing.Color.White;
            this.Pants.Location = new System.Drawing.Point(849, 244);
            this.Pants.Name = "Pants";
            this.Pants.Size = new System.Drawing.Size(130, 142);
            this.Pants.TabIndex = 4;
            this.Pants.Text = "Pants";
            this.Pants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pants.UseVisualStyleBackColor = false;
            this.Pants.CheckedChanged += new System.EventHandler(this.Pants_CheckedChanged);
            // 
            // noOverlay
            // 
            this.noOverlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.noOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(91)))));
            this.noOverlay.Cursor = System.Windows.Forms.Cursors.Cross;
            this.noOverlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.noOverlay.FlatAppearance.BorderSize = 5;
            this.noOverlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(28)))), ((int)(((byte)(138)))));
            this.noOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noOverlay.Font = new System.Drawing.Font("LEMON MILK Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOverlay.ForeColor = System.Drawing.Color.White;
            this.noOverlay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.noOverlay.Location = new System.Drawing.Point(849, 456);
            this.noOverlay.Name = "noOverlay";
            this.noOverlay.Size = new System.Drawing.Size(130, 142);
            this.noOverlay.TabIndex = 5;
            this.noOverlay.Text = "None";
            this.noOverlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noOverlay.UseVisualStyleBackColor = false;
            this.noOverlay.CheckedChanged += new System.EventHandler(this.noOverlay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 96);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // githubLink
            // 
            this.githubLink.BackColor = System.Drawing.Color.Transparent;
            this.githubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubLink.Image = global::RobloxAssetDownloader.Properties.Resources.github;
            this.githubLink.Location = new System.Drawing.Point(12, 39);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(75, 75);
            this.githubLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.githubLink.TabIndex = 8;
            this.githubLink.TabStop = false;
            this.githubLink.Click += new System.EventHandler(this.GithubLink);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RobloxAssetDownloader.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 750);
            this.Controls.Add(this.noOverlay);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.Pants);
            this.Controls.Add(this.Shirt);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.ImageOutput);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "UI";
            this.Text = "Roblox Asset Downloader";
            this.Load += new System.EventHandler(this.Loaded);
            ((System.ComponentModel.ISupportInitialize)(this.ImageOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.PictureBox ImageOutput;
        private System.Windows.Forms.RadioButton Shirt;
        private System.Windows.Forms.RadioButton Pants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox githubLink;
        private System.Windows.Forms.RadioButton noOverlay;
    }
    }

