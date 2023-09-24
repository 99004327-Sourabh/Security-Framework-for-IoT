using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace UserApp
{
    class Logger
    {
        public static void Log(string message)
        {
            FileStream fp = new FileStream("log.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(fp);
            writer.WriteLine(message);
            writer.Close();
            fp.Close();
        }

    }
}
