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

namespace BootCampQuiz.Forms
{
    public partial class frmRonde2 : Form, IQuizForm
    {
        // fields
        private QuizControl _control;
        private CasparCGDataCollection _dataCollection = new CasparCGDataCollection();

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

        public frmRonde2()
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
                        this.tlpButtonsTeamA.Enabled = true;
                        break;

                    case 2:
                        this.lblTeamB.ForeColor = Color.Red;
                        this.tlpButtonsTeamB.Enabled = true;
                        break;

                    case 3:
                        this.lblTeamC.ForeColor = Color.Red;
                        this.tlpButtonsTeamC.Enabled = true;
                        break;
                }
            }
            else
            {
                // reset kleuren
                this.lblTeamA.ForeColor = SystemColors.ControlText;
                this.lblTeamB.ForeColor = SystemColors.ControlText;
                this.lblTeamC.ForeColor = SystemColors.ControlText;

                // disable panels
                this.tlpButtonsTeamA.Enabled = false;
                this.tlpButtonsTeamB.Enabled = false;
                this.tlpButtonsTeamC.Enabled = false;
            }
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
                        this.Caspar.Channels[1].Load("Blue_A", false);
                        break;

                    case 2:
                        this.Caspar.Channels[1].Load("Blue_B", false);
                        break;

                    case 3:
                        this.Caspar.Channels[1].Load("Blue_C", false);
                        break;
                }

                this.Caspar.Channels[1].Play();
            }
        }

        private void frmRonde2_Load(object sender, EventArgs e)
        {
            // team namen invoegen
            this.lblTeamA.Text = this.Control.TeamA.Naam;
            this.lblTeamB.Text = this.Control.TeamB.Naam;
            this.lblTeamC.Text = this.Control.TeamC.Naam;

            // toevoegen databindings
            this.nudTeamA.DataBindings.Add("Text", this.Control.TeamA, "Punten");
            this.nudTeamB.DataBindings.Add("Text", this.Control.TeamB, "Punten");
            this.nudTeamC.DataBindings.Add("Text", this.Control.TeamC, "Punten");

            // set gui
            this.SetGUI();

            // laad punten naar caspar
            _dataCollection.SetData("score1", this.Control.TeamA.Punten.ToString());
            _dataCollection.SetData("score2", this.Control.TeamB.Punten.ToString());
            _dataCollection.SetData("score3", this.Control.TeamC.Punten.ToString());

            this.Caspar.Channels[2].CG.Add(10, "SCORE", _dataCollection);
            this.Caspar.Channels[2].CG.Play(10);
        }

        private void btnTeamA_Click(object sender, EventArgs e)
        {
            // cast button
            Button _button = sender as Button;

            // voeg punten uit tag toe
            this.Control.TeamA.Punten += Convert.ToInt32(_button.Tag);

            // caspar cg template clear
            this.Caspar.Channels[1].Clear();
        }

        private void btnTeamB_Click(object sender, EventArgs e)
        {
            // cast button
            Button _button = sender as Button;

            // voeg punten uit tag toe
            this.Control.TeamB.Punten += Convert.ToInt32(_button.Tag);

            // caspar cg template clear
            this.Caspar.Channels[1].Clear();
        }

        private void btnTeamC_Click(object sender, EventArgs e)
        {
            // cast button
            Button _button = sender as Button;

            // voeg punten uit tag toe
            this.Control.TeamC.Punten += Convert.ToInt32(_button.Tag);

            // caspar cg template clear
            this.Caspar.Channels[1].Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Control.Reset();

            // caspar cg template laden
            this.Caspar.Channels[1].Clear();
        }
    }
}
