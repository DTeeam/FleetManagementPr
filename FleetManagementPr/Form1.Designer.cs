
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDownYearOfMake = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonToAddVeichle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxForVeichles = new System.Windows.Forms.ListBox();
            this.buttonToPrintVeichles = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonToUpdatePlace = new System.Windows.Forms.Button();
            this.buttonToAddPlace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlaceNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonToPrintPlaces = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make and model";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxMake);
            this.tabPage2.Controls.Add(this.comboBoxModel);
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
            this.buttonToAddVeichle.Location = new System.Drawing.Point(118, 178);
            this.buttonToAddVeichle.Name = "buttonToAddVeichle";
            this.buttonToAddVeichle.Size = new System.Drawing.Size(75, 23);
            this.buttonToAddVeichle.TabIndex = 18;
            this.buttonToAddVeichle.Text = "Add veichle";
            this.buttonToAddVeichle.UseVisualStyleBackColor = true;
            this.buttonToAddVeichle.Click += new System.EventHandler(this.buttonToAddVeichle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Veichle model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
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
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(93, 134);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 28;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(93, 18);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxModel.TabIndex = 29;
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Location = new System.Drawing.Point(93, 60);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMake.TabIndex = 30;
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
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.ComboBox comboBoxModel;
    }
}

