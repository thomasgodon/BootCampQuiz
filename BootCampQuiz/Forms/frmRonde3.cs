using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svt.Caspar;
using BootCampQuiz.Quiz;
using Videohouse.Timing;

namespace BootCampQuiz.Forms
{
    public partial class frmRonde3 : Form, IQuizForm
    {
        // fields
        private QuizControl _control;
        private CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
        private string[] _genres; // lijst met genres
        private int _genre = 0;

        // _________________________________ CLASS PROPERTIES _________________________________

        /// <summary>
        /// Referentie van quiz control object dat geinitialiseerd werd in frmBootCamp
        /// </summary>
        public QuizControl Control
        {
            get
            {
                return _control;
            }
            set
            {
                _control = value;
                _control.TeamPushed += new EventHandler(Control_TeamPushed);
            }
        }

        /// <summary>
        /// Referentoe van caspar device object
        /// </summary>
        public CasparDevice Caspar { get; set; }

        // _________________________________ CLASS METHODS _________________________________

        public frmRonde3()
        {
            this.InitializeComponent();
        }

        private void SetGUI()
        {
            // checken of er gedrukt is of gereset
            if (this.Control.Afgedrukt)
            {
                switch (this.Control.AfgedruktTeam.Id)
                {
                    case 1:
                        this.lblTeamA.ForeColor = Color.Red;
                        break;

                    case 2:
                        this.lblTeamB.ForeColor = Color.Red;
                        break;

                    case 3:
                        this.lblTeamC.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                // reset kleuren
                this.lblTeamA.ForeColor = SystemColors.ControlText;
                this.lblTeamB.ForeColor = SystemColors.ControlText;
                this.lblTeamC.ForeColor = SystemColors.ControlText;
            }
        }

        private void SetReferenceClocks()
        {
            if (!rcTeamA.IsRunning) this.rcTeamA.Sync(TimeSpan.FromSeconds(this.Control.TeamA.Punten));
            if (!rcTeamB.IsRunning) this.rcTeamB.Sync(TimeSpan.FromSeconds(this.Control.TeamB.Punten));
            if (!rcTeamC.IsRunning) this.rcTeamC.Sync(TimeSpan.FromSeconds(this.Control.TeamC.Punten));
        }

        private void LoadScores()
        {
            _dataCollection.SetData("score1", this.Control.TeamA.Punten.ToString());
            _dataCollection.SetData("score2", this.Control.TeamB.Punten.ToString());
            _dataCollection.SetData("score3", this.Control.TeamC.Punten.ToString());

            this.Caspar.Channels[(int)Consumer.A].CG.Add(11, "score", _dataCollection);
            this.Caspar.Channels[(int)Consumer.A].CG.Play(11);

            this.Caspar.Channels[(int)Consumer.B].CG.Add(11, "score_afkijk", _dataCollection);
            this.Caspar.Channels[(int)Consumer.B].CG.Play(11);
        }

        private void LoadGenres()
        {
            _dataCollection.Clear();

            _dataCollection.SetData("genre1", btnGenre1.Text);
            _dataCollection.SetData("genre2", btnGenre2.Text);
            _dataCollection.SetData("genre3", btnGenre3.Text);
            _dataCollection.SetData("gekozen1", Convert.ToInt32(!btnGenre1.Checked).ToString());
            _dataCollection.SetData("gekozen2", Convert.ToInt32(!btnGenre2.Checked).ToString());
            _dataCollection.SetData("gekozen3", Convert.ToInt32(!btnGenre3.Checked).ToString());

            this.Caspar.Channels[(int)Consumer.B].CG.Add(12, "R3", _dataCollection);
            this.Caspar.Channels[(int)Consumer.B].CG.Play(12);
        }

        // _________________________________ EVENT HANDLERS _________________________________

        private void Control_TeamPushed(object sender, EventArgs e)
        {
            this.SetGUI();

            if (this.Control.Afgedrukt)
            {
                switch (this.Control.AfgedruktTeam.Id)
                {
                    case 1:
                        rcTeamA.Stop();
                        break;

                    case 2:
                        rcTeamB.Stop();
                        break;

                    case 3:
                        rcTeamC.Stop();
                        break;
                }
            }
        }

        private void frmRonde3_Load(object sender, EventArgs e)
        {
            // team namen invoegen
            this.lblTeamA.Text = this.Control.TeamA.Naam;
            this.lblTeamB.Text = this.Control.TeamB.Naam;
            this.lblTeamC.Text = this.Control.TeamC.Naam;

            // toevoegen databindings
            this.nudTeamA.DataBindings.Add("Text", this.Control.TeamA, "Punten");
            this.nudTeamB.DataBindings.Add("Text", this.Control.TeamB, "Punten");
            this.nudTeamC.DataBindings.Add("Text", this.Control.TeamC, "Punten");

            // geef punten als seconden door aan reference timing object
            this.SetReferenceClocks();

            // laadt scores naar caspar
            this.LoadScores();

            // laadt genres naar caspar
            this.LoadGenres();

            // laadt antwoorden uit file
            _genres = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\\resources\\genres.txt");

            // push genres naar buttons
            if (_genres.Count() > 0) btnGenre1.Text = _genres[0];
            if (_genres.Count() > 1) btnGenre2.Text = _genres[1];
            if (_genres.Count() > 2) btnGenre3.Text = _genres[2];

            // selecteer eerste liedjes
            cmbMusicA.SelectedIndex = 0;
            cmbMusicB.SelectedIndex = 0;
            cmbMusicC.SelectedIndex = 0;

            // clear layer 10 (lampen)
            this.Caspar.Channels[(int)Consumer.A].Clear(10);

        }

        private void btnGenre_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadGenres();

            // cast sender
            CheckBox button = sender as CheckBox;

            if (button.Checked) _genre = Convert.ToInt32(button.Tag);
        }

        private void rcTeamA_Elapsed(object sender, elapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Control.TeamA.Punten = (int)e.time.TotalSeconds;
            });
        }

        private void rcTeamB_Elapsed(object sender, elapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Control.TeamB.Punten = (int)e.time.TotalSeconds;
            });
        }

        private void rcTeamC_Elapsed(object sender, elapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Control.TeamC.Punten = (int)e.time.TotalSeconds;
            });
        }

        private void btnTeamAStart_Click(object sender, EventArgs e)
        {
            if (!rcTeamA.IsRunning)
            {
                rcTeamA.Start();
                this.Control.Reset();
            }
            else
            {
                rcTeamA.Stop();
            }
        }

        private void btnTeamAHalf_Click(object sender, EventArgs e)
        {
            // return wanneer klok loopt
            if (rcTeamA.IsRunning) return;

            this.Control.Reset();
            this.Control.TeamA.Punten += 15;
        }

        private void btnTeamABeide_Click(object sender, EventArgs e)
        {
            // return wanneer klok loopt
            if (rcTeamA.IsRunning) return;

            this.Control.Reset();
            this.Control.TeamA.Punten += 30;
        }

        private void btnTeamBStart_Click(object sender, EventArgs e)
        {
            if (!rcTeamB.IsRunning)
            {
                rcTeamB.Start();
                this.Control.Reset();
            }
            else
            {
                rcTeamB.Stop();
            }
        }

        private void btnTeamBHalf_Click(object sender, EventArgs e)
        {
            // return wanneer klok loopt
            if (rcTeamB.IsRunning) return;

            this.Control.Reset();
            this.Control.TeamB.Punten += 15;
        }

        private void btnTeamBBeide_Click(object sender, EventArgs e)
        {
            // return wanneer klok loopt
            if (rcTeamB.IsRunning) return;

            this.Control.Reset();
            this.Control.TeamB.Punten += 30;
        }

        private void btnTeamCStart_Click(object sender, EventArgs e)
        {
            if (!rcTeamC.IsRunning)
            {
                rcTeamC.Start();
                this.Control.Reset();
            }
            else
            {
                rcTeamC.Stop();
            }
        }

        private void btnTeamCHalf_Click(object sender, EventArgs e)
        {
            // return wanneer klok loopt
            if (rcTeamC.IsRunning) return;

            this.Control.Reset();
            this.Control.TeamC.Punten += 15;
        }

        private void btnTeamCBeide_Click(object sender, EventArgs e)
        {
            // return wanneer klok loopt
            if (rcTeamC.IsRunning) return;

            this.Control.Reset();
            this.Control.TeamB.Punten += 30;
        }

        private void nudTeam_ValueChanged(object sender, EventArgs e)
        {
            this.SetReferenceClocks();
        }

        private void frmRonde3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stop klokken
            rcTeamA.Stop();
            rcTeamB.Stop();
            rcTeamC.Stop();

            // remove genres
            this.Caspar.Channels[(int)Consumer.B].Clear();
        }

        private void rcTeamA_StartedStopped(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (rcTeamA.IsRunning)
                {
                    btnTeamAStart.Text = "Stop";

                    // speel muziek
                    this.Caspar.Channels[(int)Consumer.A].LoadBG(12, $"R3/Ronde3_Thema{_genre.ToString()}_Lied{(cmbMusicA.SelectedIndex + 1).ToString()}", false);
                    System.Threading.Thread.Sleep(100);
                    this.Caspar.Channels[(int)Consumer.A].Play(12);
                }
                else
                {
                    btnTeamAStart.Text = "Start";

                    // stop muziek
                    this.Caspar.Channels[(int)Consumer.A].Stop(12);
                }
            });            
        }

        private void rcTeamB_StartedStopped(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (rcTeamB.IsRunning)
                {
                    btnTeamBStart.Text = "Stop";

                    // speel muziek
                    this.Caspar.Channels[(int)Consumer.A].LoadBG(12, $"R3/Ronde3_Thema{_genre.ToString()}_Lied{(cmbMusicB.SelectedIndex + 1).ToString()}", false);
                    System.Threading.Thread.Sleep(100);
                    this.Caspar.Channels[(int)Consumer.A].Play(12);
                }
                else
                {
                    btnTeamBStart.Text = "Start";

                    // stop muziek
                    this.Caspar.Channels[(int)Consumer.A].Stop(12);
                }
            });
        }

        private void rcTeamC_StartedStopped(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (rcTeamC.IsRunning)
                {
                    btnTeamCStart.Text = "Stop";

                    // speel muziek
                    this.Caspar.Channels[(int)Consumer.A].LoadBG(12, $"R3/Ronde3_Thema{_genre.ToString()}_Lied{(cmbMusicC.SelectedIndex + 1).ToString()}", false);
                    System.Threading.Thread.Sleep(100);
                    this.Caspar.Channels[(int)Consumer.A].Play(12);
                }
                else
                {
                    btnTeamCStart.Text = "Start";

                    // stop muziek
                    this.Caspar.Channels[(int)Consumer.A].Stop(12);
                }
            });
        }
    }
}
