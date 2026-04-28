namespace LanguageListManager
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
            groupBox1 = new GroupBox();
            textBoxEnterProgLang = new TextBox();
            labelRemovedDateTime = new Label();
            remveButton = new Button();
            addLangButton = new Button();
            labelEnterProgLang = new Label();
            lstLanguages = new ListBox();
            labelTitle = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(textBoxEnterProgLang);
            groupBox1.Controls.Add(labelRemovedDateTime);
            groupBox1.Controls.Add(remveButton);
            groupBox1.Controls.Add(addLangButton);
            groupBox1.Controls.Add(labelEnterProgLang);
            groupBox1.Controls.Add(lstLanguages);
            groupBox1.Controls.Add(labelTitle);
            groupBox1.Location = new Point(47, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 427);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBoxEnterProgLang
            // 
            textBoxEnterProgLang.ForeColor = SystemColors.WindowFrame;
            textBoxEnterProgLang.Location = new Point(41, 290);
            textBoxEnterProgLang.Name = "textBoxEnterProgLang";
            textBoxEnterProgLang.PlaceholderText = "Enter programming language:";
            textBoxEnterProgLang.Size = new Size(710, 27);
            textBoxEnterProgLang.TabIndex = 6;
            textBoxEnterProgLang.Text = "\r\n\r\n";
            // 
            // labelRemovedDateTime
            // 
            labelRemovedDateTime.AutoSize = true;
            labelRemovedDateTime.BackColor = SystemColors.Window;
            labelRemovedDateTime.FlatStyle = FlatStyle.Flat;
            labelRemovedDateTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRemovedDateTime.ForeColor = SystemColors.ControlDarkDark;
            labelRemovedDateTime.Location = new Point(41, 383);
            labelRemovedDateTime.Name = "labelRemovedDateTime";
            labelRemovedDateTime.Size = new Size(81, 23);
            labelRemovedDateTime.TabIndex = 5;
            labelRemovedDateTime.Text = "Removed";
            // 
            // remveButton
            // 
            remveButton.BackColor = Color.Red;
            remveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remveButton.ForeColor = SystemColors.ButtonHighlight;
            remveButton.Location = new Point(185, 324);
            remveButton.Name = "remveButton";
            remveButton.Size = new Size(125, 41);
            remveButton.TabIndex = 4;
            remveButton.Text = "Remove";
            remveButton.UseVisualStyleBackColor = false;
            remveButton.Click += remveButton_Click;
            // 
            // addLangButton
            // 
            addLangButton.BackColor = Color.Blue;
            addLangButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addLangButton.ForeColor = SystemColors.ButtonHighlight;
            addLangButton.Location = new Point(41, 324);
            addLangButton.Name = "addLangButton";
            addLangButton.Size = new Size(125, 41);
            addLangButton.TabIndex = 3;
            addLangButton.Text = "Add Language";
            addLangButton.UseVisualStyleBackColor = false;
            addLangButton.Click += addLangButton_Click;
            // 
            // labelEnterProgLang
            // 
            labelEnterProgLang.AutoSize = true;
            labelEnterProgLang.BackColor = SystemColors.Window;
            labelEnterProgLang.FlatStyle = FlatStyle.Flat;
            labelEnterProgLang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEnterProgLang.ForeColor = SystemColors.ControlDarkDark;
            labelEnterProgLang.Location = new Point(41, 287);
            labelEnterProgLang.Name = "labelEnterProgLang";
            labelEnterProgLang.Size = new Size(0, 23);
            labelEnterProgLang.TabIndex = 2;
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(41, 87);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(710, 184);
            lstLanguages.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(136, 33);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(527, 38);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "My Favourite Programming Languages";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(911, 508);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Favorite Programming Language";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstLanguages;
        private Label labelTitle;
        private Label labelEnterProgLang;
        private Button remveButton;
        private Button addLangButton;
        private Label labelRemovedDateTime;
        private TextBox textBoxEnterProgLang;
    }
}
