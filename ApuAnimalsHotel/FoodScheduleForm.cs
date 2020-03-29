using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApuAnimalsHotel
{
    /// <summary>
    /// Form to add items to a food schedule.
    /// </summary>
    public partial class FoodScheduleForm : Form
    {
        private List<string> items;

        /// <summary>
        /// Default constructor that creates a list of items of type string.
        /// </summary>
        public FoodScheduleForm()
        {
            InitializeComponent();
            if (items == null)
            {
                items = new List<string>();
            }
        }
        /// <summary>
        /// constructor that loads the form with an existing food schedule items.
        /// </summary>
        /// <param name="itemList"></param>
        public FoodScheduleForm(string[] itemList)
        {
            InitializeComponent();

            if (itemList!=null)
            {
                items = new List<string>(itemList); // converts array to list
                foreach (string item in items)
                {
                    lbItems.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Method to add a food item to the list of food schedule.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>true on success</returns>
        private bool AddItem(string item)
        {
            if (item != null)
            {
                items.Add(item);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Removes the selected food item from the food schedule.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool RemoveItemAtIndex(int index)
        {
            if (items.Count > 0)
            {
                items.RemoveAt(index);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Getter of the food items list.
        /// </summary>
        /// <returns></returns>
        public string[] GetFoodScheduleList()
        {
            if (items.Count > 0)
            {
                string[] returnedList = items.ToArray();
                return returnedList;
            }
            else
                return null;            
        }
        /// <summary>
        /// Adds input to food items list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtItem.Text!=null)
            {
                AddItem(txtItem.Text);
                lbItems.Items.Add(txtItem.Text);
                txtItem.Clear();
            }
        }

        /// <summary>
        /// Removes the selected item from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItemAtIndex(lbItems.SelectedIndex);            
        }
    }
}
