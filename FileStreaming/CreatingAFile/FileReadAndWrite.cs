using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAFile
{
    public class FileReadAndWrite
    {

        public void FileDotWriteLines()
        {

            string[] content = { "Do not touch him" };

            File.WriteAllLines(@"task.txt", content);
        }
    }
}
