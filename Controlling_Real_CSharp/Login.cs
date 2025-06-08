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
    
    public partial class Login : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            // Kết nối Project của chúng ta đến Firebase
            AuthSecret = "e5r8WvATQzZ4GlCrhTKzHacPsG3Y0dTcgndNwa0I",
            BasePath = "https://smarthome-e7e9b-default-rtdb.firebaseio.com",

        };
        IFirebaseClient client;

        public Login()
        {
            InitializeComponent();
           
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            // Tạo một nhánh dữ liệu trên Project Firebase

            client = new FireSharp.FirebaseClient(config);
        }

        private async  void btn_login_Click(object sender, EventArgs e)
        {
           FirebaseResponse response1 = await client.GetAsync("Login/User");

           String User = response1.ResultAs<String>().ToString();

           FirebaseResponse response2 = await client.GetAsync("Login/Password");

           String Password = response2.ResultAs<String>().ToString();

            Security security = new Security();

            if (User == user.Text && Password == password.Text)
            {
                security.ShowDialog();

            } else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
          
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
