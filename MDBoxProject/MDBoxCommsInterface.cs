using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MDBoxProject
{
    public class MDBoxCommsInterface
    {
        private UdpClient Client;
        public bool Use10Axis { get; set; }

        #region Constructors

        public MDBoxCommsInterface(string hostName, int senderPort, int receiverPort)
        {
            Client = new UdpClient(senderPort);
            var endpoint = new IPEndPoint(IPAddress.Parse(hostName), receiverPort);
            Client.Connect(endpoint);
        }

        public MDBoxCommsInterface(int senderPort, int receiverPort)
        {
            Client = new UdpClient(senderPort);
            var endpoint = new IPEndPoint(IPAddress.Broadcast, receiverPort);
            Client.Connect(endpoint);
        }
        #endregion Constructors

        #region Commands

        public void Test()
        {
            Send(Encoding.ASCII.GetBytes("test"));
        }

        public void GoToMaxPosition()
        {
            Send(Use10Axis ? Constants.GOTO_MAX_10AXIS.GetBytesFromEscapedString(): Constants.GOTO_MAX.GetBytesFromEscapedString());
        }

        public void GoToZero()
        {
            Send(Use10Axis ? Constants.GO_TO_ZERO_10AXIS.GetBytesFromEscapedString() : Constants.GOTO_ZERO.GetBytesFromEscapedString());
        }

        #endregion Commands

        #region Helpers

        private void Send(byte[] data)
        {
            try
            {
                Client.Send(data, data.Length);
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        #endregion Helpers
    }
}
