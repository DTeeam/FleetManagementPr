
namespace FleetManagementPr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonToDeleteMake = new System.Windows.Forms.Button();
            this.buttonToUpdateMake = new System.Windows.Forms.Button();
            this.buttonToAddMake = new System.Windows.Forms.Button();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxModel = new System.Windows.Forms.ListBox();
            this.listBoxMake = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDeleteVeichle = new System.Windows.Forms.Button();
            this.buttonUpdateVeichle = new System.Windows.Forms.Button();
            this.textBoxVeichlePlace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxVeichlePlaces = new System.Windows.Forms.ListBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.numericUpDownYearOfMake = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonToAddVeichle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxForVeichles = new System.Windows.Forms.ListBox();
            this.buttonToPrintVeichles = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonToDeletePlace = new System.Windows.Forms.Button();
            this.buttonToUpdatePlace = new System.Windows.Forms.Button();
            this.buttonToAddPlace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlaceNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonToPrintPlaces = new System.Windows.Forms.Button();
            this.buttonToUpdateMakeList = new System.Windows.Forms.Button();
            this.buttonToUpdateModelList = new System.Windows.Forms.Button();
            this.buttonToDeleteModel = new System.Windows.Forms.Button();
            this.buttonToUpdateModel = new System.Windows.Forms.Button();
            this.buttonToAddModel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearOfMake)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 452);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonToDeleteModel);
            this.tabPage1.Controls.Add(this.buttonToUpdateModel);
            this.tabPage1.Controls.Add(this.buttonToAddModel);
            this.tabPage1.Controls.Add(this.buttonToUpdateModelList);
            this.tabPage1.Controls.Add(this.buttonToUpdateMakeList);
            this.tabPage1.Controls.Add(this.buttonToDeleteMake);
            this.tabPage1.Controls.Add(this.buttonToUpdateMake);
            this.tabPage1.Controls.Add(this.buttonToAddMake);
            this.tabPage1.Controls.Add(this.textBoxModel);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxMake);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.listBoxModel);
            this.tabPage1.Controls.Add(this.listBoxMake);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make and model";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonToDeleteMake
            // 
            this.buttonToDeleteMake.Location = new System.Drawing.Point(454, 94);
            this.buttonToDeleteMake.Name = "buttonToDeleteMake";
            this.buttonToDeleteMake.Size = new System.Drawing.Size(100, 23);
            this.buttonToDeleteMake.TabIndex = 9;
            this.buttonToDeleteMake.Text = "Delete make";
            this.buttonToDeleteMake.UseVisualStyleBackColor = true;
            this.buttonToDeleteMake.Click += new System.EventHandler(this.buttonToDeleteMake_Click);
            // 
            // buttonToUpdateMake
            // 
            this.buttonToUpdateMake.Location = new System.Drawing.Point(454, 65);
            this.buttonToUpdateMake.Name = "buttonToUpdateMake";
            this.buttonToUpdateMake.Size = new System.Drawing.Size(100, 23);
            this.buttonToUpdateMake.TabIndex = 8;
            this.buttonToUpdateMake.Text = "Update make";
            this.buttonToUpdateMake.UseVisualStyleBackColor = true;
            // 
            // buttonToAddMake
            // 
            this.buttonToAddMake.Location = new System.Drawing.Point(426, 36);
            this.buttonToAddMake.Name = "buttonToAddMake";
            this.buttonToAddMake.Size = new System.Drawing.Size(128, 23);
            this.buttonToAddMake.TabIndex = 7;
            this.buttonToAddMake.Text = "Add make and model";
            this.buttonToAddMake.UseVisualStyleBackColor = true;
            this.buttonToAddMake.Click += new System.EventHandler(this.buttonToAddMake_Click);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(454, 240);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Make:";
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(454, 10);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(100, 20);
            this.textBoxMake.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Make:";
            // 
            // listBoxModel
            // 
            this.listBoxModel.FormattingEnabled = true;
            this.listBoxModel.Location = new System.Drawing.Point(582, 237);
            this.listBoxModel.Name = "listBoxModel";
            this.listBoxModel.Size = new System.Drawing.Size(201, 147);
            this.listBoxModel.TabIndex = 2;
            this.listBoxModel.SelectedIndexChanged += new System.EventHandler(this.listBoxModel_SelectedIndexChanged);
            // 
            // listBoxMake
            // 
            this.listBoxMake.FormattingEnabled = true;
            this.listBoxMake.Location = new System.Drawing.Point(582, 6);
            this.listBoxMake.Name = "listBoxMake";
            this.listBoxMake.Size = new System.Drawing.Size(201, 147);
            this.listBoxMake.TabIndex = 0;
            this.listBoxMake.SelectedIndexChanged += new System.EventHandler(this.listBoxMake_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDeleteVeichle);
            this.tabPage2.Controls.Add(this.buttonUpdateVeichle);
            this.tabPage2.Controls.Add(this.textBoxVeichlePlace);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.listBoxVeichlePlaces);
            this.tabPage2.Controls.Add(this.comboBoxModel);
            this.tabPage2.Controls.Add(this.comboBoxMake);
            this.tabPage2.Controls.Add(this.textBoxType);
            this.tabPage2.Controls.Add(this.numericUpDownYearOfMake);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonToAddVeichle);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBoxForVeichles);
            this.tabPage2.Controls.Add(this.buttonToPrintVeichles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Veichles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteVeichle
            // 
            this.buttonDeleteVeichle.Location = new System.Drawing.Point(352, 202);
            this.buttonDeleteVeichle.Name = "buttonDeleteVeichle";
            this.buttonDeleteVeichle.Size = new System.Drawing.Size(88, 23);
            this.buttonDeleteVeichle.TabIndex = 35;
            this.buttonDeleteVeichle.Text = "Delete veichle";
            this.buttonDeleteVeichle.UseVisualStyleBackColor = true;
            this.buttonDeleteVeichle.Click += new System.EventHandler(this.buttonDeleteVeichle_Click);
            // 
            // buttonUpdateVeichle
            // 
            this.buttonUpdateVeichle.Location = new System.Drawing.Point(105, 196);
            this.buttonUpdateVeichle.Name = "buttonUpdateVeichle";
            this.buttonUpdateVeichle.Size = new System.Drawing.Size(88, 23);
            this.buttonUpdateVeichle.TabIndex = 34;
            this.buttonUpdateVeichle.Text = "Update veichle";
            this.buttonUpdateVeichle.UseVisualStyleBackColor = true;
            this.buttonUpdateVeichle.Click += new System.EventHandler(this.buttonUpdateVeichle_Click);
            // 
            // textBoxVeichlePlace
            // 
            this.textBoxVeichlePlace.Location = new System.Drawing.Point(93, 170);
            this.textBoxVeichlePlace.Name = "textBoxVeichlePlace";
            this.textBoxVeichlePlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxVeichlePlace.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Place:";
            // 
            // listBoxVeichlePlaces
            // 
            this.listBoxVeichlePlaces.FormattingEnabled = true;
            this.listBoxVeichlePlaces.Location = new System.Drawing.Point(10, 259);
            this.listBoxVeichlePlaces.Name = "listBoxVeichlePlaces";
            this.listBoxVeichlePlaces.Size = new System.Drawing.Size(317, 147);
            this.listBoxVeichlePlaces.TabIndex = 31;
            this.listBoxVeichlePlaces.SelectedIndexChanged += new System.EventHandler(this.listBoxveichlePlaces_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(93, 60);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxModel.TabIndex = 30;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Location = new System.Drawing.Point(93, 18);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMake.TabIndex = 29;
            this.comboBoxMake.SelectedIndexChanged += new System.EventHandler(this.comboBoxMake_SelectedIndexChanged);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(93, 134);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 28;
            // 
            // numericUpDownYearOfMake
            // 
            this.numericUpDownYearOfMake.Location = new System.Drawing.Point(93, 93);
            this.numericUpDownYearOfMake.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericUpDownYearOfMake.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownYearOfMake.Name = "numericUpDownYearOfMake";
            this.numericUpDownYearOfMake.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownYearOfMake.TabIndex = 25;
            this.numericUpDownYearOfMake.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Year of make:";
            // 
            // buttonToAddVeichle
            // 
            this.buttonToAddVeichle.Location = new System.Drawing.Point(105, 225);
            this.buttonToAddVeichle.Name = "buttonToAddVeichle";
            this.buttonToAddVeichle.Size = new System.Drawing.Size(88, 23);
            this.buttonToAddVeichle.TabIndex = 18;
            this.buttonToAddVeichle.Text = "Add veichle";
            this.buttonToAddVeichle.UseVisualStyleBackColor = true;
            this.buttonToAddVeichle.Click += new System.EventHandler(this.buttonToAddVeichle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Veichle model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Veichle make:";
            // 
            // listBoxForVeichles
            // 
            this.listBoxForVeichles.FormattingEnabled = true;
            this.listBoxForVeichles.Location = new System.Drawing.Point(465, 3);
            this.listBoxForVeichles.Name = "listBoxForVeichles";
            this.listBoxForVeichles.Size = new System.Drawing.Size(323, 420);
            this.listBoxForVeichles.TabIndex = 13;
            this.listBoxForVeichles.SelectedIndexChanged += new System.EventHandler(this.listBoxForVeichles_SelectedIndexChanged);
            // 
            // buttonToPrintVeichles
            // 
            this.buttonToPrintVeichles.Location = new System.Drawing.Point(384, 397);
            this.buttonToPrintVeichles.Name = "buttonToPrintVeichles";
            this.buttonToPrintVeichles.Size = new System.Drawing.Size(75, 23);
            this.buttonToPrintVeichles.TabIndex = 12;
            this.buttonToPrintVeichles.Text = "Update";
            this.buttonToPrintVeichles.UseVisualStyleBackColor = true;
            this.buttonToPrintVeichles.Click += new System.EventHandler(this.buttonToPrintVeichles_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonToDeletePlace);
            this.tabPage3.Controls.Add(this.buttonToUpdatePlace);
            this.tabPage3.Controls.Add(this.buttonToAddPlace);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBoxPlaceNum);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxPlaceName);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.buttonToPrintPlaces);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Places";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonToDeletePlace
            // 
            this.buttonToDeletePlace.Location = new System.Drawing.Point(120, 174);
            this.buttonToDeletePlace.Name = "buttonToDeletePlace";
            this.buttonToDeletePlace.Size = new System.Drawing.Size(88, 23);
            this.buttonToDeletePlace.TabIndex = 36;
            this.buttonToDeletePlace.Text = "Delete place";
            this.buttonToDeletePlace.UseVisualStyleBackColor = true;
            this.buttonToDeletePlace.Click += new System.EventHandler(this.buttonToDeletePlace_Click);
            // 
            // buttonToUpdatePlace
            // 
            this.buttonToUpdatePlace.Location = new System.Drawing.Point(120, 136);
            this.buttonToUpdatePlace.Name = "buttonToUpdatePlace";
            this.buttonToUpdatePlace.Size = new System.Drawing.Size(100, 23);
            this.buttonToUpdatePlace.TabIndex = 12;
            this.buttonToUpdatePlace.Text = "Update place";
            this.buttonToUpdatePlace.UseVisualStyleBackColor = true;
            this.buttonToUpdatePlace.Click += new System.EventHandler(this.buttonToUpdatePlace_Click);
            // 
            // buttonToAddPlace
            // 
            this.buttonToAddPlace.Location = new System.Drawing.Point(120, 97);
            this.buttonToAddPlace.Name = "buttonToAddPlace";
            this.buttonToAddPlace.Size = new System.Drawing.Size(75, 23);
            this.buttonToAddPlace.TabIndex = 11;
            this.buttonToAddPlace.Text = "Add place";
            this.buttonToAddPlace.UseVisualStyleBackColor = true;
            this.buttonToAddPlace.Click += new System.EventHandler(this.buttonToAddPlace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Postal number:";
            // 
            // textBoxPlaceNum
            // 
            this.textBoxPlaceNum.Location = new System.Drawing.Point(95, 53);
            this.textBoxPlaceNum.Name = "textBoxPlaceNum";
            this.textBoxPlaceNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlaceNum.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Place name:";
            // 
            // textBoxPlaceName
            // 
            this.textBoxPlaceName.Location = new System.Drawing.Point(95, 15);
            this.textBoxPlaceName.Name = "textBoxPlaceName";
            this.textBoxPlaceName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlaceName.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(546, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 420);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonToPrintPlaces
            // 
            this.buttonToPrintPlaces.Location = new System.Drawing.Point(465, 393);
            this.buttonToPrintPlaces.Name = "buttonToPrintPlaces";
            this.buttonToPrintPlaces.Size = new System.Drawing.Size(75, 23);
            this.buttonToPrintPlaces.TabIndex = 5;
            this.buttonToPrintPlaces.Text = "Update";
            this.buttonToPrintPlaces.UseVisualStyleBackColor = true;
            this.buttonToPrintPlaces.Click += new System.EventHandler(this.buttonToPrintPlaces_Click);
            // 
            // buttonToUpdateMakeList
            // 
            this.buttonToUpdateMakeList.Location = new System.Drawing.Point(582, 160);
            this.buttonToUpdateMakeList.Name = "buttonToUpdateMakeList";
            this.buttonToUpdateMakeList.Size = new System.Drawing.Size(75, 23);
            this.buttonToUpdateMakeList.TabIndex = 10;
            this.buttonToUpdateMakeList.Text = "Update";
            this.buttonToUpdateMakeList.UseVisualStyleBackColor = true;
            this.buttonToUpdateMakeList.Click += new System.EventHandler(this.buttonToUpdateMakeList_Click);
            // 
            // buttonToUpdateModelList
            // 
            this.buttonToUpdateModelList.Location = new System.Drawing.Point(582, 390);
            this.buttonToUpdateModelList.Name = "buttonToUpdateModelList";
            this.buttonToUpdateModelList.Size = new System.Drawing.Size(75, 23);
            this.buttonToUpdateModelList.TabIndex = 11;
            this.buttonToUpdateModelList.Text = "Update";
            this.buttonToUpdateModelList.UseVisualStyleBackColor = true;
            this.buttonToUpdateModelList.Click += new System.EventHandler(this.buttonToUpdateModelList_Click);
            // 
            // buttonToDeleteModel
            // 
            this.buttonToDeleteModel.Location = new System.Drawing.Point(454, 324);
            this.buttonToDeleteModel.Name = "buttonToDeleteModel";
            this.buttonToDeleteModel.Size = new System.Drawing.Size(100, 23);
            this.buttonToDeleteModel.TabIndex = 14;
            this.buttonToDeleteModel.Text = "Delete model";
            this.buttonToDeleteModel.UseVisualStyleBackColor = true;
            this.buttonToDeleteModel.Click += new System.EventHandler(this.buttonToDeleteModel_Click);
            // 
            // buttonToUpdateModel
            // 
            this.buttonToUpdateModel.Location = new System.Drawing.Point(454, 295);
            this.buttonToUpdateModel.Name = "buttonToUpdateModel";
            this.buttonToUpdateModel.Size = new System.Drawing.Size(100, 23);
            this.buttonToUpdateModel.TabIndex = 13;
            this.buttonToUpdateModel.Text = "Update model";
            this.buttonToUpdateModel.UseVisualStyleBackColor = true;
            this.buttonToUpdateModel.Click += new System.EventHandler(this.buttonToUpdateModel_Click);
            // 
            // buttonToAddModel
            // 
            this.buttonToAddModel.Location = new System.Drawing.Point(454, 266);
            this.buttonToAddModel.Name = "buttonToAddModel";
            this.buttonToAddModel.Size = new System.Drawing.Size(100, 23);
            this.buttonToAddModel.TabIndex = 12;
            this.buttonToAddModel.Text = "Add model";
            this.buttonToAddModel.UseVisualStyleBackColor = true;
            this.buttonToAddModel.Click += new System.EventHandler(this.buttonToAddModel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearOfMake)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonToPrintPlaces;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlaceNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlaceName;
        private System.Windows.Forms.Button buttonToAddPlace;
        private System.Windows.Forms.Button buttonToAddVeichle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxForVeichles;
        private System.Windows.Forms.Button buttonToPrintVeichles;
        private System.Windows.Forms.NumericUpDown numericUpDownYearOfMake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonToUpdatePlace;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.ListBox listBoxVeichlePlaces;
        private System.Windows.Forms.TextBox textBoxVeichlePlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUpdateVeichle;
        private System.Windows.Forms.Button buttonDeleteVeichle;
        private System.Windows.Forms.Button buttonToDeletePlace;
        private System.Windows.Forms.ListBox listBoxMake;
        private System.Windows.Forms.ListBox listBoxModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonToDeleteMake;
        private System.Windows.Forms.Button buttonToUpdateMake;
        private System.Windows.Forms.Button buttonToAddMake;
        private System.Windows.Forms.Button buttonToDeleteModel;
        private System.Windows.Forms.Button buttonToUpdateModel;
        private System.Windows.Forms.Button buttonToAddModel;
        private System.Windows.Forms.Button buttonToUpdateModelList;
        private System.Windows.Forms.Button buttonToUpdateMakeList;
    }
}

