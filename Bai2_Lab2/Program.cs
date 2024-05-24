using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Lab2
{
    internal class Program
    {
        public void bai2a()
        {
            var userInfo = new
            {
                id = "2024",
                name = "faker",
                isplaying = false,
                bag = new
                {
                    skins = 0,
                    cups = 0
                }
            };
            Debug.WriteLine("id: " + userInfo.id);
            Debug.WriteLine("name: " + userInfo.name);
            Debug.WriteLine("isplaying: " + userInfo.isplaying);
            Debug.WriteLine("bag skins: " + userInfo.bag.skins);
            Debug.WriteLine("bag cups: " + userInfo.bag.cups);
        }

        public void bai2b()
        {
            int y = 10;
            Action<int> AnonymousMethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Debug.WriteLine("Sum: " + sum);
                Debug.WriteLine("Sub: " + sub);
            };
            AnonymousMethod(5);
        }

        static void Main(string[] args)
        {
            
        }
    }
        
       
    
}
