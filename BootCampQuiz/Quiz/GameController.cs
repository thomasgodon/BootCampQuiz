using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using SharpDX;
using SharpDX.DirectInput;
using System.Threading;

namespace BootCampQuiz.Quiz
{
    // Class die de gamecontroller interface verwerkt
    public class GameController
    {
        // fields
        private object ListLock = new object();
        private object DeviceCountLock = new object();
        private Queue<JoystickUpdate> JoystickEvents = new Queue<JoystickUpdate>();
        private List<Joystick> Joysticks = new List<Joystick>();
        private int _Devicecount;
        private DirectInput directInput = new DirectInput();
        private bool _loop = true;

        // _________________________________ EVENTS _________________________________

        /// <summary>
        ///Raises when a joystickbutton is pressed
        /// </summary>
        public event EventHandler<JoyStickUpdateArgs> JoystickButtonPressed;

        /// <summary>
        ///Raises when the number of joysticks changed
        /// </summary>
        public event EventHandler JoystickCountChanged;

        // _________________________________ PROPERTIES _________________________________

        /// <summary>
        /// The number of connected joysticks
        /// </summary>
        public int JoystickCount
        {
            get
            {
                lock (DeviceCountLock)
                {
                    return _Devicecount;
                }
            }
        }

        /// <summary>
        /// Name of the id
        /// </summary>
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// True if there is at least 1 joystick connected
        /// </summary>
        public bool Connected
        {
            get
            {
                if (this.JoystickCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // _________________________________ METDODS _________________________________

        /// <summary>
        /// Initializes a new instance of this class
        /// </summary>
        public GameController()
        {
            Thread FindJoySticks = new Thread(new ThreadStart(SearchJoySticks));
            Thread EventManager = new Thread(new ThreadStart(JoystickEventManagerThread));
            FindJoySticks.Start();
            EventManager.Start();
        }

        //Tries to connect to joysticks
        private void SearchJoySticks()
        {
            _Devicecount = 0;
            // Initialize DirectInput

            while (_loop)
            {
                lock (DeviceCountLock)
                {
                    if (_Devicecount != directInput.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly).Count)
                    {
                        Joysticks.Clear();
                        //Look for Joysticks
                        foreach (DeviceInstance deviceInstance in directInput.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly))
                        {
                            Joystick newJoystick = new Joystick(directInput, deviceInstance.InstanceGuid);
                            Thread JoystickListenerThread = new Thread(new ParameterizedThreadStart(JoyStickListener));
                            JoystickListenerThread.Start(newJoystick);

                            Joysticks.Add(newJoystick);

                        }
                        _Devicecount = directInput.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly).Count;
                        JoystickCountChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                Thread.Sleep(500);
            }
        }

        //Listens for joystick press events
        private void JoyStickListener(object Joystick)
        {
            Joystick joystick = (Joystick)Joystick;
            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();

            //exit the loop when disposed
            while (!joystick.IsDisposed && _loop)
            {
                try
                {
                    joystick.Poll();
                    JoystickUpdate[] datas = joystick.GetBufferedData();
                    foreach (JoystickUpdate state in datas)
                    {
                        lock (ListLock)
                        {
                            JoystickEvents.Enqueue(state);
                        }
                    }
                }
                catch (SharpDXException e)
                {
                    System.Windows.Forms.MessageBox.Show("JOYSTICK LISTENER  KAPOT" + e.Message);
                    break;
                }

                Thread.Sleep(10);
            }
        }

        //Handles the ButtonPress Queue
        private void JoystickEventManagerThread()
        {
            while (_loop)
            {
                try
                {
                    if (JoystickEvents.Count > 0)
                    {
                        JoystickUpdate current;

                        lock (ListLock)
                        {
                            current = JoystickEvents.Dequeue();
                        }

                        if (current.Value != 0)
                        {
                            JoystickButtonPressed?.Invoke(this, new JoyStickUpdateArgs(current));
                        }
                    }

                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

                Thread.Sleep(2);
            }
        }

        public void Exit()
        {
            _loop = false;
        }

        /// <summary>
        /// EventArgs for a Joystick button event
        /// </summary>
        public class JoyStickUpdateArgs : EventArgs
        {
            /// <summary>
            /// The raw data
            /// </summary>
            public JoystickUpdate Data;

            internal JoyStickUpdateArgs(JoystickUpdate update)
            {
                this.Data = update;
            }
        }
    }
}
