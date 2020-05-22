﻿namespace MAChanger
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.Adapters_CB = new ReaLTaiizor.ForeverComboBox();
            this.Refresh_B = new ReaLTaiizor.LostAcceptButton();
            this.Generate_B = new ReaLTaiizor.LostCancelButton();
            this.Current_L = new ReaLTaiizor.ForeverLabel();
            this.New_L = new ReaLTaiizor.ForeverLabel();
            this.New_TB = new ReaLTaiizor.ForeverTextBox();
            this.Current_TB = new ReaLTaiizor.ForeverTextBox();
            this.Save_B = new ReaLTaiizor.LostButton();
            this.Undo_B = new ReaLTaiizor.LostButton();
            this.SuspendLayout();
            // 
            // Adapters_CB
            // 
            this.Adapters_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.Adapters_CB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adapters_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Adapters_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Adapters_CB.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Adapters_CB.ForeColor = System.Drawing.Color.White;
            this.Adapters_CB.FormattingEnabled = true;
            this.Adapters_CB.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Adapters_CB.ItemHeight = 18;
            this.Adapters_CB.Location = new System.Drawing.Point(5, 39);
            this.Adapters_CB.MaxDropDownItems = 12;
            this.Adapters_CB.Name = "Adapters_CB";
            this.Adapters_CB.Size = new System.Drawing.Size(394, 24);
            this.Adapters_CB.TabIndex = 3;
            this.Adapters_CB.SelectedIndexChanged += new System.EventHandler(this.Adapters_CB_SelectedIndexChanged);
            // 
            // Refresh_B
            // 
            this.Refresh_B.BackColor = System.Drawing.Color.SeaGreen;
            this.Refresh_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_B.ForeColor = System.Drawing.Color.White;
            this.Refresh_B.HoverColor = System.Drawing.Color.ForestGreen;
            this.Refresh_B.Image = null;
            this.Refresh_B.Location = new System.Drawing.Point(295, 69);
            this.Refresh_B.Name = "Refresh_B";
            this.Refresh_B.Size = new System.Drawing.Size(104, 29);
            this.Refresh_B.TabIndex = 5;
            this.Refresh_B.Text = "Refresh";
            this.Refresh_B.Click += new System.EventHandler(this.Refresh_B_Click);
            // 
            // Generate_B
            // 
            this.Generate_B.BackColor = System.Drawing.Color.Crimson;
            this.Generate_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Generate_B.ForeColor = System.Drawing.Color.White;
            this.Generate_B.HoverColor = System.Drawing.Color.IndianRed;
            this.Generate_B.Image = null;
            this.Generate_B.Location = new System.Drawing.Point(295, 104);
            this.Generate_B.Name = "Generate_B";
            this.Generate_B.Size = new System.Drawing.Size(104, 29);
            this.Generate_B.TabIndex = 6;
            this.Generate_B.Text = "Generate";
            this.Generate_B.Click += new System.EventHandler(this.Generate_B_Click);
            // 
            // Current_L
            // 
            this.Current_L.BackColor = System.Drawing.Color.Transparent;
            this.Current_L.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Current_L.ForeColor = System.Drawing.Color.LightGray;
            this.Current_L.Location = new System.Drawing.Point(5, 69);
            this.Current_L.Name = "Current_L";
            this.Current_L.Size = new System.Drawing.Size(168, 29);
            this.Current_L.TabIndex = 8;
            this.Current_L.Text = "MAC Address Used:";
            this.Current_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_L
            // 
            this.New_L.BackColor = System.Drawing.Color.Transparent;
            this.New_L.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.New_L.ForeColor = System.Drawing.Color.LightGray;
            this.New_L.Location = new System.Drawing.Point(5, 104);
            this.New_L.Name = "New_L";
            this.New_L.Size = new System.Drawing.Size(168, 29);
            this.New_L.TabIndex = 10;
            this.New_L.Text = "New MAC Address:";
            this.New_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_TB
            // 
            this.New_TB.BackColor = System.Drawing.Color.Transparent;
            this.New_TB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.New_TB.FocusOnHover = false;
            this.New_TB.Location = new System.Drawing.Point(179, 104);
            this.New_TB.MaxLength = 12;
            this.New_TB.Multiline = false;
            this.New_TB.Name = "New_TB";
            this.New_TB.ReadOnly = false;
            this.New_TB.Size = new System.Drawing.Size(110, 29);
            this.New_TB.TabIndex = 9;
            this.New_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.New_TB.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.New_TB.UseSystemPasswordChar = false;
            this.New_TB.TextChanged += new System.EventHandler(this.New_TB_TextChanged);
            // 
            // Current_TB
            // 
            this.Current_TB.BackColor = System.Drawing.Color.Transparent;
            this.Current_TB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Current_TB.FocusOnHover = false;
            this.Current_TB.Location = new System.Drawing.Point(179, 69);
            this.Current_TB.MaxLength = 12;
            this.Current_TB.Multiline = false;
            this.Current_TB.Name = "Current_TB";
            this.Current_TB.ReadOnly = true;
            this.Current_TB.Size = new System.Drawing.Size(110, 29);
            this.Current_TB.TabIndex = 7;
            this.Current_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Current_TB.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Current_TB.UseSystemPasswordChar = false;
            // 
            // Save_B
            // 
            this.Save_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.Save_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_B.ForeColor = System.Drawing.Color.White;
            this.Save_B.HoverColor = System.Drawing.Color.DodgerBlue;
            this.Save_B.Image = null;
            this.Save_B.Location = new System.Drawing.Point(5, 136);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(168, 35);
            this.Save_B.TabIndex = 11;
            this.Save_B.Text = "SAVE";
            this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
            // 
            // Undo_B
            // 
            this.Undo_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.Undo_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undo_B.ForeColor = System.Drawing.Color.White;
            this.Undo_B.HoverColor = System.Drawing.Color.DodgerBlue;
            this.Undo_B.Image = null;
            this.Undo_B.Location = new System.Drawing.Point(231, 139);
            this.Undo_B.Name = "Undo_B";
            this.Undo_B.Size = new System.Drawing.Size(168, 35);
            this.Undo_B.TabIndex = 12;
            this.Undo_B.Text = "UNDO";
            this.Undo_B.Click += new System.EventHandler(this.Undo_B_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(404, 182);
            this.Controls.Add(this.Undo_B);
            this.Controls.Add(this.Save_B);
            this.Controls.Add(this.New_L);
            this.Controls.Add(this.New_TB);
            this.Controls.Add(this.Current_L);
            this.Controls.Add(this.Current_TB);
            this.Controls.Add(this.Generate_B);
            this.Controls.Add(this.Refresh_B);
            this.Controls.Add(this.Adapters_CB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Image = global::MAChanger.Properties.Resources.Wifi;
            this.MaximizeBox = false;
            this.Name = "MAIN";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAC Changer v1.3";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.ForeverComboBox Adapters_CB;
        private ReaLTaiizor.LostAcceptButton Refresh_B;
        private ReaLTaiizor.LostCancelButton Generate_B;
        private ReaLTaiizor.ForeverLabel Current_L;
        private ReaLTaiizor.ForeverLabel New_L;
        private ReaLTaiizor.ForeverTextBox New_TB;
        private ReaLTaiizor.ForeverTextBox Current_TB;
        private ReaLTaiizor.LostButton Save_B;
        private ReaLTaiizor.LostButton Undo_B;
    }
}