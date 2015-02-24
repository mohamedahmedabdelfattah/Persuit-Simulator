using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PersuitSimulation
{
    public partial class MainWindow : Form
    {
        //Global Variables
        int vf = 0;
        int Time = 0;
        double Distance = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        void EscapeAnimation()
        {
            CheckForIllegalCrossThreadCalls = false;

            txtoutput.ForeColor = Color.Yellow;
            txtoutput.Text = "\r\nUnidentified Aircraft Detected\r\nFighter In Persuit";

            Bomber.Image = PersuitSimulator.Properties.Resources.Bomber;
            Fighter.Image = PersuitSimulator.Properties.Resources.AirplaneLate;

            Bomber.Visible = true;
            Fighter.Visible = true;

            for (int n = 0; n < 500; n++)
            {
                for (int n2 = 0; n2 < 500000; n2++)
                {
                }
                Fighter.Location = new Point(n - 250, n - 390);
                Bomber.Location = new Point(n - 100, 100);
                Bomber.Refresh();
                Fighter.Refresh();
            }
            Bomber.Visible = false;
            Fighter.Visible = false;
            txtoutput.ForeColor = System.Drawing.Color.Red;
            txtoutput.Text = "\r\nThe Target Has Escaped";
        }

        void DestroyAnimation()
        {
            CheckForIllegalCrossThreadCalls = false;

            txtoutput.ForeColor = Color.Yellow;
            txtoutput.Text = "\r\nUnidentified Aircraft Detected\r\nFighter In Persuit";

            int[] xb = { 80, 90, 99, 108, 116, 125, 133, 141, 151, 160, 169, 179, 180 };
            int[] yb = { 0, -2, -5, -9, -15, -18, -23, -29, -28, -25, -21, -20, -17 };

            double cosx, sinx;

            double[] dist = new double[13];

            double[] xf = new double[13];
            double[] yf = new double[13];

            xf[0] = 0.0;
            yf[0] = 50.0;

            dist[0] = Math.Sqrt((xf[0] - xb[0]) * (xf[0] - xb[0]) + (yf[0] - yb[0]) * (yf[0] - yb[0]));

            for (int t = 0; t <= 11; t++)
            {
                cosx = (xb[t] - xf[t]) / dist[t];
                sinx = (yb[t] - yf[t]) / dist[t];
                xf[t + 1] = xf[t] + vf * cosx;
                yf[t + 1] = yf[t] + vf * sinx;
                dist[t + 1] = Math.Sqrt((xf[t + 1] - xb[t + 1]) * (xf[t + 1] - xb[t + 1]) + (yf[t + 1] - yb[t + 1]) * (yf[t + 1] - yb[t + 1]));

                if (dist[t + 1] <= 10)
                {
                    Time = t + 1;
                    Distance = (double)dist[t + 1];

                    //Battle Animation
                    Bomber.Image = PersuitSimulator.Properties.Resources.Bomber;
                    Fighter.Image = PersuitSimulator.Properties.Resources.Fighter;

                    for (int i = 0; i < 13; i++)
                    {
                        int x = (int)xf[i];
                        int y = (int)yf[i];

                        if (x != 0 && y != 0)
                        {
                            Fighter.Location = new Point(x + 40, y + 100);
                            Fighter.Visible = true;
                            Fighter.Refresh();
                        }
                        for (int j = 0; j < 10000000; j++)
                        {
                        }

                        Bomber.Location = new Point(xb[i] + 130, yb[i] + 100);
                        Bomber.Visible = true;
                        Bomber.Refresh();

                        if (i == 12)
                        {
                            //Rocket Animation
                            int rocketinitx = Fighter.Location.X + 60;
                            int rocketinity = Fighter.Location.Y + 20;
                            int space = Bomber.Location.X - rocketinitx - 33;

                            Rocket.Visible = true;

                            for (int move = 0; move <= space; move++)
                            {
                                for (int n2 = 0; n2 < 5000000; n2++)
                                {
                                }
                                Rocket.Location = new Point(rocketinitx+move, rocketinity);
                                Rocket.Refresh();
                            }
                            
                            Rocket.Visible = false;


                            Bomber.Image = PersuitSimulator.Properties.Resources.AirplaneEscaped;

                            for (int n5 = 0; n5 < 80; n5++)
                            {
                                //Bomber Falling
                                int x2 = Bomber.Location.X;
                                int y2 = Bomber.Location.Y;
                                for (int n2 = 0; n2 < 5000000; n2++)
                                {
                                }

                                int y3 = y2 + n5;
                                if (y3 <= 160)
                                {
                                    Bomber.Location = new Point(x2, y3);
                                    Bomber.Refresh();
                                }
                                else
                                    Bomber.Visible = false;

                                txtoutput.ForeColor = System.Drawing.Color.Lime;
                                txtoutput.Text = "\r\nThe Target Has Been Destroyed .\r\nTime = " + Time + " min, Distance = " + Distance + " km .";


                                //Fighter Continue With Bomber Falling
                                int x1 = Fighter.Location.X;
                                int y1 = Fighter.Location.Y;
                                for (int j = 0; j < 5000000; j++)
                                {
                                }
                                Fighter.Location = new Point(x1 + 3, y1);
                                Fighter.Refresh();
                            }
                        }
                    }
                    Fighter.Visible = false;
                    Bomber.Visible = false;
                    
                    //To Stop checking if (dist[t + 1] <= 10) at first occurance
                    break;
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            bg.WorkerSupportsCancellation = true;
            Rocket.Visible = false;
            Bomber.Visible = false;
            Fighter.Visible = false;
            btndestroy.Checked = false;
            btnescape.Checked = false;
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            About.AboutForm about = new About.AboutForm();
            about.ShowDialog();
        }

        private void QuitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DetailsMenu_Click(object sender, EventArgs e)
        {
            PersuitSimulator.DetailsWindow details = new PersuitSimulator.DetailsWindow();
            details.ShowDialog();
        }

        private void ResetSimulatorMenu_Click(object sender, EventArgs e)
        {
            btndestroy.Checked = false;
            btnescape.Checked = false;
            txtoutput.Clear();
        }

        private void btnStopSim_Click(object sender, EventArgs e)
        {
            if(bg.IsBusy == true)
                bg.CancelAsync();
        }

        private void SimulationOutput_CheckedChanged(object sender, EventArgs e)
        {
            txtoutput.Text = "";
        }

        private void btnStartSim_Click(object sender, EventArgs e)
        {
            //Clear the display for new a simulation
            if (txtoutput.Text != "" || Bomber.Visible == true || Fighter.Visible == true || Rocket.Visible == true)
            {
                Bomber.Visible = false;
                Fighter.Visible = false;
                Rocket.Visible = false;
                txtoutput.Clear();
            }

            //Check for requested Simulation Output
            if (btndestroy.Checked == false && btnescape.Checked == false)
            {
                MessageBox.Show("\nPlease specify a Simulation Output first.", "Persuit Simulator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnstartsim.Enabled = true;
                ResetSimulatorMenu.Enabled = true;
                StartSimMenu.Enabled = true;
            }
            else
            {
                //Set Fighter Velocity to Control the Simulation Output
                // if vf<15 with same bomber givens above the bomber will always escape

                if (btndestroy.Checked == true)
                {
                    vf = 20;
                    bg.RunWorkerAsync();
                }
                else
                {
                    vf = 10;
                    bg.RunWorkerAsync();
                }
                btnstartsim.Enabled = false;
                ResetSimulatorMenu.Enabled = false;
                StartSimMenu.Enabled = false;
            }
        }

        private void TargetDestroyedMenu_Click(object sender, EventArgs e)
        {
            btndestroy.Checked = true;
            btnstartsim.PerformClick();
        }

        private void TargetEscapedMenu_Click(object sender, EventArgs e)
        {
            btnescape.Checked = true;
            btnstartsim.PerformClick();
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bg = sender as BackgroundWorker;

            if (bg.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                if (btndestroy.Checked == true)
                    DestroyAnimation();
                else
                    EscapeAnimation();
            }
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
                if (e.Cancelled)
                {
                    txtoutput.ForeColor = Color.White;
                    txtoutput.Text = "\r\nOperation Cancelled";
                }
                else
                {
                }
            btnstartsim.Enabled = true;
            ResetSimulatorMenu.Enabled = true;
            StartSimMenu.Enabled = true;
        }
    }
}