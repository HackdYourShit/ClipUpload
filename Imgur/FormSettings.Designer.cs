﻿namespace Imgur
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFormat = new System.Windows.Forms.ComboBox();
            this.comboDragKeys = new System.Windows.Forms.ComboBox();
            this.checkDragModShift = new System.Windows.Forms.CheckBox();
            this.checkDragModAlt = new System.Windows.Forms.CheckBox();
            this.checkDragModCtrl = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkPasteModCtrl = new System.Windows.Forms.CheckBox();
            this.checkPasteModAlt = new System.Windows.Forms.CheckBox();
            this.checkPasteModShift = new System.Windows.Forms.CheckBox();
            this.comboPasteKeys = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAuthenticate = new System.Windows.Forms.Button();
            this.labelAuthed = new System.Windows.Forms.Label();
            this.picPro = new System.Windows.Forms.PictureBox();
            this.labelPro = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPro)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format:";
            // 
            // comboFormat
            // 
            this.comboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormat.FormattingEnabled = true;
            this.comboFormat.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "GIF"});
            this.comboFormat.Location = new System.Drawing.Point(92, 67);
            this.comboFormat.Name = "comboFormat";
            this.comboFormat.Size = new System.Drawing.Size(136, 21);
            this.comboFormat.TabIndex = 0;
            // 
            // comboDragKeys
            // 
            this.comboDragKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDragKeys.FormattingEnabled = true;
            this.comboDragKeys.Location = new System.Drawing.Point(92, 117);
            this.comboDragKeys.Name = "comboDragKeys";
            this.comboDragKeys.Size = new System.Drawing.Size(136, 21);
            this.comboDragKeys.TabIndex = 37;
            // 
            // checkDragModShift
            // 
            this.checkDragModShift.AutoSize = true;
            this.checkDragModShift.Location = new System.Drawing.Point(183, 94);
            this.checkDragModShift.Name = "checkDragModShift";
            this.checkDragModShift.Size = new System.Drawing.Size(47, 17);
            this.checkDragModShift.TabIndex = 36;
            this.checkDragModShift.Text = "Shift";
            this.checkDragModShift.UseVisualStyleBackColor = true;
            // 
            // checkDragModAlt
            // 
            this.checkDragModAlt.AutoSize = true;
            this.checkDragModAlt.Location = new System.Drawing.Point(139, 94);
            this.checkDragModAlt.Name = "checkDragModAlt";
            this.checkDragModAlt.Size = new System.Drawing.Size(38, 17);
            this.checkDragModAlt.TabIndex = 35;
            this.checkDragModAlt.Text = "Alt";
            this.checkDragModAlt.UseVisualStyleBackColor = true;
            // 
            // checkDragModCtrl
            // 
            this.checkDragModCtrl.AutoSize = true;
            this.checkDragModCtrl.Location = new System.Drawing.Point(92, 94);
            this.checkDragModCtrl.Name = "checkDragModCtrl";
            this.checkDragModCtrl.Size = new System.Drawing.Size(41, 17);
            this.checkDragModCtrl.TabIndex = 34;
            this.checkDragModCtrl.Text = "Ctrl";
            this.checkDragModCtrl.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Drag shortcut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Paste shortcut:";
            // 
            // checkPasteModCtrl
            // 
            this.checkPasteModCtrl.AutoSize = true;
            this.checkPasteModCtrl.Location = new System.Drawing.Point(92, 144);
            this.checkPasteModCtrl.Name = "checkPasteModCtrl";
            this.checkPasteModCtrl.Size = new System.Drawing.Size(41, 17);
            this.checkPasteModCtrl.TabIndex = 34;
            this.checkPasteModCtrl.Text = "Ctrl";
            this.checkPasteModCtrl.UseVisualStyleBackColor = true;
            // 
            // checkPasteModAlt
            // 
            this.checkPasteModAlt.AutoSize = true;
            this.checkPasteModAlt.Location = new System.Drawing.Point(139, 144);
            this.checkPasteModAlt.Name = "checkPasteModAlt";
            this.checkPasteModAlt.Size = new System.Drawing.Size(38, 17);
            this.checkPasteModAlt.TabIndex = 35;
            this.checkPasteModAlt.Text = "Alt";
            this.checkPasteModAlt.UseVisualStyleBackColor = true;
            // 
            // checkPasteModShift
            // 
            this.checkPasteModShift.AutoSize = true;
            this.checkPasteModShift.Location = new System.Drawing.Point(183, 144);
            this.checkPasteModShift.Name = "checkPasteModShift";
            this.checkPasteModShift.Size = new System.Drawing.Size(47, 17);
            this.checkPasteModShift.TabIndex = 36;
            this.checkPasteModShift.Text = "Shift";
            this.checkPasteModShift.UseVisualStyleBackColor = true;
            // 
            // comboPasteKeys
            // 
            this.comboPasteKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPasteKeys.FormattingEnabled = true;
            this.comboPasteKeys.Location = new System.Drawing.Point(92, 167);
            this.comboPasteKeys.Name = "comboPasteKeys";
            this.comboPasteKeys.Size = new System.Drawing.Size(136, 21);
            this.comboPasteKeys.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPro);
            this.groupBox1.Controls.Add(this.picPro);
            this.groupBox1.Controls.Add(this.buttonAuthenticate);
            this.groupBox1.Controls.Add(this.labelAuthed);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 49);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // buttonAuthenticate
            // 
            this.buttonAuthenticate.Location = new System.Drawing.Point(6, 19);
            this.buttonAuthenticate.Name = "buttonAuthenticate";
            this.buttonAuthenticate.Size = new System.Drawing.Size(112, 23);
            this.buttonAuthenticate.TabIndex = 1;
            this.buttonAuthenticate.Text = "Authenticate";
            this.buttonAuthenticate.UseVisualStyleBackColor = true;
            this.buttonAuthenticate.Click += new System.EventHandler(this.buttonAuthenticate_Click);
            // 
            // labelAuthed
            // 
            this.labelAuthed.AutoSize = true;
            this.labelAuthed.Location = new System.Drawing.Point(124, 24);
            this.labelAuthed.Name = "labelAuthed";
            this.labelAuthed.Size = new System.Drawing.Size(92, 13);
            this.labelAuthed.TabIndex = 0;
            this.labelAuthed.Text = "Not authenticated";
            // 
            // picPro
            // 
            this.picPro.Image = ((System.Drawing.Image)(resources.GetObject("picPro.Image")));
            this.picPro.Location = new System.Drawing.Point(277, 22);
            this.picPro.Name = "picPro";
            this.picPro.Size = new System.Drawing.Size(16, 16);
            this.picPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPro.TabIndex = 2;
            this.picPro.TabStop = false;
            this.picPro.Visible = false;
            // 
            // labelPro
            // 
            this.labelPro.AutoSize = true;
            this.labelPro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPro.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelPro.Location = new System.Drawing.Point(248, 24);
            this.labelPro.Name = "labelPro";
            this.labelPro.Size = new System.Drawing.Size(29, 13);
            this.labelPro.TabIndex = 3;
            this.labelPro.Text = "PRO";
            this.labelPro.Visible = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboPasteKeys);
            this.Controls.Add(this.comboDragKeys);
            this.Controls.Add(this.checkPasteModShift);
            this.Controls.Add(this.checkPasteModAlt);
            this.Controls.Add(this.checkDragModShift);
            this.Controls.Add(this.checkPasteModCtrl);
            this.Controls.Add(this.checkDragModAlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkDragModCtrl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imgur Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFormat;
        private System.Windows.Forms.ComboBox comboDragKeys;
        private System.Windows.Forms.CheckBox checkDragModShift;
        private System.Windows.Forms.CheckBox checkDragModAlt;
        private System.Windows.Forms.CheckBox checkDragModCtrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkPasteModCtrl;
        private System.Windows.Forms.CheckBox checkPasteModAlt;
        private System.Windows.Forms.CheckBox checkPasteModShift;
        private System.Windows.Forms.ComboBox comboPasteKeys;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAuthenticate;
        private System.Windows.Forms.Label labelAuthed;
        private System.Windows.Forms.PictureBox picPro;
        private System.Windows.Forms.Label labelPro;
    }
}