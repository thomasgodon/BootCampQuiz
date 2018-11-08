using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BootCampQuiz.Quiz;

namespace BootCampQuiz.Forms
{
    public partial class frmTeamSelect : Form
    {
        // field
        private QuizControl _control;

        // _________________________________ CLASS PROPERTIES _________________________________

        /// <summary>
        /// Finale team A
        /// </summary>
        public QuizControl.Team TeamA { internal set; get; }

        /// <summary>
        /// Finale team B
        /// </summary>
        public QuizControl.Team TeamB { internal set; get; }

        // _________________________________ CLASS METHODS _________________________________

        public frmTeamSelect(QuizControl Control)
        {
            this.InitializeComponent();

            // maak referentie van het quizcontrol object
            _control = Control;

            // zet waardes in de labels
            this.lblTeamA.Text = _control.TeamA.Naam;
            this.lblTeamB.Text = _control.TeamB.Naam;
            this.lblTeamC.Text = _control.TeamC.Naam;

            this.lblPuntenTeamA.Text = _control.TeamA.Punten.ToString();
            this.lblPuntenTeamB.Text = _control.TeamB.Punten.ToString();
            this.lblPuntenTeamC.Text = _control.TeamC.Punten.ToString();
        }

        // _________________________________ EVENT HANDLERS _________________________________

        private void btnSelectTeam_Click(object sender, EventArgs e)
        {
            // cast sender naar button
            Button _button = sender as Button;

            // bij het selecteren van het afvallende team weten we de 2 finale teams
            switch(_button.Tag as string)
            {
                case "A":
                    this.TeamA = _control.TeamB;
                    this.TeamB = _control.TeamC;
                    break;

                case "B":
                    this.TeamA = _control.TeamA;
                    this.TeamB = _control.TeamC;
                    break;

                case "C":
                    this.TeamA = _control.TeamA;
                    this.TeamB = _control.TeamB;
                    break;
            }

            // zet het dialog result op ok
            this.DialogResult = DialogResult.OK;

            // sluit dit form
            this.Close();
        }
    }
}
