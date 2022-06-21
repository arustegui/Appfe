using System.Diagnostics;

namespace appNinox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarP12_Click(object sender, EventArgs e)
        {
            string comandoAliasp12 = $"C:\\OpenSSL-Win64\\bin\\OpenSSL.exe pkcs12 -export -inkey privada -in resultado.crt -out alias.p12";

            txtAliasp12.Text = comandoAliasp12;
        }

        private void btnCopiarcp_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCp.Text);
        }

        private void btnCopiarCsr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCsr.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRsocial.Text = String.Empty;
            txtCuit.Text = String.Empty;
            txtErpAlias.Text = String.Empty;
            txtCp.Text = String.Empty;
            txtCsr.Text = String.Empty;
            txtAliasp12.Text = String.Empty;
            txtVencimiento.Text = String.Empty;
        }

        private void btnCrearCarpeta_Click(object sender, EventArgs e)
        {
            string rootDir = AppDomain.CurrentDomain.BaseDirectory;
            string dataDir = Path.Combine(rootDir, "data");

            string aliasNinox = txtErpAlias.Text;
            string aliasDir = Path.Combine(dataDir, aliasNinox);

            if (Directory.Exists(aliasDir))
            {
                MessageBox.Show("Carpeta Existe");
                Process.Start("explorer.exe", aliasDir);
            } 
            
            else
            {
                MessageBox.Show("Creando la carpeta...");
                System.IO.Directory.CreateDirectory(aliasDir);
                Process.Start("explorer.exe", aliasDir);
            }
        }

        private void btnGenerarCpCsr_Click(object sender, EventArgs e)
        {
            string comandoCp = $"C:\\OpenSSL-Win64\\bin\\OpenSSL.exe genrsa -out privada 2048";
 
            txtCp.Text = comandoCp;

            string cuit = txtCuit.Text;
            string rSocial = txtRsocial.Text;
            string comandoCsr = $"C:\\OpenSSL-Win64\\bin\\OpenSSL.exe req -new -key privada -subj \"/C=AR/O={rSocial}/CN=ninoxnet2022/serialNumber=CUIT {cuit}\" -out pedido";

            txtCsr.Text = comandoCsr;

        }

    }

}