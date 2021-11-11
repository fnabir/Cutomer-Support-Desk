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


        static byte[] GenerateSaltedHash(string stringPassword, byte[] salt)
        {
            byte[] bytePassword = Encoding.UTF8.GetBytes(stringPassword);
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] passwordSaltBytes =
              new byte[bytePassword.Length + salt.Length];

            for (int i = 0; i < bytePassword.Length; i++)
            {
                passwordSaltBytes[i] = bytePassword[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                passwordSaltBytes[bytePassword.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(passwordSaltBytes);
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
