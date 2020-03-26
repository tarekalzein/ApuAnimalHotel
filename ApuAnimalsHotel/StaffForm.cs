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
    public partial class StaffForm : Form
    {
        private Staff m_staff;

        /// <summary>
        /// Constructor that initializes components and creates an instance of Staff.
        /// </summary>
        public StaffForm()
        {
            InitializeComponent();
            if(m_staff == null)
                m_staff = new Staff();            
        }

        /// <summary>
        /// Getter and setter of the Staff object
        /// </summary>
        public Staff Staff
        {
            get { return m_staff; }
            set { m_staff = value; }
        }
        /// <summary>
        /// Method to add properties to the Staff instsance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //To Do: Add validation for name and qualification.
            m_staff.Name = txtName.Text;
            m_staff.AddQualification(txtQualifications.Text);
            lbStaff.Items.Add(txtQualifications.Text);
            txtQualifications.Clear();
        }
    }
}
