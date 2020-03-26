using ApuAnimalsHotel.POCO;
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

    public partial class RecipeForm : Form
    {
        private Recipe recipe;

        /// <summary>
        /// Constructor that initializes components and creates an instance of Recipe.
        /// </summary>
        public RecipeForm()
        {
            InitializeComponent();
            if (recipe == null)
                recipe = new Recipe();
        }

        /// <summary>
        /// Getter and setter of the Recipe object
        /// </summary>
        public Recipe Recipe
        {
            get { return recipe; }
            set { recipe = value; }
        }

        /// <summary>
        /// This Button returns DialogResult.OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Method to add properties to the Recipe instsance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            recipe.Name = txtName.Text;
            recipe.AddIngredient(txtIngredients.Text);
            lbIngredients.Items.Add(txtIngredients.Text);
            txtIngredients.Clear(); //Clear the text box after adding item.
        }
    }
}
