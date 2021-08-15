using System;
using System.Threading;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread t = Thread.currentThread;

            // 2015 is year, 12 is month, 25 is day  
            DateTime date1 =  DateTime.Now;
            
            Console.WriteLine(date1.ToString());
            Thread.Sleep(1000);
            Console.Clear();// 12/25/2015 12:00:00 AM
            Console.WriteLine("give the time u need stopwaatch");
            int time = int.Parse(Console.ReadLine());
            for (int i = 1; i <= time; i++)
            {
                
                DateTime date2 = DateTime.Now; 
                Console.WriteLine(date2.ToString());
                Thread.Sleep(1000);
                Console.Clear();
                
            }
            DateTime date3 = DateTime.Now;
            Console.WriteLine(date3.ToString());
            // 2015 - year, 12 - month, 25 – day, 10 – hour, 30 – minute, 50 - second  
            // DateTime date2 = DateTime.Now;


            //TimeSpan difference = date2 - date1;



            // Console.WriteLine(date2-date1);

            // int seconds = 0;
            // int minutes = 0;
            // int hours = 0;
            // int days = 0;
            // int months = 0;
            // int years = 0;
            //while(date1<=date2)
            // {
            //     seconds++;
            //     if(seconds>59)
            //     {
            //         minutes++;
            //         seconds = 0;
            //     }
            //     if(minutes>59)
            //     {
            //         hours++;
            //         minutes = 0;
            //     }
            //     if(hours>23)
            //     {
            //         hours = 0;
            //     }
            //     Console.WriteLine(seconds + "::" + minutes + "::" + hours);

            //     Console.Clear();

            //}



        }
    }
}
