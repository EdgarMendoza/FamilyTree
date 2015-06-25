namespace Family_Tree.Presentation_Layer
{
    partial class AddPersonScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonScreen));
            this.fnLabel = new System.Windows.Forms.Label();
            this.fnTxtBox = new System.Windows.Forms.TextBox();
            this.lnLabel = new System.Windows.Forms.Label();
            this.lnTxtBox = new System.Windows.Forms.TextBox();
            this.bdLabel = new System.Windows.Forms.Label();
            this.bdPicker = new System.Windows.Forms.DateTimePicker();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bpLabel = new System.Windows.Forms.Label();
            this.bpTxtBox = new System.Windows.Forms.TextBox();
            this.deceasedCheckbox = new System.Windows.Forms.CheckBox();
            this.ddLabel = new System.Windows.Forms.Label();
            this.ddDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dpLabel = new System.Windows.Forms.Label();
            this.dpTxtBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(13, 16);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(60, 13);
            this.fnLabel.TabIndex = 0;
            this.fnLabel.Text = "First Name:";
            // 
            // fnTxtBox
            // 
            this.fnTxtBox.Location = new System.Drawing.Point(91, 12);
            this.fnTxtBox.Name = "fnTxtBox";
            this.fnTxtBox.Size = new System.Drawing.Size(146, 20);
            this.fnTxtBox.TabIndex = 1;
            this.fnTxtBox.TextChanged += new System.EventHandler(this.fnTxtBox_TextChanged);
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.Location = new System.Drawing.Point(12, 43);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(61, 13);
            this.lnLabel.TabIndex = 2;
            this.lnLabel.Text = "Last Name:";
            // 
            // lnTxtBox
            // 
            this.lnTxtBox.Location = new System.Drawing.Point(91, 40);
            this.lnTxtBox.Name = "lnTxtBox";
            this.lnTxtBox.Size = new System.Drawing.Size(146, 20);
            this.lnTxtBox.TabIndex = 2;
            this.lnTxtBox.TextChanged += new System.EventHandler(this.lnTxtBox_TextChanged);
            // 
            // bdLabel
            // 
            this.bdLabel.AutoSize = true;
            this.bdLabel.Location = new System.Drawing.Point(12, 98);
            this.bdLabel.Name = "bdLabel";
            this.bdLabel.Size = new System.Drawing.Size(52, 13);
            this.bdLabel.TabIndex = 4;
            this.bdLabel.Text = "Birthdate:";
            // 
            // bdPicker
            // 
            this.bdPicker.Checked = false;
            this.bdPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdPicker.Location = new System.Drawing.Point(91, 94);
            this.bdPicker.Name = "bdPicker";
            this.bdPicker.ShowCheckBox = true;
            this.bdPicker.Size = new System.Drawing.Size(146, 20);
            this.bdPicker.TabIndex = 4;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(12, 70);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 13);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(91, 67);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(146, 21);
            this.genderComboBox.TabIndex = 3;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Family_Tree.Models.Person);
            // 
            // bpLabel
            // 
            this.bpLabel.AutoSize = true;
            this.bpLabel.Location = new System.Drawing.Point(12, 123);
            this.bpLabel.Name = "bpLabel";
            this.bpLabel.Size = new System.Drawing.Size(61, 13);
            this.bpLabel.TabIndex = 8;
            this.bpLabel.Text = "Birth Place:";
            // 
            // bpTxtBox
            // 
            this.bpTxtBox.Location = new System.Drawing.Point(91, 120);
            this.bpTxtBox.Name = "bpTxtBox";
            this.bpTxtBox.Size = new System.Drawing.Size(146, 20);
            this.bpTxtBox.TabIndex = 5;
            // 
            // deceasedCheckbox
            // 
            this.deceasedCheckbox.AutoSize = true;
            this.deceasedCheckbox.Location = new System.Drawing.Point(91, 146);
            this.deceasedCheckbox.Name = "deceasedCheckbox";
            this.deceasedCheckbox.Size = new System.Drawing.Size(81, 17);
            this.deceasedCheckbox.TabIndex = 6;
            this.deceasedCheckbox.Text = "Deceased?";
            this.deceasedCheckbox.UseVisualStyleBackColor = true;
            this.deceasedCheckbox.CheckedChanged += new System.EventHandler(this.deceasedCheckbox_CheckedChanged);
            // 
            // ddLabel
            // 
            this.ddLabel.AutoSize = true;
            this.ddLabel.Location = new System.Drawing.Point(12, 175);
            this.ddLabel.Name = "ddLabel";
            this.ddLabel.Size = new System.Drawing.Size(60, 13);
            this.ddLabel.TabIndex = 12;
            this.ddLabel.Text = "Deathdate:";
            // 
            // ddDatePicker
            // 
            this.ddDatePicker.Checked = false;
            this.ddDatePicker.Enabled = false;
            this.ddDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddDatePicker.Location = new System.Drawing.Point(91, 169);
            this.ddDatePicker.Name = "ddDatePicker";
            this.ddDatePicker.ShowCheckBox = true;
            this.ddDatePicker.Size = new System.Drawing.Size(146, 20);
            this.ddDatePicker.TabIndex = 7;
            // 
            // dpLabel
            // 
            this.dpLabel.AutoSize = true;
            this.dpLabel.Location = new System.Drawing.Point(12, 198);
            this.dpLabel.Name = "dpLabel";
            this.dpLabel.Size = new System.Drawing.Size(69, 13);
            this.dpLabel.TabIndex = 14;
            this.dpLabel.Text = "Death Place:";
            // 
            // dpTxtBox
            // 
            this.dpTxtBox.Enabled = false;
            this.dpTxtBox.Location = new System.Drawing.Point(91, 195);
            this.dpTxtBox.Name = "dpTxtBox";
            this.dpTxtBox.Size = new System.Drawing.Size(146, 20);
            this.dpTxtBox.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 235);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 40);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(147, 235);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 40);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddPersonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 300);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dpTxtBox);
            this.Controls.Add(this.dpLabel);
            this.Controls.Add(this.ddDatePicker);
            this.Controls.Add(this.ddLabel);
            this.Controls.Add(this.deceasedCheckbox);
            this.Controls.Add(this.bpTxtBox);
            this.Controls.Add(this.bpLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.bdPicker);
            this.Controls.Add(this.bdLabel);
            this.Controls.Add(this.lnTxtBox);
            this.Controls.Add(this.lnLabel);
            this.Controls.Add(this.fnTxtBox);
            this.Controls.Add(this.fnLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPersonScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Person";
            this.Load += new System.EventHandler(this.AddPersonScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.TextBox fnTxtBox;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.TextBox lnTxtBox;
        private System.Windows.Forms.Label bdLabel;
        private System.Windows.Forms.DateTimePicker bdPicker;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label bpLabel;
        private System.Windows.Forms.TextBox bpTxtBox;
        private System.Windows.Forms.CheckBox deceasedCheckbox;
        private System.Windows.Forms.Label ddLabel;
        private System.Windows.Forms.DateTimePicker ddDatePicker;
        private System.Windows.Forms.Label dpLabel;
        private System.Windows.Forms.TextBox dpTxtBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}