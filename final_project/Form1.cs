using System;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace final_project
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<MoodData> moodDataList = new List<MoodData>();

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

        private void ReadCsvData()
        {
            moodDataList.Clear();

            string csvFilePath = "C:\\Users\\ustinova\\Documents\\your_mood_data.csv";

            if (File.Exists(csvFilePath))
            {
                using (var reader = new StreamReader(csvFilePath))
                using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    moodDataList = csv.GetRecords<MoodData>().ToList();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedMood = GetSelectedMood();
            DateTime selectedDate = dateTimePicker1.Value;
            string moodData = $"{selectedDate.ToShortDateString()},{selectedMood}";

            string csvFilePath = "C:\\Users\\ustinova\\Documents\\your_mood_data.csv";

            if (!File.Exists(csvFilePath))
            {
                CreateCsvFileWithHeaders(csvFilePath);
            }

            using (StreamWriter sw = new StreamWriter(csvFilePath, true))
            {
                sw.WriteLine(moodData);
                sw.Close();
            }

            MessageBox.Show("Mood data added to the database.", "Success");
        }

        private void CreateCsvFileWithHeaders(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Date,Mood");
                sw.Close();
            }
        }

        private void PlotMoodData()
        {
            chartMoods.Series.Clear();

            var uniqueMoods = moodDataList.Select(m => m.Mood).Distinct().ToList();

            foreach (var mood in uniqueMoods)
            {
                var moodDataForMood = moodDataList.Where(m => m.Mood == mood).ToList();
                Series series = new Series(mood)
                {
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.Date
                };

                foreach (var data in moodDataForMood)
                {
                    series.Points.AddXY(data.Date, 1);
                }

                chartMoods.Series.Add(series);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadCsvData();
            PlotMoodData();
        }
    }
    public class MoodData
    {
        public string Date { get; set; }
        public string Mood { get; set; }
    }
}
