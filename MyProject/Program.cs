using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MyProject;

namespace MyProject
{

    class Program
    {

        //const string FILE_NAME = "Incoming.txt";
        //const string test = "Incoming test.txt";
        //const string testLoad = "test.txt";
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            shop.Create();

            shop.Menu();


        }
    }
}
