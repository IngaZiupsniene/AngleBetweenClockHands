using System;

namespace AngleOfClockHands
{
    class Program
    {
        static void Main(string[] args)
        {
            string valHour;
            int hour;

            while (true)
            {
                Console.Write("Enter hour between 1 to 12 : ");
                valHour = Console.ReadLine();
                hour = Convert.ToInt32(valHour);
                if (hour <= 0 || hour > 12)
                    Console.Write("Wrong hour input. ");
                else
                    break;
            }

            string valMinute;
            int minute;

            while (true)
            {
                Console.Write("Enter minutes between 0 to 59 : ");
                valMinute = Console.ReadLine();
                minute = Convert.ToInt32(valMinute);
                if (minute < 0 || minute >= 60)
                    Console.Write("Wrong minute input");
                else
                    break;
            }

            if (hour == 12) hour = 0;
            
            Console.WriteLine("Angle between hour and minute hands is " + calculateAngle(hour, minute));
            Console.Read();
        }

        private static int calculateAngle(int hour, int minute)
        {
            int hourAngle = (int)(0.5 * (hour * 60 + minute));
            int minuteAngle = (int)(6 * minute);

            int angle = Math.Abs(hourAngle - minuteAngle);
            angle = Math.Min(360 - angle, angle);

            return angle;
        }
    }
}
