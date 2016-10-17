namespace StudentskaSluzba
{
    partial class StudentForm
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
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.firstNameLabelText = new System.Windows.Forms.Label();
            this.lastNameLabelText = new System.Windows.Forms.Label();
            this.indexNumberLabelText = new System.Windows.Forms.Label();
            this.studyProgramLabelText = new System.Windows.Forms.Label();
            this.gradeLabelText = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.indexNumberLabel = new System.Windows.Forms.Label();
            this.studyProgramLabel = new System.Windows.Forms.Label();
            this.gradeAverageLabel = new System.Windows.Forms.Label();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(13, 39);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(241, 225);
            this.studentListBox.TabIndex = 0;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // firstNameLabelText
            // 
            this.firstNameLabelText.AutoSize = true;
            this.firstNameLabelText.Location = new System.Drawing.Point(275, 39);
            this.firstNameLabelText.Name = "firstNameLabelText";
            this.firstNameLabelText.Size = new System.Drawing.Size(24, 13);
            this.firstNameLabelText.TabIndex = 1;
            this.firstNameLabelText.Text = "Ime";
            // 
            // lastNameLabelText
            // 
            this.lastNameLabelText.AutoSize = true;
            this.lastNameLabelText.Location = new System.Drawing.Point(275, 63);
            this.lastNameLabelText.Name = "lastNameLabelText";
            this.lastNameLabelText.Size = new System.Drawing.Size(44, 13);
            this.lastNameLabelText.TabIndex = 2;
            this.lastNameLabelText.Text = "Prezime";
            // 
            // indexNumberLabelText
            // 
            this.indexNumberLabelText.AutoSize = true;
            this.indexNumberLabelText.Location = new System.Drawing.Point(275, 89);
            this.indexNumberLabelText.Name = "indexNumberLabelText";
            this.indexNumberLabelText.Size = new System.Drawing.Size(59, 13);
            this.indexNumberLabelText.TabIndex = 3;
            this.indexNumberLabelText.Text = "Broj indexa";
            // 
            // studyProgramLabelText
            // 
            this.studyProgramLabelText.AutoSize = true;
            this.studyProgramLabelText.Location = new System.Drawing.Point(275, 114);
            this.studyProgramLabelText.Name = "studyProgramLabelText";
            this.studyProgramLabelText.Size = new System.Drawing.Size(87, 13);
            this.studyProgramLabelText.TabIndex = 4;
            this.studyProgramLabelText.Text = "Studijski program";
            // 
            // gradeLabelText
            // 
            this.gradeLabelText.AutoSize = true;
            this.gradeLabelText.Location = new System.Drawing.Point(275, 140);
            this.gradeLabelText.Name = "gradeLabelText";
            this.gradeLabelText.Size = new System.Drawing.Size(77, 13);
            this.gradeLabelText.TabIndex = 5;
            this.gradeLabelText.Text = "Prosjek ocjena";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(462, 39);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(35, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "label1";
            this.firstNameLabel.Visible = false;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(461, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(35, 13);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "label2";
            this.lastNameLabel.Visible = false;
            // 
            // indexNumberLabel
            // 
            this.indexNumberLabel.AutoSize = true;
            this.indexNumberLabel.Location = new System.Drawing.Point(461, 89);
            this.indexNumberLabel.Name = "indexNumberLabel";
            this.indexNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.indexNumberLabel.TabIndex = 8;
            this.indexNumberLabel.Text = "label3";
            this.indexNumberLabel.Visible = false;
            // 
            // studyProgramLabel
            // 
            this.studyProgramLabel.AutoSize = true;
            this.studyProgramLabel.Location = new System.Drawing.Point(461, 114);
            this.studyProgramLabel.Name = "studyProgramLabel";
            this.studyProgramLabel.Size = new System.Drawing.Size(35, 13);
            this.studyProgramLabel.TabIndex = 9;
            this.studyProgramLabel.Text = "label4";
            this.studyProgramLabel.Visible = false;
            // 
            // gradeAverageLabel
            // 
            this.gradeAverageLabel.AutoSize = true;
            this.gradeAverageLabel.Location = new System.Drawing.Point(461, 140);
            this.gradeAverageLabel.Name = "gradeAverageLabel";
            this.gradeAverageLabel.Size = new System.Drawing.Size(35, 13);
            this.gradeAverageLabel.TabIndex = 10;
            this.gradeAverageLabel.Text = "label5";
            this.gradeAverageLabel.Visible = false;
            // 
            // addGradeButton
            // 
            this.addGradeButton.Location = new System.Drawing.Point(280, 190);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(218, 23);
            this.addGradeButton.TabIndex = 11;
            this.addGradeButton.Text = "Dodati ocjenu";
            this.addGradeButton.UseVisualStyleBackColor = true;
            this.addGradeButton.Visible = false;
            this.addGradeButton.Click += new System.EventHandler(this.addGradeButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(278, 241);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(219, 23);
            this.addStudentButton.TabIndex = 12;
            this.addStudentButton.Text = "Dodati studenta";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Podaci";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveMenuItem.Text = "Sačuvaj";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 319);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.addGradeButton);
            this.Controls.Add(this.gradeAverageLabel);
            this.Controls.Add(this.studyProgramLabel);
            this.Controls.Add(this.indexNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.gradeLabelText);
            this.Controls.Add(this.studyProgramLabelText);
            this.Controls.Add(this.indexNumberLabelText);
            this.Controls.Add(this.lastNameLabelText);
            this.Controls.Add(this.firstNameLabelText);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.Text = "Studentska služba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label firstNameLabelText;
        private System.Windows.Forms.Label lastNameLabelText;
        private System.Windows.Forms.Label indexNumberLabelText;
        private System.Windows.Forms.Label studyProgramLabelText;
        private System.Windows.Forms.Label gradeLabelText;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label indexNumberLabel;
        private System.Windows.Forms.Label studyProgramLabel;
        private System.Windows.Forms.Label gradeAverageLabel;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
    }
}

