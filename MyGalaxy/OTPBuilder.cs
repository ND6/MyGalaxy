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
        static byte[] inkey = { 0xf0, 0xff };
        //static byte[] text = { 0xff, 0xff };
        //Encoding encoder = Encoding.UTF8;
        //byte[] hashBytes = compute (fs, algName);
        //System.Security.Cryptography
        public static string GetOneSecondOTP(byte[] key = null)
        {
            if(key==null)
                key = inkey;
            using (HMACSHA1 hmac = new HMACSHA1(key))
            {
                    string stext = Convert.ToString(DateTime.UtcNow);
                    byte[] text = Encoding.UTF32.GetBytes(stext);
                    byte[] hashvalue = hmac.ComputeHash(text);
                    string oneSecondOTP = GetOTPString(hashvalue, 6);
                    return oneSecondOTP;
            }
        }
        public static string GetTenMinOTP(byte[] key = null)
        {
            if (key == null)
                key = inkey;
            using (HMACSHA1 hmac = new HMACSHA1(key))
            {
                    string stext = Convert.ToString(((int)(DateTime.UtcNow-DateTime.MinValue).TotalMinutes)/10);
                    byte[] text = Encoding.UTF32.GetBytes(stext);
                    byte[] hashvalue = hmac.ComputeHash(text);
                    string oneSecondOTP = GetOTPString(hashvalue);
                    return oneSecondOTP;
            }
        }
        /// <summary>
        /// 将hash数组转换成数字码
        /// </summary>
        /// <param name="hashvalue"></param>
        /// <param name="otpLength"></param>
        /// <returns></returns>
        private static string GetOTPString(byte[] hashvalue,int otpLength=6)
        {
            if(otpLength<1)
                throw new Exception("动态密码长度不能为0");
            int len = (Int32)Math.Pow(10, otpLength);
            int index = hashvalue[0] & 0xf;
            int binary =
               ((hashvalue[index] & 0x7f) << 24) |
               ((hashvalue[index + 1] & 0xff) << 16) |
               ((hashvalue[index + 2] & 0xff) << 8) |
               (hashvalue[index + 3] & 0xff);
            int tag = binary % len;
            string OTPstring = string.Format("{0:d6}", tag);
            return OTPstring;
        }


    }
}
