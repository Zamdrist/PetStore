using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class frmAnimalSelection : Form
    {

        public frmAnimalSelection()
        {
            InitializeComponent();
        }

        private decimal Calculate()
        {
            //Calculates the total price based on the quantity of animals for that one addition
            decimal result = 0m;
            if (lstPets.Text == "Cat")
            {
                result = 25 * Convert.ToInt32(txtQuantity.Text);
                return result;
            }
            else if (lstPets.Text == "Dog")
            {
                result = 30 * Convert.ToInt32(txtQuantity.Text);
                return result;
            }
            else if (lstPets.Text == "Lizard")
            {
                result = 15 * Convert.ToInt32(txtQuantity.Text);
                return result;
            }
            else if (lstPets.Text == "Snake")
            {
                result = 10 * Convert.ToInt32(txtQuantity.Text);
                return result;
            }
            else
            {
                result = -1;
                return result;
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            //Calls the data validation before adding the data to the Inventory form
            if (IsValidData())
            {
                //exception handling
                try
                {
                    this.SaveData();
                }
                catch (FormatException)
                {
                    //catch a format exception
                    MessageBox.Show("A format exception has occured. Please check all entries.", "Entry Error");
                }
                catch (OverflowException)
                {
                    //catch the overflow exception if a number is too large
                    MessageBox.Show("An overflow exception has occurred. Please enter smaller values.", "Entry Error");
                }
                catch (Exception ex)
                {
                    //General catch all exception
                    MessageBox.Show(ex.Message + "\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
                }
            }
        }

        private bool IsValidData()
        {
            //Data validation to enture a month and year are selected
            if (cboMonths.SelectedIndex == 0)
            {
                MessageBox.Show("You must slect a pickup month.", "Entry Error");
                cboMonths.Focus();
                return false;
            }
            if (cboYears.SelectedIndex == 0)
            {
                MessageBox.Show("You must slect a pickup Year.", "Entry Error");
                cboMonths.Focus();
                return false;
            }

            return
            //Checks that quantity is present and is an integer value
            IsPresent(txtQuantity, "Quantity") &&
                IsInt32(txtQuantity, "Quantity") &&
                IsWithinRange(txtQuantity, "Quantity", 0, 10);
                
        }

        private void SaveData()
        {
            //Takes all entered data and puts it into one string and sends to the Inventory form
            string msg = null;
            decimal cost = 0m;
            msg += "Animal: " + lstPets.Text + "\t" + "Quantity: " + txtQuantity.Text + "\t";
            msg += "Pickup Date: " + cboMonths.Text + "/" + cboYears.Text + "\t";
            msg += "Cost: " + Calculate().ToString("c2");
            cost = Calculate();

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

        private void frmAnimalSelection_load(object sender, EventArgs e)
        {
            //Loads the animal selection form with the available animals
            lstPets.Items.Add("Cat");
            lstPets.Items.Add("Dog");
            lstPets.Items.Add("Lizard");
            lstPets.Items.Add("Snake");
            lstPets.SelectedIndex = 0;

            //loads the animal selection form with pickup months
            string[] months =
                {"Select a month...",
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December"};

            foreach (string month in months)
                cboMonths.Items.Add(month);
            cboMonths.SelectedIndex = 0;            

            //loads the animal selection form with pickup year
            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboYears.Items.Add("Select a year...");
            while (year < endYear)
            {
                cboYears.Items.Add(year);
                year++;
            }
            cboYears.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //closes the animal selection form
            this.Close();
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            //Data validation for general use to see if a text box has an entry
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsInt32(TextBox textBox, string name)
        {
            //Data validation for general use to see if a text box has an integer
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            //Data validation that limits the entry to numbers between 0-10 
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
