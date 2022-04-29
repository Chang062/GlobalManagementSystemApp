using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalManagementSystemApp
{
    internal class gmsUtil
    {

        public static string EncryptedPW(string password)
        {
            SHA256 encryp = SHA256.Create();
            //Convert input String to a byte array and compute hash
            byte[] data = encryp.ComputeHash(Encoding.UTF8.GetBytes(password));
            //create a string builder to collect the bytes and create string
            StringBuilder sBuilder = new StringBuilder();

            //loop through each byte of hashed data and format each one as a hexadecimal
            for (int interator = 0; interator < data.Length; interator++)
            {
                sBuilder.Append(data[interator].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static bool FormIsOpnen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(openForm => openForm.GetType() == formtype);
        }

        public static string DefaultPassword()
        {
            SHA256 encryp = SHA256.Create();
            //Convert input String to a byte array and compute hash
            byte[] data = encryp.ComputeHash(Encoding.UTF8.GetBytes("2@change"));
            //create a string builder to collect the bytes and create string
            StringBuilder sBuilder = new StringBuilder();

            //loop through each byte of hashed data and format each one as a hexadecimal
            for (int interator = 0; interator < data.Length; interator++)
            {
                sBuilder.Append(data[interator].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static string Admin()
        {

            var admin_usr = "Administrator";

            return admin_usr;

        }

        public static string ViewOnly()
        {
            var usr = "View Only";

            return usr;
        }
    }
}
