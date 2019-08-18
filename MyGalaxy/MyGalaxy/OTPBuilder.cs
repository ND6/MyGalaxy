using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MyGalaxy
{
    class OTPBuilder
    {
        private static OTPBuilder OTPbuilder;
        public static OTPBuilder Instance()
        {
            if (OTPbuilder == null)
                OTPbuilder = new OTPBuilder();
            return OTPbuilder;
        }
        static string HashKey = "123";
        static string HashText = " ";
        static byte[] key = { 0xf0, 0xff };
        static byte[] text = { 0xff, 0xff };
        //Encoding encoder = Encoding.UTF8;
        //byte[] hashBytes = compute (fs, algName);
        //System.Security.Cryptography
        public static string GetOneSecondOTP()
        {
            using (HMACSHA1 hmac = new HMACSHA1(key))
            {
                do
                {
                    string stext = Convert.ToString(DateTime.UtcNow);
                    byte[] text = Encoding.UTF32.GetBytes(stext);
                    byte[] hashvalue = hmac.ComputeHash(text);
                    string oneSecondOTP = GetOTPString(hashvalue, 6);
                    return oneSecondOTP;
                } while (true);
            }
        }
        public static string GetTenMinOTP()
        {
            using (HMACSHA1 hmac = new HMACSHA1(key))
            {
                do
                {
                    string stext = Convert.ToString(((int)(DateTime.UtcNow-DateTime.MinValue).TotalMinutes)/10);
                    byte[] text = Encoding.UTF32.GetBytes(stext);
                    byte[] hashvalue = hmac.ComputeHash(text);
                    string oneSecondOTP = GetOTPString(hashvalue, 6);
                    return oneSecondOTP;
                } while (true);
            }
        }
        /// <summary>
        /// 将hash数组转换成数字码
        /// </summary>
        /// <param name="hashvalue"></param>
        /// <param name="otpLength">偶数长度的otp，最长为40位</param>
        /// <returns></returns>
        private static string GetOTPString(byte[] hashvalue,int otpLength)
        {
            int len = otpLength/2;
            for (int i = 0; i < len; i++)
            {
                hashvalue[i] = (byte)(hashvalue[i] & 0x99);
            }
            byte[] tag = new byte[len];
            Array.Copy(hashvalue, 0, tag, 0, 3);
            string OTPstring = BitConverter.ToString(tag).Replace("-", "-");
            return OTPstring;
        }


    }
}
