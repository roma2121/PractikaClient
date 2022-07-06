using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;


namespace ClientS
{
    public partial class Client : Form
    {
        static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;

        static AES objAes;
        static RSA objRsa;

        static byte[] aesPubKey;

        public Client(string name)
        {
            InitializeComponent();

            userName = name;

            objAes = new AES();
            objRsa = new RSA();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            Connection();
        }

        private void отключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disconnect();
            Environment.Exit(0);
        }

        private void Connection()
        {
            client = new TcpClient();
            try
            {
                client.Connect(host, port);
                stream = client.GetStream();

                string message = userName;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // запускаем новый поток для получения данных
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start(); //старт потока
                richTextBox1.Text += $"Добро пожаловать, {userName}";


                KeyTransfer();
            }
            catch (Exception ex)
            {
                richTextBox1.Text += ex.Message;
            }
        }

        private void KeyTransfer()
        {
            string s = "rsaKey:" + Convert.ToBase64String(objRsa.GetPublicKey());
            // Байты для отправки через сокет
            byte[] data = Encoding.Unicode.GetBytes(s);
            stream.Write(data, 0, data.Length);
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = objAes.Decrypt(richTextBox1.Text, aesPubKey);
        }

        static void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64];
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();

                    if (message.Contains("aesKey:"))
                    {
                        byte[] key = objRsa.Decrypt(message.Substring("aesKey:".Length));


                        aesPubKey = key;
                    }
                    else
                    {
                        richTextBox1.Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.Text = message;
                        });
                    }
                }
                catch
                {
                    Disconnect();
                    MessageBox.Show("Подключение прервано!");
                    Environment.Exit(0);
                }
            }
        }

        static void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }
    }
}
