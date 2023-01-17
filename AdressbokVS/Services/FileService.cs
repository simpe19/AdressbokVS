

namespace AdressbokVS.Services
{
    internal class FileService
    {
        public void Save(string filePath, string console) 
        { 
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(console);
        }

        public string Read(string filePath) 
        {
            try
            {
                using var sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }
            catch { return null!; }
        }
    }
}
