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
    public partial class Door_Controll : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            // Kết nối Project của chúng ta đến Firebase
            AuthSecret = "e5r8WvATQzZ4GlCrhTKzHacPsG3Y0dTcgndNwa0I",
            BasePath = "https://smarthome-e7e9b-default-rtdb.firebaseio.com",

        };
        IFirebaseClient client;
        public Door_Controll()
        {
            InitializeComponent();
        }

        private async void btn_open_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("Security/Door_password");

            String door_password = response.ResultAs<String>().ToString();

            String doorPassword = password.Text.ToString();

            if (door_password == doorPassword)
            {
                SetResponse response3 = await client.SetAsync("Security/Door", "Normal");
                SetResponse response1 = await client.SetAsync("Security/Door_status", "Open");
                Security security = new Security();
                security.ShowDialog();
            } else
            {
                MessageBox.Show("You entered wrong door password");
                SetResponse response2 = await client.SetAsync("Security/Door", "Theft");
            }
        }

        private async void Door_Controll_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
