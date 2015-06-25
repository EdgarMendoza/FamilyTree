namespace Family_Tree
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddPerson = new System.Windows.Forms.Button();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deceasedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deathDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.familyContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyContextBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeFamilyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(926, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitFileMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.Size = new System.Drawing.Size(92, 22);
            this.exitFileMenu.Text = "Exit";
            this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenu_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btn_AddPerson
            // 
            this.btn_AddPerson.Location = new System.Drawing.Point(12, 27);
            this.btn_AddPerson.Name = "btn_AddPerson";
            this.btn_AddPerson.Size = new System.Drawing.Size(120, 56);
            this.btn_AddPerson.TabIndex = 1;
            this.btn_AddPerson.Text = "Add Person";
            this.btn_AddPerson.UseVisualStyleBackColor = true;
            this.btn_AddPerson.Click += new System.EventHandler(this.btn_AddPerson_Click);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDataGridView.AutoGenerateColumns = false;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.birthPlaceDataGridViewTextBoxColumn,
            this.deceasedDataGridViewCheckBoxColumn,
            this.deathDateDataGridViewTextBoxColumn,
            this.deathPlaceDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.generationDataGridViewTextBoxColumn});
            this.mainDataGridView.DataSource = this.personBindingSource;
            this.mainDataGridView.Location = new System.Drawing.Point(296, 27);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(618, 389);
            this.mainDataGridView.TabIndex = 3;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // birthPlaceDataGridViewTextBoxColumn
            // 
            this.birthPlaceDataGridViewTextBoxColumn.DataPropertyName = "BirthPlace";
            this.birthPlaceDataGridViewTextBoxColumn.HeaderText = "BirthPlace";
            this.birthPlaceDataGridViewTextBoxColumn.Name = "birthPlaceDataGridViewTextBoxColumn";
            // 
            // deceasedDataGridViewCheckBoxColumn
            // 
            this.deceasedDataGridViewCheckBoxColumn.DataPropertyName = "Deceased";
            this.deceasedDataGridViewCheckBoxColumn.HeaderText = "Deceased";
            this.deceasedDataGridViewCheckBoxColumn.Name = "deceasedDataGridViewCheckBoxColumn";
            // 
            // deathDateDataGridViewTextBoxColumn
            // 
            this.deathDateDataGridViewTextBoxColumn.DataPropertyName = "DeathDate";
            this.deathDateDataGridViewTextBoxColumn.HeaderText = "DeathDate";
            this.deathDateDataGridViewTextBoxColumn.Name = "deathDateDataGridViewTextBoxColumn";
            // 
            // deathPlaceDataGridViewTextBoxColumn
            // 
            this.deathPlaceDataGridViewTextBoxColumn.DataPropertyName = "DeathPlace";
            this.deathPlaceDataGridViewTextBoxColumn.HeaderText = "DeathPlace";
            this.deathPlaceDataGridViewTextBoxColumn.Name = "deathPlaceDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // generationDataGridViewTextBoxColumn
            // 
            this.generationDataGridViewTextBoxColumn.DataPropertyName = "Generation";
            this.generationDataGridViewTextBoxColumn.HeaderText = "Generation";
            this.generationDataGridViewTextBoxColumn.Name = "generationDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Family_Tree.Models.Person);
            // 
            // familyContextBindingSource1
            // 
            this.familyContextBindingSource1.DataSource = typeof(Family_Tree.Data_Access_Layer.FamilyContext);
            // 
            // familyContextBindingSource
            // 
            this.familyContextBindingSource.DataSource = typeof(Family_Tree.Data_Access_Layer.FamilyContext);
            // 
            // wholeFamilyBindingSource
            // 
            this.wholeFamilyBindingSource.DataSource = typeof(Family_Tree.Models.Tree);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 627);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.btn_AddPerson);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Tree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyContextBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeFamilyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddPerson;
        private System.Windows.Forms.BindingSource familyContextBindingSource;
        private System.Windows.Forms.BindingSource wholeFamilyBindingSource;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn treeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource familyContextBindingSource1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deceasedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generationDataGridViewTextBoxColumn;
    }
}

