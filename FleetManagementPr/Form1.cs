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
        string placeID = "";
        string veichleID = "";
        public Form1()
        {
            InitializeComponent();
            db = new CompanyDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Places> listToDisplayPlaces = db.readPlaces();
            listBox1.Items.Clear();

            foreach (Places place in listToDisplayPlaces)
            {
                listBox1.Items.Add(place.id + " | " + place.name + " | "  + place.postalNum);
            }

            List<Veichles> listToDisplayVeichles = db.readVeichles();
            listBoxForVeichles.Items.Clear();

            foreach (Veichles veichle in listToDisplayVeichles)
            {
                //MessageBox.Show(veichle.type);
                listBoxForVeichles.Items.Add(veichle.id + " | " + veichle.type + " | " + veichle.make + " | " +
                    veichle.model + " | " + veichle.yearOfMake + " | " + veichle.place);
            }

            List<Places> listToDisplayMake;
            comboBoxModel.Items.Clear();

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
                listBox1.Items.Add(place.id + " | " + place.name + " | " + place.postalNum);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test = listBox1.SelectedItem;

            string splitString = test.ToString();
            string[] array = splitString.Split(new string[] { " | "}, StringSplitOptions.None);

            string name = "";
            string postalNum = "";

            foreach (String s in array)
            {
                placeID = array[0];
                name = array[1];
                postalNum = array[2];
            }
            //int finalName = Convert.ToInt32(name);
            //double finalNum = Convert.ToDouble(postalNum);
            textBoxPlaceName.Text = name;
            textBoxPlaceNum.Text = postalNum;
            
        }

        private void buttonToUpdatePlace_Click(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a place first.");
            }

            else
            {
                string name;
                string postalNum;
                //string id = "";


                name = textBoxPlaceName.Text;
                postalNum = textBoxPlaceNum.Text;


                Places place = new Places(Convert.ToInt32(placeID), name, postalNum);
                db.updatePlace(place);
            }
            
        }

        private void buttonToPrintVeichles_Click(object sender, EventArgs e)
        {
            List<Veichles> listToDisplay = db.readVeichles();
            listBoxForVeichles.Items.Clear();

            foreach (Veichles veichle in listToDisplay)
            {
                //MessageBox.Show(veichle.type);
                listBoxForVeichles.Items.Add(veichle.id + " | " + veichle.type + " | " + veichle.make + " | " +
                    veichle.model + " | " + veichle.yearOfMake + " | " + veichle.place);
            }
        }

        private void listBoxForVeichles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test = listBoxForVeichles.SelectedItem;

            string splitString = test.ToString();
            string[] array = splitString.Split(new string[] { " | " }, StringSplitOptions.None);

            string name = "";
            string postalNum = "";

            foreach (String s in array)
            {
                veichleID = array[0];
                name = array[1];
                postalNum = array[2];
            }
            //int finalName = Convert.ToInt32(name);
            //double finalNum = Convert.ToDouble(postalNum);
            textBoxPlaceName.Text = name;
            textBoxPlaceNum.Text = postalNum;

        }

        private void buttonToAddVeichle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
