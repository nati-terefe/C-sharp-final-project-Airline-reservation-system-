﻿namespace Airline_reservation
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernamelabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernamelabel.ForeColor = System.Drawing.Color.Black;
            this.usernamelabel.Location = new System.Drawing.Point(243, 159);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(108, 25);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "User name";
            this.usernamelabel.Click += new System.EventHandler(this.usernamelabel_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordlabel.ForeColor = System.Drawing.Color.Black;
            this.passwordlabel.Location = new System.Drawing.Point(243, 232);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(100, 25);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password";
            // 
            // usernametextbox
            // 
            this.usernametextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernametextbox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernametextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.usernametextbox.Location = new System.Drawing.Point(345, 164);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(191, 20);
            this.usernametextbox.TabIndex = 2;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.passwordtextbox.Location = new System.Drawing.Point(345, 232);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(191, 20);
            this.passwordtextbox.TabIndex = 3;
            this.passwordtextbox.TextChanged += new System.EventHandler(this.passwordtextbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-8, -2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(255, 135);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(490, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
    }
}

