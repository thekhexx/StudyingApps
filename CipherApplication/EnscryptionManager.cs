using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace CipherApplication
{
    class EnscryptionManager
    {
        public byte[][] internalKey; //generateInternalKey, addRoundKey

        public void generateAllInternalKey(string key) //men-generate internal key pseudo random
        {
            byte[] byteKey = Encoding.ASCII.GetBytes(key);
            byte[] firstHalfInternalKey = new byte[key.Length / 2];
            byte[] secondHalfInternalKey = new byte[key.Length / 2];

            //initialize internalKey
            internalKey = new byte[10][];
            for (int i = 0; i < 10; i++)
            {
                internalKey[i] = new byte[key.Length / 2];
            }

            //integer seed
            int sumKey = 0;
            for (int i = 0; i < key.Length; i++)
                sumKey += (int)key[i];

            //generate (i = 10) internal key
            Random rnd = new Random(sumKey);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < key.Length / 2; j++)
                {
                    firstHalfInternalKey[j] = (byte)rnd.Next(255); //random max value = 255 (ASCII)
                    secondHalfInternalKey[j] = (byte)rnd.Next(255);
                    secondHalfInternalKey[j] = (byte)rnd.Next(255);
                    internalKey[i][j] = (byte)(firstHalfInternalKey[j] ^ secondHalfInternalKey[j]);
                }
            }
        }

        public byte[] generateNewVector(byte[] input) //generate IV
        {
            int sum = 0;
            byte[] result = new byte[input.Length];
            for (int i = 0; i < 10; i++)
                sum += internalKey[i][1];

            Random rnd = new Random(sum);
            for (int i = 0; i < input.Length; i++)
            {
                result[i] = (byte)(rnd.Next() % 255); //random max value = 255 (ASCII)
                result[i] = (byte)(rnd.Next() % 255); //random max value = 255 (ASCII)
            }
            return result;
        }

        public byte[] addRoundKey(byte[] b) 
        {
            byte[] roundKey = generateNewVector(b);
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = (byte)((b[i] ^ roundKey[i]) ^ internalKey[i % 10][i % 4]);

            }
            return b;
        }

        //tabel lookup 
        private static readonly byte[] TABLE = new byte[] { 0x26, 0xdc, 0xff, 0x00, 0xad, 0xed, 0x7a, 0xee, 0xc5, 0xfe, 0x07, 0xaf, 0x4d, 0x08, 0x22, 0x3c };
        public static byte[] Substitusi(byte[] b, string key)
        {
            MemoryStream memoryStream;
            CryptoStream cryptoStream;
            Rijndael rijndael = Rijndael.Create();
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(key, TABLE);
            rijndael.Key = pdb.GetBytes(32);
            rijndael.IV = pdb.GetBytes(16);
            memoryStream = new MemoryStream();
            cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(b, 0, b.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }

        public byte[] transpose(byte[] b)
        {
            UInt32 length = (UInt32)b.Length;

            Fibonacci fib = new Fibonacci();
            fib.start();

            //initialize value, i=1, j=2
            UInt32 i = fib.next(), j = fib.next();

            //from-start tranposition
            while (j < length)
            {
                Byte temp = b[i];
                b[i] = b[j];
                b[j] = temp;

                i = j; j = fib.next();
            }

            //from-end transposition
            fib.start();
            //initialize i=1, j=2
            i = fib.next(); j = fib.next();

            while (j < length)
            {
                Byte temp = b[length - i - 1];
                b[length - i - 1] = b[length - j - 1];
                b[length - j - 1] = temp;

                i = j; j = fib.next();
            }

            return b;
        }

        public byte[] feistel(byte[] plain, byte[][] b)
        {
            

            int totalRound = 9;

            //temp var
            byte[] L = new byte[b[0].Length];
            byte[] R = new byte[b[0].Length];

            //res var
            byte[] resL = new byte[b[0].Length];
            byte[] resR = new byte[b[0].Length];
            byte[] res = new byte[plain.Length];

            for (int left = 0; left < plain.Length / 2; left++)
            {
                resL[left] = plain[left];
                L[left] = plain[left];
            }
            for (int right = plain.Length / 2; right < plain.Length - plain.Length % 2; right++)
            {
                resR[right - plain.Length / 2] = plain[right];
                R[right - plain.Length / 2] = plain[right];
            }

           
            int j = 0;
            do
            {
                for (int i = 0; i < R.Length; i++)
                {
                    R[i] = resR[i];
                }
                for (int i = 0; i < L.Length; i++)
                {
                    L[i] = (byte)(resL[i] ^ (R[i] ^ b[j][i]));
                }
                for (int x = 0; x < L.Length; x++)
                {
                    resR[x] = L[x];
                }
                for (int y = 0; y < R.Length; y++)
                {
                    resL[y] = R[y];
                }
              

                j++;
            } while (j < totalRound);

            for (int i = 0; i < R.Length; i++)
            {
                R[i] = resR[i];
            }
            for (int i = 0; i < L.Length; i++)
            {
                L[i] = (byte)(resL[i] ^ (R[i] ^ b[9][i]));
            }
            for (int x = 0; x < L.Length; x++)
            {
                resR[x] = R[x];
            }
            for (int y = 0; y < R.Length; y++)
            {
                resL[y] = L[y];
            }

          

            for (int i = 0; i < resL.Length; i++)
            {
                res[i] = resL[i];
            }
            for (int i = 0; i < resR.Length; i++)
            {
                res[i + resR.Length] = resR[i];
            }
            if (plain.Length % 2 != 0) res[plain.Length - 1] = plain[plain.Length - 1];
            
            return res;
        }

        internal byte[] encrypt(byte[] blokPlain, byte[] key)
        {
            generateAllInternalKey(Encoding.ASCII.GetString(key));
            byte[] result = blokPlain;
            result = addRoundKey(result);
            int loop = 3;
            for (int i = 0; i < loop; i++)
            {

                result = transpose(result);
                result = feistel(result, internalKey);
                result = addRoundKey(result);
            }

            
            result = transpose(result);
            result = addRoundKey(result);
            return result;
        }
    }
}
