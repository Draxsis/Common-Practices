using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotinProjects.ToolkitLibrary
{
    internal class Class1
    {
        public static void main()
        {
            string[] names = { "ali", "reza", "alireza", "Anahita"};

            var linq01 = (
               from n in names
               group n by n[0].ToString().ToLower() into firstChar
               select new
               {
                   firstChar.Key
               });
                
        }
    }
}
