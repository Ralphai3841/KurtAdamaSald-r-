﻿
namespace KurtAdamaSaldırı
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pcbWolfMan = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolfMan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Irk :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Silah :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(213, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(169, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // txtWeapon
            // 
            this.txtWeapon.Location = new System.Drawing.Point(213, 185);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(169, 22);
            this.txtWeapon.TabIndex = 5;
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbRace.Location = new System.Drawing.Point(214, 97);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(168, 24);
            this.cmbRace.TabIndex = 6;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Archer",
            "Assassin"});
            this.cmbBranch.Location = new System.Drawing.Point(214, 139);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(168, 24);
            this.cmbBranch.TabIndex = 7;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(214, 233);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(157, 72);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pcbWolfMan
            // 
            this.pcbWolfMan.Image = global::KurtAdamaSaldırı.Properties.Resources.hqdefault;
            this.pcbWolfMan.Location = new System.Drawing.Point(507, 62);
            this.pcbWolfMan.Name = "pcbWolfMan";
            this.pcbWolfMan.Size = new System.Drawing.Size(238, 281);
            this.pcbWolfMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWolfMan.TabIndex = 9;
            this.pcbWolfMan.TabStop = false;
            this.pcbWolfMan.Visible = false;
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.DarkRed;
            this.lblHealth.Location = new System.Drawing.Point(504, 366);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(241, 23);
            this.lblHealth.TabIndex = 10;
            this.lblHealth.Text = "label5";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(213, 366);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(158, 52);
            this.btnAttack.TabIndex = 11;
            this.btnAttack.Text = "Saldır";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.pcbWolfMan);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolfMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pcbWolfMan;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnAttack;
    }
}

