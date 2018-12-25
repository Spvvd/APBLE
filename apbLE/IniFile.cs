using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace apbLE
{
    public class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileSectionNames(byte[] lpszReturnBuffer, int nSize, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(2097152);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 2097152, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }

        public System.Collections.Generic.List<string> ReadSections()
        {
            byte[] buffer = new byte[2097152];
            GetPrivateProfileSectionNames(buffer, buffer.Length, Path);
            string allSections = System.Text.Encoding.Default.GetString(buffer);
            var sections = new System.Collections.Generic.List<string>();

            foreach (string section in allSections.Split('\0'))
            {
                if (section != string.Empty)
                {
                    sections.Add(section);
                }
            }
            return sections;
        }

        public System.Collections.Generic.List<string> GetKeys(string category)
        {

            byte[] buffer = new byte[2097152];

            GetPrivateProfileSection(category, buffer, 2097152, Path);
            string[] tmp = Encoding.ASCII.GetString(buffer).Trim('\0').Split('\0');

            var result = new System.Collections.Generic.List<string>();

            foreach (string entry in tmp)
            {
                result.Add(entry.Substring(0, entry.IndexOf("=")));
            }

            return result;
        }
    }
}
