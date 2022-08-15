namespace WinFormsApp1
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private string RandomLowercase()
        {
            string[] lc = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
            Random rand = new Random();
            return lc[rand.Next(lc.Length)];
        }
        private string RandomUppercase()
        {
            string[] uc = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Random rand = new Random();
            return uc[rand.Next(uc.Length)];
        }
        private string RandomNumber()
        {
            string[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
            Random rand = new Random();
            return num[rand.Next(num.Length)];
        }
        private string RandomSpecialCharacter()
        {
            string[] spec = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_","-","=","+" };
            Random rand = new Random();
            return spec[rand.Next(spec.Length)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();//show text from number box to textbox
            Random rand = new Random();
            string password = "";
            string tempValue = "";
            bool isUppercaseUsed = uppercaseLetterBox.Checked;//checks to see if the box is checked
            bool isLowercaseUsed = checkBox1.Checked;
            bool isNumbersUsed = checkBox2.Checked;
            bool isSpecialCharactersUsed = checkBox3.Checked;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                int index = rand.Next(0,4);
                tempValue = GetValueForPassword(isUppercaseUsed, isLowercaseUsed, isNumbersUsed, isSpecialCharactersUsed,index);
                password += tempValue;
            }
            textBox1.Text = password;
        }
        private string GetValueForPassword(bool uppercase, bool lowercase, bool numberUsed, bool specialcharactersUsed, int Value)
        {
            string val = "";
            if (Value == 0)
            {
                if (uppercase == true)
                {
                    val = RandomUppercase();
                }
                else if (lowercase == true)
                {
                    val = RandomLowercase();
                }
                else if (numberUsed == true)
                {
                    val = RandomNumber();
                }
                else if (specialcharactersUsed == true)
                {
                    val = RandomSpecialCharacter();
                }
                else
                {
                    val = "";
                }
            }

            if (Value == 1)
            {
                if (lowercase == true)
                {
                    val = RandomLowercase();
                }
                else if (uppercase == true)
                {
                    val = RandomUppercase();
                }
                else if (numberUsed == true)
                {
                    val = RandomNumber();
                }
                else if (specialcharactersUsed == true)
                {
                    val = RandomSpecialCharacter();
                }
                else
                {
                    val = "";
                }
            }

            if (Value == 2)
            {
                if (numberUsed == true)
                {
                    val = RandomNumber();
                }
                else if (uppercase == true)
                {
                    val = RandomUppercase();
                }
                else if (lowercase == true)
                {
                    val = RandomLowercase();
                }
                else if (specialcharactersUsed == true)
                {
                    val = RandomSpecialCharacter();
                }
                else
                {
                    val = "";
                }
            }

            if (Value == 3)
            {
                if (specialcharactersUsed == true)
                {
                    val = RandomSpecialCharacter();
                }
                else if (uppercase == true)
                {
                    val = RandomUppercase();
                }
                else if (lowercase == true)
                {
                    val = RandomLowercase();
                }
                else if (numberUsed == true)
                {
                    val = RandomNumber();
                }
                else
                {
                    val = "";
                }
            }
            return val;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox1.Text);
        }
    }
}