using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace WMIClass
{
    public partial class Form1 : Form
    {
        enum HashType : byte
        {
            MD5, SHA256, SHA512
        }

        ManagementObjectSearcher searcher = new ManagementObjectSearcher();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor WHERE Name IS NOT NULL AND ProcessorId IS NOT NULL");
            foreach (ManagementObject queryObj in searcher.Get())
                cmb_processor.Items.Add(queryObj.Properties["Name"].Value.ToString());
            searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive WHERE Caption IS NOT NULL AND SerialNumber IS NOT NULL");
            foreach (ManagementObject queryObj in searcher.Get())
                cmb_diskdrive.Items.Add(queryObj.Properties["Caption"].Value.ToString());
            searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapter WHERE Name IS NOT NULL AND GUID IS NOT NULL AND MACAddress IS NOT NULL AND PhysicalAdapter=True");
            foreach (ManagementObject queryObj in searcher.Get())
                cmb_networkadapter.Items.Add(queryObj.Properties["Name"].Value.ToString());
            progressBar1.Value = 100;
        }

        private void cmb_processor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_processor.SelectedIndex > -1)
            {
                progressBar1.Value = 0;
                searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor WHERE Name ='" + cmb_processor.Items[cmb_processor.SelectedIndex] + "'");
                foreach (ManagementObject queryObj in searcher.Get())
                    txt_procid.Text = queryObj.Properties["ProcessorId"].Value.ToString().Replace("-", "").Trim(new char[] { ' ', '{', '}', '-' });
                progressBar1.Value = 100;
            }
        }

        private void cmb_diskdrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_diskdrive.SelectedIndex > -1)
            {
                progressBar1.Value = 0;
                searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive WHERE Caption ='" + cmb_diskdrive.Items[cmb_diskdrive.SelectedIndex] + "'");
                foreach (ManagementObject queryObj in searcher.Get())
                    txt_diskserial.Text = queryObj.Properties["SerialNumber"].Value.ToString().Replace("-", "").Trim(new char[] { ' ', '{', '}', '-' });
                progressBar1.Value = 100;
            }
        }

        private void cmb_networkadapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_networkadapter.SelectedIndex > -1)
            {
                progressBar1.Value = 0;
                searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapter WHERE Name ='" + cmb_networkadapter.Items[cmb_networkadapter.SelectedIndex] + "'");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    txt_networkguid.Text = queryObj.Properties["GUID"].Value.ToString().Replace("-", "").Trim(new char[] { ' ', '{', '}', '-' });
                    txt_mac.Text = queryObj.Properties["MACAddress"].Value.ToString().Replace("-", "").Replace(":", "").Trim(new char[] { ' ', '{', '}', '-' });
                }
                progressBar1.Value = 100;
            }
        }

        private void btn_generatehwid_Click(object sender, EventArgs e)
        {
            if (txt_procid.TextLength > 0 && txt_diskserial.TextLength > 0 && txt_networkguid.TextLength > 0 && txt_mac.TextLength > 0)
            {
                progressBar1.Value = 0;
                string input = string.Join("", new string[] { txt_procid.Text, txt_diskserial.Text, txt_networkguid.Text, txt_mac.Text });
                txt_md5.Text = GenerateHash(HashType.MD5, input); 
                txt_sha256.Text = GenerateHash(HashType.SHA256, input); 
                txt_sha512.Text = GenerateHash(HashType.SHA512, input); 
                lbl_md5.Text = txt_md5.TextLength.ToString();
                lbl_sha256.Text = txt_sha256.TextLength.ToString();
                lbl_sha512.Text = txt_sha512.TextLength.ToString();
                progressBar1.Value = 100;
            }
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            txt_md5.Text = "";
            txt_sha256.Text = "";
            txt_sha512.Text = "";
            lbl_md5.Text = txt_md5.TextLength.ToString();
            lbl_sha256.Text = txt_sha256.TextLength.ToString();
            lbl_sha512.Text = txt_sha512.TextLength.ToString();
        }

        private string GenerateHash(HashType hashType, string inputString)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(inputString);
            byte[] hashBytes = { };
            switch ((byte)hashType)
            {
                case 0:
                    {
                        using (var hashAlgorithm = System.Security.Cryptography.MD5.Create())
                            hashBytes = hashAlgorithm.ComputeHash(inputBytes);
                        break;
                    }
                case 1:
                    {
                        using (var hashAlgorithm = System.Security.Cryptography.SHA256.Create())
                            hashBytes = hashAlgorithm.ComputeHash(inputBytes);
                        break;
                    }
                case 2:
                    {
                        using (var hashAlgorithm = System.Security.Cryptography.SHA512.Create())
                            hashBytes = hashAlgorithm.ComputeHash(inputBytes);
                        break;
                    }
            }
            return ByteToHex(hashBytes);
        }

        string ByteToHex(byte[] byteArray)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < byteArray.Length; i++)
                sb.Append(byteArray[i].ToString("X2"));
            return sb.ToString();
        }
    }
}
