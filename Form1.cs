using System.Net;
using System.Net.Sockets;


namespace UckApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString()+ " "+DateTime.Now.ToLongTimeString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SD");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bilgisayarAdi = Dns.GetHostName();
            textBox2.Text = bilgisayarAdi;
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            textBox3.Text =ipAdresi;
            timer1.Start();

            textBox1.Text = System.Windows.Forms.SystemInformation.UserName;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
