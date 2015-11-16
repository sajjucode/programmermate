namespace Pss.ProgrammerMate
{
    partial class frmBusinessEntity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusinessEntity));
            this.gbRight = new System.Windows.Forms.GroupBox();
            this.bnMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.cmbSolutionsDB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSolutions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvgTableColumns = new System.Windows.Forms.DataGridView();
            this.clmSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbkSelectAll = new System.Windows.Forms.CheckBox();
            this.cmdColumns = new System.Windows.Forms.Button();
            this.cmbDBTables = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBaseFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dvgSolutionDBQuery = new System.Windows.Forms.DataGridView();
            this.clmQueryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtGeneratedClass = new System.Windows.Forms.TextBox();
            this.txtProjectNamespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGenerateBESaveIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGenerateBENamespace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdGenerateBE = new System.Windows.Forms.Button();
            this.cmdBrowseFolder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bnbtnExit = new System.Windows.Forms.ToolStripButton();
            this.txtCopyClipboard = new System.Windows.Forms.ToolStripButton();
            this.cmdExecuteQuery = new System.Windows.Forms.ToolStripButton();
            this.Solutions_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SolutionsDB_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SolutionsDBTables_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableColumns_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Projects_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkisSavedOnGenerate = new System.Windows.Forms.CheckBox();
            this.gbRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).BeginInit();
            this.bnMain.SuspendLayout();
            this.gbHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTableColumns)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSolutionDBQuery)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Solutions_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionsDB_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionsDBTables_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableColumns_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projects_bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRight
            // 
            this.gbRight.Controls.Add(this.bnMain);
            this.gbRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbRight.Location = new System.Drawing.Point(900, 0);
            this.gbRight.Name = "gbRight";
            this.gbRight.Size = new System.Drawing.Size(84, 611);
            this.gbRight.TabIndex = 9;
            this.gbRight.TabStop = false;
            // 
            // bnMain
            // 
            this.bnMain.AddNewItem = null;
            this.bnMain.CountItem = this.bindingNavigatorCountItem;
            this.bnMain.DeleteItem = null;
            this.bnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bnbtnExit,
            this.toolStripSeparator1,
            this.txtCopyClipboard,
            this.toolStripSeparator2,
            this.cmdExecuteQuery});
            this.bnMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.bnMain.Location = new System.Drawing.Point(3, 16);
            this.bnMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMain.Name = "bnMain";
            this.bnMain.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMain.Size = new System.Drawing.Size(78, 592);
            this.bnMain.TabIndex = 2;
            this.bnMain.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(76, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(76, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(76, 6);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(76, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(76, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(76, 6);
            // 
            // gbHeader
            // 
            this.gbHeader.Controls.Add(this.cmdRefresh);
            this.gbHeader.Controls.Add(this.cmdConnect);
            this.gbHeader.Controls.Add(this.cmbSolutionsDB);
            this.gbHeader.Controls.Add(this.label1);
            this.gbHeader.Controls.Add(this.cmbSolutions);
            this.gbHeader.Controls.Add(this.label3);
            this.gbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeader.Location = new System.Drawing.Point(0, 0);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(900, 58);
            this.gbHeader.TabIndex = 10;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "DB Connection";
            // 
            // cmbSolutionsDB
            // 
            this.cmbSolutionsDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSolutionsDB.FormattingEnabled = true;
            this.cmbSolutionsDB.Items.AddRange(new object[] {
            "MS SQL",
            "My SQL"});
            this.cmbSolutionsDB.Location = new System.Drawing.Point(409, 23);
            this.cmbSolutionsDB.Name = "cmbSolutionsDB";
            this.cmbSolutionsDB.Size = new System.Drawing.Size(388, 21);
            this.cmbSolutionsDB.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "DB Connection:";
            // 
            // cmbSolutions
            // 
            this.cmbSolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSolutions.FormattingEnabled = true;
            this.cmbSolutions.Items.AddRange(new object[] {
            "MS SQL",
            "My SQL"});
            this.cmbSolutions.Location = new System.Drawing.Point(67, 23);
            this.cmbSolutions.Name = "cmbSolutions";
            this.cmbSolutions.Size = new System.Drawing.Size(206, 21);
            this.cmbSolutions.TabIndex = 45;
            this.cmbSolutions.SelectedIndexChanged += new System.EventHandler(this.cmbSolutions_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Solution:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 553);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvgTableColumns);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 470);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // dvgTableColumns
            // 
            this.dvgTableColumns.AllowUserToAddRows = false;
            this.dvgTableColumns.AllowUserToDeleteRows = false;
            this.dvgTableColumns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgTableColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTableColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSelect,
            this.clmName,
            this.clmType});
            this.dvgTableColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgTableColumns.Location = new System.Drawing.Point(3, 16);
            this.dvgTableColumns.Name = "dvgTableColumns";
            this.dvgTableColumns.RowHeadersVisible = false;
            this.dvgTableColumns.Size = new System.Drawing.Size(340, 451);
            this.dvgTableColumns.TabIndex = 2;
            // 
            // clmSelect
            // 
            this.clmSelect.FalseValue = "0";
            this.clmSelect.Frozen = true;
            this.clmSelect.HeaderText = "Select";
            this.clmSelect.Name = "clmSelect";
            this.clmSelect.TrueValue = "1";
            this.clmSelect.Width = 43;
            // 
            // clmName
            // 
            this.clmName.Frozen = true;
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.Width = 150;
            // 
            // clmType
            // 
            this.clmType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmType.HeaderText = "Type";
            this.clmType.Name = "clmType";
            this.clmType.Width = 80;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbkSelectAll);
            this.groupBox3.Controls.Add(this.cmdColumns);
            this.groupBox3.Controls.Add(this.cmbDBTables);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 64);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // cbkSelectAll
            // 
            this.cbkSelectAll.AutoSize = true;
            this.cbkSelectAll.Location = new System.Drawing.Point(6, 41);
            this.cbkSelectAll.Name = "cbkSelectAll";
            this.cbkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbkSelectAll.TabIndex = 14;
            this.cbkSelectAll.Text = "Select All";
            this.cbkSelectAll.UseVisualStyleBackColor = true;
            this.cbkSelectAll.CheckedChanged += new System.EventHandler(this.cbkSelectAll_CheckedChanged);
            // 
            // cmdColumns
            // 
            this.cmdColumns.Location = new System.Drawing.Point(265, 41);
            this.cmdColumns.Name = "cmdColumns";
            this.cmdColumns.Size = new System.Drawing.Size(75, 20);
            this.cmdColumns.TabIndex = 13;
            this.cmdColumns.Text = "Columns";
            this.cmdColumns.UseVisualStyleBackColor = true;
            this.cmdColumns.Click += new System.EventHandler(this.cmdColumns_Click);
            // 
            // cmbDBTables
            // 
            this.cmbDBTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDBTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDBTables.FormattingEnabled = true;
            this.cmbDBTables.Items.AddRange(new object[] {
            "MS SQL",
            "My SQL"});
            this.cmbDBTables.Location = new System.Drawing.Point(3, 16);
            this.cmbDBTables.Name = "cmbDBTables";
            this.cmbDBTables.Size = new System.Drawing.Size(340, 21);
            this.cmbDBTables.TabIndex = 3;
            this.cmbDBTables.SelectedIndexChanged += new System.EventHandler(this.cmbDBTables_SelectedIndexChanged);
            this.cmbDBTables.TextChanged += new System.EventHandler(this.cmbDBTables_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtProjectNamespace);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmdBrowseFolder);
            this.groupBox4.Controls.Add(this.txtBaseFolder);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.cmbProjects);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(352, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 104);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Project:";
            // 
            // txtBaseFolder
            // 
            this.txtBaseFolder.Location = new System.Drawing.Point(96, 50);
            this.txtBaseFolder.Name = "txtBaseFolder";
            this.txtBaseFolder.Size = new System.Drawing.Size(362, 20);
            this.txtBaseFolder.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Base Folder:";
            // 
            // cmbProjects
            // 
            this.cmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Items.AddRange(new object[] {
            "MS SQL",
            "My SQL"});
            this.cmbProjects.Location = new System.Drawing.Point(96, 23);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(309, 21);
            this.cmbProjects.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Entity Projects:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dvgSolutionDBQuery);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.Location = new System.Drawing.Point(352, 162);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(193, 449);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Business Entity";
            // 
            // dvgSolutionDBQuery
            // 
            this.dvgSolutionDBQuery.AllowUserToAddRows = false;
            this.dvgSolutionDBQuery.AllowUserToDeleteRows = false;
            this.dvgSolutionDBQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgSolutionDBQuery.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgSolutionDBQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSolutionDBQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmQueryName});
            this.dvgSolutionDBQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgSolutionDBQuery.Location = new System.Drawing.Point(3, 16);
            this.dvgSolutionDBQuery.Name = "dvgSolutionDBQuery";
            this.dvgSolutionDBQuery.RowHeadersVisible = false;
            this.dvgSolutionDBQuery.Size = new System.Drawing.Size(187, 430);
            this.dvgSolutionDBQuery.TabIndex = 2;
            // 
            // clmQueryName
            // 
            this.clmQueryName.HeaderText = "Class Name";
            this.clmQueryName.Name = "clmQueryName";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkisSavedOnGenerate);
            this.groupBox5.Controls.Add(this.cmdGenerateBE);
            this.groupBox5.Controls.Add(this.txtGenerateBENamespace);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtGenerateBESaveIn);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtGeneratedClass);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(545, 162);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(355, 449);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected Class";
            // 
            // txtGeneratedClass
            // 
            this.txtGeneratedClass.HideSelection = false;
            this.txtGeneratedClass.Location = new System.Drawing.Point(3, 115);
            this.txtGeneratedClass.Multiline = true;
            this.txtGeneratedClass.Name = "txtGeneratedClass";
            this.txtGeneratedClass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGeneratedClass.Size = new System.Drawing.Size(349, 355);
            this.txtGeneratedClass.TabIndex = 19;
            // 
            // txtProjectNamespace
            // 
            this.txtProjectNamespace.Location = new System.Drawing.Point(96, 76);
            this.txtProjectNamespace.Name = "txtProjectNamespace";
            this.txtProjectNamespace.Size = new System.Drawing.Size(362, 20);
            this.txtProjectNamespace.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Namespace:";
            // 
            // txtGenerateBESaveIn
            // 
            this.txtGenerateBESaveIn.Location = new System.Drawing.Point(74, 19);
            this.txtGenerateBESaveIn.Name = "txtGenerateBESaveIn";
            this.txtGenerateBESaveIn.Size = new System.Drawing.Size(266, 20);
            this.txtGenerateBESaveIn.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Save In:";
            // 
            // txtGenerateBENamespace
            // 
            this.txtGenerateBENamespace.Location = new System.Drawing.Point(74, 45);
            this.txtGenerateBENamespace.Name = "txtGenerateBENamespace";
            this.txtGenerateBENamespace.Size = new System.Drawing.Size(266, 20);
            this.txtGenerateBENamespace.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Namespace:";
            // 
            // cmdGenerateBE
            // 
            this.cmdGenerateBE.Image = global::Pss.ProgrammerMate.Properties.Resources.GenerateC;
            this.cmdGenerateBE.Location = new System.Drawing.Point(218, 71);
            this.cmdGenerateBE.Name = "cmdGenerateBE";
            this.cmdGenerateBE.Size = new System.Drawing.Size(122, 38);
            this.cmdGenerateBE.TabIndex = 62;
            this.cmdGenerateBE.Text = "Generate BE";
            this.cmdGenerateBE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGenerateBE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGenerateBE.UseVisualStyleBackColor = true;
            this.cmdGenerateBE.Click += new System.EventHandler(this.cmdGenerateBE_Click_1);
            // 
            // cmdBrowseFolder
            // 
            this.cmdBrowseFolder.Image = global::Pss.ProgrammerMate.Properties.Resources.browsefolder;
            this.cmdBrowseFolder.Location = new System.Drawing.Point(464, 48);
            this.cmdBrowseFolder.Name = "cmdBrowseFolder";
            this.cmdBrowseFolder.Size = new System.Drawing.Size(29, 23);
            this.cmdBrowseFolder.TabIndex = 58;
            this.cmdBrowseFolder.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Pss.ProgrammerMate.Properties.Resources._1417109849_view_refresh_32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(411, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.BackgroundImage = global::Pss.ProgrammerMate.Properties.Resources._1417109849_view_refresh_32;
            this.cmdRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRefresh.Location = new System.Drawing.Point(279, 15);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(34, 35);
            this.cmdRefresh.TabIndex = 13;
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdConnect
            // 
            this.cmdConnect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdConnect.Image = global::Pss.ProgrammerMate.Properties.Resources.connectdb_small;
            this.cmdConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConnect.Location = new System.Drawing.Point(803, 13);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(91, 39);
            this.cmdConnect.TabIndex = 49;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdConnect.UseVisualStyleBackColor = false;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(76, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(76, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(76, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(76, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bnbtnExit
            // 
            this.bnbtnExit.Image = global::Pss.ProgrammerMate.Properties.Resources._1417110356_Log_Out;
            this.bnbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnbtnExit.Name = "bnbtnExit";
            this.bnbtnExit.Size = new System.Drawing.Size(76, 20);
            this.bnbtnExit.Text = "E&xit";
            // 
            // txtCopyClipboard
            // 
            this.txtCopyClipboard.Image = ((System.Drawing.Image)(resources.GetObject("txtCopyClipboard.Image")));
            this.txtCopyClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtCopyClipboard.Name = "txtCopyClipboard";
            this.txtCopyClipboard.Size = new System.Drawing.Size(76, 20);
            this.txtCopyClipboard.Text = "&Copy";
            this.txtCopyClipboard.Click += new System.EventHandler(this.txtCopyClipboard_Click);
            // 
            // cmdExecuteQuery
            // 
            this.cmdExecuteQuery.Image = ((System.Drawing.Image)(resources.GetObject("cmdExecuteQuery.Image")));
            this.cmdExecuteQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExecuteQuery.Name = "cmdExecuteQuery";
            this.cmdExecuteQuery.Size = new System.Drawing.Size(76, 20);
            this.cmdExecuteQuery.Text = "&Run Qry";
            // 
            // chkisSavedOnGenerate
            // 
            this.chkisSavedOnGenerate.AutoSize = true;
            this.chkisSavedOnGenerate.Location = new System.Drawing.Point(9, 83);
            this.chkisSavedOnGenerate.Name = "chkisSavedOnGenerate";
            this.chkisSavedOnGenerate.Size = new System.Drawing.Size(115, 17);
            this.chkisSavedOnGenerate.TabIndex = 63;
            this.chkisSavedOnGenerate.Text = "Save On Generate";
            this.chkisSavedOnGenerate.UseVisualStyleBackColor = true;
            // 
            // frmBusinessEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.gbRight);
            this.MaximizeBox = false;
            this.Name = "frmBusinessEntity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Entity Generation";
            this.Load += new System.EventHandler(this.frmBusinessEntity_Load);
            this.gbRight.ResumeLayout(false);
            this.gbRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).EndInit();
            this.bnMain.ResumeLayout(false);
            this.bnMain.PerformLayout();
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTableColumns)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSolutionDBQuery)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Solutions_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionsDB_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionsDBTables_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableColumns_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projects_bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRight;
        private System.Windows.Forms.BindingNavigator bnMain;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bnbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton txtCopyClipboard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cmdExecuteQuery;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.ComboBox cmbSolutionsDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSolutions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvgTableColumns;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbkSelectAll;
        private System.Windows.Forms.Button cmdColumns;
        private System.Windows.Forms.ComboBox cmbDBTables;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdBrowseFolder;
        private System.Windows.Forms.TextBox txtBaseFolder;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dvgSolutionDBQuery;
        private System.Windows.Forms.BindingSource Solutions_bindingSource;
        private System.Windows.Forms.BindingSource SolutionsDB_bindingSource;
        private System.Windows.Forms.BindingSource SolutionsDBTables_bindingSource;
        private System.Windows.Forms.BindingSource TableColumns_bindingSource;
        private System.Windows.Forms.BindingSource Projects_bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQueryName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtGeneratedClass;
        private System.Windows.Forms.TextBox txtProjectNamespace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdGenerateBE;
        private System.Windows.Forms.TextBox txtGenerateBENamespace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGenerateBESaveIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkisSavedOnGenerate;
    }
}