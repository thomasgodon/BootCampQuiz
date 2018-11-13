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
    public partial class frmRonde4 : Form, IQuizForm
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
        /// Referentie van caspar device object
        /// </summary>
        public CasparDevice Caspar { get; set; }

        // _________________________________ CLASS METHODS _________________________________

        public frmRonde4()
        {
            InitializeComponent();
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

        private void LoadScore()
        {
            _dataCollection.SetData("score1", this.Control.TeamA.Punten.ToString());
            _dataCollection.SetData("score2", this.Control.TeamB.Punten.ToString());
            _dataCollection.SetData("score3", this.Control.TeamC.Punten.ToString());

            this.Caspar.Channels[(int)Consumer.A].CG.Add(11, "score", _dataCollection);
            this.Caspar.Channels[(int)Consumer.A].CG.Play(11);

            this.Caspar.Channels[(int)Consumer.B].CG.Add(11, "score_afkijk", _dataCollection);
            this.Caspar.Channels[(int)Consumer.B].CG.Play(11);
        }

        // _________________________________ EVENT HANDLERS _________________________________

        private void Control_TeamPushed(object sender, EventArgs e)
        {
            this.SetGUI();            
        }

        private void frmRonde4_Load(object sender, EventArgs e)
        {
            // team namen invoegen
            this.lblTeamA.Text = this.Control.TeamA.Naam;
            this.lblTeamB.Text = this.Control.TeamB.Naam;
            this.lblTeamC.Text = this.Control.TeamC.Naam;

            // toevoegen databindings
            this.nudTeamA.DataBindings.Add("Text", this.Control.TeamA, "Punten");
            this.nudTeamB.DataBindings.Add("Text", this.Control.TeamB, "Punten");
            this.nudTeamC.DataBindings.Add("Text", this.Control.TeamC, "Punten");

            // laad score
            this.LoadScore();

            // clear layer 10 (lampen)
            this.Caspar.Channels[(int)Consumer.A].Clear(10);
        }

        private void btnTeamAGelachen_Click(object sender, EventArgs e)
        {
            try
            {
                nudSecondenA.Value -= 10;
            }
            catch { }
        }

        private void btnTeamBGelachen_Click(object sender, EventArgs e)
        {
            try
            {
                nudSecondenB.Value -= 10;
            }
            catch { }          
        }

        private void btnTeamCGelachen_Click(object sender, EventArgs e)
        {
            try
            {
                nudSecondenC.Value -= 10;
            }
            catch { }         
        }

        private void btnTeamAStart_Click(object sender, EventArgs e)
        {

            nudSecondenA.Value = 30;
        }

        private void btnTeamBStart_Click(object sender, EventArgs e)
        {

            nudSecondenB.Value = 30;
        }

        private void btnTeamCStart_Click(object sender, EventArgs e)
        {

            nudSecondenC.Value = 30;
        }
   
        private void btnUpdateScoreA_Click(object sender, EventArgs e)
        {
            this.Control.TeamA.Punten += (int)nudSecondenA.Value;
        }

        private void btnUpdateScoreB_Click(object sender, EventArgs e)
        {
            this.Control.TeamB.Punten += (int)nudSecondenB.Value;
        }

        private void btnUpdateScoreC_Click(object sender, EventArgs e)
        {
            this.Control.TeamC.Punten += (int)nudSecondenC.Value;
        }
    }
}
