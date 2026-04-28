using System;
using System.Windows.Forms;

namespace IdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load citizenship options into ComboBox
            comboBox1Citizen.Items.Add("Citizen");
            comboBox1Citizen.Items.Add("Permanent Resident");
            comboBox1Citizen.Items.Add("Visitor");

            comboBox1Citizen.SelectedIndex = 0;

            // Setup results box
            textBox1USERPROFILE.Multiline = true;
            textBox1USERPROFILE.ScrollBars = ScrollBars.Vertical;
            textBox1USERPROFILE.ReadOnly = true;
        }

        // VALIDATE BUTTON
        private void buttonValidatelD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1EnterName.Text) ||
                string.IsNullOrWhiteSpace(textBox2EnterID.Text) ||
                string.IsNullOrWhiteSpace(comboBox1Citizen.Text))
            {
                labelValidOrInvalid.Text = "Please fill in all fields.";
                labelValidOrInvalid.ForeColor = System.Drawing.Color.Red;
                return;
            }

            CitizenProfile cp = new CitizenProfile(
                textBox1EnterName.Text,
                textBox2EnterID.Text,
                comboBox1Citizen.Text
            );

            string result = cp.ValidateID();

            labelValidOrInvalid.Text = result;

            // Valid Id feeback or invalid id
            if (result.StartsWith("Valid"))
                labelValidOrInvalid.ForeColor = System.Drawing.Color.Green;
            else
                labelValidOrInvalid.ForeColor = System.Drawing.Color.Red;
        }

        // GENERATE PROFILE BUTTON
        private void buttonGenrateProf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1EnterName.Text) ||
                string.IsNullOrWhiteSpace(textBox2EnterID.Text) ||
                string.IsNullOrWhiteSpace(comboBox1Citizen.Text))
            {
                textBox1USERPROFILE.Text = "Please complete all fields before generating profile.";
                return;
            }

            CitizenProfile cp = new CitizenProfile(
                textBox1EnterName.Text,
                textBox2EnterID.Text,
                comboBox1Citizen.Text
            );

            string validation = cp.ValidateID();

            textBox1USERPROFILE.Text =
                "DIGITAL CITIZEN SUMMARY\n" +
                "\nName: " + cp.FullName + "\n" +
                "\nID Number: " + cp.IDNumber + "\n" +
                "\nAge: " + cp.Age + "\n" +
                "\nCitizenship: " + cp.CitizenshipStatus + "\n" +
                "\nValidation: " + validation + "\n" +
                "\nProcessed at: Home Affairs Digital Desk\n" +
                "\nTimestamp: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        private void label1Heading_Click(object sender, EventArgs e)
        {
        }
    }
}