using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace MDBoxProject
{
    public partial class mainForm : Form
    {

        MDBoxCommsInterface controller;


        public mainForm()
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
        #endregion

        #region Button Events
        private void TestButtonClick(object sender, EventArgs e)
        {
            controller.Test();
        }

        private void GoToMaxClick(object sender, EventArgs e)
        {
            controller.GoToMaxPosition();
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


                btnMaxPos.Enabled = btnZero.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        #endregion Button Events

        private void CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;
            txtIPAddress.Enabled = !check.Checked;
        }

        #endregion Events
    }
}
