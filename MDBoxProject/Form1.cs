using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace MDBoxProject
{
    public partial class MainForm : Form
    {

        MDBoxCommsInterface controller;


        public MainForm()
        {
            InitializeComponent();
            
        }

        #region Events

        #region TextBox Events
        private void IPSubNetValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IPAddress.TryParse(txtIPAddress.Text.Replace(" ", string.Empty), out IPAddress address);
            errorProvider1.SetError(txtIPAddress, "Invalid IPv4 subnet format providec");
        }

        private void IPSubnetValidated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtIPAddress, "");
        }

        private void IPSubnetKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                var jump = 0;
                var split = txtIPAddress.Text.Split('.');
                for (int i = 0; i < split.Length; i++)
                {
                    if (int.TryParse(split[i], out int parsed))
                    {
                        jump += 4;
                    }
                    txtIPAddress.SelectionStart = jump;
                }
            }
        }

        private void IPSubnetGetFocus(object sender, EventArgs e)
        {
            txtIPAddress.SelectionStart = 0;
        }
        #endregion TextBox Events

        #region Button Events
        private void TestButtonClick(object sender, EventArgs e)
        {
            controller.Test();
        }

        private void GoToMaxClick(object sender, EventArgs e)
        {
            controller.GoToMaxPosition(!checkUserCmmands.Checked);
        }

        private void GoToZeroClick(object sender, EventArgs e)
        {
            controller.GoToZero();
        }

        private void ConnectClick(object sender, EventArgs e)
        {
            try
            {
                if (checkDefault.Checked)
                {
                    controller = new MDBoxCommsInterface(Constants.HOST_PORT, Constants.MBOX_PORT);
                }
                else if (txtIPAddress.MaskCompleted)
                {
                    controller = new MDBoxCommsInterface(txtIPAddress.Text.Replace(" ",string.Empty), Constants.HOST_PORT, Constants.MBOX_PORT);
                }
                else
                {
                    MessageBox.Show("Invalid connection configuration provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                btnMaxPos.Enabled = btnZero.Enabled = btnSend.Enabled = btnReset.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void SendAxisDataClick(object sender, EventArgs e)
        {
            var data = new AxisData(trackXAxis.Value, trackYAxis.Value, trackZAxis.Value,
                trackUAxis.Value, trackVAxis.Value, trackWAxis.Value, !checkUserCmmands.Checked);
            controller.SendAxisData(data);
        }

        private void ResetClick(object sender, EventArgs e)
        {
            controller.Reset();
        }

        #endregion Button Events

        private void CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;
            txtIPAddress.Enabled = !check.Checked;
        }

        #region Axis Position
        private void NumericUpDownValueChanged(object sender, EventArgs e)
        {
            var upDown = sender as NumericUpDown;
            Extensions.SetTrackBar(Controls, upDown.Tag.ToString(), Convert.ToInt32(upDown.Value), out bool found);
            //Controls.SetTrackBar(upDown.Tag.ToString(), Convert.ToInt32(upDown.Value), out bool found);
        }

        private void TrackBarValueChanged(object sender, EventArgs e)
        {
            var trackBar = sender as TrackBar;
            Extensions.SetNumericUpDown(Controls, trackBar.Tag.ToString(), trackBar.Value, out bool found);
            //Controls.SetNumericUpDown(trackBar.Tag.ToString(), trackBar.Value, out bool found);
        }
        #endregion Axis Position

        #endregion Events
    }
}
