using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlling_Real_CSharp
{
    public partial class Reset_Door_Password : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            // Kết nối Project của chúng ta đến Firebase
            AuthSecret = "e5r8WvATQzZ4GlCrhTKzHacPsG3Y0dTcgndNwa0I",
            BasePath = "https://smarthome-e7e9b-default-rtdb.firebaseio.com",

        };
        IFirebaseClient client;
        public Reset_Door_Password()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            FirebaseResponse response1 = await client.GetAsync("Login/User");

            String User = response1.ResultAs<String>().ToString();

            FirebaseResponse response2 = await client.GetAsync("Login/Password");

            String Password = response2.ResultAs<String>().ToString();

            if (User == user.Text && Password == password.Text)
            {
                label1.Visible = false;
                label12.Visible = false;
                label4.Visible = false;
                user.Visible = false;
                password.Visible = false;
                btn_login.Visible = false;

                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                new_password.Visible = true;
                con_password.Visible = true;
                btn_reset.Visible = true;

            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
        }

        private async void Reset_Door_Password_Load(object sender, EventArgs e)
        {

            // Tạo một nhánh dữ liệu trên Project Firebase

            client = new FireSharp.FirebaseClient(config);

        }

        private async void btn_reset_Click(object sender, EventArgs e)
        {
            String new_pass = new_password.Text.ToString();
            String con_pass = con_password.Text.ToString();
            if (new_pass == con_pass && new_pass != "" && con_pass != "")
            {
                SetResponse response = await client.SetAsync("Security/Door_password", con_pass);
                MessageBox.Show("You changed your open door password successfully");
            }
            else
            {
                MessageBox.Show("Your new password isn't similar to your confirm password or you left blank fields");
            }

            Security security = new Security();
            security.ShowDialog();
        }
    }
}
