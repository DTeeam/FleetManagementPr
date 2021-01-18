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
        int veichlePlaceID;
        int makeID;
        int modelID;
        public Form1()
        {
            InitializeComponent();
            db = new CompanyDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Places> listToDisplayPlaces = db.readPlaces();
            listBox1.Items.Clear();
            listBoxVeichlePlaces.Items.Clear();

            foreach (Places place in listToDisplayPlaces)
            {
                listBox1.Items.Add(place.id + " | " + place.name + " | " + place.postalNum);
            }

            foreach (Places place in listToDisplayPlaces)
            {
                listBoxVeichlePlaces.Items.Add(place.name);
            }

            List<Veichles> listToDisplayVeichles = db.readVeichles();
            listBoxForVeichles.Items.Clear();

            foreach (Veichles veichle in listToDisplayVeichles)
            {
                //MessageBox.Show(veichle.type);
                listBoxForVeichles.Items.Add(veichle.id + " | " + veichle.type + " | " + veichle.make + " | " +
                    veichle.model + " | " + veichle.yearOfMake + " | " + veichle.place);
            }

            List<Veichles> listToDisplayMake = db.readMakes();
            List<Veichles> listToDisplayModel = db.readModels();

            comboBoxMake.Items.Clear();
            comboBoxModel.Items.Clear();

            printListComboModel(listToDisplayMake);
            printListComboMake(listToDisplayModel);
            
            listBoxMake.Items.Clear();
            listBoxModel.Items.Clear();

            foreach (Veichles veichle in listToDisplayMake)
            {
                listBoxMake.Items.Add(veichle.makeID + " | " + veichle.model);
            }

            foreach (Veichles veichle in listToDisplayModel)
            {
                listBoxModel.Items.Add(veichle.makeID + " | " + veichle.model);
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

        private void buttonToDeletePlace_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(placeID);
            Places removePlace = new Places(id);
            db.deletePlace(removePlace);
        }

        private void listBoxForVeichles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxForVeichles.SelectedItem == null)
                return;

            var test = listBoxForVeichles.SelectedItem;

            string splitString = test.ToString();
            string[] array = splitString.Split(new string[] { " | " }, StringSplitOptions.None);

            string model = "";
            string make = "";
            string type = "";
            string year = "";
            string place = "";

            foreach (String s in array)
            {
                veichleID = array[0];
                type = array[1];
                make = array[2];
                model = array[3];
                year = array[4];
                place = array[5];
            }

            textBoxType.Text = type;
            comboBoxMake.Text = make;
            comboBoxModel.Text = model;
            numericUpDownYearOfMake.Value = Convert.ToInt32(year);
            textBoxVeichlePlace.Text = place;

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

        private void buttonToAddVeichle_Click(object sender, EventArgs e)
        {
            string type = textBoxType.Text;
            int year = Convert.ToInt32(numericUpDownYearOfMake.Value);
            
            Veichles addVeichle = new Veichles(type, year, modelID, veichlePlaceID);
            db.addVeichle(addVeichle);
            MessageBox.Show(modelID.ToString());
        }

        private void buttonUpdateVeichle_Click(object sender, EventArgs e)
        {
            string type;
            int year;
            
            string place;
            int placeID = 0;

            type = textBoxType.Text;
            year = Convert.ToInt32(numericUpDownYearOfMake.Value);
            place = textBoxVeichlePlace.Text;
            int i = listBoxVeichlePlaces.Items.Count;

            while (i != listBoxVeichlePlaces.SelectedIndex + 1)
            {
                listBoxVeichlePlaces.SelectedItem = place;

                i--;
                placeID = i;
            }
            
            Veichles updateVeichle = new Veichles(Convert.ToInt32(veichleID), type, year, modelID, placeID);
            db.updateVeichle(updateVeichle);
        }

        private void buttonDeleteVeichle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(veichleID);
            Veichles removeVeichle = new Veichles(id);
            db.deleteVeichle(removeVeichle);
        }

        private void listBoxveichlePlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxVeichlePlace.Text = listBoxVeichlePlaces.SelectedItem.ToString();
            veichlePlaceID = listBoxVeichlePlaces.SelectedIndex + 1;
        }


        private void printListComboModel(List<Veichles> listToDisplay)
        {
            foreach (Veichles veichle in listToDisplay)
            {
                comboBoxMake.Items.Add(veichle.makeID + " | " +  veichle.model);
            }
        }
        private void printListComboMake(List<Veichles> listToDisplay)
        {
            foreach (Veichles veichle in listToDisplay)
            {
                comboBoxModel.Items.Add(veichle.makeID + " | " + veichle.model);
            }
        }

        private void listBoxMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMake.SelectedItem == null)
                return;

            var test = listBoxMake.SelectedItem;

            string splitString = test.ToString();
            string[] array = splitString.Split(new string[] { " | " }, StringSplitOptions.None);

            string id = "";
            string make = "";

            foreach (String s in array)
            {
                id = array[0];
                make = array[1];
            }

            makeID = Convert.ToInt32(id);
            
            textBoxMake.Text = make;
        }
        private void listBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxModel.SelectedItem == null)
                return;

            var test = listBoxModel.SelectedItem;

            string splitString = test.ToString();
            string[] array = splitString.Split(new string[] { " | " }, StringSplitOptions.None);

            string id = "";
            string model = "";

            foreach (String s in array)
            {
                id = array[0];
                model = array[1];
            }

            modelID = Convert.ToInt32(id);

            textBoxModel.Text = model;
        }

        private void comboBoxMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test = comboBoxMake.SelectedItem;

            string splitString = test.ToString();
            string[] array = splitString.Split(new string[] { " | " }, StringSplitOptions.None);

            string id = "";

            foreach (String s in array)
            {
                id = array[0];
            }
            makeID = Convert.ToInt32(id);

        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test = comboBoxModel.SelectedItem;

            string splitString = test.ToString();
            string[] array = splitString.Split(new string[] { " | " }, StringSplitOptions.None);

            string id = "";

            foreach (String s in array)
            {
                id = array[0];
            }
            modelID = Convert.ToInt32(id);
        }



        private void buttonToUpdateMakeList_Click(object sender, EventArgs e)
        {
            List<Veichles> listToDisplayMake = db.readMakes();
            
            listBoxMake.Items.Clear();
            
            foreach (Veichles veichle in listToDisplayMake)
            {
                listBoxMake.Items.Add(veichle.makeID + " | " + veichle.model);
            }

        }

        private void buttonToUpdateModelList_Click(object sender, EventArgs e)
        {
            List<Veichles> listToDisplayModel = db.readModels();

            listBoxModel.Items.Clear();

            foreach (Veichles veichle in listToDisplayModel)
            {
                listBoxModel.Items.Add(veichle.makeID + " | " + veichle.model);
            }
        }

        private void buttonToAddModel_Click(object sender, EventArgs e)
        {
            string model = textBoxModel.Text;

            Veichles addModel = new Veichles(model);
            db.addModel(addModel);
        }
        private void buttonToUpdateModel_Click(object sender, EventArgs e)
        {
            string model = textBoxModel.Text;
            Veichles updateModel = new Veichles(modelID, model);
            db.updateModel(updateModel);
        }

        private void buttonToDeleteModel_Click(object sender, EventArgs e)
        {
            Veichles deleteModel = new Veichles(modelID);
            db.deleteModel(deleteModel);
        }
    }
}