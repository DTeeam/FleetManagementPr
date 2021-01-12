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

        private void buttonToAddPlace_Click(object sender, EventArgs e)
        {
            string name = textBoxPlaceName.Text;
            string postalNum = textBoxPlaceNum.Text;

            if (postalNum.Length == 4)
            {
                Places addPlace = new Places(name, postalNum);
                db.addPlace(addPlace);
                //MessageBox.Show(name + postalNum);
            }
            else
                MessageBox.Show("Postal number must not be longer than 4 numbers.");
            
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
            textBoxPlaceName.Text = name;
            textBoxPlaceNum.Text = postalNum;
        }

        private void buttonToPrintVeichles_Click(object sender, EventArgs e)
        {
            List<Veichles> listToDisplay = db.readVeichles();
            listBoxForVeichles.Items.Clear();

            foreach (Veichles veichle in listToDisplay)
            {
                //MessageBox.Show(veichle.type);
                listBoxForVeichles.Items.Add(veichle.type + " | " + veichle.make + " | " + veichle.model + " | " + veichle.yearOfMake);
            }
        }
    }
}
