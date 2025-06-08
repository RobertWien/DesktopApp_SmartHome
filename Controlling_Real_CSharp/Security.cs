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
    public partial class Security : Form
    {
        bool check_status;// biến để cập nhật ảnh mở cửa đóng cửa
        bool status;

        IFirebaseConfig config = new FirebaseConfig
        {
            // Kết nối Project của chúng ta đến Firebase
            AuthSecret = "e5r8WvATQzZ4GlCrhTKzHacPsG3Y0dTcgndNwa0I",
            BasePath = "https://smarthome-e7e9b-default-rtdb.firebaseio.com",

        };
        IFirebaseClient client;
        public Security()
        {
            InitializeComponent();
        }

        private async void Security_Load(object sender, EventArgs e)
        {
            // Tạo một nhánh dữ liệu trên Project Firebase

            client = new FireSharp.FirebaseClient(config);

            btn_enter_old.Visible = false;
            btn_enter_new.Visible = false;
            old_password.Visible = false;
            new_password.Visible = false;
            confirm_password.Visible = false;

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            btn_door.Visible = true;
            label_door_controll.Visible = true;

            btn_ok.Visible = false;
            btn_got.Visible = false;
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            FirebaseResponse response1 = await client.GetAsync("Security/Warning");

            String warning = response1.ResultAs<String>().ToString();


            FirebaseResponse response2 = await client.GetAsync("Security/Door");

            String door = response2.ResultAs<String>().ToString();

            FirebaseResponse response3 = await client.GetAsync("Security/Door_status");

            String door_status = response3.ResultAs<String>().ToString();


            warning_1.ForeColor = Color.Red;
            warning_door.ForeColor = Color.Red;

            // Xử lý an ninh các hệ thống khác không tính cửa ra vào
            if (warning == "Normal")
            {
                warning_1.Text = "    NORMAL";
                pic_normal.Visible = true;
                pic_fire.Visible = false;
                pic_gas.Visible = false;
                pic_temp.Visible = false;
                pic_rain.Visible = false;
                pic_sus.Visible = false;
                warning_1.ForeColor = Color.Blue;
            }


            if (warning == "There is fire")
            {
                warning_1.Text = "THERE IS FIRE";
                pic_normal.Visible = false;
                pic_fire.Visible = true;
                pic_gas.Visible = false;
                pic_temp.Visible = false;
                pic_rain.Visible = false;
                pic_sus.Visible = false;
            }

            if (warning == "Gas leakage")
            {
                warning_1.Text = "GAS LEAKAGE";
                pic_normal.Visible = false;
                pic_fire.Visible = false;
                pic_gas.Visible = true;
                pic_temp.Visible = false;
                pic_rain.Visible = false;
                pic_sus.Visible = false;
            }

            if (warning == "High temperature")
            {
                warning_1.Text = "HIGH TEMPERATURE";
                pic_normal.Visible = false;
                pic_fire.Visible = false;
                pic_gas.Visible = false;
                pic_temp.Visible = true;
                pic_rain.Visible = false;
                pic_sus.Visible = false;
            }

            if (warning == "Suspicious object")
            {
                warning_1.Text = "SUSPICIOUS OBJECT";
                pic_normal.Visible = false;
                pic_fire.Visible = false;
                pic_gas.Visible = false;
                pic_temp.Visible = false;
                pic_rain.Visible = false;
                pic_sus.Visible = true;
            }

            if (warning == "Rain")
            {
                warning_1.Text = "IT'S RAINING";
                pic_normal.Visible = false;
                pic_fire.Visible = false;
                pic_gas.Visible = false;
                pic_temp.Visible = false;
                pic_rain.Visible = true;
                pic_sus.Visible = false;
            }

            // xử lý an ninh cửa ra vào

            if (door == "Normal")
            {
                warning_door.Text = "    NORMAL";
                pic_normal_door.Visible = true;
                pic_guest.Visible = false;
                pic_theft.Visible = false;

                warning_door.ForeColor = Color.Blue;

            }

            if (door == "Theft")
            {
                warning_door.Text = "THERE'S THEFT";
                pic_normal_door.Visible = false;
                pic_guest.Visible = false;
                pic_theft.Visible = true;
                SetResponse response_theft = await client.SetAsync("Security/Door_solve", "Abnormal");

            }

            if (door == "Guest")
            {
                warning_door.Text = "THERE'S GUEST";
                pic_normal_door.Visible = false;
                pic_guest.Visible = true;
                pic_theft.Visible = false;
                SetResponse response_guest = await client.SetAsync("Security/Door_solve", "Abnormal");

            }

            // xử lý nút OK để tắt cảnh báo cho cửa ra vào nếu có khách hoặc có trộm
            if (door == "Guest" || door == "Theft")
            {
                btn_ok.Visible = true;
            }

            // xử lý nút GOT IT để tắt cảnh báo cho các tình trạng có lửa, rò khí gas....
            if (warning == "There is fire" || warning == "Gas leakage" || warning == "Rain"||
                warning == "Suspicious object" || warning == "High Temperature")
            {
                btn_got.Visible = true;
            }


            //xử lý cập nhật tình trạng của cửa cụ thể là Close hoặc Open
            if (door_status == "Close")
                {
                    pic_close_door.Visible = true;
                    pic_open_door.Visible = false;
                    btn_door.Text = "CLOSE";
                    btn_door.ForeColor = Color.Blue;
                    btn_door.BackColor = Color.Red;

                    check_status = false;
                    status = check_status;

                }

                if (door_status == "Open")
                {
                    pic_open_door.Visible = true;
                    pic_close_door.Visible = false;
                    btn_door.Text = "OPEN";
                    btn_door.ForeColor = Color.Red;
                    btn_door.BackColor = Color.Blue;

                    check_status = true;
                    status = check_status;

            }
                // xử lý không cho hiện thị hình ảnh của của ra vào khi nhấn nút UPDATE
                if (change_password.Checked == true)
                {
                    pic_close_door.Visible = false;
                    pic_open_door.Visible = false;
                }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_password_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void change_password_CheckedChanged(object sender, EventArgs e)
        {
            if (change_password.Checked == true)
            {
                btn_enter_old.Visible = true;
                old_password.Visible = true;
                label6.Visible = true;

                btn_door.Visible = false;
                label_door_controll.Visible = false;

                pic_open_door.Visible = false;
                pic_close_door.Visible = false;

                btn_enter_new.Visible = false;
            }
            else
            {
                btn_enter_old.Visible = false;
                old_password.Visible = false;
                label6.Visible = false;

                new_password.Visible = false;
                label4.Visible = false;

                confirm_password.Visible = false;
                label5.Visible = false;

                btn_door.Visible = true;
                label_door_controll.Visible = true;

                if (check_status == true)
                {
                    pic_open_door.Visible = true;
                }
                else
                {
                    pic_close_door.Visible = true;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            FirebaseResponse response3 = await client.GetAsync("Security/Door_password");

            String old_door_pass = response3.ResultAs<String>().ToString();

            String old_pass = old_password.Text.ToString();
            if (old_pass == old_door_pass)
            {
                new_password.Visible = true;
                confirm_password.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                btn_enter_new.Visible = true;
                
                label6.Visible = false;
                old_password.Visible = false;
                btn_enter_old.Visible = false;



            }
            else
            {
                new_password.Visible = false;
                confirm_password.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                MessageBox.Show("You typed wrong your old password");
            }
        }

        private async void btn_enter_new_Click(object sender, EventArgs e)
        {
            String new_pass = new_password.Text.ToString();
            String con_pass = confirm_password.Text.ToString();
            if (new_pass == con_pass && new_pass != "" && con_pass != "")
            {
                SetResponse response = await client.SetAsync("Security/Door_password", con_pass);
                MessageBox.Show("You changed your open door password successfully");
            }
            else
            {
                MessageBox.Show("Your new password isn't similar to your confirm password or you left blank fields");
            }

        }

        private async void btn_ok_Click(object sender, EventArgs e)
        {
            SetResponse response1 = await client.SetAsync("Security/Door_solve", "Normal");
            SetResponse response2 = await client.SetAsync("Security/Door", "Normal");

            pic_normal_door.Visible = true;
            pic_guest.Visible = false;
            pic_theft.Visible = false;
            btn_ok.Visible = false;

            warning_door.Text = "    NORMAL";
            warning_door.ForeColor = Color.Blue;
        }

        private async void btn_door_Click(object sender, EventArgs e)
        {
            FirebaseResponse response1 = await client.GetAsync("Security/Door_status");

            String door_status_1 = response1.ResultAs<String>().ToString();

            if (door_status_1 == "Close")
            {
                Door_Controll doorControll = new Door_Controll();
                doorControll.ShowDialog();
            }

            if (door_status_1 == "Open")
            {
                status = false;
            } else
            {
                status = true;
            }

            if (status == true)
            {
                btn_door.Text = "OPEN";
                btn_door.BackColor = Color.Blue;
                btn_door.ForeColor = Color.Red;
                status = false;

                pic_close_door.Visible = false;
                pic_open_door.Visible = true;
            }
            else
            {
                SetResponse response2 = await client.SetAsync("Security/Door_status", "Close");
                btn_door.Text = "CLOSE";
                btn_door.BackColor = Color.Red;
                btn_door.ForeColor = Color.Blue;
                status = true;

                pic_close_door.Visible = true;
                pic_open_door.Visible = false;


            }
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

        private void forgotDoorPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset_Door_Password reset_Door_Password = new Reset_Door_Password();
            reset_Door_Password.ShowDialog();

        }

        private void warning_1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_got_Click(object sender, EventArgs e)
        {
            SetResponse response10 = await client.SetAsync("Security/Warning", "Normal");

            pic_normal.Visible = true;
            pic_rain.Visible = false;
            pic_sus.Visible = false;
            pic_fire.Visible = false;
            pic_gas.Visible = false;
            pic_temp.Visible = false;
            btn_got.Visible = false;

            warning_1.Text = "    NORMAL";
            warning_1.ForeColor = Color.Blue;
        }
    }
}
