using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int room1Seconds = 0;
        private int room2Seconds = 0;
        private int room3Seconds = 0;
        private int room4Seconds = 0;

        private Color room1OldColor;
        private Color room2OldColor;
        private Color room3OldColor;
        private Color room4OldColor;

        private Color room1OldTextColor;
        private Color room2OldTextColor;
        private Color room3OldTextColor;
        private Color room4OldTextColor;

        public Form1()
        {
            InitializeComponent();

            // İlkin rəngləri yadda saxla
            room1OldColor = roomButton1.BackColor;
            room2OldColor = roomButton2.BackColor;
            room3OldColor = roomButton3.BackColor;
            room4OldColor = roomButton4.BackColor;

            room1OldTextColor = roomButton1.ForeColor;
            room2OldTextColor = roomButton2.ForeColor;
            room3OldTextColor = roomButton3.ForeColor;
            room4OldTextColor = roomButton4.ForeColor;

            // TIMER EVENT-LƏRİ
            roomTimer1.Tick += RoomTimer1_Tick;
            roomTimer2.Tick += RoomTimer2_Tick;
            roomTimer3.Tick += RoomTimer3_Tick;
            roomTimer4.Tick += RoomTimer4_Tick;

            // BUTTON EVENT-LƏRİ
            roomButton1.Click += RoomButton1_Click;
            roomButton2.Click += RoomButton2_Click;
            roomButton3.Click += RoomButton3_Click;
            roomButton4.Click += RoomButton4_Click;

            resetButton.Click += ResetButton_Click;

            // Timer yazıları
            timerLabel1.Text = "0";
            timerLabel2.Text = "0";
            timerLabel3.Text = "0";
            timerLabel4.Text = "0";

            timerLabel1.Font = new Font(
                timerLabel1.Font,
                FontStyle.Bold);

            timerLabel2.Font = new Font(
                timerLabel2.Font,
                FontStyle.Bold);

            timerLabel3.Font = new Font(
                timerLabel3.Font,
                FontStyle.Bold);

            timerLabel4.Font = new Font(
                timerLabel4.Font,
                FontStyle.Bold);
        }

      
        private int GetDurationSeconds()
        {
            string text = new string(
                durationMaskedTextBox.Text
                    .Where(char.IsDigit)
                    .ToArray());

            if (!int.TryParse(text, out int seconds))
            {
                MessageBox.Show(
                    "Müddəti daxil edin.",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return 0;
            }

            if (seconds <= 0)
            {
                MessageBox.Show(
                    "Müddət 0-dan böyük olmalıdır.",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return 0;
            }

           
            return seconds;
        }


        private string GetGuestName()
        {
            string name = nameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                return "Müştəri";
            }

            return name;
        }

        

        private void RoomButton1_Click(object sender, EventArgs e)
        {
            int seconds = GetDurationSeconds();

            if (seconds <= 0)
                return;

            string guestName = GetGuestName();

            roomTimer1.Stop();

            room1Seconds = seconds;

            roomButton1.BackColor = Color.Red;
            roomButton1.ForeColor = Color.White;

            
            roomButton1.Text =
                guestName + Environment.NewLine +
                room1Seconds + " san";

            timerLabel1.Text = room1Seconds.ToString();

            roomTimer1.Start();
        }

        private void RoomTimer1_Tick(object sender, EventArgs e)
        {
            room1Seconds--;

            if (room1Seconds < 0)
                room1Seconds = 0;

            roomButton1.Text =
                GetGuestName() + Environment.NewLine +
                room1Seconds + " san";

            timerLabel1.Text = room1Seconds.ToString();

            if (room1Seconds <= 0)
            {
                roomTimer1.Stop();

                roomButton1.Text = "Otaq 1";

                roomButton1.BackColor = room1OldColor;
                roomButton1.ForeColor = room1OldTextColor;

                timerLabel1.Text = "0";
            }
        }

        private void RoomButton2_Click(object sender, EventArgs e)
        {
            int seconds = GetDurationSeconds();

            if (seconds <= 0)
                return;

            string guestName = GetGuestName();

            roomTimer2.Stop();

            room2Seconds = seconds;

            roomButton2.BackColor = Color.Red;
            roomButton2.ForeColor = Color.White;

            roomButton2.Text =
                guestName + Environment.NewLine +
                room2Seconds + " san";

            timerLabel2.Text = room2Seconds.ToString();

            roomTimer2.Start();
        }

        private void RoomTimer2_Tick(object sender, EventArgs e)
        {
            room2Seconds--;

            if (room2Seconds < 0)
                room2Seconds = 0;

            roomButton2.Text =
                GetGuestName() + Environment.NewLine +
                room2Seconds + " san";

            timerLabel2.Text = room2Seconds.ToString();

            if (room2Seconds <= 0)
            {
                roomTimer2.Stop();

                roomButton2.Text = "Otaq 2";

                roomButton2.BackColor = room2OldColor;
                roomButton2.ForeColor = room2OldTextColor;

                timerLabel2.Text = "0";
            }
        }


        private void RoomButton3_Click(object sender, EventArgs e)
        {
            int seconds = GetDurationSeconds();

            if (seconds <= 0)
                return;

            string guestName = GetGuestName();

            roomTimer3.Stop();

            room3Seconds = seconds;

            roomButton3.BackColor = Color.Red;
            roomButton3.ForeColor = Color.White;

            roomButton3.Text =
                guestName + Environment.NewLine +
                room3Seconds + " san";

            timerLabel3.Text = room3Seconds.ToString();

            roomTimer3.Start();
        }

        private void RoomTimer3_Tick(object sender, EventArgs e)
        {
            room3Seconds--;

            if (room3Seconds < 0)
                room3Seconds = 0;

            roomButton3.Text =
                GetGuestName() + Environment.NewLine +
                room3Seconds + " san";

            timerLabel3.Text = room3Seconds.ToString();

            if (room3Seconds <= 0)
            {
                roomTimer3.Stop();

                roomButton3.Text = "Otaq 3";

                roomButton3.BackColor = room3OldColor;
                roomButton3.ForeColor = room3OldTextColor;

                timerLabel3.Text = "0";
            }
        }

     
        private void RoomButton4_Click(object sender, EventArgs e)
        {
            int seconds = GetDurationSeconds();

            if (seconds <= 0)
                return;

            string guestName = GetGuestName();

            roomTimer4.Stop();

            room4Seconds = seconds;

            roomButton4.BackColor = Color.Red;
            roomButton4.ForeColor = Color.White;

            roomButton4.Text =
                guestName + Environment.NewLine +
                room4Seconds + " san";

            timerLabel4.Text = room4Seconds.ToString();

            roomTimer4.Start();
        }

        private void RoomTimer4_Tick(object sender, EventArgs e)
        {
            room4Seconds--;

            if (room4Seconds < 0)
                room4Seconds = 0;

            roomButton4.Text =
                GetGuestName() + Environment.NewLine +
                room4Seconds + " san";

            timerLabel4.Text = room4Seconds.ToString();

            if (room4Seconds <= 0)
            {
                roomTimer4.Stop();

                roomButton4.Text = "Otaq 4";

                roomButton4.BackColor = room4OldColor;
                roomButton4.ForeColor = room4OldTextColor;

                timerLabel4.Text = "0";
            }
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            roomTimer1.Stop();
            roomTimer2.Stop();
            roomTimer3.Stop();
            roomTimer4.Stop();

            room1Seconds = 0;
            room2Seconds = 0;
            room3Seconds = 0;
            room4Seconds = 0;

            timerLabel1.Text = "0";
            timerLabel2.Text = "0";
            timerLabel3.Text = "0";
            timerLabel4.Text = "0";

            roomButton1.Text = "Otaq 1";
            roomButton2.Text = "Otaq 2";
            roomButton3.Text = "Otaq 3";
            roomButton4.Text = "Otaq 4";

            roomButton1.BackColor = room1OldColor;
            roomButton2.BackColor = room2OldColor;
            roomButton3.BackColor = room3OldColor;
            roomButton4.BackColor = room4OldColor;

            roomButton1.ForeColor = room1OldTextColor;
            roomButton2.ForeColor = room2OldTextColor;
            roomButton3.ForeColor = room3OldTextColor;
            roomButton4.ForeColor = room4OldTextColor;
        }

    
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            roomTimer1.Stop();
            roomTimer2.Stop();
            roomTimer3.Stop();
            roomTimer4.Stop();

            roomTimer1.Dispose();
            roomTimer2.Dispose();
            roomTimer3.Dispose();
            roomTimer4.Dispose();

            base.OnFormClosing(e);
        }
    }
}
