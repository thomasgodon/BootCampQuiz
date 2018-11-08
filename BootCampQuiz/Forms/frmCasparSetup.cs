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

namespace BootCampQuiz.Forms
{
    public partial class frmCasparSetup : Form
    {
        // fields
        private bool _hasChanges;
        private CasparDevice _casparCG; // declaratie voor referentie casparDevice

        // _________________________________ CLASS METHODS _________________________________

        public frmCasparSetup(CasparDevice CasparDevice)
        {
            InitializeComponent();

            // referentie casparDevice
            _casparCG = CasparDevice;

            // huidige settings tonen
            this.txtHost.Text = _casparCG.Settings.Hostname;
            this.nudPort.Value = _casparCG.Settings.Port;

            // reset _hasChanges -> worden true gezet door initializeren components
            _hasChanges = false;
        }

        private void Save()
        {
            // checken of er verranderingen zijn aangebracht en of casparDevice een null reference is
            if (!_hasChanges || _casparCG == null) return;

            // save in properties
            Properties.Settings.Default.CasparCG_Host = this.txtHost.Text;
            Properties.Settings.Default.CasparCG_Port = (int)this.nudPort.Value;

            // save in casparCG device
            _casparCG.Settings.Hostname = this.txtHost.Text;
            _casparCG.Settings.Port = (int)this.nudPort.Value;

            // reset _hasChanges
            _hasChanges = false;
        }

        // _________________________________ EVENT HANDLERS _________________________________

        private void frmCasparSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_hasChanges) return;

            if (MessageBox.Show("Aanpassingen bewaren?", "Aanpassingen bewaren?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Save();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
            this.Close();
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            _hasChanges = true;
        }

        private void nudPort_ValueChanged(object sender, EventArgs e)
        {
            _hasChanges = true;
        }
    }
}
