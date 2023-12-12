
using AdressBook.Interfaces;
using System.Diagnostics;

namespace AdressBook.Services;

    internal class FileService : IFileService
    {
        public string GetContentFromFile(string filepath)
        {
            try
            {
              if (File.Exists(filepath))
            {
                return File.ReadAllText(filepath);
            }

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;

        }

        public bool SaveContectToFile(string filePath, string content)
        {
            try
            {
              using var sw=new StreamWriter(filePath);
              sw.WriteLine(content);
              return true;

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }

         
        
    }

