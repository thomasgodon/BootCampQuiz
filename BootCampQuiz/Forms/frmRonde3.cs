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
        // _________________________________ CLASS PROPERTIES _________________________________

        /// <summary>
        /// Referentie van quiz control object dat geinitialiseerd werd in frmBootCamp
        /// </summary>
        public QuizControl Control { get; set; }

        /// <summary>
        /// Referentoe van caspar device object
        /// </summary>
        public CasparDevice Caspar { get; set; }

        // _________________________________ CLASS METHODS _________________________________

        public frmRonde3()
        {
            this.InitializeComponent();
        }

        private void SetGUITimerTeamA()
        {
            if (this.TimerTeamA.IsRunning)
            {
                btnStartTimerTeamA.Text = "STOP";
            }
            else
            {
                btnStartTimerTeamA.Text = "START";
            }
        }

        private void SetGUITimerTeamB()
        {
            if (this.TimerTeamB.IsRunning)
            {
                btnStartTimerTeamB.Text = "STOP";
            }
            else
            {
                btnStartTimerTeamB.Text = "START";
            }
        }

        private void SetGUITimerTeamC()
        {
            if (this.TimerTeamC.IsRunning)
            {
                btnStartTimerTeamC.Text = "STOP";
            }
            else
            {
                btnStartTimerTeamC.Text = "START";
            }
        }

        private void SendTimeToCasparCG(TimeSpan Time)
        {
            CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
            _dataCollection.SetData("tijd", Time.TotalSeconds.ToString("0"));
            this.Caspar.Channels[2].CG.Update(10, _dataCollection);
        }

        private void SendPointsToCasparCG(int Points)
        {
            CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
            _dataCollection.SetData("punten", Points.ToString());
            this.Caspar.Channels[2].CG.Update(10, _dataCollection);
        }

        private void ResetCasparCG()
        {
            CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
            _dataCollection.SetData("punten", "0");
            _dataCollection.SetData("tijd", "120");
            this.Caspar.Channels[2].CG.Update(10, _dataCollection);
        }

        // _________________________________ EVENT HANDLERS _________________________________

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

            // standaard seconden toevoegen
            this.TimerTeamA.Sync(TimeSpan.FromSeconds(120));
            this.TimerTeamB.Sync(TimeSpan.FromSeconds(120));
            this.TimerTeamC.Sync(TimeSpan.FromSeconds(120));

            // laad template in casparCG
            this.Caspar.Channels[2].CG.Add(10, "R3");
            this.Caspar.Channels[2].CG.Play(10);

            this.ResetCasparCG();
        }

        private void frmRonde3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stop timers
            this.TimerTeamA.Stop();
            this.TimerTeamB.Stop();
            this.TimerTeamC.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void TimerTeamA_Elapsed(object sender, elapsedEventArgs e)
        {
            // dit event wordt geraised vanuit een andere thread -> we moeten dus invoken naar de main (UI) thread
            this.Invoke((MethodInvoker)delegate
            {
                this.nudTimerTeamA.Value = (int)e.time.TotalSeconds;
            });

            // stuurt tijd naar caspar
            if (this.rbTeamA.Checked)
            {
                this.SendTimeToCasparCG(e.time);
            }            
        }

        private void TimerTeamB_Elapsed(object sender, elapsedEventArgs e)
        {
            // dit event wordt geraised vanuit een andere thread -> we moeten dus invoken naar de main (UI) thread
            this.Invoke((MethodInvoker)delegate
            {
                this.nudTimerTeamB.Value = (int)e.time.TotalSeconds;
            });

            // stuurt tijd naar caspar
            if (this.rbTeamB.Checked)
            {
                this.SendTimeToCasparCG(e.time);
            }
        }

        private void TimerTeamC_Elapsed(object sender, elapsedEventArgs e)
        {
            // dit event wordt geraised vanuit een andere thread -> we moeten dus invoken naar de main (UI) thread
            this.Invoke((MethodInvoker)delegate
            {
                this.nudTimerTeamC.Value = (int)e.time.TotalSeconds;
            });

            // stuurt tijd naar caspar
            if (this.rbTeamC.Checked)
            {
                this.SendTimeToCasparCG(e.time);
            }
        }

        private void btnStartTimerTeamA_Click(object sender, EventArgs e)
        {
            // check of de timer al loopt
            if (!this.TimerTeamA.IsRunning)
            {
                this.TimerTeamA.Start();
            }
            else
            {
                this.TimerTeamA.Stop();
            }

            // update GUI
            this.SetGUITimerTeamA();
        }

        private void btnStartTimerTeamB_Click(object sender, EventArgs e)
        {
            // check of de timer al loopt
            if (!this.TimerTeamB.IsRunning)
            {
                this.TimerTeamB.Start();
            }
            else
            {
                this.TimerTeamB.Stop();
            }

            // update GUI
            this.SetGUITimerTeamB();
        }

        private void btnStartTimerTeamC_Click(object sender, EventArgs e)
        {
            // check of de timer al loopt
            if (!this.TimerTeamC.IsRunning)
            {
                this.TimerTeamC.Start();
            }
            else
            {
                this.TimerTeamC.Stop();
            }

            // update GUI
            this.SetGUITimerTeamC();
        }

        private void TimerTeamA_Stopped(object sender, EventArgs e)
        {
            // dit event wordt vanop een andere thread geraised -> we moeten dus invoken naar de UI thread
            this.Invoke((MethodInvoker)delegate
            {
                // wanneer de timer stopt -> gui updaten
                this.SetGUITimerTeamA();
            });

            // tel overblijvende seconden bij de punten
            this.Control.TeamA.Punten += (int)this.TimerTeamA.ElapsedTime.TotalSeconds;
        }

        private void TimerTeamB_Stopped(object sender, EventArgs e)
        {
            // dit event wordt vanop een andere thread geraised -> we moeten dus invoken naar de UI thread
            this.Invoke((MethodInvoker)delegate
            {
                // wanneer de timer stopt -> gui updaten
                this.SetGUITimerTeamB();
            });

            // tel overblijvende seconden bij de punten
            this.Control.TeamB.Punten += (int)this.TimerTeamB.ElapsedTime.TotalSeconds;
        }

        private void TimerTeamC_Stopped(object sender, EventArgs e)
        {
            // dit event wordt vanop een andere thread geraised -> we moeten dus invoken naar de UI thread
            this.Invoke((MethodInvoker)delegate
            {
                // wanneer de timer stopt -> gui updaten
                this.SetGUITimerTeamC();
            });

            // tel overblijvende seconden bij de punten
            this.Control.TeamB.Punten += (int)this.TimerTeamB.ElapsedTime.TotalSeconds;
        }

        private void nudTimerTeamA_ValueChanged(object sender, EventArgs e)
        {
            // wanneer de timer loopt -> return void
            if (this.TimerTeamA.IsRunning) return;

            // zet de tijd van de timer gelijk met de ingevoerde waarde
            this.TimerTeamA.Sync(TimeSpan.FromSeconds((int)this.nudTimerTeamA.Value));
        }

        private void nudTimerTeamB_ValueChanged(object sender, EventArgs e)
        {
            // wanneer de timer loopt -> return void
            if (this.TimerTeamB.IsRunning) return;

            // zet de tijd van de timer gelijk met de ingevoerde waarde
            this.TimerTeamB.Sync(TimeSpan.FromSeconds((int)this.nudTimerTeamB.Value));
        }

        private void nudTimerTeamC_ValueChanged(object sender, EventArgs e)
        {
            // wanneer de timer loopt -> return void
            if (this.TimerTeamC.IsRunning) return;

            // zet de tijd van de timer gelijk met de ingevoerde waarde
            this.TimerTeamC.Sync(TimeSpan.FromSeconds((int)this.nudTimerTeamC.Value));
        }

        private void btnJuistTeamA_Click(object sender, EventArgs e)
        {
            // check of de huidige waarde gelijk is aan 10
            if (this.nudTimeTeamA.Value == 10) return;

            this.nudTimeTeamA.Value += 1;
        }

        private void btnJuistTeamB_Click(object sender, EventArgs e)
        {
            // check of de huidige waarde gelijk is aan 10
            if (this.nudTimeTeamB.Value == 10) return;

            this.nudTimeTeamB.Value += 1;
        }

        private void btnJuistTeamC_Click(object sender, EventArgs e)
        {
            // check of de huidige waarde gelijk is aan 10
            if (this.nudTimeTeamC.Value == 10) return;

            this.nudTimeTeamC.Value += 1;
        }

        private void nudTimeTeamA_ValueChanged(object sender, EventArgs e)
        {
            // check of waarde = 10 -> stop timer
            if (this.nudTimeTeamA.Value == 10) this.TimerTeamA.Stop();

            // stuur punten door naar caspar
            this.SendPointsToCasparCG((int)this.nudTimeTeamA.Value);
        }

        private void nudTimeTeamB_ValueChanged(object sender, EventArgs e)
        {
            // check of waarde = 10 -> stop timer
            if (this.nudTimeTeamB.Value == 10) this.TimerTeamB.Stop();

            // stuur punten door naar caspar
            this.SendPointsToCasparCG((int)this.nudTimeTeamB.Value);
        }

        private void nudTimeTeamC_ValueChanged(object sender, EventArgs e)
        {
            // check of waarde = 10 -> stop timer
            if (this.nudTimeTeamC.Value == 10) this.TimerTeamC.Stop();

            // stuur punten door naar caspar
            this.SendPointsToCasparCG((int)this.nudTimeTeamC.Value);
        }

        private void rbTeam_CheckedChanged(object sender, EventArgs e)
        {
            // cast sender naar radiobutton
            RadioButton _radioButton = sender as RadioButton;

            if (_radioButton.Checked)
            {
                this.ResetCasparCG();
            }
        }
    }
}
