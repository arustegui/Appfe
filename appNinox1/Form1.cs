namespace appNinox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cuit_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cuit = txtCuit.Text;
            string rSocial = txtRsocial.Text;
            string comandoCsr = $"C:\\OpenSSL-Win64\\bin\\OpenSSL.exe req -new -key privada -subj \"/C=AR/O={rSocial}/CN=ninoxnet2022/serialNumber=CUIT {cuit}\" -out pedido";

            txtCsr.Text = comandoCsr;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtCsr_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cp = txtCp.Text;
            string comandoCp = $"C:\\OpenSSL-Win64\\bin\\OpenSSL.exe genrsa -out privada 2048";

            txtCp.Text = comandoCp;
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string aliasp12 = txtAliasp12.Text;
            string comandoAliasp12 = $"C:\\OpenSSL-Win64\\bin\\OpenSSL.exe pkcs12 -export -inkey privada -in resultado.crt -out alias.p12";

            txtAliasp12.Text = aliasp12;
        }

        private void btnCopiarcp_Click(object sender, EventArgs e)
        {
            string btnGenerar = Clipboard.SetText(txtCp.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }