using Keysight.Ccl.Wsl.UI;
using MVVMCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MainApplication.SecuritySample
{
  /// <summary>
  /// Interaction logic for Encrypt_Decrypt.xaml
  /// </summary>
  public partial class Encrypt_Decrypt : WslDialog
  {
    public Encrypt_Decrypt()
    {
      InitializeComponent();
     
    }

    string hash = "SanjayGupta";

    private void btnE_Click(object sender, RoutedEventArgs e)
    {
      byte[] data = UTF8Encoding.UTF8.GetBytes(txtVlue.Text);
      using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
      {
        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        using (TripleDESCryptoServiceProvider tripDesc  = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7})
        {
          ICryptoTransform transform = tripDesc.CreateEncryptor();
          byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
          txtEncrypt.Text = Convert.ToBase64String(results, 0, results.Length);

        }

      }
    }

    private void btnD_Click(object sender, RoutedEventArgs e)
    {
      byte[] data = Convert.FromBase64String(txtEncrypt.Text);
      using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
      {
        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        using (TripleDESCryptoServiceProvider tripDesc = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
        {
          ICryptoTransform transform = tripDesc.CreateDecryptor();
          byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
          txtDecrypt.Text = UTF8Encoding.UTF8.GetString(results);

        }
      }
    }
  }
} 
