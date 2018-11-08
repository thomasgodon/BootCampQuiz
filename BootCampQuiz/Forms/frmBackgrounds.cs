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
    public partial class frmBackgrounds : Form, IQuizForm
    {

        public CasparDevice Caspar { get; set; }
        public QuizControl Control { get; set; }

        public frmBackgrounds()
        {
            this.InitializeComponent();
        }

        private void btnBackground1_Click(object sender, EventArgs e)
        {
            this.Caspar.Channels[0].Load("BKGD_1", true);
            this.Caspar.Channels[0].Play();
        }

        private void btnBackground2_Click(object sender, EventArgs e)
        {
            this.Caspar.Channels[0].Load("BKGD_2", true);
            this.Caspar.Channels[0].Play();
        }

        private void btnBackground3_Click(object sender, EventArgs e)
        {
            this.Caspar.Channels[0].Load("BKGD_3", true);
            this.Caspar.Channels[0].Play();
        }

        private void btnFinale_Click(object sender, EventArgs e)
        {
            this.Caspar.Channels[0].Load("BKGD_4", true);
            this.Caspar.Channels[0].Play();
        }
    }
}
