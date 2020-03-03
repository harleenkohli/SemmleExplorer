using System;
using System.Security.Cryptography;

namespace InadequateRSAPadding
{
    class Main
    {

        static public byte[] EncryptWithRSAAndNoPadding(byte[] plaintext, RSAParameters key) {
             try {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.ImportParameters(key);
                return rsa.Encrypt(plaintext, false); // VIOLATION
            }
            catch(CryptographicException e) {
                 Console.WriteLine(e.Message);
                return null;
            }
        }

        static public byte[] EncryptWithRSAAndPadding(byte[] plaintext, RSAParameters key) {
             try {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.ImportParameters(key);
                return rsa.Encrypt(plaintext, true); // NON-VIOLATION
            }
            catch(CryptographicException e) {
                 Console.WriteLine(e.Message);
                return null;
            }
        }

    }

}
