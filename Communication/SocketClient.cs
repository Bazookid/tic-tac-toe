using System.Net;
using System.Net.Sockets;
using System.Text;

// Client app is the one sending messages to a Server/listener.
// Both listener and client can send messages back and forth once a
// communication is established.
public class SocketClient
{
    public static void StartClient(RichTextBox textBox, string hostIpAddress)
    {
        byte[] bytes = new byte[1024];

        try
        {
            // Connect to a Remote server
            // Get Host IP Address that is used to establish a connection
            // If "localhost" is entered, we get one IP address that is IP : 127.0.0.1
            // If a host has multiple addresses, you will get a list of addresses
            IPHostEntry host = Dns.GetHostEntry(hostIpAddress);
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

            // Create a TCP/IP  socket.
            Socket sender = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Connect the socket to the remote endpoint. Catch any errors.
            try
            {
                // Connect to Remote EndPoint
                sender.Connect(remoteEP);

                textBox.AppendText("Socket connected to " + sender.RemoteEndPoint.ToString());

                // Encode the data string into a byte array.
                byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                // Send the data through the socket.
                int bytesSent = sender.Send(msg);

                // Receive the response from the remote device.
                int bytesRec = sender.Receive(bytes);
                textBox.AppendText("Echoed test = " + Encoding.ASCII.GetString(bytes, 0, bytesRec));

                // Release the socket.
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();

            }
            catch (ArgumentNullException ane)
            {
                textBox.AppendText("ArgumentNullException : " + ane.ToString());
            }
            catch (SocketException se)
            {
                textBox.AppendText("SocketException : " + se.ToString());
            }
            catch (Exception e)
            {
                textBox.AppendText("Unexpected exception : " +  e.ToString());
            }

        }
        catch (Exception e)
        {
            textBox.AppendText(e.ToString());
        }
    }
}