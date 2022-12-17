namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            var ipAddress = IpAddress.Text;
            // We should validate the format of the input
            InstructionLabel.Text = "IP Address entered: " + ipAddress;

            if (ServerRadioButton.Checked)
            {
                SocketListener.StartServer(OutputTextBox, ipAddress);
            }
            else
            {
                SocketClient.StartClient(OutputTextBox, ipAddress);
            }
        }

        private void ServerRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClientRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}