using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] users = new string[] {"user1","user2","user3" };

            //using (StreamWriter streamWriter=new StreamWriter(@"C:\Users\HP\Desktop\test\users.txt"))
            //{
            //    foreach (var item in users)
            //    {
            //        streamWriter.WriteLine(item);
            //    }
              
            //}

            DirectoryInfo directoryInfo = new DirectoryInfo(@".");
           
            
            FileInfo[] fileInfos = directoryInfo.GetFiles("*.txt",SearchOption.AllDirectories);
            
            foreach (var item in fileInfos)
            {
                
              
                
                    Console.WriteLine(item);
                
            }
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }
    }
}
