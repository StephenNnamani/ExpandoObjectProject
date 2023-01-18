using System.Reflection;

namespace FileStreaming
{
    internal class Program
    {
        static void Main()
        {
            //CreatingAFile.FileReadAndWrite file = new CreatingAFile.FileReadAndWrite();
            //file.FileDotWriteLines();
            Assembly asm = null;
            asm = Assembly.LoadFrom("CreatingAFile");
            ListMembers(asm);
        }
        static void ListMembers(Assembly assembly)
        {
            Console.WriteLine("******* List of all the members ********");
            var assemblyMembers = from members in assembly.GetTypes() orderby members.Name select members;

            foreach(var s in assemblyMembers)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}