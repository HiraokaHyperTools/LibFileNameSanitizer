using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFileNameSanitizer {
    public class FileNameSanitizer {
        public static string forFileName(string name) {
            return forFileName(name, "_");
        }

        public static string forFileName(string name, string replaceInvalidCharsWith) {
            // https://stackoverflow.com/a/847251
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            return System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, replaceInvalidCharsWith);
        }
    }
}
