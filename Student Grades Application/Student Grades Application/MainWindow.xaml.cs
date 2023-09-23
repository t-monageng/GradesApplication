using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using GivLib;

namespace Student_Grades_Application
{
    public partial class MainWindow : Window
    {
        string Filename = "";
        string filePath = "";
        string folderPath = "";
        Encryption enc = new Encryption();
        ClassValidation val = new ClassValidation();   

        public MainWindow()
        {
            InitializeComponent();
            Backup();
        }

        private void CreateFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Creating a new txt file using dedicated textbox
                if (txtFileName.Text != null | txtFileName.Text != "")
                {
                    Filename = txtFileName.Text;
                    //Filename = enc.EncryptString(txtFileName.Text, "MySecretKey12345");
                    Filename = $"{Filename}.txt";

                     folderPath = @"C:\StudentGradesApp\Files"; // Replace with your desired folder path
                    Directory.CreateDirectory(folderPath);


                    filePath = Path.Combine(folderPath, Filename); // Specify the file name and extension
                    File.Create(filePath).Close();




                    //  File.Create(Filename).Close();
                    //File.Encrypt(Filename);

                    AddToCombo();
                    //Notify file created and clear
                    MessageBox.Show($"{txtFileName.Text} created successfully :)");
                    txtFileName.Text = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }


        
        private void AddToFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Add data from textboxes to grades.txt
                string studentNumber = StudentNumberTextBox.Text;
                string studentName = StudentNameTextBox.Text;
                string surname = SurnameTextBox.Text;
                string subject = SubjectTextBox.Text;
                string indivAssignGrade = IndivAssignGradeTextBox.Text;
                string groupAssignGrade = GroupAssignGradeTextBox.Text;
                string testGrade = TestGradeTextBox.Text;
                if (combFileList.SelectedIndex != 0)
                {
                    if (val.AddCheck(combFileList.SelectedItem.ToString(), subject, studentNumber, studentName,
                       surname, indivAssignGrade, groupAssignGrade, testGrade) == false)
                    {
                        //File.Decrypt(Filename);
                        string selectedFile = @"C:\StudentGradesApp\Files\" + combFileList.SelectedItem.ToString();
                        //Filename = enc.DecryptString(Filename,"MySecretKey12345");

                        

                        string dataToWrite = $"{studentNumber},{studentName},{surname},{subject},{indivAssignGrade},{groupAssignGrade},{testGrade}";
                        File.AppendAllText(folderPath + selectedFile, dataToWrite + Environment.NewLine);

                        // Clear textboxes after adding data
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show($"Error: You cant add an empty field to {combFileList.SelectedItem.ToString()}");
                    }
                }
                else 
                {
                    MessageBox.Show("Error: Please select a file to add to."); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }
        private void Display_Click(object sender, RoutedEventArgs e)
        {
            string selectedFile = combFileList.SelectedItem.ToString();
            // Read the contents of grades.txt using LINQ and display them in the DataGridView
            List<string[]> data = File.ReadAllLines(@"C:\StudentGradesApp\Files\"+ selectedFile)
                .Select(line => line.Split(','))
                .ToList();

            // Bind the data to the DataGridView
            DataGridView.ItemsSource = data;
        }
        private void ClearTextBoxes()
        {
            StudentNumberTextBox.Clear();
            StudentNameTextBox.Clear();
            SurnameTextBox.Clear();
            SubjectTextBox.Clear();
            IndivAssignGradeTextBox.Clear();
            GroupAssignGradeTextBox.Clear();
            TestGradeTextBox.Clear();
        }

        private void Backup()
        {
            string listPath = @"C:\StudentGradesApp\Backup"; // Replace with your desired folder path
            Directory.CreateDirectory(listPath);


            filePath = Path.Combine(listPath, "Filelist.txt" ); // Specify the file name and extension
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }


            AddToCombo();

        }
        private void AddToCombo()
        {
            //adding 
            string folderPath = @"C:\StudentGradesApp\Files"; 
            string outputFile = @"C:\StudentGradesApp\Backup\FileList"; 

            string[] files = Directory.GetFiles(folderPath);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (string file in files)
                {
                    writer.WriteLine(file);
                }
            }

            combFileList.Items.Clear();

            // Add each file name to the ComboBox
            foreach (string file in files)
            {
                // You can choose to display only the file name or the full path
                // by using Path.GetFileName(file) or file, respectively.
                combFileList.Items.Add(Path.GetFileName(file));
            }
        }
        private void enableTextboxes()
        {
            StudentNumberTextBox.IsEnabled = true;  
            StudentNameTextBox.IsEnabled = true;
            SurnameTextBox.IsEnabled = true;
            SubjectTextBox.IsEnabled = true;
            IndivAssignGradeTextBox.IsEnabled = true;
            GroupAssignGradeTextBox.IsEnabled = true;
            TestGradeTextBox.IsEnabled = true;
        }
        private void disableTextboxes()
        {
            StudentNumberTextBox.IsEnabled = false;
            StudentNameTextBox.IsEnabled = false;
            SurnameTextBox.IsEnabled = false;
            SubjectTextBox.IsEnabled = false;
            IndivAssignGradeTextBox.IsEnabled = false;
            GroupAssignGradeTextBox.IsEnabled = false;
            TestGradeTextBox.IsEnabled = false;
        }


    }
}

