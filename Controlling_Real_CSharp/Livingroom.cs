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
    public partial class Livingroom : Form
    {
        bool check_status_light;// biến để cập nhật ảnh bật hoặc tắt đèn phòng khách
        bool status_light;

        bool check_status_fan;// biến để cập nhật ảnh bật hoặc tắt QUẠT phòng khách
        bool status_fan;

        bool check_status_air;// biến để cập nhật ảnh bật hoặc tắt ĐIỀU HÒA phòng khách
        bool status_air;
        IFirebaseConfig config = new FirebaseConfig
        {
            // Kết nối Project của chúng ta đến Firebase
            AuthSecret = "e5r8WvATQzZ4GlCrhTKzHacPsG3Y0dTcgndNwa0I",
            BasePath = "https://smarthome-e7e9b-default-rtdb.firebaseio.com",

        };
        IFirebaseClient client;

        public Livingroom()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private  async void btn_update_Click(object sender, EventArgs e)
        {
            FirebaseResponse response1 = await client.GetAsync("Livingroom/Temperature");

            String temp = response1.ResultAs<String>();
            label_temp.Text = temp.ToString();

            FirebaseResponse response2 = await client.GetAsync("Livingroom/Humidity");

            String humid = response2.ResultAs<String>();
            label_humid.Text = humid.ToString();


            // xử lý điều khiển đèn, quạt và điều hòa

            FirebaseResponse response3 = await client.GetAsync("Livingroom/Light");

            String light = response3.ResultAs<String>().ToString();


            FirebaseResponse response4 = await client.GetAsync("Livingroom/Fan");

            String fan = response4.ResultAs<String>().ToString();

            FirebaseResponse response5 = await client.GetAsync("Livingroom/Air_conditioner");

            String air = response5.ResultAs<String>().ToString();


            //xử lý cập nhật tình trạng của đèn phòng khách cụ thể là bật hoặc tắt
            if (light == "Close")
            {
                pic_light_off.Visible = true;
                pic_light_on.Visible = false;
                btn_light.Text = "CLOSE";
                btn_light.ForeColor = Color.Blue;
                btn_light.BackColor = Color.Red;

                //check_status_light = false;
                //status_light = check_status_light;

            }

            if (light == "Open")
            {
                pic_light_on.Visible = true;
                pic_light_off.Visible = false;
                btn_light.Text = "OPEN";
                btn_light.ForeColor = Color.Red;
                btn_light.BackColor = Color.Blue;

                //check_status_light = true;
                //status_light = check_status_light;

            }


            //xử lý cập nhật tình trạng của QUẠT phòng khách cụ thể là bật hoặc tắt
            if (fan == "Close")
            {
                pic_fan_off.Visible = true;
                pic_fan_on.Visible = false;
                btn_fan.Text = "CLOSE";
                btn_fan.ForeColor = Color.Blue;
                btn_fan.BackColor = Color.Red;

                //check_status_light = false;
                //status_light = check_status_light;

            }

            if (fan == "Open")
            {
                pic_fan_on.Visible = true;
                pic_fan_off.Visible = false;
                btn_fan.Text = "OPEN";
                btn_fan.ForeColor = Color.Red;
                btn_fan.BackColor = Color.Blue;

                //check_status_light = true;
                //status_light = check_status_light;

            }

            //xử lý cập nhật tình trạng của ĐIỀU HÒA phòng khách cụ thể là bật hoặc tắt
            if (air == "Close")
            {
                pic_air_off.Visible = true;
                pic_air_on.Visible = false;
                btn_air.Text = "CLOSE";
                btn_air.ForeColor = Color.Blue;
                btn_air.BackColor = Color.Red;

                //check_status_light = false;
                //status_light = check_status_light;

            }

            if (air == "Open")
            {
                pic_air_on.Visible = true;
                pic_air_off.Visible = false;
                btn_air.Text = "OPEN";
                btn_air.ForeColor = Color.Red;
                btn_air.BackColor = Color.Blue;

                //check_status_light = true;
                //status_light = check_status_light;

            }



        }

        private async void Livingroom_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private async void btn_light_Click(object sender, EventArgs e)
        {
            if (status_light == true)
            {
                SetResponse response1 = await client.SetAsync("Livingroom/Light", "Open");
                btn_light.Text = "OPEN";
                btn_light.BackColor = Color.Blue;
                btn_light.ForeColor = Color.Red;
                status_light = false;

                pic_light_off.Visible = false;
                pic_light_on.Visible = true;


            }
            else
            {
                SetResponse response2 = await client.SetAsync("Livingroom/Light", "Close");
                btn_light.Text = "CLOSE";
                btn_light.BackColor = Color.Red;
                btn_light.ForeColor = Color.Blue;
                status_light = true;

                pic_light_off.Visible = true;
                pic_light_on.Visible = false;


            }

        }

        private async void btn_fan_Click(object sender, EventArgs e)
        {
            if (status_fan == true)
            {
                SetResponse response1 = await client.SetAsync("Livingroom/Fan", "Open");
                btn_fan.Text = "OPEN";
                btn_fan.BackColor = Color.Blue;
                btn_fan.ForeColor = Color.Red;
                status_fan = false;

                pic_fan_off.Visible = false;
                pic_fan_on.Visible = true;


            }
            else
            {
                SetResponse response2 = await client.SetAsync("Livingroom/Fan", "Close");
                btn_fan.Text = "CLOSE";
                btn_fan.BackColor = Color.Red;
                btn_fan.ForeColor = Color.Blue;
                status_fan = true;

                pic_fan_off.Visible = true;
                pic_fan_on.Visible = false;


            }
        }

        private async void btn_air_Click(object sender, EventArgs e)
        {
            if (status_air == true)
            {
                SetResponse response1 = await client.SetAsync("Livingroom/Air_conditioner", "Open");
                btn_air.Text = "OPEN";
                btn_air.BackColor = Color.Blue;
                btn_air.ForeColor = Color.Red;
                status_air = false;

                pic_air_off.Visible = false;
                pic_air_on.Visible = true;


            }
            else
            {
                SetResponse response2 = await client.SetAsync("Livingroom/Air_conditioner", "Close");
                btn_air.Text = "CLOSE";
                btn_air.BackColor = Color.Red;
                btn_air.ForeColor = Color.Blue;
                status_air = true;

                pic_air_off.Visible = true;
                pic_air_on.Visible = false;


            }

        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security security = new Security();
            security.ShowDialog();
        }

        private void bedroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bedroom bedroom = new Bedroom();
            bedroom.ShowDialog();
        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitchen kitchen = new Kitchen();
            kitchen.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void livingroomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
