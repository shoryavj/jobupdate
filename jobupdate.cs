using System;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.Nomad

{
     class UpdateChanges
    {


          static void Main(string args)
        { 
                string[] jsonArray = JsonConvert.DeserializeObject(args);

                    Console.WriteLine(jsonArray);
               
                
      //          string Content = args[0];
        //        string Path = args[1];
//                Console.WriteLine($"{Path}");
          //      string root = ("./../" + Path);
               // Console.Writeline(Content) ;
                //Console.Writeline(Path) ;
                //Console.Writeline(root) ;

               // This text is added only once to the file.
               
                    // Create a file to write to.
            //        File.WriteAllText(root, Content);
             
                //Open the file to read from.
              //  string readText = File.ReadAllText(root);
                               //   Thread.Sleep(15000);

               // Console.WriteLine(readText);
            }
        

    }


}
