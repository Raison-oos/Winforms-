using System.Collections;

namespace Login
{
    public partial class Form1 : Form
    {
        public SortedList Credentials = new SortedList();
        public Form1()
        {
            InitializeComponent();
            Credentials.Add("admin", "admin");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DictionaryEntry element in Credentials)
            {
                if(txtLoginUsername.Text == element.Key.ToString() && txtLoginPassword.Text == element.Value.ToString())
                {
                    MessageBox.Show("Welcome " + txtLoginUsername.Text + "!", "Login Succesfully");
                    txtLoginUsername.Text = "";
                    txtLoginPassword.Text = "";
                    break;
                }
                else
                {
                    MessageBox.Show("Wrong Credentials.", "Login Failed");
                    txtLoginUsername.Text = "";
                    txtLoginPassword.Text = "";
                }
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(txtSignUpUsername.Text == "" || txtSignUpPassword.Text == "")
            {
                MessageBox.Show("Enter Credentials", "Enter Credentials");
            }
            else
            {
                foreach (DictionaryEntry element in Credentials)
                {
                    if(element.Key.ToString() != txtSignUpUsername.Text)
                    {
                        Credentials.Add(txtSignUpUsername.Text, txtSignUpPassword.Text);
                        MessageBox.Show("Sign Up Succesfully", "Sign Up Succesfully");
                        txtSignUpUsername.Text = "";
                        txtSignUpPassword.Text = "";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("This username is already taken!", "Enter Credentials");
                        txtSignUpUsername.Text = "";
                        txtSignUpPassword.Text = "";
                    }
                }
            }
        }
    }
}
