using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialChecker
{
    public static class LoggerSample
    {
        

        public static void Debug(string message)
        {
            DateTime dtNow = DateTime.Now;

            StreamWriter wr = new StreamWriter(Form1.filepath,true, Encoding.GetEncoding("Shift_JIS"));
            wr.WriteLine(dtNow.ToString() + "                                                     "+message);
            wr.Close();

        }

       
    }
}
