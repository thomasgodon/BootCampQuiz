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
    public partial class frmFinale : Form, IQuizForm
    {
        // fields
        private Team _teamA; // finale team 1
        private Team _teamB; // finale team 2
        private List<string[]> _antwoorden = new List<string[]>(); // lijst met antwoorden
        private int _huidigeVraag; // zero indexed!

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

        public frmFinale()
        {
            this.InitializeComponent();
        }

        private void LoadAnswers(int index)
        {
            // laadt antwoorden uit file
            this.btnAntwoord1.Text = _antwoorden[index][0];
            this.btnAntwoord2.Text = _antwoorden[index][1];
            this.btnAntwoord3.Text = _antwoorden[index][2];
            this.btnAntwoord4.Text = _antwoorden[index][3];
            this.btnAntwoord5.Text = _antwoorden[index][4];

            // stuur antwoorden naar caspar
            CasparCGDataCollection _dataCollection = new CasparCGDataCollection();

            _dataCollection.SetData("tijd1", _teamA.Punten.ToString());
            _dataCollection.SetData("tijd2", _teamB.Punten.ToString());
            _dataCollection.SetData("woord1", _antwoorden[index][0]);
            _dataCollection.SetData("woord2", _antwoorden[index][1]);
            _dataCollection.SetData("woord3", _antwoorden[index][2]);
            _dataCollection.SetData("woord4", _antwoorden[index][3]);
            _dataCollection.SetData("woord5", _antwoorden[index][4]);
            _dataCollection.SetData("resetLayer", "1");

            this.Caspar.Channels[(int)Consumer.B].CG.Update(10, _dataCollection);
        }

        private void UpdateTimerGUI()
        {
            if (this.TimerTeamA.IsRunning || this.TimerTeamB.IsRunning)
            {
                this.btnStartStop.Text = "STOP";
            }
            else
            {
                this.btnStartStop.Text = "START";
            }
        }

        // _________________________________ EVENT HANDLERS _________________________________

        private void frmFinale_Load(object sender, EventArgs e)
        {
            // we moeten te weten komen welke teams de finale spelen
            frmTeamSelect _selectTeam = new frmTeamSelect(this.Control);

            // geef het selectie venster weer
            if (_selectTeam.ShowDialog() == DialogResult.OK)
            {
                // wanneer het dialogresult = OK dan is het afvallende team geselecteerd
                _teamA = _selectTeam.TeamA;
                _teamB = _selectTeam.TeamB;
            }
            else
            {
                // sluit dit form bij geen selectie van het afgevallen team
                this.BeginInvoke(new MethodInvoker(this.Close));
            }

            // team namen invoegen
            this.lblTeamA.Text = _teamA.Naam;
            this.lblTeamB.Text = _teamB.Naam;

            // toevoegen databindings
            this.nudTimeTeamA.DataBindings.Add("Text", _teamA, "Punten");
            this.nudTimeTeamB.DataBindings.Add("Text", _teamB, "Punten");

            // laadt antwoorden uit file
            string[] lines = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\\resources\\antwoorden_finale.txt");

            // splits de antwoorden
            foreach(var line in lines)
            {
                // split lijn ;
                string[] _antw = line.Split(';');

                // voeg gesplitste antwoorden toe aan lijst
                _antwoorden.Add(_antw);
            }

            // laad template in casparCG
            this.Caspar.Channels[(int)Consumer.A].Clear();
            this.Caspar.Channels[(int)Consumer.A].CG.Clear();
            this.Caspar.Channels[(int)Consumer.B].CG.Add(10, "FINALE");
            this.Caspar.Channels[(int)Consumer.B].CG.Play(10);

            // laadt eerste antwoorden
            this.LoadAnswers(_huidigeVraag);
        }

        private void frmFinale_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stop de timers
            this.TimerTeamA.Stop();
            this.TimerTeamB.Stop();

            this.Caspar.Channels[(int)Consumer.B].CG.Clear();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            // tel 20 seconden af bij het andere team
            if (this.rbTeamA.Checked)
            {
                // check of we 10 punten kunnen aftrekken
                if ((this.nudTimeTeamB.Value - 10) < 0)
                {
                    this.nudTimeTeamB.Value = 0;
                }
                else
                {
                    this.nudTimeTeamB.Value -= 10;
                }
            }
            else
            {
                // check of we 10 punten kunnen aftrekken
                if ((this.nudTimeTeamA.Value - 10) < 0)
                {
                    this.nudTimeTeamA.Value = 0;
                }
                else
                {
                    this.nudTimeTeamA.Value -= 10;
                }
            }

            // check of er 1 van de 2 tijden op 0 staat -> stop de aftelklokken
            if (this.nudTimeTeamA.Value == 0 || this.nudTimeTeamB.Value == 0)
            {
                this.TimerTeamA.Stop();
                this.TimerTeamB.Stop();
            }

            // cast object naar button om te weten welke button heeft gedrukt -> nodig om te weten welk antwoord er werd gedrukt
            Button _button = sender as Button;
            int buttonId = Convert.ToInt32(_button.Tag);

            string _antwoord = _antwoorden[_huidigeVraag][buttonId];

            // stuur geselecteerde antwoord door naar caspar
            CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
            _dataCollection.SetData("woord" + (buttonId + 1).ToString() + "goed", _antwoord);
            this.Caspar.Channels[(int)Consumer.B].CG.Update(10, _dataCollection);
        }

        private void btnVolgendeVraag_Click(object sender, EventArgs e)
        {
            // volgende vraag
            _huidigeVraag++;

            // check of huidige vraag niet meer is dan totaal aantal vragen
            if (_huidigeVraag >= _antwoorden.Count()) _huidigeVraag = _antwoorden.Count - 1;

            this.lblVraag.Text = "Vraag " + (_huidigeVraag + 1).ToString();

            // laadt antwoorden
            this.LoadAnswers(_huidigeVraag);
        }

        private void btnVorigeVraag_Click(object sender, EventArgs e)
        {
            // vorige vraag
            _huidigeVraag--;

            // check of huidige vraag niet minder is dan 0
            if (_huidigeVraag < 0) _huidigeVraag = 0;

            this.lblVraag.Text = "Vraag " + (_huidigeVraag + 1).ToString();

            // laadt antwoorden
            this.LoadAnswers(_huidigeVraag);
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            // check welk team aan beurt is
            if (this.rbTeamA.Checked)
            {
                if (this.TimerTeamA.IsRunning)
                {
                    this.TimerTeamA.Stop();
                }
                else
                {
                    this.TimerTeamA.Start();
                }

                // stop timer B
                this.TimerTeamB.Stop();
            }
            else
            {
                if (this.TimerTeamB.IsRunning)
                {
                    this.TimerTeamB.Stop();
                }
                else
                {
                    this.TimerTeamB.Start();
                }

                // stop timer A
                this.TimerTeamA.Stop();
            }

            // update gui
            this.UpdateTimerGUI();
        }

        private void TimerTeamA_Elapsed(object sender, elapsedEventArgs e)
        {
            // dit event wordt vanop een andere thread geraised -> we moeten dus invoken naar de UI thread
            this.Invoke((MethodInvoker)delegate
            {
                // wanneer de timer stopt -> gui updaten
                this.nudTimeTeamA.Value = (int)e.time.TotalSeconds;
            });
        }

        private void TimerTeamB_Elapsed(object sender, elapsedEventArgs e)
        {
            // dit event wordt vanop een andere thread geraised -> we moeten dus invoken naar de UI thread
            this.Invoke((MethodInvoker)delegate
            {
                // wanneer de timer stopt -> gui updaten
                this.nudTimeTeamB.Value = (int)e.time.TotalSeconds;
            });
        }

        private void Timer_Stopped(object sender, EventArgs e)
        {
            // dit event wordt geraised vanuit een andere thread -> we moeten dus invoken naar de main (UI) thread
            this.Invoke((MethodInvoker)delegate
            {
                this.UpdateTimerGUI();
            });
        }

        private void nudTimeTeamA_ValueChanged(object sender, EventArgs e)
        {
            // wanneer de timer niet loopt en er worden punten aangepast -> sync met timer object
            if (!this.TimerTeamA.IsRunning)
            {
                this.TimerTeamA.Sync(TimeSpan.FromSeconds((int)nudTimeTeamA.Value));
            }

            // stuur tijd van team A naar caspar
            CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
            _dataCollection.SetData("tijd1", this.nudTimeTeamA.Value.ToString());
            this.Caspar.Channels[(int)Consumer.B].CG.Update(10, _dataCollection);
        }

        private void nudTimeTeamB_ValueChanged(object sender, EventArgs e)
        {
            // wanneer de timer niet loopt en er worden punten aangepast -> sync met timer object
            if (!this.TimerTeamB.IsRunning)
            {
                this.TimerTeamB.Sync(TimeSpan.FromSeconds((int)nudTimeTeamB.Value));
            }

            // stuur tijd van team B naar caspar
            CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
            _dataCollection.SetData("tijd2", this.nudTimeTeamB.Value.ToString());
            this.Caspar.Channels[(int)Consumer.B].CG.Update(10, _dataCollection);
        }

        private void rbTeamA_CheckedChanged(object sender, EventArgs e)
        {
            // wanneer radiobutton van team A wordt geselecteerd en de timer van team B loopt nog -> zet deze dan stop
            if (this.rbTeamA.Checked && this.TimerTeamB.IsRunning)
            {
                this.TimerTeamB.Stop();
            }
        }

        private void rbTeamB_CheckedChanged(object sender, EventArgs e)
        {
            // wanneer radiobutton van team B wordt geselecteerd en de timer van team B loopt nog -> zet deze dan stop
            if (this.rbTeamB.Checked && this.TimerTeamA.IsRunning)
            {
                this.TimerTeamA.Stop();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
            _dataCollection.SetData("reset", "1");
            _dataCollection.SetData("woord1", _antwoorden[_huidigeVraag][0]);
            _dataCollection.SetData("woord2", _antwoorden[_huidigeVraag][1]);
            _dataCollection.SetData("woord3", _antwoorden[_huidigeVraag][2]);
            _dataCollection.SetData("woord4", _antwoorden[_huidigeVraag][3]);
            _dataCollection.SetData("woord5", _antwoorden[_huidigeVraag][4]);
            this.Caspar.Channels[(int)Consumer.B].CG.Update(10, _dataCollection);
        }
    }
}
