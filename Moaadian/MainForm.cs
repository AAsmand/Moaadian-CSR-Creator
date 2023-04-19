
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Moaadian
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cmbType.Text = "";
            cmbType.Items.Clear();
            cmbType.ValueMember = "value";
            cmbType.DisplayMember = "Text";
            cmbType.Items.Add(new PersonType { Value = "Governmental", Text = "حقوقی وابسته به دولت" });
            cmbType.Items.Add(new PersonType { Value = "Non-Governmental", Text = "حقوقی وابسته به غیر دولت" });
            cmbType.SelectedIndex= 0;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnSaveKeyAddress_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "MyKey";
            saveFileDialog.Filter = "Key files (*.key)|*.key";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                SaveKeyAddressTxt.Text = fileName;
            }
        }

        private void btnSaveCSRAddress_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "MyCSR";
            saveFileDialog.Filter = "CSR files (*.csr)|*.csr";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                SaveCSRAddressTxt.Text = fileName;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtNationalCode.Text) || cmbType.SelectedItem == null)
            {
                MessageBox.Show("لطفا مقادیر اجباری را به درستی وارد نمائید", "عملیات ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(btnSaveCSRAddress.Text) || string.IsNullOrEmpty(SaveKeyAddressTxt.Text))
            {
                MessageBox.Show("لطفا محل ذخیره فایل ها را انتخاب نمائید", "عملیات ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var distinguishedName = new List<(string, string)>();

            if (!string.IsNullOrEmpty(txtFullName.Text)) distinguishedName.Add(("CN", txtFullName.Text+" [Stamp]"));
            if (!string.IsNullOrEmpty(txtNationalCode.Text)) distinguishedName.Add(("SERIALNUMBER", txtNationalCode.Text));
            if (cmbType.SelectedItem != null) distinguishedName.Add(("O", ((PersonType)cmbType.SelectedItem).Value));
            if (!string.IsNullOrEmpty(txtOrganizationPart2.Text)) distinguishedName.Add(("OU", txtOrganizationPart2.Text));
            if (!string.IsNullOrEmpty(txtOrganizationPart1.Text)) distinguishedName.Add(("OU", txtOrganizationPart1.Text));
            if (!string.IsNullOrEmpty(txtOrganizationName.Text)) distinguishedName.Add(("OU", txtOrganizationName.Text));
            distinguishedName.Add(("C", "IR"));

            var key = RSA.Create(2048);
            var certificateRequest = new CertificateRequest(
            new X500DistinguishedName(BuildDistinguishedName(distinguishedName), System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags.UseUTF8Encoding),
            key,
            HashAlgorithmName.SHA256,
            RSASignaturePadding.Pkcs1);
            certificateRequest.CertificateExtensions.Add(new X509BasicConstraintsExtension(false, false, 0, false));
            certificateRequest.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.NonRepudiation, false));
            certificateRequest.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(new OidCollection { new Oid("1.3.6.1.5.5.7.3.1") }, false));

            var csrBytes = certificateRequest.CreateSigningRequest();
            var privateKeyBytes = key.ExportPkcs8PrivateKey();
            var publicKeyBytes=key.ExportRSAPublicKey();

            var privateKey = Convert.ToBase64String(privateKeyBytes);
            var publicKey = Convert.ToBase64String(publicKeyBytes);
            var csr = Convert.ToBase64String(csrBytes);

            File.WriteAllText(SaveCSRAddressTxt.Text, csr);
            File.WriteAllText(SaveKeyAddressTxt.Text, privateKey);
            File.WriteAllText(SaveKeyAddressTxt.Text.Replace(".key",".txt"), publicKey);
            MessageBox.Show("گواهی و کلید شما صادر شد","عملیات موفق",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
        private static string BuildDistinguishedName(List<(string, string)> distinguishedName)
        {
            var builder = new StringBuilder();

            foreach (var kvp in distinguishedName)
            {
                builder.Append($"{kvp.Item1}={kvp.Item2},");
            }

            return builder.ToString().TrimEnd(',');
        }

        private void txtFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
                errorProvider.SetError(txtFullName, "وارد کردن فیلد نام سازمان به انگلیسی، الزامی است");
            else
                errorProvider.SetError(txtFullName, "");
        }

        private void cmbType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbType.SelectedItem==null)
                errorProvider.SetError(cmbType, "انتخاب نوع شخص اجباری است");
            else
                errorProvider.SetError(cmbType, "");
        }

        private void txtNationalCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalCode.Text))
                errorProvider.SetError(txtNationalCode, "وارد کردن فیلد شناسه 11 رقمی سازمان، الزامی است");
            else
                errorProvider.SetError(txtNationalCode, "");
            if (txtNationalCode.Text.Length!=11)
                errorProvider.SetError(txtNationalCode, "طول شناسه ملی سازمان باید 11 رقم باشد");
            else
                errorProvider.SetError(txtNationalCode, "");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.sepidarsystem.com") { UseShellExecute = true };
            Process.Start(sInfo);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(this.pictureBox1, "سپیدار سیستم آسیا");
        }
    }
}