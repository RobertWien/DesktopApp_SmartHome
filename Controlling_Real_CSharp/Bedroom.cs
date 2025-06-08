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
    public partial class Bedroom : Form
    {
        bool check_status_light;// biến để cập nhật ảnh bật hoặc tắt đèn phòng ngủ
        bool status_light;

        bool check_status_fan;// biến để cập nhật ảnh bật hoặc tắt QUẠT phòng ngủ
        bool status_fan;

        bool check_status_air;// biến để cập nhật ảnh bật hoặc tắt ĐIỀU HÒA phòng ngủ
        bool status_air;
        IFirebaseConfig config = new FirebaseConfig
        {
            // Kết nối Project của chúng ta đến Firebase
            AuthSecret = "e5r8WvATQzZ4GlCrhTKzHacPsG3Y0dTcgndNwa0I",
            BasePath = "https://smarthome-e7e9b-default-rtdb.firebaseio.com",

        };
        IFirebaseClient client;
        public Bedroom()
        {
            InitializeComponent();
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security security = new Security();
            security.ShowDialog();
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
            Livingroom livingroom = new Livingroom();
            livingroom.ShowDialog();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            FirebaseResponse response1 = await client.GetAsync("Bedroom/Temperature");

            String temp = response1.ResultAs<String>();
            label_temp.Text = temp.ToString();

            FirebaseResponse response2 = await client.GetAsync("Bedroom/Humidity");

            String humid = response2.ResultAs<String>();
            label_humid.Text = humid.ToString();

            // cập nhật tốc độ của QUẠT theo dữ liệu từ phần cứng đưa lên
            FirebaseResponse response = await client.GetAsync("Bedroom/Fan_speed");

            String fan_speed = response.ResultAs<String>();
            speed_unit.Text = fan_speed.ToString();

            // xử lý điều khiển đèn, quạt và điều hòa

            FirebaseResponse response3 = await client.GetAsync("Bedroom/Light");

            String light = response3.ResultAs<String>().ToString();


            FirebaseResponse response4 = await client.GetAsync("Bedroom/Fan");

            String fan = response4.ResultAs<String>().ToString();

            FirebaseResponse response5 = await client.GetAsync("Bedroom/Air_conditioner");

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

                combo_speed.Enabled = false;

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

                combo_speed.Enabled = true;

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

        private async void Bedroom_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

        }

        private async void btn_light_Click(object sender, EventArgs e)
        {
            if (status_light == true)
            {
                SetResponse response1 = await client.SetAsync("Bedroom/Light", "Open");
                btn_light.Text = "OPEN";
                btn_light.BackColor = Color.Blue;
                btn_light.ForeColor = Color.Red;
                status_light = false;

                pic_light_off.Visible = false;
                pic_light_on.Visible = true;


            }
            else
            {
                SetResponse response2 = await client.SetAsync("Bedroom/Light", "Close");
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
                SetResponse response1 = await client.SetAsync("Bedroom/Fan", "Open");
                btn_fan.Text = "OPEN";
                btn_fan.BackColor = Color.Blue;
                btn_fan.ForeColor = Color.Red;
                status_fan = false;

                pic_fan_off.Visible = false;
                pic_fan_on.Visible = true;
                combo_speed.Enabled = true;


            }
            else
            {
                SetResponse response2 = await client.SetAsync("Bedroom/Fan", "Close");
                btn_fan.Text = "CLOSE";
                btn_fan.BackColor = Color.Red;
                btn_fan.ForeColor = Color.Blue;
                status_fan = true;

                pic_fan_off.Visible = true;
                pic_fan_on.Visible = false;
                combo_speed.Enabled = false;


            }
        }

        private async void btn_air_Click(object sender, EventArgs e)
        {
            if (status_air == true)
            {
                SetResponse response1 = await client.SetAsync("Bedroom/Air_conditioner", "Open");
                btn_air.Text = "OPEN";
                btn_air.BackColor = Color.Blue;
                btn_air.ForeColor = Color.Red;
                status_air = false;

                pic_air_off.Visible = false;
                pic_air_on.Visible = true;


            }
            else
            {
                SetResponse response2 = await client.SetAsync("Bedroom/Air_conditioner", "Close");
                btn_air.Text = "CLOSE";
                btn_air.BackColor = Color.Red;
                btn_air.ForeColor = Color.Blue;
                status_air = true;

                pic_air_off.Visible = true;
                pic_air_on.Visible = false;


            }

        }

        private async void combo_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedIndex.ToString() == "1")
            {
                MessageBox.Show("Change Speed Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "1");
            }

            if (cb.SelectedIndex.ToString() == "2")
            {
                MessageBox.Show("Change Speed Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "2");
            }

            if (cb.SelectedIndex.ToString() == "3")
            {
                MessageBox.Show("Change Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "3");
            }

            if (cb.SelectedIndex.ToString() == "4")
            {
                MessageBox.Show("Change Speed Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "4");
            }

            if (cb.SelectedIndex.ToString() == "5")
            {
                MessageBox.Show("Change Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "5");
            }

            if (cb.SelectedIndex.ToString() == "6")
            {
                MessageBox.Show("Change Speed Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "6");
            }
            if (cb.SelectedIndex.ToString() == "7")
            {
                MessageBox.Show("Change Speed Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "7");
            }
            if (cb.SelectedIndex.ToString() == "8")
            {
                MessageBox.Show("Change Speed Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "8");
            }
            if (cb.SelectedIndex.ToString() == "9")
            {
                MessageBox.Show("Change Speed Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "9");
            }
            if (cb.SelectedIndex.ToString() == "10")
            {
                MessageBox.Show("Change Speed Unit");
                SetResponse response = await client.SetAsync("Bedroom/Fan_controll", "10");
            }
           
        }

        private void label_humid_Click(object sender, EventArgs e)
        {

        }

        private void pic_air_on_Click(object sender, EventArgs e)
        {

        }
    }
}
