using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Inventory_Management
{


    public partial class frmInvMgmt : Form
    {
        public frmInvMgmt()
        {
            InitializeComponent();
        }

        //Create the animals array
        List<decimal> animalsList = new List<decimal>();

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //creates a pop up form to add an animal to the order list
                txtTotalPriceOutput.Clear();
                string cost = null;
                Form selectAnimal = new frmAnimalSelection();
                DialogResult selectedButton = selectAnimal.ShowDialog();
                if (selectedButton == DialogResult.OK)
                {
                    //Gathers the information into a string to display in the lstbox
                    lstBoxAnimals.Items.Add((string)selectAnimal.Tag);
                    //gathers only the price of the animals and adds them to the animalsList
                    cost = Regex.Match((string)selectAnimal.Tag, @"\$\d+").Value;
                    cost = cost.Replace("$", String.Empty);
                    animalsList.Add(Convert.ToDecimal(cost));
                }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all items
            lstBoxAnimals.Items.Clear();
            txtTotalPriceOutput.Clear();
            animalsList.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //adds all animal costs together from the animalsList and displayst the final price
            decimal totalCost = 0m;
            foreach (decimal cost in animalsList)
            {
                totalCost += cost;
            }

            txtTotalPriceOutput.Text = totalCost.ToString("c2");
        }
    }
}
