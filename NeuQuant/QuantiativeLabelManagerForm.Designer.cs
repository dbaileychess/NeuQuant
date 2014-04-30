﻿namespace NeuQuant
{
    partial class QuantiativeLabelManagerForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isotopologueListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.createChannelButton = new System.Windows.Forms.Button();
            this.modNameBox = new System.Windows.Forms.TextBox();
            this.siteListBox = new System.Windows.Forms.CheckedListBox();
            this.formulaBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aminoAcidRadioButton = new System.Windows.Forms.RadioButton();
            this.tagRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.isotopologueListBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(283, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 404);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Isotopologue";
            // 
            // isotopologueListBox
            // 
            this.isotopologueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.isotopologueListBox.FormattingEnabled = true;
            this.isotopologueListBox.Location = new System.Drawing.Point(6, 46);
            this.isotopologueListBox.Name = "isotopologueListBox";
            this.isotopologueListBox.Size = new System.Drawing.Size(186, 329);
            this.isotopologueListBox.TabIndex = 21;
            this.isotopologueListBox.SelectedIndexChanged += new System.EventHandler(this.isotopologueListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(434, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save Channels";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::NeuQuant.Properties.Resources.add1_16;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(419, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Channel";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(198, 46);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(336, 328);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // createChannelButton
            // 
            this.createChannelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createChannelButton.Location = new System.Drawing.Point(7, 375);
            this.createChannelButton.Name = "createChannelButton";
            this.createChannelButton.Size = new System.Drawing.Size(88, 23);
            this.createChannelButton.TabIndex = 9;
            this.createChannelButton.Text = "Save Mod As";
            this.createChannelButton.UseVisualStyleBackColor = true;
            this.createChannelButton.Click += new System.EventHandler(this.createChannelButton_Click);
            // 
            // modNameBox
            // 
            this.modNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.modNameBox.Location = new System.Drawing.Point(99, 375);
            this.modNameBox.Name = "modNameBox";
            this.modNameBox.Size = new System.Drawing.Size(160, 20);
            this.modNameBox.TabIndex = 20;
            // 
            // siteListBox
            // 
            this.siteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.siteListBox.CheckOnClick = true;
            this.siteListBox.ColumnWidth = 60;
            this.siteListBox.FormattingEnabled = true;
            this.siteListBox.Location = new System.Drawing.Point(9, 244);
            this.siteListBox.MultiColumn = true;
            this.siteListBox.Name = "siteListBox";
            this.siteListBox.Size = new System.Drawing.Size(250, 124);
            this.siteListBox.TabIndex = 2;
            this.siteListBox.UseTabStops = false;
            // 
            // formulaBox
            // 
            this.formulaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formulaBox.Location = new System.Drawing.Point(60, 216);
            this.formulaBox.Name = "formulaBox";
            this.formulaBox.Size = new System.Drawing.Size(199, 20);
            this.formulaBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // aminoAcidRadioButton
            // 
            this.aminoAcidRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aminoAcidRadioButton.AutoSize = true;
            this.aminoAcidRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.aminoAcidRadioButton.Location = new System.Drawing.Point(83, 193);
            this.aminoAcidRadioButton.Name = "aminoAcidRadioButton";
            this.aminoAcidRadioButton.Size = new System.Drawing.Size(78, 17);
            this.aminoAcidRadioButton.TabIndex = 17;
            this.aminoAcidRadioButton.TabStop = true;
            this.aminoAcidRadioButton.Text = "Amino Acid";
            this.aminoAcidRadioButton.UseVisualStyleBackColor = false;
            // 
            // tagRadioButton
            // 
            this.tagRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tagRadioButton.AutoSize = true;
            this.tagRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.tagRadioButton.Location = new System.Drawing.Point(167, 193);
            this.tagRadioButton.Name = "tagRadioButton";
            this.tagRadioButton.Size = new System.Drawing.Size(44, 17);
            this.tagRadioButton.TabIndex = 18;
            this.tagRadioButton.TabStop = true;
            this.tagRadioButton.Text = "Tag";
            this.tagRadioButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Label Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.createChannelButton);
            this.groupBox1.Controls.Add(this.modNameBox);
            this.groupBox1.Controls.Add(this.modListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tagRadioButton);
            this.groupBox1.Controls.Add(this.aminoAcidRadioButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.formulaBox);
            this.groupBox1.Controls.Add(this.siteListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 404);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification";
            // 
            // modListBox
            // 
            this.modListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modListBox.FormattingEnabled = true;
            this.modListBox.Location = new System.Drawing.Point(9, 14);
            this.modListBox.Name = "modListBox";
            this.modListBox.Size = new System.Drawing.Size(250, 173);
            this.modListBox.TabIndex = 20;
            this.modListBox.SelectedIndexChanged += new System.EventHandler(this.modListBox_SelectedIndexChanged);
            this.modListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modListBox_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Formula";
            // 
            // QuantiativeLabelManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "QuantiativeLabelManagerForm";
            this.Text = "Label Manager";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createChannelButton;
        private System.Windows.Forms.TextBox modNameBox;
        private System.Windows.Forms.CheckedListBox siteListBox;
        private System.Windows.Forms.TextBox formulaBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton aminoAcidRadioButton;
        private System.Windows.Forms.RadioButton tagRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox modListBox;
        private System.Windows.Forms.ListBox isotopologueListBox;
        private System.Windows.Forms.Label label1;
    }
}