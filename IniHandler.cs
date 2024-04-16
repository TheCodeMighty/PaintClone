using System.Text;
using System.Runtime.InteropServices;

namespace WinFormsLab
{
    public class IniHandler
    {
        private string filePath;

        //https://stackoverflow.com/questions/1891279/why-cant-i-get-getprivateprofilestring-to-work-via-pinvoke
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public IniHandler(string filePath)
        {
            this.filePath = filePath;
        }

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, filePath);
        }

        public string Read(string section, string key, string defaultValue = "")
        {
            StringBuilder SB = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, defaultValue, SB, 255, filePath);
            return SB.ToString();
        }
    }
}