using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetSelectedMood()
        {
            if (rbAmazing.Checked) return "Amazing";
            if (rbGood.Checked) return "Good";
            if (rbNormal.Checked) return "Normal";
            if (rbBad.Checked) return "Bad";
            if (rbTerrible.Checked) return "Terrible";
            return "Unknown";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedMood = GetSelectedMood();
            DateTime selectedDate = dateTimePicker1.Value;
            string moodData = $"{selectedDate.ToShortDateString()}, {selectedMood}";

            string csvFilePath = "C:\\Users\\ustinova\\Documents\\your_mood_data.csv";

            if (!File.Exists(csvFilePath))
            {
                CreateCsvFileWithHeaders(csvFilePath);
            }

            using (StreamWriter sw = new StreamWriter(csvFilePath, true))
            {
                sw.WriteLine(moodData);
            }

            MessageBox.Show("Mood data added to the database.", "Success");
        }

        private void CreateCsvFileWithHeaders(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Date, Mood");
            }
        }
    }
}
