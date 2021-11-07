using System;
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

        private void PutButton_Click(object sender, EventArgs e)
        {
            NumberOutPer = NumberOut.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            NumberIncPer = NumberInc.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            DateConnectionPer = Convert.ToString(DateConnection.Value.ToShortDateString());
            TimeConnectionPer = Convert.ToString(TimeConnection.Text);
            DurationCallPer = DurationCall.Text;

            if (NumberOutPer.Length != 12)
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Outgoing call"" ";
            }

            else if (NumberIncPer.Length != 12)
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

        }
    }
}
