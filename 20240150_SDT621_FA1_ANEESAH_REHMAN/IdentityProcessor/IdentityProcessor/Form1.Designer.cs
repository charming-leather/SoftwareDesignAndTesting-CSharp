namespace IdentityProcessor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1Heading = new Label();
            label1Name = new Label();
            textBox1EnterName = new TextBox();
            label1enterID = new Label();
            textBox2EnterID = new TextBox();
            label2Citizenchoose = new Label();
            comboBox1Citizen = new ComboBox();
            buttonValidateID = new Button();
            buttonGenrateProf = new Button();
            labelValidOrInvalid = new Label();
            textBox1USERPROFILE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIP_removebg_preview;
            pictureBox1.Location = new Point(12, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 582);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1Heading
            // 
            label1Heading.AutoSize = true;
            label1Heading.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Heading.ForeColor = Color.Green;
            label1Heading.Location = new Point(479, 39);
            label1Heading.Name = "label1Heading";
            label1Heading.Size = new Size(461, 31);
            label1Heading.TabIndex = 1;
            label1Heading.Text = "Home Affairs Digital Identity Processor";
            label1Heading.Click += label1Heading_Click;
            // 
            // label1Name
            // 
            label1Name.AutoSize = true;
            label1Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Name.Location = new Point(479, 93);
            label1Name.Name = "label1Name";
            label1Name.Size = new Size(150, 23);
            label1Name.TabIndex = 2;
            label1Name.Text = "Enter your Name:";
            // 
            // textBox1EnterName
            // 
            textBox1EnterName.BackColor = Color.LightGray;
            textBox1EnterName.Location = new Point(635, 89);
            textBox1EnterName.Name = "textBox1EnterName";
            textBox1EnterName.Size = new Size(339, 27);
            textBox1EnterName.TabIndex = 3;
            // 
            // label1enterID
            // 
            label1enterID.AutoSize = true;
            label1enterID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1enterID.Location = new Point(508, 136);
            label1enterID.Name = "label1enterID";
            label1enterID.Size = new Size(121, 23);
            label1enterID.TabIndex = 4;
            label1enterID.Text = "Enter your ID:";
            // 
            // textBox2EnterID
            // 
            textBox2EnterID.BackColor = Color.LightGray;
            textBox2EnterID.Location = new Point(635, 132);
            textBox2EnterID.Name = "textBox2EnterID";
            textBox2EnterID.Size = new Size(339, 27);
            textBox2EnterID.TabIndex = 5;
            // 
            // label2Citizenchoose
            // 
            label2Citizenchoose.AutoSize = true;
            label2Citizenchoose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2Citizenchoose.Location = new Point(461, 175);
            label2Citizenchoose.Name = "label2Citizenchoose";
            label2Citizenchoose.Size = new Size(173, 23);
            label2Citizenchoose.TabIndex = 6;
            label2Citizenchoose.Text = "Choose your Citizen:";
            // 
            // comboBox1Citizen
            // 
            comboBox1Citizen.BackColor = Color.LightGray;
            comboBox1Citizen.FormattingEnabled = true;
            comboBox1Citizen.Location = new Point(635, 170);
            comboBox1Citizen.Name = "comboBox1Citizen";
            comboBox1Citizen.Size = new Size(339, 28);
            comboBox1Citizen.TabIndex = 7;
            // 
            // buttonValidateID
            // 
            buttonValidateID.BackColor = Color.Green;
            buttonValidateID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonValidateID.Location = new Point(729, 221);
            buttonValidateID.Name = "buttonValidateID";
            buttonValidateID.Size = new Size(170, 48);
            buttonValidateID.TabIndex = 8;
            buttonValidateID.Text = "Validate ID";
            buttonValidateID.UseVisualStyleBackColor = false;
            buttonValidateID.Click += buttonValidatelD_Click;
            // 
            // buttonGenrateProf
            // 
            buttonGenrateProf.BackColor = Color.Green;
            buttonGenrateProf.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenrateProf.Location = new Point(729, 620);
            buttonGenrateProf.Name = "buttonGenrateProf";
            buttonGenrateProf.Size = new Size(170, 48);
            buttonGenrateProf.TabIndex = 9;
            buttonGenrateProf.Text = "Generate Profile";
            buttonGenrateProf.UseVisualStyleBackColor = false;
            buttonGenrateProf.Click += buttonGenrateProf_Click;
            // 
            // labelValidOrInvalid
            // 
            labelValidOrInvalid.AutoSize = true;
            labelValidOrInvalid.Location = new Point(709, 287);
            labelValidOrInvalid.Name = "labelValidOrInvalid";
            labelValidOrInvalid.Size = new Size(0, 20);
            labelValidOrInvalid.TabIndex = 10;
            labelValidOrInvalid.Click += labelValidOrInvalid_Click;
            // 
            // textBox1USERPROFILE
            // 
            textBox1USERPROFILE.Location = new Point(635, 350);
            textBox1USERPROFILE.Multiline = true;
            textBox1USERPROFILE.Name = "textBox1USERPROFILE";
            textBox1USERPROFILE.ReadOnly = true;
            textBox1USERPROFILE.ScrollBars = ScrollBars.Vertical;
            textBox1USERPROFILE.Size = new Size(339, 248);
            textBox1USERPROFILE.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1006, 735);
            Controls.Add(textBox1USERPROFILE);
            Controls.Add(labelValidOrInvalid);
            Controls.Add(buttonGenrateProf);
            Controls.Add(buttonValidateID);
            Controls.Add(comboBox1Citizen);
            Controls.Add(label2Citizenchoose);
            Controls.Add(textBox2EnterID);
            Controls.Add(label1enterID);
            Controls.Add(textBox1EnterName);
            Controls.Add(label1Name);
            Controls.Add(label1Heading);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Home Affairs Digital Identity Processor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1Heading;
        private Label label1Name;
        private TextBox textBox1EnterName;
        private Label label1enterID;
        private TextBox textBox2EnterID;
        private Label label2Citizenchoose;
        private ComboBox comboBox1Citizen;
        private Button buttonValidateID;
        private Button buttonGenrateProf;
        private Label labelValidOrInvalid;
        private TextBox textBox1USERPROFILE;
    }
}
