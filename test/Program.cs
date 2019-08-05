using System;
using Newtonsoft.Json;
using test.Common;
using test.Models;
using test.Service;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string ok = Class1.GetStr();
            Console.WriteLine(ok);
            UserInfo info = new UserInfo();
            info.Id = 1;
            info.Name = "ol";
            Console.WriteLine(info);
            Console.WriteLine(JsonConvert.SerializeObject(info));
            UserGoup userGoup = new UserGoup();
            userGoup.roleId = "12";
            Console.WriteLine(userGoup.roleId);
            Console.WriteLine("Hello World!");
        }
    }
}
