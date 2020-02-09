using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApuAnimalsHotel.Enums;

namespace ApuAnimalsHotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //List CategoryType items in list box.
            Array categoryArray = typeof(CategoryType).GetEnumValues();
            foreach (CategoryType categoryType in categoryArray)
            {
                lbCategory.Items.Add(categoryType);
            }

            //List Gender types in Combo box.
            Array genderArray= Enum.GetValues(typeof(GenderType));
            foreach(GenderType genderType in genderArray)
            {
                cmbGender.Items.Add(genderType);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryType categoryType = (CategoryType)lbCategory.SelectedItem;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenderType genderType = (GenderType)cmbGender.SelectedItem;
        }

        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategory.GetItemText(lbCategory.SelectedItem) == "Mammal") 
            
            {
                grpbx2.Visible=true;
            }
            else
            {
                grpbx2.Visible = false;
            }
            
        }

        private void grpbx2_Enter(object sender, EventArgs e)
        {

        }
    }
}
