using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace FleetManagementPr
{
    public partial class Form1 : Form
    {
        private Database db;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonToAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Veichle added succeauioshdcui");
        }

        private void buttonToAddPlaces_Click(object sender, EventArgs e)
        {
            string name = textBoxPlaceName.ToString();
            int num = Convert.ToInt32(textBoxPlaceNum);
            string len = textBoxPlaceNum.ToString();

            if (len.Length != 4)
                MessageBox.Show("Please enter a correct postal number.");

            
        }
    }
}
