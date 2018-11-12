using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampQuiz.Quiz
{
    /// <summary>
    /// Class die de game status bijhoud (punten, ...)
    /// </summary>
    public sealed class QuizControl
    {
        // events
        public event EventHandler TeamPushed;

        // _________________________________ CLASS PROPERTIES _________________________________

        public Team TeamA { get; set; } = new Team(1);
        public Team TeamB { get; set; } = new Team(2);
        public Team TeamC { get; set; } = new Team(3);

        /// <summary>
        /// Indicatie dat een team heeft afgedrukt
        /// </summary>
        public bool Afgedrukt { private set; get; }

        /// <summary>
        /// Referentie van het afgedrukt team. Referentie is null wanneer er gereset werd
        /// </summary>
        public Team AfgedruktTeam { private set; get; }

        // _________________________________ EVENT HANDLERS _________________________________

        private void Team_Pushed(object sender, EventArgs e)
        {
            // check of er al is afgedrukt
            if (this.Afgedrukt) return;

            // speel geluidje :)
            System.Media.SystemSounds.Beep.Play();

            // zet status afgedrukt team
            this.Afgedrukt = true;
            this.AfgedruktTeam = sender as Team;

            // raise event
            this.TeamPushed?.Invoke(this, EventArgs.Empty);
        }

        // _________________________________ CLASS METHODS _________________________________

        public QuizControl()
        {
            // initialiseer teams
            this.TeamA.Naam = Properties.Settings.Default.TeamA;
            this.TeamB.Naam = Properties.Settings.Default.TeamB;
            this.TeamC.Naam = Properties.Settings.Default.TeamC;

            this.AddHandlers();
        }

        private void AddHandlers()
        {
            this.TeamA.Pushed += new EventHandler(Team_Pushed);
            this.TeamB.Pushed += new EventHandler(Team_Pushed);
            this.TeamC.Pushed += new EventHandler(Team_Pushed);
        }

        public void Reset()
        {
            this.Afgedrukt = false;
            this.AfgedruktTeam = null;

            // raise event
            this.TeamPushed?.Invoke(this, EventArgs.Empty);
        }
    }
}
