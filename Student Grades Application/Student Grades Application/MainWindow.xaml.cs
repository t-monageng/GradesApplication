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
        Encryption enc = new Encryption();

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
                    Encryption enc = new Encryption();
                    //Filename = enc.EncryptString(txtFileName.Text, "MySecretKey12345");
                    Filename = $"{Filename}.txt";

                    string folderPath = @"C:\StudentGradesApp\Files"; // Replace with your desired folder path
                    Directory.CreateDirectory(folderPath);


                    filePath = Path.Combine(folderPath, Filename); // Specify the file name and extension
                    File.Create(filePath).Close();




                    //  File.Create(Filename).Close();
                    //File.Encrypt(Filename);

                    //Notify file created and clear
                    AddToCombo();
                    MessageBox.Show($"{txtFileName.Text} created successfully :)");
                    txtFileName.Text = "";
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error: " + exc.Message);
            }
        }


        private void Display_Click(object sender, RoutedEventArgs e)
        {
            // Read the contents of grades.txt using LINQ and display them in the DataGridView
            List<string[]> data = File.ReadAllLines(filePath)
                .Select(line => line.Split(','))
                .ToList();

            // Bind the data to the DataGridView
            DataGridView.ItemsSource = data;
        }
        private void AddToFile_Click(object sender, RoutedEventArgs e)
        {
            Encryption enc = new Encryption();
            File.Decrypt(Filename);


            //Filename = enc.DecryptString(Filename,"MySecretKey12345");

            // Add data from textboxes to grades.txt
            string studentNumber = StudentNumberTextBox.Text;
            string studentName = StudentNameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string subject = SubjectTextBox.Text;
            string indivAssignGrade = IndivAssignGradeTextBox.Text;
            string groupAssignGrade = GroupAssignGradeTextBox.Text;
            string testGrade = TestGradeTextBox.Text;

            string dataToWrite = $"{studentNumber},{studentName},{surname},{subject},{indivAssignGrade},{groupAssignGrade},{testGrade}";

            File.AppendAllText(Filename, dataToWrite + Environment.NewLine);

            // Clear textboxes after adding data
            ClearTextBoxes();
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


            filePath = Path.Combine(listPath, "File list.txt" ); // Specify the file name and extension
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }


            AddToCombo();

        }
        private void AddToCombo()
        {
            //adding 
            string folderPath = @"C:\StudentGradesApp\Files"; // Replace with your folder path
            string outputFile = @"C:\StudentGradesApp\Backup\FileList"; // Replace with your output file path

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
    }
}

