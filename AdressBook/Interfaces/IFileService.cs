namespace AdressBook.Interfaces;

public interface IFileService
{
    /// <summary>
    /// Save content to specificed filepath.
    /// </summary>
    /// <param name="filePath">enter the filepath with extention (eg. c:\project\myfile.json)</param>
    /// <param name="content"> enter your content as a string</param>
    /// <returns> returns true if saved , else false is failed.</returns>
    bool SaveContectToFile(string filePath, string content);


    /// <summary>
    /// Get content as string from a specified filepath
    /// </summary>
    /// <param name="filePath">enter the filepath with extention (eg. c:\project\myfile.json)</param>
    /// <returns> returns file content as string if file exisist , else retrun null</returns>
    string GetContentFromFile(string filePath);
}
