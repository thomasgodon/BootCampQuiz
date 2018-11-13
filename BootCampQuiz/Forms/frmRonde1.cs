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
    public partial class frmRonde1 : Form, IQuizForm
    {
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

        public frmRonde1()
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
                        this.btnTeamAFout.Enabled = true;
                        this.btnTeamAJuist.Enabled = true;
                        break;

                    case 2:
                        this.lblTeamB.ForeColor = Color.Red;
                        this.btnTeamBFout.Enabled = true;
                        this.btnTeamBJuist.Enabled = true;
                        break;

                    case 3:
                        this.lblTeamC.ForeColor = Color.Red;
                        this.btnTeamCFout.Enabled = true;
                        this.btnTeamCJuist.Enabled = true;
                        break;
                }
            }
            else
            {
                // reset kleuren
                this.lblTeamA.ForeColor = SystemColors.ControlText;
                this.lblTeamB.ForeColor = SystemColors.ControlText;
                this.lblTeamC.ForeColor = SystemColors.ControlText;

                // disable buttons
                this.btnTeamAFout.Enabled = false;
                this.btnTeamAJuist.Enabled = false;
                this.btnTeamBFout.Enabled = false;
                this.btnTeamBJuist.Enabled = false;
                this.btnTeamCFout.Enabled = false;
                this.btnTeamCJuist.Enabled = false;
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

            if (this.Control.Afgedrukt)
            {
                switch(this.Control.AfgedruktTeam.Id)
                {
                    case 1:
                        this.Caspar.Channels[(int)Consumer.A].Load(10, "Actief_A", false);
                        break;

                    case 2:
                        this.Caspar.Channels[(int)Consumer.A].Load(10, "Actief_B", false);
                        break;

                    case 3:
                        this.Caspar.Channels[(int)Consumer.A].Load(10, "Actief_C", false);
                        break;
                }

                this.Caspar.Channels[(int)Consumer.A].Play(10);
            }
        }

        private void frmRonde1_Load(object sender, EventArgs e)
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
            this.LoadScore();
        }

        private void btnJuist_Click(object sender, EventArgs e)
        {
            // cast sender object naar button -> deze method wordt enkel door buttons gecalled
            Button _sender = sender as Button;

            // speel systeem geluidje :)
            System.Media.SystemSounds.Exclamation.Play();

            // toevoegen punten
            // check tag -> letter zit in de tag
            switch (_sender.Tag as string)
            {
                case "A":
                    this.Control.TeamA.Punten += 10;
                    this.Caspar.Channels[(int)Consumer.A].Load(10, "Goed_A", false);               
                    break;

                case "B":
                    this.Control.TeamB.Punten += 10;
                    this.Caspar.Channels[(int)Consumer.A].Load(10, "Goed_B", false);
                    break;

                case "C":
                    this.Control.TeamC.Punten += 10;
                    this.Caspar.Channels[(int)Consumer.A].Load(10, "Goed_C", false);
                    break;
            }

            // play gfx
            this.Caspar.Channels[(int)Consumer.A].Play(10);

            // reset knoppen
            this.Control.Reset();
        }

        private void btnFout_Click(object sender, EventArgs e)
        {
            // cast sender object naar button -> deze method wordt enkel door buttons gecalled
            Button _sender = sender as Button;

            // speel systeem geluidje :)
            System.Media.SystemSounds.Hand.Play();

            // toevoegen punten
            // check tag -> letter zit in de tag
            switch (_sender.Tag as string)
            {
                case "A":
                    this.Caspar.Channels[(int)Consumer.A].Load(10, "Fout_A", false);
                    break;

                case "B":
                    this.Caspar.Channels[(int)Consumer.A].Load(10, "Fout_B", false);
                    break;

                case "C":
                    this.Caspar.Channels[(int)Consumer.A].Load(10, "Fout_C", false);
                    break;
            }

            this.Caspar.Channels[(int)Consumer.A].Play(10);

            // reset knoppen
            this.Control.Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Control.Reset();

            // caspar cg template laden
            this.Caspar.Channels[(int)Consumer.A].Clear(10);
        }

        private void frmRonde1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _control.TeamPushed -= Control_TeamPushed;
        }
    }
}
