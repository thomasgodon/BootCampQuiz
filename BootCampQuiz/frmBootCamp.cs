using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BootCampQuiz.Forms;
using Svt.Network;
using Svt.Caspar;
using Svt.Caspar.Controls;
using System.Net.Sockets;
using BootCampQuiz.Quiz;
using SharpDX.DirectInput;

namespace BootCampQuiz
{
    public partial class frmBootCamp : Form
    {
        // fields
        private QuizControl _control = new QuizControl(); // initialize quiz control object
        private CasparDevice _caspar = new CasparDevice(); // initialize caspar device
        private GameController _gameController = new GameController();

        // declaraties van spel ronde forms -> worden geinitialiseerd bij het aanklikken van de menu items
        private frmRonde1 _ronde1 = null;
        private frmRonde2 _ronde2 = null;
        private frmRonde3 _ronde3 = null;
        private frmRonde4 _ronde4 = null;
        private frmFinale _finale = null;
        private frmAfdruk _afdruk = null;
        private frmBackgrounds _backgrounds = null;

        // _________________________________ CLASS METHODS _________________________________

        public frmBootCamp()
        {
            InitializeComponent();

            // event handlers toevoegen
            this.AddHandlers();

            // laadt settings caspar device
            _caspar.Settings.Hostname = Properties.Settings.Default.CasparCG_Host;
            _caspar.Settings.Port = Properties.Settings.Default.CasparCG_Port;
        }

        /// <summary>
        /// Generic method voor het openen van forms
        /// </summary>
        private void ShowForm<T>(ref T Form) where T : Form, IQuizForm, new()
        {
            if (Form == null) Form = new T(); // check of Form geen null reference is
            if (Form.IsDisposed) Form = new T(); // check of Form niet disposed is

            Form.Control = _control; // maak referentie control object
            Form.Caspar = _caspar; // maak referentie van caspar device

            Form.MdiParent = this; // maak frmBootCamp de mdi parent
            Form.BringToFront();
            Form.Show();
        }

        private void AddHandlers()
        {
            // caspar connectie event handler
            _caspar.ConnectionStatusChanged += new EventHandler<ConnectionEventArgs>(_caspar_ConnectionStatusChanged);
            _gameController.JoystickButtonPressed += new EventHandler<GameController.JoyStickUpdateArgs>(_gameController_JoystickButtonPressed);
            _control.TeamA.PropertyChanged += new PropertyChangedEventHandler(TeamA_PropertyChanged);
            _control.TeamB.PropertyChanged += new PropertyChangedEventHandler(TeamB_PropertyChanged);
            _control.TeamC.PropertyChanged += new PropertyChangedEventHandler(TeamC_PropertyChanged);
        }

        private void RemoveHandlers()
        {
            _caspar.ConnectionStatusChanged -= _caspar_ConnectionStatusChanged;
        }

        private void SetCasparCGStatus()
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblCasparCGStatus.ForeColor = Color.White;

                if (_caspar.IsConnected)
                {
                    lblCasparCGStatus.Text = "CasparCG Server: " + _caspar.Settings.Hostname + " Port: " + _caspar.Settings.Port.ToString();
                    tsCasparCGStatus.BackColor = Color.Green;
                    miCasparCGConnect.Text = "Disconnect";
                }
                else
                {
                    lblCasparCGStatus.Text = "CasparCG Server: Verbroken ";
                    tsCasparCGStatus.BackColor = Color.Red;
                    miCasparCGConnect.Text = "Connect";
                }
            });           
        }

        // _________________________________ EVENT HANDLERS _________________________________

        private void _caspar_ConnectionStatusChanged(object sender, ConnectionEventArgs e)
        {
            // checken of er een exception gerased werd
            if (e.Exception != null)
            {
                // cast referentie naar socketException
                SocketException _exception = e.Exception as SocketException;

                // toon exception in messagebox
                MessageBox.Show(_exception.Message, "Error: " + _exception.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // verrander status
            this.SetCasparCGStatus();
        }

        private void _gameController_JoystickButtonPressed(object sender, GameController.JoyStickUpdateArgs e)
        {
            // invoke naar de main thread (GUI)
            this.Invoke((MethodInvoker)delegate
            {
                switch (e.Data.Offset)
                {
                    //Team A
                    case JoystickOffset.Buttons0:

                        _control.TeamA.Push();
                        break;

                    //Team B
                    case JoystickOffset.Buttons1:
                        _control.TeamB.Push();
                        break;

                    //Team C
                    case JoystickOffset.Buttons2:
                        _control.TeamC.Push();
                        break;
                }
            });           
        }

        private void TeamA_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Punten")
            {
                CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
                _dataCollection.SetData("score1", _control.TeamA.Punten.ToString());
                _caspar.Channels[(int)Consumer.A].CG.Update(11, _dataCollection);
                _caspar.Channels[(int)Consumer.B].CG.Update(11, _dataCollection);
            }
        }

        private void TeamB_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Punten")
            {
                CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
                _dataCollection.SetData("score2", _control.TeamB.Punten.ToString());
                _caspar.Channels[(int)Consumer.A].CG.Update(11, _dataCollection);
                _caspar.Channels[(int)Consumer.B].CG.Update(11, _dataCollection);
            }
        }

        private void TeamC_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Punten")
            {
                CasparCGDataCollection _dataCollection = new CasparCGDataCollection();
                _dataCollection.SetData("score3", _control.TeamC.Punten.ToString());
                _caspar.Channels[(int)Consumer.A].CG.Update(11, _dataCollection);
                _caspar.Channels[(int)Consumer.B].CG.Update(11, _dataCollection);
            }
        }

        private void miRonde1_Click(object sender, EventArgs e)
        {
            this.ShowForm<frmRonde1>(ref _ronde1); // open form
        }

        private void miRonde2_Click(object sender, EventArgs e)
        {
            this.ShowForm<frmRonde2>(ref _ronde2);
        }

        private void miRonde3_Click(object sender, EventArgs e)
        {
            this.ShowForm<frmRonde3>(ref _ronde3);
        }

        private void miRonde4_Click(object sender, EventArgs e)
        {
            this.ShowForm<frmRonde4>(ref _ronde4);
        }

        private void miFinale_Click(object sender, EventArgs e)
        {
            this.ShowForm<frmFinale>(ref _finale);
        }

        private void miBackgrounds_Click(object sender, EventArgs e)
        {
            this.ShowForm<frmBackgrounds>(ref _backgrounds);
        }

        private void miAfdrukken_Click(object sender, EventArgs e)
        {
            this.ShowForm<frmAfdruk>(ref _afdruk);
        }

        private void miCasparCGSetup_Click(object sender, EventArgs e)
        {
            frmCasparSetup _setup = new frmCasparSetup(_caspar);
            _setup.ShowDialog();
        }

        private void frmBootCamp_Load(object sender, EventArgs e)
        {
            this.SetCasparCGStatus();
        }

        private void frmBootCamp_FormClosing(object sender, FormClosingEventArgs e)
        {
            _caspar.Disconnect();
            _gameController.Exit();
        }

        private void miCasparCGConnect_Click(object sender, EventArgs e)
        {
            if (_caspar.IsConnected)
            {
                _caspar.Disconnect();
            }
            else
            {
                _caspar.Connect();
            }          
        }
    }
}
