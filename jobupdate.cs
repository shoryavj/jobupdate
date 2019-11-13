using System;
using System.IO;

namespace Api.Nomad

{
     class UpdateChanges
    {

        static void Main(string[] args)
        {

            {

                
                var Content = args[0];
                var Path = args[1];
//                Console.WriteLine($"{Path}");
                var root = ("./" + Path);
                Console.Writeline(Content) ;
                Console.Writeline(Path) ;
                Console.Writeline(root) ;

               // This text is added only once to the file.
                if (!File.Exists(root))
                {
                    // Create a file to write to.
                    File.WriteAllText(root, Content);
                }



                //Open the file to read from.
                string readText = File.ReadAllText(root);
               Console.WriteLine(readText);
            }
        }

    }


}
