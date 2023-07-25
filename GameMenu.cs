using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Racing
{
    public partial class GameMenu : Form
    {
        private string myDB = "datasource = localhost; user = root; database = TaxiRush";

        int RoadSpeed;
        int TrafficSpeed;
        int PlayerSpeed = 12;
        int Score;
        int CarImage;

        Random random = new Random();
        Random CarPosition = new Random();

        bool GoLeft, GoRight;

        public GameMenu()
        {
            InitializeComponent();
            GameReset();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //No Content
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //No Content
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //No Content
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //No Content
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //No Content
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = false;
            }
        }

        public void GameTimerEvent(object sender, EventArgs e)
        {
            GameScore.Text = "Score: " + Score;
            Score++;


            if (GoLeft == true && PlayerCar.Left > 25)
            {
                PlayerCar.Left -= PlayerSpeed;
            }
            if (GoRight == true && PlayerCar.Left < 415)
            {
                PlayerCar.Left += PlayerSpeed;
            }

            RoadTrack.Top += RoadSpeed;
            RoadTrackContinuation.Top += RoadSpeed;

            if (RoadTrackContinuation.Top > 549)
            {
                RoadTrackContinuation.Top = -549;
            }
            if (RoadTrack.Top > 549)
            {
                RoadTrack.Top = -549;
            }

            AI_Car1.Top += TrafficSpeed;
            AI_Car2.Top += TrafficSpeed;

            if (AI_Car1.Top > 550)
            {
                ChangeAI_Cars(AI_Car1);
            }
            if (AI_Car2.Top > 550)
            {
                ChangeAI_Cars(AI_Car2);
            }

            if (PlayerCar.Bounds.IntersectsWith(AI_Car1.Bounds) || PlayerCar.Bounds.IntersectsWith(AI_Car2.Bounds))
            {
                GameOver();
            }

            if (Score < 500)
            {
                Award.Image = Properties.Resources.bronze;
            }
            if (Score >= 500 && Score < 2000)
            {
                Award.Image = Properties.Resources.silver;
                RoadSpeed = 21;
                TrafficSpeed = 22;
            }
            if (Score >= 2000 && Score < 3000)
            {
                Award.Image = Properties.Resources.gold;
                RoadSpeed = 25;
                TrafficSpeed = 27;
            }
            if (Score >= 3000)
            {
                Award.Image = Properties.Resources.gold;
                RoadSpeed = 29;
                TrafficSpeed = 31;
            }


        }

        public void ChangeAI_Cars(PictureBox TempCar)
        {
            CarImage = random.Next(1, 22);

            switch (CarImage)
            {
                case 1:
                    TempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    TempCar.Image = Properties.Resources.bumblebee;
                    break;
                case 3:
                    TempCar.Image = Properties.Resources.black_limo;
                    break;
                case 4:
                    TempCar.Image = Properties.Resources.white_limo;
                    break;
                case 5:
                    TempCar.Image = Properties.Resources.black_car;
                    break;
                case 6:
                    TempCar.Image = Properties.Resources.blue_pickup;
                    break;
                case 7:
                    TempCar.Image = Properties.Resources.blue_sports_car;
                    break;
                case 8:
                    TempCar.Image = Properties.Resources.black_van;
                    break;
                case 9:
                    TempCar.Image = Properties.Resources.black_pickup;
                    break;
                case 10:
                    TempCar.Image = Properties.Resources.black_sports_car;
                    break;
                case 11:
                    TempCar.Image = Properties.Resources.firetruck;
                    break;
                case 12:
                    TempCar.Image = Properties.Resources.gray_pickup;
                    break;
                case 13:
                    TempCar.Image = Properties.Resources.pink_car;
                    break;
                case 14:
                    TempCar.Image = Properties.Resources.gray_van;
                    break;
                case 15:
                    TempCar.Image = Properties.Resources.orange_car;
                    break;
                case 16:
                    TempCar.Image = Properties.Resources.police_car;
                    break;
                case 17:
                    TempCar.Image = Properties.Resources.red_pickup;
                    break;
                case 18:
                    TempCar.Image = Properties.Resources.red_sports_car;
                    break;
                case 19:
                    TempCar.Image = Properties.Resources.red_van;
                    break;
                case 20:
                    TempCar.Image = Properties.Resources.white_pickup;
                    break;
                case 21:
                    TempCar.Image = Properties.Resources.white_sports_car;
                    break;
                case 22:
                    TempCar.Image = Properties.Resources.yellow_pickup;
                    break;
            }

            TempCar.Top = CarPosition.Next(100, 400) * -1;

            if ((string)TempCar.Tag == "CarLeft")
            {
                TempCar.Left = CarPosition.Next(25, 195);
            }
            if ((string)TempCar.Tag == "CarRight")
            {
                TempCar.Left = CarPosition.Next(245, 415);
            }


        }

        public void GameOver()
        {
            FinalScore.Text = "Score: " + Score;
            Score++;

            RecordPanel.Visible = true;
            RecordPanel.Enabled = true;

            PlaySound();
            GameTimer.Stop();
            Explosion.Visible = true;
            PlayerCar.Controls.Add(Explosion);
            Explosion.Location = new Point(0, 10);
            Explosion.BackColor = Color.Transparent;

            Award.Visible = true;
            Award.BringToFront();
        }

        public void GameReset()
        {
            RecordPanel.Visible = false;
            RecordPanel.Enabled = false;

            Explosion.Visible = false;
            Award.Visible = false;
            GoLeft = false;
            GoRight = false;
            Score = 0;
            Award.Image = Properties.Resources.bronze;

            RoadSpeed = 12;
            TrafficSpeed = 15;

            AI_Car1.Top = CarPosition.Next(200, 500) * -1;
            AI_Car1.Left = CarPosition.Next(25, 195);

            AI_Car2.Top = CarPosition.Next(200,500) * -1;
            AI_Car2.Left = CarPosition.Next(245, 415);

            GameTimer.Start();
        }

        public void StartGame(object sender, EventArgs e)
        {
            GameReset();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                {
                    MessageBox.Show("Please enter a valid name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO records(PlayerName, PlayerScore) VALUES(@PlayerName, @PlayerScore)";
                using (MySqlConnection mycon2 = new MySqlConnection(myDB))
                {
                    mycon2.Open();
                    using (MySqlCommand mycommand = new MySqlCommand(query, mycon2))
                    {
                        // Set parameter values
                        mycommand.Parameters.AddWithValue("@PlayerName", NameTextBox.Text);
                        mycommand.Parameters.AddWithValue("@PlayerScore", Score);

                        // Execute the query
                        mycommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Recorded.");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            NameTextBox.Clear();
        }

        public void PlaySound()
        {
            System.Media.SoundPlayer CarCrash = new System.Media.SoundPlayer(Properties.Resources._8bit_Crash);
            CarCrash.Play();
        }
    }
}
