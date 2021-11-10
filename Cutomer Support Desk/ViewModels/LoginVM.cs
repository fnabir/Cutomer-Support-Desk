using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cutomer_Support_Desk.ViewModels
{
    public class LoginVM : BaseVM
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand SubmitCommand { get; }


        static byte[] GenerateSaltedHash(string userpassword, byte[] salt)
        {
            byte[] strtobytPass = Encoding.UTF8.GetBytes(userpassword);
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[strtobytPass.Length + salt.Length];

            for (int i = 0; i < strtobytPass.Length; i++)
            {
                plainTextWithSaltBytes[i] = strtobytPass[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[strtobytPass.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        public static bool Passwordcheck(byte[] inputPassword, byte[] setPassword)
        {
            if (inputPassword.Length != setPassword.Length)
            {
                return false;
            }

            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (inputPassword[i] != setPassword[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
