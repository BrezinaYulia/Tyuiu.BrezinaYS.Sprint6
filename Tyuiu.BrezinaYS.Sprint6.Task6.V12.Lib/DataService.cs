using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrezinaYS.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string str, string path)
        {
            string[] a = File.ReadAllLines(path);
            string pr = "";
            string res = "";
            
            foreach (string line in a)
            {
                pr = pr + " " + line;
            }
            string[] words = pr.Split(' ').ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(str))
                {
                    res = res + " " + words[i];
                }
            }
            return res;

        }
    }
}
