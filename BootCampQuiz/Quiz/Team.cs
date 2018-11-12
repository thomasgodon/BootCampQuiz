using System;
using System.ComponentModel;

namespace BootCampQuiz.Quiz
{
    /// <summary>
    /// Team class
    /// </summary>
    public class Team : INotifyPropertyChanged
    {
        // fields
        private int _punten = 60;

        // _________________________________ CLASS PROPERTIES _________________________________

        /// <summary>
        /// Punten
        /// </summary>
        public int Punten
        {
            get
            {
                return _punten;
            }
            set
            {
                if (_punten != value)
                {
                    _punten = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Punten"));
                }
            }
        }

        /// <summary>
        /// Team naam
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// Team id -> voor identifieceren team
        /// </summary>
        public int Id { get; }

        // events
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Team heeft afgedrukt
        /// </summary>
        internal event EventHandler Pushed;

        // _________________________________ CLASS METHODS _________________________________

        public Team(int Id)
        {
            this.Id = Id;
        }

        /// <summary>
        /// Team drukt af
        /// </summary>
        public void Push()
        {
            this.Pushed?.Invoke(this, EventArgs.Empty);
        }

        public override string ToString()
        {
            return Naam + " - " + Punten.ToString();
        }
    }
}
