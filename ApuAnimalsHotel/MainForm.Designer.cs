﻿namespace ApuAnimalsHotel
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
            this.grpbx1 = new System.Windows.Forms.GroupBox();
            this.cbListAll = new System.Windows.Forms.CheckBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.imgAnimal = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxSpecialChar = new System.Windows.Forms.GroupBox();
            this.txtChar2 = new System.Windows.Forms.TextBox();
            this.txtChar1 = new System.Windows.Forms.TextBox();
            this.lblChar2 = new System.Windows.Forms.Label();
            this.lblChar1 = new System.Windows.Forms.Label();
            this.lbObject = new System.Windows.Forms.ListBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_special = new System.Windows.Forms.Label();
            this.grpbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnimal)).BeginInit();
            this.grpbxSpecialChar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx1
            // 
            this.grpbx1.Controls.Add(this.cbListAll);
            this.grpbx1.Controls.Add(this.btnLoadImage);
            this.grpbx1.Controls.Add(this.imgAnimal);
            this.grpbx1.Controls.Add(this.btnAdd);
            this.grpbx1.Controls.Add(this.label5);
            this.grpbx1.Controls.Add(this.label4);
            this.grpbx1.Controls.Add(this.label3);
            this.grpbx1.Controls.Add(this.label2);
            this.grpbx1.Controls.Add(this.label1);
            this.grpbx1.Controls.Add(this.grpbxSpecialChar);
            this.grpbx1.Controls.Add(this.lbObject);
            this.grpbx1.Controls.Add(this.lbCategory);
            this.grpbx1.Controls.Add(this.cmbGender);
            this.grpbx1.Controls.Add(this.txtAge);
            this.grpbx1.Controls.Add(this.txtName);
            this.grpbx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grpbx1.Location = new System.Drawing.Point(12, 23);
            this.grpbx1.Name = "grpbx1";
            this.grpbx1.Size = new System.Drawing.Size(588, 313);
            this.grpbx1.TabIndex = 0;
            this.grpbx1.TabStop = false;
            this.grpbx1.Text = "Animal Specifications";
            this.grpbx1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbListAll
            // 
            this.cbListAll.AutoSize = true;
            this.cbListAll.ForeColor = System.Drawing.Color.Black;
            this.cbListAll.Location = new System.Drawing.Point(469, 210);
            this.cbListAll.Name = "cbListAll";
            this.cbListAll.Size = new System.Drawing.Size(93, 17);
            this.cbListAll.TabIndex = 14;
            this.cbListAll.Text = "List all animals";
            this.cbListAll.UseVisualStyleBackColor = true;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.ForeColor = System.Drawing.Color.Blue;
            this.btnLoadImage.Location = new System.Drawing.Point(469, 50);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(100, 22);
            this.btnLoadImage.TabIndex = 13;
            this.btnLoadImage.Text = "Load photo";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgAnimal
            // 
            this.imgAnimal.Location = new System.Drawing.Point(469, 78);
            this.imgAnimal.Name = "imgAnimal";
            this.imgAnimal.Size = new System.Drawing.Size(100, 126);
            this.imgAnimal.TabIndex = 12;
            this.imgAnimal.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(351, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add this animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(362, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Animal Object";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(241, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // grpbxSpecialChar
            // 
            this.grpbxSpecialChar.Controls.Add(this.txtChar2);
            this.grpbxSpecialChar.Controls.Add(this.txtChar1);
            this.grpbxSpecialChar.Controls.Add(this.lblChar2);
            this.grpbxSpecialChar.Controls.Add(this.lblChar1);
            this.grpbxSpecialChar.ForeColor = System.Drawing.Color.Blue;
            this.grpbxSpecialChar.Location = new System.Drawing.Point(6, 180);
            this.grpbxSpecialChar.Name = "grpbxSpecialChar";
            this.grpbxSpecialChar.Size = new System.Drawing.Size(325, 106);
            this.grpbxSpecialChar.TabIndex = 5;
            this.grpbxSpecialChar.TabStop = false;
            this.grpbxSpecialChar.Text = "Special Characteristics";
            this.grpbxSpecialChar.Enter += new System.EventHandler(this.grpbx2_Enter);
            // 
            // txtChar2
            // 
            this.txtChar2.Location = new System.Drawing.Point(124, 65);
            this.txtChar2.Name = "txtChar2";
            this.txtChar2.Size = new System.Drawing.Size(100, 20);
            this.txtChar2.TabIndex = 3;
            this.txtChar2.Visible = false;
            // 
            // txtChar1
            // 
            this.txtChar1.Location = new System.Drawing.Point(124, 31);
            this.txtChar1.Name = "txtChar1";
            this.txtChar1.Size = new System.Drawing.Size(100, 20);
            this.txtChar1.TabIndex = 2;
            this.txtChar1.Visible = false;
            this.txtChar1.TextChanged += new System.EventHandler(this.txtChar1_TextChanged);
            // 
            // lblChar2
            // 
            this.lblChar2.AutoSize = true;
            this.lblChar2.ForeColor = System.Drawing.Color.Blue;
            this.lblChar2.Location = new System.Drawing.Point(7, 65);
            this.lblChar2.Name = "lblChar2";
            this.lblChar2.Size = new System.Drawing.Size(98, 13);
            this.lblChar2.TabIndex = 1;
            this.lblChar2.Text = "Special character 2";
            // 
            // lblChar1
            // 
            this.lblChar1.AutoSize = true;
            this.lblChar1.ForeColor = System.Drawing.Color.Blue;
            this.lblChar1.Location = new System.Drawing.Point(6, 34);
            this.lblChar1.Name = "lblChar1";
            this.lblChar1.Size = new System.Drawing.Size(100, 13);
            this.lblChar1.TabIndex = 0;
            this.lblChar1.Text = "Special Character 1";
            // 
            // lbObject
            // 
            this.lbObject.FormattingEnabled = true;
            this.lbObject.Location = new System.Drawing.Point(351, 52);
            this.lbObject.Name = "lbObject";
            this.lbObject.Size = new System.Drawing.Size(102, 173);
            this.lbObject.TabIndex = 4;
            this.lbObject.SelectedIndexChanged += new System.EventHandler(this.lbObject_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.Location = new System.Drawing.Point(218, 52);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(113, 108);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.SelectedIndexChanged += new System.EventHandler(this.lbCategory_SelectedIndexChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(60, 139);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(140, 21);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(100, 96);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_special);
            this.groupBox2.Controls.Add(this.lbl_gender);
            this.groupBox2.Controls.Add(this.lbl_age);
            this.groupBox2.Controls.Add(this.lbl_name);
            this.groupBox2.Controls.Add(this.lb_id);
            this.groupBox2.Controls.Add(this.lbResults);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of registered animals";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(6, 33);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(576, 147);
            this.lbResults.TabIndex = 0;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(10, 20);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(49, 19);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(34, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(126, 19);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_age.TabIndex = 3;
            this.lbl_age.Text = "Age";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(199, 19);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 4;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_special
            // 
            this.lbl_special.AutoSize = true;
            this.lbl_special.Location = new System.Drawing.Point(338, 20);
            this.lbl_special.Name = "lbl_special";
            this.lbl_special.Size = new System.Drawing.Size(96, 13);
            this.lbl_special.TabIndex = 5;
            this.lbl_special.Text = "Special Characters";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbx1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpbx1.ResumeLayout(false);
            this.grpbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnimal)).EndInit();
            this.grpbxSpecialChar.ResumeLayout(false);
            this.grpbxSpecialChar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx1;
        private System.Windows.Forms.CheckBox cbListAll;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox imgAnimal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbxSpecialChar;
        private System.Windows.Forms.TextBox txtChar2;
        private System.Windows.Forms.TextBox txtChar1;
        private System.Windows.Forms.Label lblChar2;
        private System.Windows.Forms.Label lblChar1;
        private System.Windows.Forms.ListBox lbObject;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label lbl_special;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lb_id;
    }
}