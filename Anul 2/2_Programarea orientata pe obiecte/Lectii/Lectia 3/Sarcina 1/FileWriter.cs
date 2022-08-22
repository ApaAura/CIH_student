using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sarcina_1
{
    public class FileWriter
    {

        public static void WriteTextFile(string FilePath, string text)
        {
            if (File.Exists(FilePath))
            {
                StreamWriter sw = new StreamWriter(FilePath);
                sw.WriteLine(text);
                sw.Close();
            }
            else
            {
                Stream stream = File.Open(FilePath, FileMode.Create);
                StreamWriter sw = new StreamWriter(stream);
                sw.Write(text);
                sw.Close();
                stream.Close();
            }
        }
        public static void WriteBinaryFile(string FilePath, string text)
        {
            if (File.Exists(FilePath))
            {
                Stream sw = File.Open(FilePath, FileMode.Open);
                BinaryWriter binaryWriter = new BinaryWriter(sw);
                binaryWriter.Write(text);
                binaryWriter.Close();
                sw.Close();
            }
            else
            {
                Stream sw = new FileStream(FilePath, FileMode.Create);
                BinaryWriter binaryWriter = new BinaryWriter(sw);
                binaryWriter.Write(text);
                binaryWriter.Close();
                sw.Close();
            }
        }
    }
}
