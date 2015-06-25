using Family_Tree.Data_Logic_Layer;
using Family_Tree.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Tree.Presentation_Layer
{
    public partial class AddPersonScreen : Form
    {
        public AddPersonScreen()
        {
            InitializeComponent();
        }

        private void AddPersonScreen_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            bdPicker.Value = currentDate;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PersonManagement manager = new PersonManagement();
            Person newPerson = new Person();

            if(CheckRequiredEntered())
            {
                newPerson.FirstName = fnTxtBox.Text;
                newPerson.LastName = lnTxtBox.Text;

                if (genderComboBox.SelectedIndex == 0)
                    newPerson.Gender = Gender.Male;
                else
                    newPerson.Gender = Gender.Female;

                //Neeed to work on the following 2 instances of setting a datetime property from the datetimepicker control
                newPerson.Birthdate = DateTime.Parse(bdPicker.Value.ToString());
                newPerson.BirthPlace = bpTxtBox.Text;

                if(deceasedCheckbox.Checked == true)
                {
                    newPerson.Deceased = true;
                    newPerson.DeathDate = DateTime.Parse(ddDatePicker.Value.ToString());
                    newPerson.DeathPlace = dpTxtBox.Text;
                }
            }

            manager.AddPerson(newPerson);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deceasedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(deceasedCheckbox.Checked == true)
            {
                ddDatePicker.Enabled = true;
                dpTxtBox.Enabled = true;
            }
            else
            {
                ddDatePicker.Enabled = false;
                dpTxtBox.Enabled = false;
            }
        }

        private void fnTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(fnTxtBox.Text != "")
            {
                fnLabel.BackColor = SystemColors.Control;
                fnLabel.ForeColor = SystemColors.ControlText;
            }
        }

        private void lnTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(lnTxtBox.Text != "")
            {
                lnLabel.BackColor = SystemColors.Control;
                lnLabel.ForeColor = SystemColors.ControlText;
            }
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(genderComboBox.SelectedIndex != -1)
            {
                genderLabel.BackColor = SystemColors.Control;
                genderLabel.ForeColor = SystemColors.ControlText;
            }
        }

        bool CheckRequiredEntered()
        {
            if (fnTxtBox.Text == "" || lnTxtBox.Text == "" || genderComboBox.SelectedIndex == -1)
            {
                if (fnTxtBox.Text == "")
                {
                    fnLabel.BackColor = SystemColors.Highlight;
                    fnLabel.ForeColor = SystemColors.HighlightText;
                }
                if (lnTxtBox.Text == "")
                {
                    lnLabel.BackColor = SystemColors.Highlight;
                    lnLabel.ForeColor = SystemColors.HighlightText;
                }
                if (genderComboBox.SelectedIndex == -1)
                {
                    genderLabel.BackColor = SystemColors.Highlight;
                    genderLabel.ForeColor = SystemColors.HighlightText;
                }

                MessageBox.Show("Fist Name, Last Name, and Gender are required fields", "Required Fields Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            
            //if(genderComboBox.SelectedIndex != 0 || genderComboBox.SelectedIndex != 1)
            //{
            //    MessageBox.Show("An invalid Gender has been entered", "Invalid Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return true;
        }
    }
}
