namespace Übung_13
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            FileState fileState = new FileState();
            fileState.ReadAllFiles();
            fileState.save();
            
            
        }
    }
}