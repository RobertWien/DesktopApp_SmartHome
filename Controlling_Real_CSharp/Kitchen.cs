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
    public partial class Kitchen : Form
    {
        bool check_status_light;// biến để cập nhật ảnh bật hoặc tắt đèn phòng khách
        bool status_light;

        bool check_status_fan;// biến để cập nhật ảnh bật hoặc tắt QUẠT phòng khách
        bool status_fan;

        bool check_status_line;// biến để cập nhật ảnh bật hoặc tắt ĐIỀU HÒA phòng khách
        bool status_line;

        IFirebaseConfig config = new FirebaseConfig
        {
            // Kết nối Project của chúng ta đến Firebase
            AuthSecret = "e5r8WvATQzZ4GlCrhTKzHacPsG3Y0dTcgndNwa0I",
            BasePath = "https://smarthome-e7e9b-default-rtdb.firebaseio.com",

        };
        IFirebaseClient client;
        public Kitchen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pic_air_on_Click(object sender, EventArgs e)
        {

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            // xử lý điều khiển đèn, quạt và dây phơi quần áo

            FirebaseResponse response1 = await client.GetAsync("Kitchen/Light");

            String light = response1.ResultAs<String>().ToString();


            FirebaseResponse response2 = await client.GetAsync("Kitchen/Alarm");

            String alarm = response2.ResultAs<String>().ToString();

            FirebaseResponse response3 = await client.GetAsync("Kitchen/Clothes_line");

            String line = response3.ResultAs<String>().ToString();

            // Kiểm tra tình trạng warning để đưa ra quyết định điều khiển dây phơi quần áo

            FirebaseResponse response4 = await client.GetAsync("Security/Warning");

            String check_warning = response4.ResultAs<String>().ToString();


            //xử lý cập nhật tình trạng của đèn nhà bếp cụ thể là bật hoặc tắt
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


            //xử lý cập nhật tình trạng của QUẠT  nhà bếp cụ thể là bật hoặc tắt
            if (alarm == "Close")
            {
                pic_fan_off.Visible = true;
                pic_fan_on.Visible = false;
                btn_fan.Text = "CLOSE";
                btn_fan.ForeColor = Color.Blue;
                btn_fan.BackColor = Color.Red;

                //check_status_light = false;
                //status_light = check_status_light;

            }

            if (alarm == "Open")
            {
                pic_fan_on.Visible = true;
                pic_fan_off.Visible = false;
                btn_fan.Text = "OPEN";
                btn_fan.ForeColor = Color.Red;
                btn_fan.BackColor = Color.Blue;

                //check_status_light = true;
                //status_light = check_status_light;

            }

            //xử lý cập nhật tình trạng của  cụ thể của dây phơi quần áo 
            if (line == "In" )
            {
                pic_line_in.Visible = true;
                pic_line_out.Visible = false;
                pic_rain_in.Visible = false;
                btn_line.Text = "IN";
                btn_line.ForeColor = Color.Blue;
                btn_line.BackColor = Color.Red;

                //check_status_light = false;
                //status_light = check_status_light;

            }

            if (line == "Rain_In")
            {
                pic_line_in.Visible = false;
                pic_line_out.Visible = false;
                pic_rain_in.Visible = true;
                btn_line.Text = "IN";
                btn_line.ForeColor = Color.Blue;
                btn_line.BackColor = Color.Red;
            }

            if (line == "Out" && check_warning != "Rain")
            {
                pic_line_out.Visible = true;
                pic_line_in.Visible = false;
                pic_rain_in.Visible = false;
                btn_line.Text = "OUT";
                btn_line.ForeColor = Color.Red;
                btn_line.BackColor = Color.Blue;

                //check_status_light = true;
                //status_light = check_status_light;

            } else
            {
               // SetResponse response_set = await client.SetAsync("Kitchen/Clothes_line", "In");
                if (check_warning == "Rain")
                {
                    MessageBox.Show("CLOTHES LINE IS PULLED IN BECAUSE OF THE SUDDEN RAIN!!!");
                }
            }
        }

        private async void Kitchen_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private async void btn_light_Click(object sender, EventArgs e)
        {
            if (status_light == true)
            {
                SetResponse response1 = await client.SetAsync("Kitchen/Light", "Open");
                btn_light.Text = "OPEN";
                btn_light.BackColor = Color.Blue;
                btn_light.ForeColor = Color.Red;
                status_light = false;

                pic_light_off.Visible = false;
                pic_light_on.Visible = true;


            }
            else
            {
                SetResponse response2 = await client.SetAsync("Kitchen/Light", "Close");
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
                SetResponse response1 = await client.SetAsync("Kitchen/Alarm", "Open");
                btn_fan.Text = "OPEN";
                btn_fan.BackColor = Color.Blue;
                btn_fan.ForeColor = Color.Red;
                status_fan = false;

                pic_fan_off.Visible = false;
                pic_fan_on.Visible = true;


            }
            else
            {
                SetResponse response2 = await client.SetAsync("Kitchen/Alarm", "Close");
                btn_fan.Text = "CLOSE";
                btn_fan.BackColor = Color.Red;
                btn_fan.ForeColor = Color.Blue;
                status_fan = true;

                pic_fan_off.Visible = true;
                pic_fan_on.Visible = false;


            }
        }

        private async void btn_line_Click(object sender, EventArgs e)
        {
            // cập nhật xem từ cảnh báo có mưa hay không
            FirebaseResponse response = await client.GetAsync("Security/Warning");
            String check_weather = response.ResultAs<String>().ToString();

            if (status_line == true)
            {
                if (check_weather != "Rain")
                {
                    SetResponse response1 = await client.SetAsync("Kitchen/Clothes_line", "Out");
                    btn_line.Text = "OUT";
                    btn_line.BackColor = Color.Blue;
                    btn_line.ForeColor = Color.Red;
                    status_line = false;

                    pic_line_in.Visible = false;
                    pic_line_out.Visible = true;
                    pic_rain_in.Visible = false;
                }
                else
                {
                    MessageBox.Show("IT'S RAINING NOW, PLEASE DON'T PULL OUT YOUR CLOTHES LINE !!!");
                }
            } else {
                FirebaseResponse response5 = await client.GetAsync("Kitchen/Clothes_line");
                String line_1 = response5.ResultAs<String>().ToString();

                if (line_1 != "Rain_In")
                {
                    SetResponse response2 = await client.SetAsync("Kitchen/Clothes_line", "In");
                    pic_line_in.Visible = true;
                    pic_line_out.Visible = false;
                    pic_rain_in.Visible = false;
                }

                btn_line.Text = "IN";
                btn_line.BackColor = Color.Red;
                btn_line.ForeColor = Color.Blue;
                status_line = true;
            }
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security security = new Security();
            security.ShowDialog();
        }

        private void livingroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Livingroom livingroom = new Livingroom();
            livingroom.ShowDialog();
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
    }
}
