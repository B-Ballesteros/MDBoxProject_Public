using System;
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
    }
}
