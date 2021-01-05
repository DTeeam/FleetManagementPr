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
        private CompanyDB db;
        public Form1()
        {
            InitializeComponent();
            db = new CompanyDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Places> listToDisplay = db.readPlaces();
            listBox1.Items.Clear();

            foreach (Places place in listToDisplay)
            {
                listBox1.Items.Add(place.name + " | " + place.postalNum);
            }
        }

        private void buttonToAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Veichle added succeauioshdcui");
        }

        private void buttonToPrintPlaces_Click(object sender, EventArgs e)
        {
            List<Places> listToDisplay = db.readPlaces();
            listBox1.Items.Clear();

            foreach(Places place in listToDisplay)
            {
                listBox1.Items.Add(place.name + " | " + place.postalNum);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test = listBox1.SelectedItem;

            string splitString = test.ToString();
            string[] array = splitString.Split('|');

            string name = "";
            string postalNum = "";

            foreach (String s in array)
            {
                name = array[0];
                postalNum = array[1];
            }
            //int finalName = Convert.ToInt32(name);
            //double finalNum = Convert.ToDouble(postalNum);
            textBox1.Text = name;
            textBox2.Text = postalNum;
        }

        private void buttonToAddPlace_Click(object sender, EventArgs e)
        {

        }
    }
}
