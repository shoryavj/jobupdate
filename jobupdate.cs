using System;
using System.IO;
using System.Threading;

namespace Api.Nomad

{
     class UpdateChanges
    {

        static void Main(string[] args)
        {

            {

                
                string Content = args[0];
                string Path = args[1];
//                Console.WriteLine($"{Path}");
                string root = ("./../" + Path);
               // Console.Writeline(Content) ;
                //Console.Writeline(Path) ;
                //Console.Writeline(root) ;

               // This text is added only once to the file.
               
                    // Create a file to write to.
                    File.WriteAllText(root, Content);
                



                //Open the file to read from.
                string readText = File.ReadAllText(root);
               Console.WriteLine(readText);
            }
        }

    }


}
