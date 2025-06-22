using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Text.Json;

namespace MealFinder
{
    public partial class MealFinderApp : Form
    {
        private string placeholder = "I feel like having...........";
        private int count1, count2, count3, count4 = 0;

        public MealFinderApp()
        {
            InitializeComponent();
            _mainForm = new Results();
        }

        private Results _mainForm;


        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userTextBox.Text))
            {
                userTextBox.Text = placeholder;
                userTextBox.ForeColor = Color.Gray;
            }
        }

        private void friendTextBox_Enter(object sender, EventArgs e)
        {
            if (friendTextBox.Text == placeholder)
            {
                friendTextBox.Text = "";
                friendTextBox.ForeColor = Color.Black;
            }
        }

        private void friendTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(friendTextBox.Text))
            {
                friendTextBox.Text = placeholder;
                friendTextBox.ForeColor = Color.Gray;
            }
        }

        private void userTextBox_Enter_1(object sender, EventArgs e)
        {
            if (userTextBox.Text == placeholder)
            {
                userTextBox.Text = "";
                userTextBox.ForeColor = Color.Black;
            }
        }

        private void MealFinderApp_Load(object sender, EventArgs e)
        {
            dollar1Sign.BackColor = Color.LightBlue;
            dollar2Sign.BackColor = Color.LightBlue;
            dollar3Sign.BackColor = Color.LightBlue;
            dollar4Sign.BackColor = Color.LightBlue;
        }


        private void dollar1Sign_Click_1(object sender, EventArgs e)
        {
            count1++;
            if (count1 % 2 != 0)
                dollar1Sign.BackColor = Color.White;
            else
                dollar1Sign.BackColor = Color.LightBlue;


        }

        private void dollar2Sign_Click(object sender, EventArgs e)
        {
            count2++;

            if (count2 % 2 != 0)
                dollar2Sign.BackColor = Color.White;
            else
                dollar2Sign.BackColor = Color.LightBlue;
        }

        private void dollar3Sign_Click(object sender, EventArgs e)
        {
            count3++;

            if (count3 % 2 != 0)
                dollar3Sign.BackColor = Color.White;
            else
                dollar3Sign.BackColor = Color.LightBlue;
        }

        private void dollar4Sign_Click(object sender, EventArgs e)
        {
            count4++;

            if (count4 % 2 != 0)
                dollar4Sign.BackColor = Color.White;
            else
                dollar4Sign.BackColor = Color.LightBlue;
        }

        private async void goButton_Click(object sender, EventArgs e)
        {
            await SendStringListConcatenatedAsync();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            
            addPerson person =  new addPerson();
            person.Show();

            person.FormClosed += (s, args) => this.Show();

            this.Hide();
                  
        }
        private static List<List<string>> parse(string input)
        {
            List<List<string>> retval = new List<List<string>>();
            string[] s = input.Split("],[");
            s[0] = s[0].Remove(0, 16);
            s[4] = s[4].Remove(s[4].Length - 3, 3);
            for (int i = 0; i < s.Length; i++)
            {
                List<string> ls = new List<string>();
                s[i] = s[i].Substring(1);
                s[i] = s[i].Remove(s[i].Length - 1, 1);
                string[] s2 = s[i].Split("\",\"");
                for (int j = 0; j < 3; j++)
                {
                    ls.Add(s2[j]);
                }
                retval.Add(ls);
            }
            for (int i = 0; i < retval.Count; i++)
            {
                for (int j = 0; j < retval[i].Count; j++)
                {
                    Console.WriteLine(retval[i][j]);
                }
            }
            return retval;
        }
        private async Task SendStringListConcatenatedAsync()
        {
            string userData = userTextBox.Text;
            string friendData = friendTextBox.Text;
            //string conclusion = textBoxConclusion.Text;

            var stringList = new List<string> { userData, friendData };

            string jsonString = "{\"userKey\":\"["+userData+","+friendData+"]\"}";

            string json = jsonString;

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try     
                {
                    string url = "http://127.0.0.1:5000/backend";
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    string result = await response.Content.ReadAsStringAsync();

                    List<List<string>> ls = parse(result);

                    _mainForm.UpdateLabelsValue(ls);

                    Results rs = _mainForm;
                   
                    rs.Show();

                    rs.FormClosed += (s, args) => this.Show();

                    this.Hide();
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
