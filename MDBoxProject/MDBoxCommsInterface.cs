using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MDBoxProject
{
    public class MDBoxCommsInterface
    {
        private UdpClient Client;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the Class MDBoxCommsInterface by providing the subnet to broadcast,
        /// the port used by the underlying socket to send packets and the destination port to the message.
        /// </summary>
        /// <param name="bcSubnet">Subnet address which you want to broadcast to.</param>
        /// <param name="senderPort">Port used to send packets. Range: 1024 ~  65535.</param>
        /// <param name="receiverPort">Port which will be used by the receiver to get the packets. Range: 1024 ~  65535.</param>
        public MDBoxCommsInterface(string bcSubnet, int senderPort, int receiverPort)
        {
            Client = new UdpClient(senderPort);
            var endPoint = new IPEndPoint(IPAddress.Parse(bcSubnet), receiverPort);
            Client.EnableBroadcast = true;
            Client.Connect(endPoint);
        }

        /// <summary>
        /// Initializes a new instance of the Class MDBoxCommsInterface using the default subnet to broadcast,
        /// the port used by the underlying socket to send packets and the destination port of the packet.
        /// </summary>
        /// <param name="senderPort">Port used to send packets. Range: 1024 ~  65535.</param>
        /// <param name="receiverPort">Port which will be used by the receiver to get the packets. Range: 1024 ~  65535.</param>
        public MDBoxCommsInterface(int senderPort, int receiverPort)
        {
            Client = new UdpClient(senderPort);
            var endpoint = new IPEndPoint(IPAddress.Broadcast, receiverPort);
            Client.Connect(endpoint);
        }
        #endregion Constructors

        #region Commands

        /// <summary>
        /// Command used to test the socket. Do not use to communicate with M-Box
        /// </summary>
        public void Test()
        {
            Send(Encoding.ASCII.GetBytes("test"));
        }

        /// <summary>
        /// Send a packet containing the required commands to tell M-Box to go to max position for 6-Axis mode.
        /// </summary>
        public void GoToMaxPosition()
        {
            Send(Constants.GOTO_MAX);
        }

        /// <summary>
        /// Send a packet containing the required commands to tell M-Box to go to 0 position for 6-Axis mode.
        /// </summary>
        public void GoToZero()
        {
            Send(Constants.GOTO_ZERO);
        }

        #endregion Commands

        #region Helpers

        /// <summary>
        /// Tires to send a packet to the specified UDP socket.
        /// </summary>
        /// <param name="data">Command in byte array mode.</param>
        private void Send(byte[] data)
        {
            try
            {
                Client.Send(data, data.Length);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        #endregion Helpers
    }
}
