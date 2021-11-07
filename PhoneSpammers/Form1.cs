using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace PhoneSpammers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string input;
        public string StartTime;
        public string EndTime;

        public string NumberOutPer;
        public string NumberIncPer;
        public string DateConnectionPer;
        public string TimeConnectionPer;
        public string DurationCallPer;

        private void OpenFileButton_Click(object sender, EventArgs e) // При нажатии на кнопку Open File
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    input = sr.ReadToEnd();
                    sr.Close();
                }

                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void PutButton_Click(object sender, EventArgs e) // При нажатии на кнопку Put
        {
            NumberOutPer = NumberOut.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            NumberIncPer = NumberInc.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            DateConnectionPer = Convert.ToString(DateConnection.Value.ToShortDateString());
            TimeConnectionPer = Convert.ToString(TimeConnection.Text);
            DurationCallPer = DurationCall.Text;

            if (NumberOutPer.Length != 11)
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Outgoing call"" ";
            }

            else if (NumberIncPer.Length != 11)
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Incoming call"" ";
            }

            else if (TimeConnectionPer.Length != 8)
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Time of connection start"" ";
            }

            else
            {
                int x = 1;
                try
                {
                    Convert.ToInt32(DurationCallPer);
                }

                catch
                {
                    x = 0;
                    Heading.ForeColor = Color.Red;
                    Heading.Text = @"Invalid field input format ""Connection duration"" ";
                }

                finally
                {
                    if (x == 1) // Если формат ввода верный
                    {
                        Heading.ForeColor = Color.Green;
                        Heading.Text = "Spammer Detection";

                        input += NumberOutPer + ", " + NumberIncPer + ", " + DateConnectionPer + " " + TimeConnectionPer + ", " + DurationCallPer + "\n";
                    }
                }
            }
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e) // При нажатии на кнопку Save And Close
        {
            var rs = new StreamWriter(openFileDialog1.FileName, false);
            rs.WriteLine(input);
            rs.Close();
        }

        private void SaveReportButton_Click(object sender, EventArgs e) // При нажатии на кнопку Save Report
        {
            StartTime = Convert.ToString(DateStartPeriod.Value);
            EndTime = Convert.ToString(DateEndPeriod.Value);

            var sr = new StreamReader(openFileDialog1.FileName);
            int lenfile = sr.ReadToEnd().Split('\n').Length;
            sr = new StreamReader(openFileDialog1.FileName);
            
            ArrayList ishod = new ArrayList();
            ArrayList vhod = new ArrayList();
            ArrayList time = new ArrayList();
            ArrayList len = new ArrayList();

            for (int i = 0; i < lenfile; i++)
            {
                string inputline = sr.ReadLine();
                if (inputline != "\n" && inputline != "" && inputline != null)
                { 
                    ishod.Add(inputline.Split(',')[0].Trim());
                    vhod.Add(inputline.Split(',')[1].Trim());
                    time.Add(DateTime.Parse(inputline.Split(',')[2].Trim()));
                    len.Add(Int32.Parse(inputline.Split(',')[3].Trim()));
                }
            }

            ArrayList ishodDouble = new ArrayList();
            foreach (string i in ishod)
            {
                ishodDouble.Add(i);
            }

            for (int i = 0; i < time.Count; i++) 
            {
                if (!(DateTime.Parse(StartTime.Substring(0, 10)) <= (DateTime)time[i] && DateTime.Parse(EndTime.Substring(0, 10)) >= (DateTime)time[i]))
                {
                    ishodDouble[i] = "";
                }
            }

            for (int i = 0; i < ishod.Count; i++)
            {
                ishodDouble.Remove("");
            }

            Dictionary<string, int> countOfItems = new Dictionary<string, int>();
            foreach (string eachNumber in ishodDouble)
            {
                if (countOfItems.ContainsKey(eachNumber))
                    countOfItems[eachNumber]++;
                else
                    countOfItems[eachNumber] = 1;
            }

            Dictionary<string, int> countOfItems0 = new Dictionary<string, int>();

            foreach (var i in countOfItems.OrderByDescending(u => u.Value))
            {
                countOfItems0[i.Key] = i.Value;
            }

            ArrayList filteredNumber = new ArrayList();
            foreach (var i in countOfItems0.Keys)
            {
                if (filteredNumber.Count != 10)
                {
                    filteredNumber.Add(i);
                }

                else 
                {
                    break;
                }       
            }

            string otchet = "";
            int kl = 0;
            int summ = 0;
            int h = 0;
            int m = 0;
            int s = 0;

            foreach (var i in filteredNumber)
            {

                for (int j = 0; j < ishod.Count; j++)
                {
                    if ((string)ishod[j] == (string)i)
                    {
                        kl++;
                        summ += (int)len[j];
                    }
                }

                h = summ / 3600;
                m = (summ - (h * 3600)) / 60;
                s = summ % 60;

                otchet += i + ", " + kl + ", " + h + ":" + m + ":" + s + "\n";

                kl = 0;
                summ = 0;
            }

            System.IO.File.WriteAllText("D:\\Администратор\\Documents\\Report.txt", otchet);
        }

        private void NumberOut_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
