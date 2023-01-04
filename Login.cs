using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KeyAuth
{
    public partial class Login : Form
    {

    public static api KeyAuthApp = new api(
            name: "",
            ownerid: "",
            secret: "",
            version: "1.1"
    );

        public Login()
        {
            InitializeComponent();

        }


        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private static bool succes()
        {
            string invite = "";
            MessageBox.Show("Succesfully Logged in!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(invite);
            return false;

        }

        private static bool test()
        {
            string invite = "";
            MessageBox.Show("Succesfully Logged in!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(invite);
            return false;
            return false;
        }
        private void Login_Load(object sender, EventArgs e)
        {

            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Environment.Exit(0);
            }

            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            if (KeyAuthApp.checkblack())
            {
                MessageBox.Show("USER IS BLACKLISTED!");
                Environment.Exit(0);
            }
            else
            {
                //MessageBox.Show("Not Blacklisted!", "Information");
            }
            KeyAuthApp.check();

        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

        private void UpgradeBtn_Click(object sender, EventArgs e)
        {
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }

        }

        private void RgstrBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(username.Text, password.Text, Key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void LicBtn_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private static bool check()
        {
            KeyAuthApp.checkblack();
            KeyAuthApp.check();
            return false;
        }
        private void username_TextChanged(object sender, EventArgs e)
        {
        }
        private static bool invaild()
        {
            MessageBox.Show("Invaild Username/Password", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private static bool close()
        {
            Application.Exit();
            return false;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private static bool invite()
        {
            System.Diagnostics.Process.Start("");
            return false;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {

                button1.Enabled = false;
                button1.Text = "Logging in...";

                check();
                System.Threading.Thread.Sleep(6000);
                button1.Text = "Succesfully Logged in!";
                System.Threading.Thread.Sleep(1500);
                succes();
                System.Threading.Thread.Sleep(500);
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                string user = "";
                string psw = "";
                username.Text = user;
                password.Text = psw;
                invaild();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
            invite();
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
            invite();
        }

        private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
            invite();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            KeyAuthApp.register(username.Text, password.Text, Key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }


        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(Key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        
        }

        private void key_TextChanged_TextChanged(object sender, EventArgs e)
        {

        }

        private void Key_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


