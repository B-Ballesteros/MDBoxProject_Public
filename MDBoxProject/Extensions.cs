using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MDBoxProject
{
    static class Extensions
    {
        public static byte[] GetBytesFromEscapedString(this string[] input)
        {
            try
            {
                var fullString = string.Join("", input);
                return Encoding.ASCII.GetBytes(fullString);
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public static byte[] ToByteArray(this int input)
        {
            try
            {
                if (input == 0)
                {
                    return new byte[] { 0x00, 0x00, 0x00, 0x00 };
                }
                var array = BitConverter.GetBytes(input);
                return BitConverter.IsLittleEndian ? array.Reverse().ToArray() : array;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new byte[0];
            }
        }
    }
}
