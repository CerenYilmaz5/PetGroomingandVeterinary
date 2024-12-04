using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGroomingandVeterinary
{
    public partial class WorkSpace : Form
    {
        public WorkSpace()
        {
            InitializeComponent();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void WorkSpace_Load(object sender, EventArgs e)
        {

        }
    }
}
