using System;

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

        private void FormLoad(object sender, EventArgs e)
        {
            try
            {
                controller = new MDBoxCommsInterface(Constants.HOST_PORT, Constants.MBOX_PORT);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
