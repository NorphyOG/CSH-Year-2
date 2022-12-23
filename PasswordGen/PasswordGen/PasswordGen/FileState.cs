using System.IO;
using System.Windows.Shapes;

namespace PasswordGen;

public class FileState
{
    public void save(string fileName, string content)
    {
        string[] lines = content.Split("\n");
        string root = @"Passwörter";

        if (!Directory.Exists(root))
        {
            Directory.CreateDirectory(root);
        }

        if (fileName == "")
        {
            fileName = "Passwörter";
        }
        
        fileName = IsFileNameGood(fileName, root);

        File.WriteAllLines(root + "/" + fileName + ".txt", lines);
    }

    private static string IsFileNameGood(string fileName, string root)
    {
        int numbersOfPassTxt = 0;
        bool run = true;
        string newFileName = fileName;

        while (run)
        {
            if (File.Exists(root + "/" + newFileName + ".txt"))
            {
                numbersOfPassTxt++;
                newFileName = fileName + numbersOfPassTxt;
            }
            else
            {
                run = false;
            }
        }

        return newFileName;
    }
}