using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private static bool upper, lower, number, special;
        private int pwlength;
        private int pwquantity;
        public Form1()
        {
            InitializeComponent();
            pwlength = 8;
            pwquantity = 1;
        }

        private void LengthBar_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Length: " + LengthBar.Value.ToString();
            pwlength = LengthBar.Value;
        }

        private void passwordQuantity_ValueChanged(object sender, EventArgs e)
        {
            pwquantity = (int)passwordQuantity.Value;
        }
        public static class PasswordGenerate
        {
            private static string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private static string Lower = "abcdefghijklmnopqrstuvwxyz";
            private static string Numbers = "0123456789";
            private static string Special = "!@#$%^&*()?";
            public static List<string> GeneratePassword(
                bool useUpper,
                bool useLower,
                bool useNumbers,
                bool useSpecial,
                int PasswordLength,
                int PasswordQuantity)
            {
                Random rando = new Random();
                string charSet = string.Empty;
                char[] password = new char[PasswordLength];
                List<string> passwords = new List<string>();

                if (useUpper) charSet += Upper;
                if (useLower) charSet += Lower;
                if (useNumbers) charSet += Numbers;
                if (useSpecial) charSet += Special;

                for (int j = 0; j < PasswordQuantity; j++)
                {
                    for (int i = 0; i < PasswordLength; i++)
                    {
                        password[i] = charSet[rando.Next(charSet.Length - 1)];;
                    }
                    passwords.Add(string.Join(null, password));
                }
                return passwords;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            if (pwquantity >= 4)
            {
                textBoxGenerated.ScrollBars = ScrollBars.Vertical;
            }

            if (checkBoxUpper.Checked)
            {
                upper = true;
                lower = true;
            }
            else
            {
                upper = false;
                lower = true;
            }


            if (checkBoxNumerals.Checked)
            {
                number = true;
                lower = true;
            }
            else
            {
                number = false;
                lower = true;
            }

            if (checkBoxSpecial.Checked)
            {
                special = true;
                lower = true;
            }
            else
            {
                special = false;
                lower = true;
            }

            List<string> passwords = PasswordGenerate.GeneratePassword(lower, upper, number, special, pwlength, pwquantity);
            string formatedPasswords = string.Join(Environment.NewLine, passwords);
            textBoxGenerated.Text = formatedPasswords;
            UseWaitCursor = false;

        }

        private async void buttonSimple_Click(object sender, EventArgs e)
        {
            textBoxGenerated.Clear();
            if (pwquantity >= 4)
            {
                textBoxGenerated.ScrollBars = ScrollBars.Vertical;
            }
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    UseWaitCursor = true;
                    string simplepass = "https://www.dinopass.com/password/simple";
                    int pwquantity = (int)passwordQuantity.Value;

                    for (int j = 0; j < pwquantity; j++)
                    {
                        var response = await httpClient.GetAsync(simplepass);

                        if (response.IsSuccessStatusCode)
                        {

                            string passwordresults = await response.Content.ReadAsStringAsync();
                            textBoxGenerated.AppendText(passwordresults + Environment.NewLine);
                        }
                        else
                        {
                            MessageBox.Show($"We tried to request a simple password but failed with status code: {response.StatusCode}");
                        }

                    }

                    UseWaitCursor = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private async void buttonStrong_Click(object sender, EventArgs e)
        {
            textBoxGenerated.Clear();
            if (pwquantity >= 4)
            {
                textBoxGenerated.ScrollBars = ScrollBars.Vertical;
            }
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    UseWaitCursor = true;
                    string strongpass = "https://www.dinopass.com/password/strong";

                    for (int j = 0; j < pwquantity; j++)
                    {
                        var response = await httpClient.GetAsync(strongpass);

                        if (response.IsSuccessStatusCode)
                        {
                            string passwordresults = await response.Content.ReadAsStringAsync();
                            textBoxGenerated.AppendText(passwordresults + Environment.NewLine);
                        }
                        else
                        {
                            MessageBox.Show($"We tried to request a strong password but failed with status code: {response.StatusCode}");
                        }
                    }
                    UseWaitCursor = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


    }
}