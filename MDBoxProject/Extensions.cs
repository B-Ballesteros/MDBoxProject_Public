using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MDBoxProject
{
    static class Extensions
    {
        public static byte[] GetBytesFromEscapedString(string[] input)
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

        public static byte[] ToByteArray(int input)
        {
            try
            {
                if (input == 0)
                {
                    return new byte[] { 0x00, 0x00, 0x00, 0x00 };
                }
                var array = BitConverter.GetBytes(input);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(array);
                }
                return array;
                //return BitConverter.IsLittleEndian ? array.Reverse().ToArray() : array;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new byte[0];
            }
        }

        public static void SetNumericUpDown(Control.ControlCollection controls, string tag, int value, out bool found)
        {
            found = false;
            foreach (Control ctrl in controls)
            {
                if (ctrl is NumericUpDown && Equals(ctrl.Tag, tag))
                {
                    ((NumericUpDown)ctrl).Value = value;
                    found = true;
                    break;
                }
                else
                {
                    if (ctrl.Controls?.Count > 0)
                    {
                        SetNumericUpDown(ctrl.Controls, tag, value, out found);
                        if (found)
                        {
                            break;
                        }
                    }
                }
            }
        }

        public static void SetTrackBar(Control.ControlCollection controls, string tag, int value, out bool found)
        {
            found = false;
            foreach (Control ctrl in controls)
            {
                if (ctrl is TrackBar && Equals(ctrl.Tag, tag))
                {
                    ((TrackBar)ctrl).Value = value;
                    found = true;
                    break;
                }
                else
                {
                    if (ctrl.Controls?.Count > 0)
                    {
                        SetTrackBar(ctrl.Controls, tag, value, out found);
                        if (found)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
