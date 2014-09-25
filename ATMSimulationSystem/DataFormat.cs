using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Drawing.Imaging;

namespace ATMManager
{
    class DataFormat
    {
        /// <summary> 
        /// serialization  
        /// </summary> 
        /// <param name="data">serialization object</param> 
        /// <returns>return data buffer</returns> 
        public static byte[] ObjectToBytes(object data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream rems = new MemoryStream();
            formatter.Serialize(rems, data);
            return rems.GetBuffer();
        }

        /// <summary> 
        /// Deserialization 
        /// </summary> 
        /// <param name="data">data buffer</param> 
        /// <returns>object</returns> 
        public static object ByATMManageroObject(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream rems = new MemoryStream(data);
            data = null;
            return formatter.Deserialize(rems);
        }


        /// <summary>
        /// transfer byte[] to Image
        /// </summary>
        public static Image ByteArrayToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
        /// <summary>
        /// transfer Image to byte[]
        /// </summary>
        public static byte[] ImageToBytes(Image image)
        {
            //MemoryStream Ms = new MemoryStream();
            //image.Save(Ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] bytes = new byte[Ms.Length];
            //Ms.Read(bytes, 0, DataFormat.StringToInt(Ms.Length));
            //Ms.Close();
            //return bytes;
            return null;
        }
        /// <summary>
        /// return binary data
        /// </summary>
        /// <param name="path">return file path</param>
        /// <returns></returns>
        public static byte[] FileToBytes(string path)
        {
            System.IO.Stream m_stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
            byte[] m_bytes = new byte[m_stream.Length];
            m_stream.Read(m_bytes, 0, m_bytes.Length);
            m_stream.Close();
            return m_bytes;
        }


        public static string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }




        /// <summary>
        /// transfer stream to byte[]
        /// </summary>
        public static byte[] StreamToBytes(Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            // set current stream as the beginning of the stream
            stream.Seek(0, SeekOrigin.Begin);
            return bytes;
        }
        /// <summary> 
        /// transfer byte[] to Stream 
        /// </summary> 
        public static Stream BytesToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }

        /// <summary>
        /// Digital string to number conversion
        /// </summary>
        public static int StringToInt(string value)
        {
            int number = 0;
            int.TryParse(value, out number);
            return number;
        }
        /// <summary>
        ///Digital string to number conversion
        /// </summary>
        public static float StringToFloat(string value)
        {
            float number = 0;
            float.TryParse(value, out number);
            return number;
        }
        /// <summary>
        /// Convert a string to a date type
        /// </summary>
        public static DateTime StringToDateTime(string value)
        {
            DateTime number = DateTime.Now;
            DateTime.TryParse(value, out number);
            return number;
        }
        /// <summary>
        /// 
        /// </summary>
        public static bool StringToBool(string value)
        {
            bool number = false;
            bool.TryParse(value, out number);
            return number;
        }


        #region format determination
        /// <summary>
        /// Determine the Value value is numeric format
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDoubleNumeric(string value)
        {
            try
            {
                double.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// To judge whether the value is of type double value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool isdoubleNumber(string value)
        {
            double i = 0.0f;
            return double.TryParse(value, out i);
        }

        /// <summary>
        /// Judge mailbox format is correct
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEmail(string value)
        {
            Regex myreg = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            return myreg.IsMatch(value);
        }

        /// <summary>
        /// Mobile phone number format is correct judgment
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsValatePhoneNo(string number)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(number, @"^(?:0(?:10|2[0-57-9]|[3-9]\d{2})[--]?)\d{7,8}$"))
            {
                return true;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(number, "^1\\d{10}$"))
            {
                return true;
            }
            return false;
            //return System.Text.RegularExpressions.Regex.IsMatch(number, @"(?:13\d|15[89])-?\d{5}(\d{3}|\*{3})");
        }

        /// <summary>
        /// Phone number or fax
        /// </summary>
        /// <param name="str_Phone"></param>
        /// <returns></returns>
        public static bool IsPhoneHome(string str_Phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_Phone, @"^(?:0(?:10|2[0-57-9]|[3-9]\d{2})[--]?)\d{7,8}$");
        }

        /// <summary>
        /// The full width half angle conversion into
        /// </summary>
        /// <param name="e"></param>
        public static void SBCToDBC(KeyPressEventArgs e)
        {
            if (e.KeyChar < 127 && e.KeyChar > 32)
            {
                e.KeyChar = (char)(e.KeyChar + 65248);
            }
            if (e.KeyChar == (char)12288)
                e.KeyChar = (char)32;
            if (e.KeyChar > 65280 && e.KeyChar < 65375)
            {
                e.KeyChar = (char)(e.KeyChar - 65248);
            }
        }

        /// <summary>
        /// The full width half angle into
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string DBCToSBC(string input)
        {
            char[] cc = input.ToCharArray();
            for (int i = 0; i < cc.Length; i++)
            {
                if (cc[i] == 32)
                {
                    // space
                    cc[i] = (char)12288;
                    continue;
                }
                if (cc[i] < 127 && cc[i] > 32)
                {
                    cc[i] = (char)(cc[i] + 65248);
                }
            }
            return new string(cc);
        }

        /// <summary>
        /// Determine the Value value is numeric format
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumeric(string value)
        {
            try
            {
                double tmp = Convert.ToDouble(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Determine the Value value if they contain can cause the special characters of Sql anomaly
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsParticular(string value)
        {
            if (value.Contains("'"))
            {
                return true;
            }
            if (value.Contains("`"))
            {
                return true;
            }
            if (value.Contains("{"))
            {
                return true;
            }
            if (value.Contains("["))
            {
                return true;
            }
            return false;
        }
      
        /// <summary>
        /// To determine whether the string for the digital
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool isNumber(string value)
        {
            int i = 0;
            return int.TryParse(value, out i);
        }

        /// <summary>
        /// Determine the Value value is DateTime format
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDateTime(string value)
        {
            DateTime i = new DateTime(); ;
            return DateTime.TryParse(value, out i);
        }
        /// <summary>
        /// To judge whether the string contains digital
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool isNumbers(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsNumber(value, i))
                    return true;
            }
            return false;
        }


        /// <summary>
        /// title
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="allows"></param>
        public static void TextFilter(KeyPressEventArgs e)
        {
            SBCToDBC(e);
            Regex regex = new Regex("^[\u4e00-\u9fa5 A-Z a-z]+$");
            bool flag = regex.IsMatch(e.KeyChar.ToString());
            if (flag) return; //

            if (char.IsDigit(e.KeyChar)) return; //number
            if ((int)e.KeyChar <= 32) return; //   
            e.Handled = true;
        }

        /// <summary>
        /// Digital text frame format
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="allows"></param>
        public static void TextFilter2(KeyPressEventArgs e)
        {
            SBCToDBC(e);
            if (e.KeyChar == (char)46) return;
            if ((int)e.KeyChar <= 32) return;
            if (!char.IsDigit(e.KeyChar))  // Non numeric keys, the abandonment of the input  
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Number of input format
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="allows"></param>
        public static void TextFilter3(KeyPressEventArgs e)
        {
            SBCToDBC(e);
            if (e.KeyChar == '-') return;
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') return;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z') return;
            if ((int)e.KeyChar <= 32) return;
            if (!char.IsDigit(e.KeyChar))  // 
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// ip adress is valid or not
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsIp(string value)
        {
            IPAddress address;
            return IPAddress.TryParse(value, out address);
        }

       /// <summary>
       /// length
       /// </summary>
       /// <param name="e"></param>
       /// <param name="length"></param>
       /// <param name="maxLength"></param>
        public static void IsMax(KeyPressEventArgs e, string str, int maxLength)
        {
            if ((int)e.KeyChar < 32) return;
            if (System.Text.Encoding.Default.GetByteCount(str) > maxLength)
                e.Handled = true;
        }

        #endregion

        public static double StringTodouble(string value)
        {
            double number = 0;
            double.TryParse(value, out number);
            return number;
        }

       

    }
}
