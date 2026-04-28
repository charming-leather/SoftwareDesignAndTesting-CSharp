using System;
using System.Windows.Forms;

namespace LanguageListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxEnterProgLang.PlaceholderText = "Enter programming language...";
        }
        

        // ADD LANGUAGE BUTTON
        private void addLangButton_Click(object sender, EventArgs e)
        {
            string language = textBoxEnterProgLang.Text.Trim();

            // Q. Prevent empty input from being added
            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language.");
                return;
            } 

            // Q. Prevent duplicate languages from being added
            if (lstLanguages.Items.Contains(language))
            {
                MessageBox.Show("This language already exists.");
                return;
            }

           
            lstLanguages.Items.Add(language); 

            // Q. Display  the date and time when a language is added 
            labelRemovedDateTime.Text = "Added " + language + " at " +
                DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

            textBoxEnterProgLang.Clear();
        }

        // REMOVE LANGUAGE BUTTON
        private void remveButton_Click(object sender, EventArgs e)
        {
            // If nothing is selcected displays a message
            if (lstLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove.");
                return;
            }

            string removedLanguage = lstLanguages.SelectedItem.ToString();


            lstLanguages.Items.Remove(lstLanguages.SelectedItem);

            // Display date & time when language is remoedv
            labelRemovedDateTime.Text = "Removed " + removedLanguage + " at " +
                DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
        }
    }
}