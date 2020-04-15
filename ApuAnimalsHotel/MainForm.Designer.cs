namespace ApuAnimalsHotel
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lvAnimalList = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpecies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpecialCharacters = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFoodSchedule = new System.Windows.Forms.Button();
            this.btnEditFoodSchedule = new System.Windows.Forms.Button();
            this.btnAddFoodSchedule = new System.Windows.Forms.Button();
            this.lbEaterType = new System.Windows.Forms.ListBox();
            this.lbFoodSchedule = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbFoodDetails = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnimal)).BeginInit();
            this.grpbxSpecialChar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.grpbx1.ForeColor = System.Drawing.Color.Black;
            this.grpbx1.Location = new System.Drawing.Point(12, 23);
            this.grpbx1.Name = "grpbx1";
            this.grpbx1.Size = new System.Drawing.Size(588, 288);
            this.grpbx1.TabIndex = 0;
            this.grpbx1.TabStop = false;
            this.grpbx1.Text = "Animal Specifications";
            this.grpbx1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbListAll
            // 
            this.cbListAll.AutoSize = true;
            this.cbListAll.ForeColor = System.Drawing.Color.Black;
            this.cbListAll.Location = new System.Drawing.Point(469, 202);
            this.cbListAll.Name = "cbListAll";
            this.cbListAll.Size = new System.Drawing.Size(93, 17);
            this.cbListAll.TabIndex = 14;
            this.cbListAll.Text = "List all animals";
            this.cbListAll.UseVisualStyleBackColor = true;
            this.cbListAll.CheckedChanged += new System.EventHandler(this.cbListAll_CheckedChanged);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.ForeColor = System.Drawing.Color.Blue;
            this.btnLoadImage.Location = new System.Drawing.Point(469, 42);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(100, 22);
            this.btnLoadImage.TabIndex = 13;
            this.btnLoadImage.Text = "Load photo";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgAnimal
            // 
            this.imgAnimal.Location = new System.Drawing.Point(469, 70);
            this.imgAnimal.Name = "imgAnimal";
            this.imgAnimal.Size = new System.Drawing.Size(100, 126);
            this.imgAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAnimal.TabIndex = 12;
            this.imgAnimal.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(351, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(218, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add this animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(362, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Animal Object";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(241, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 47);
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
            this.grpbxSpecialChar.Location = new System.Drawing.Point(6, 172);
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
            this.lbObject.Location = new System.Drawing.Point(351, 44);
            this.lbObject.Name = "lbObject";
            this.lbObject.Size = new System.Drawing.Size(102, 173);
            this.lbObject.TabIndex = 4;
            this.lbObject.SelectedIndexChanged += new System.EventHandler(this.lbObject_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.Location = new System.Drawing.Point(218, 44);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(113, 108);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.SelectedIndexChanged += new System.EventHandler(this.lbCategory_SelectedIndexChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(60, 131);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(140, 21);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(100, 88);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.lvAnimalList);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of registered animals";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(321, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(241, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(52, 185);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(241, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lvAnimalList
            // 
            this.lvAnimalList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chAge,
            this.chGender,
            this.chSpecies,
            this.chSpecialCharacters});
            this.lvAnimalList.FullRowSelect = true;
            this.lvAnimalList.GridLines = true;
            this.lvAnimalList.HideSelection = false;
            this.lvAnimalList.Location = new System.Drawing.Point(6, 27);
            this.lvAnimalList.MultiSelect = false;
            this.lvAnimalList.Name = "lvAnimalList";
            this.lvAnimalList.Size = new System.Drawing.Size(688, 152);
            this.lvAnimalList.TabIndex = 6;
            this.lvAnimalList.UseCompatibleStateImageBehavior = false;
            this.lvAnimalList.View = System.Windows.Forms.View.Details;
            this.lvAnimalList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvAnimalList_ColumnClick);
            this.lvAnimalList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID ▼";
            this.chID.Width = 48;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 158;
            // 
            // chAge
            // 
            this.chAge.Text = "Age";
            this.chAge.Width = 49;
            // 
            // chGender
            // 
            this.chGender.Text = "Gender";
            this.chGender.Width = 68;
            // 
            // chSpecies
            // 
            this.chSpecies.Text = "Species";
            this.chSpecies.Width = 70;
            // 
            // chSpecialCharacters
            // 
            this.chSpecialCharacters.Text = "Special Characters";
            this.chSpecialCharacters.Width = 286;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteFoodSchedule);
            this.groupBox1.Controls.Add(this.btnEditFoodSchedule);
            this.groupBox1.Controls.Add(this.btnAddFoodSchedule);
            this.groupBox1.Controls.Add(this.lbEaterType);
            this.groupBox1.Controls.Add(this.lbFoodSchedule);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(720, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feeding Schedule";
            // 
            // btnDeleteFoodSchedule
            // 
            this.btnDeleteFoodSchedule.BackgroundImage = global::ApuAnimalsHotel.Properties.Resources.Apple_64_512;
            this.btnDeleteFoodSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteFoodSchedule.Location = new System.Drawing.Point(146, 185);
            this.btnDeleteFoodSchedule.Name = "btnDeleteFoodSchedule";
            this.btnDeleteFoodSchedule.Size = new System.Drawing.Size(28, 28);
            this.btnDeleteFoodSchedule.TabIndex = 5;
            this.btnDeleteFoodSchedule.UseVisualStyleBackColor = true;
            this.btnDeleteFoodSchedule.Click += new System.EventHandler(this.btnDeleteFoodSchedule_Click);
            // 
            // btnEditFoodSchedule
            // 
            this.btnEditFoodSchedule.BackgroundImage = global::ApuAnimalsHotel.Properties.Resources.Artboard_29_512;
            this.btnEditFoodSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditFoodSchedule.Location = new System.Drawing.Point(112, 185);
            this.btnEditFoodSchedule.Name = "btnEditFoodSchedule";
            this.btnEditFoodSchedule.Size = new System.Drawing.Size(28, 28);
            this.btnEditFoodSchedule.TabIndex = 4;
            this.btnEditFoodSchedule.UseVisualStyleBackColor = true;
            this.btnEditFoodSchedule.Click += new System.EventHandler(this.btnEditFoodSchedule_Click);
            // 
            // btnAddFoodSchedule
            // 
            this.btnAddFoodSchedule.BackgroundImage = global::ApuAnimalsHotel.Properties.Resources.plus_512;
            this.btnAddFoodSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFoodSchedule.Location = new System.Drawing.Point(78, 185);
            this.btnAddFoodSchedule.Name = "btnAddFoodSchedule";
            this.btnAddFoodSchedule.Size = new System.Drawing.Size(28, 28);
            this.btnAddFoodSchedule.TabIndex = 3;
            this.btnAddFoodSchedule.UseVisualStyleBackColor = true;
            this.btnAddFoodSchedule.Click += new System.EventHandler(this.btnAddFoodSchedule_Click);
            // 
            // lbEaterType
            // 
            this.lbEaterType.FormattingEnabled = true;
            this.lbEaterType.Location = new System.Drawing.Point(120, 19);
            this.lbEaterType.Name = "lbEaterType";
            this.lbEaterType.Size = new System.Drawing.Size(126, 17);
            this.lbEaterType.TabIndex = 2;
            // 
            // lbFoodSchedule
            // 
            this.lbFoodSchedule.FormattingEnabled = true;
            this.lbFoodSchedule.Location = new System.Drawing.Point(10, 45);
            this.lbFoodSchedule.Name = "lbFoodSchedule";
            this.lbFoodSchedule.Size = new System.Drawing.Size(236, 134);
            this.lbFoodSchedule.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Eater Type";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(53, 239);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(154, 33);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStaff);
            this.groupBox3.Controls.Add(this.btnAddStaff);
            this.groupBox3.Location = new System.Drawing.Point(872, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 288);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Staff";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(6, 169);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(94, 13);
            this.lblStaff.TabIndex = 5;
            this.lblStaff.Text = "Add Staff Member";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackgroundImage = global::ApuAnimalsHotel.Properties.Resources.AddStaff;
            this.btnAddStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStaff.Location = new System.Drawing.Point(23, 108);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(56, 58);
            this.btnAddStaff.TabIndex = 4;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddFood);
            this.groupBox4.Controls.Add(this.lbFoodDetails);
            this.groupBox4.Location = new System.Drawing.Point(607, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 286);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Food Details";
            // 
            // lbFoodDetails
            // 
            this.lbFoodDetails.FormattingEnabled = true;
            this.lbFoodDetails.Location = new System.Drawing.Point(7, 20);
            this.lbFoodDetails.Name = "lbFoodDetails";
            this.lbFoodDetails.Size = new System.Drawing.Size(246, 212);
            this.lbFoodDetails.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.xMLToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFileToolStripMenuItem,
            this.binaryFileToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveAsToolStripMenuItem.Text = "Save as ...";
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.textFileToolStripMenuItem.Text = "Text File";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // binaryFileToolStripMenuItem
            // 
            this.binaryFileToolStripMenuItem.Name = "binaryFileToolStripMenuItem";
            this.binaryFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.binaryFileToolStripMenuItem.Text = "Binary File";
            this.binaryFileToolStripMenuItem.Click += new System.EventHandler(this.binaryFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromXMLFileToolStripMenuItem,
            this.exportToXMLFileToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.ToolTipText = "Export/Import  Food Recipes";
            // 
            // importFromXMLFileToolStripMenuItem
            // 
            this.importFromXMLFileToolStripMenuItem.Name = "importFromXMLFileToolStripMenuItem";
            this.importFromXMLFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importFromXMLFileToolStripMenuItem.Text = "Import from XML File";
            this.importFromXMLFileToolStripMenuItem.Click += new System.EventHandler(this.importFromXMLFileToolStripMenuItem_Click);
            // 
            // exportToXMLFileToolStripMenuItem
            // 
            this.exportToXMLFileToolStripMenuItem.Name = "exportToXMLFileToolStripMenuItem";
            this.exportToXMLFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportToXMLFileToolStripMenuItem.Text = "Export to XML File";
            this.exportToXMLFileToolStripMenuItem.Click += new System.EventHandler(this.exportToXMLFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 539);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbx1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbEaterType;
        private System.Windows.Forms.ListBox lbFoodSchedule;
        private System.Windows.Forms.ListView lvAnimalList;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chGender;
        private System.Windows.Forms.ColumnHeader chSpecialCharacters;
        private System.Windows.Forms.ColumnHeader chSpecies;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbFoodDetails;
        private System.Windows.Forms.Button btnAddFoodSchedule;
        private System.Windows.Forms.Button btnDeleteFoodSchedule;
        private System.Windows.Forms.Button btnEditFoodSchedule;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromXMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}