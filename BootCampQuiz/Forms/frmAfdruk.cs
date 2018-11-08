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
using Svt.Caspar;

namespace BootCampQuiz.Forms
{
    public partial class frmAfdruk : Form, IQuizForm
    {
        // fields
        private QuizControl _control;
        // _________________________________ CLASS PROPERTIES _________________________________

        public CasparDevice Caspar { get; set; }
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

        // _________________________________ CLASS METHODS _________________________________

        public frmAfdruk()
        {
            this.InitializeComponent();
        }

        private void SetButtonStatus()
        {
            if (!_control.Afgedrukt)
            {
                // enable alle knoppen
                this.btnTeamA.Enabled = true;
                this.btnTeamB.Enabled = true;
                this.btnTeamC.Enabled = true;
            }
            else
            {
                // disable alle knoppen
                this.btnTeamA.Enabled = false;
                this.btnTeamB.Enabled = false;
                this.btnTeamC.Enabled = false;

                // enable knop die gedrukt had
                switch(this.Control.AfgedruktTeam.Id)
                {
                    case 1:
                        this.btnTeamA.Enabled = true;
                        break;

                    case 2:
                        this.btnTeamB.Enabled = true;
                        break;

                    case 3:
                        this.btnTeamC.Enabled = true;
                        break;
                }
            }
        }

        // _________________________________ EVENT HANDLERS _________________________________

        private void Control_TeamPushed(object sender, EventArgs e)
        {
            this.SetButtonStatus();
        }

        private void btnTeamA_Click(object sender, EventArgs e)
        {
            this.Control.TeamA.Push();
        }

        private void btnTeamB_Click(object sender, EventArgs e)
        {
            this.Control.TeamB.Push();
        }

        private void btnTeamC_Click(object sender, EventArgs e)
        {
            this.Control.TeamC.Push();
        }
    }
}
