using System.Security.Cryptography;
using System.Text;

namespace Javascript_hash_with_CSharp_hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string data = txtData.Text;

            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
                txtResult.Text = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }

            if (txtResult.Text == txtJS_Hash.Text)
            {
                MessageBox.Show("Data is equal");
            }

            else MessageBox.Show("DATA IS NOT EQUAL");
        }
    }
}