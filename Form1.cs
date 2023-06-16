using Microsoft.VisualBasic.ApplicationServices;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private static bool upper, lower, number, special;
        private static int pwlength;
        public Form1()
        {
            InitializeComponent();
            pwlength = 8;

        }

        private void LengthBar_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Length: " + LengthBar.Value.ToString();
            pwlength = LengthBar.Value;
        }

        public static class PasswordGenerate
        {
            private static string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private static string Lower = "abcdefghijklmnopqrstuvwxyz";
            private static string Numbers = "0123456789";
            private static string Special = "!@#$%^&*()?";
            public static string GeneratePassword(
                bool useUpper,
                bool useLower,
                bool useNumbers,
                bool useSpecial,
                int PasswordLength)
            {
                Random rando = new Random();
                string charSet = string.Empty;
                char[] password = new char[PasswordLength];

                if (useUpper) charSet += Upper;
                if (useLower) charSet += Lower;
                if (useNumbers) charSet += Numbers;
                if (useSpecial) charSet += Special;

                for (int i = 0; i < PasswordLength; i++)
                {
                    password[i] = charSet[rando.Next(charSet.Length - 1)];
                }

                return string.Join(null, password);
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {

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

            textBoxGenerated.Text = PasswordGenerate.GeneratePassword(lower, upper, number, special, pwlength);
        }
    }
}