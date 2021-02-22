using System;

namespace Assignment_1__Clock_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hours:");
            float hours = Convert.ToInt32(Console.ReadLine());
            if (hours < 1 || hours > 12)
            {
                throw new Exception("Please enter a valid hour number: from 1 to 12");
            }

            Console.WriteLine("Enter minutes:");
            float minutes = Convert.ToInt32(Console.ReadLine());
            if (minutes < 1 || minutes > 59)
            {
                throw new Exception("Please enter a valid minute number: from 1 to 59");
            }

            // To count the angle of the minute hand shifting each minute we use this proportion: 1 minute/angle = 60 minutes/360 degrees
            // As a result of the proportion we get the formula: minutes/60*360 => minutes*6
            // Therefore each minute passed shifts the minute hand by 6 degrees.

            // To count the angle of the hour hand shifting each hour we use this proportion: 1 hour/angle = 12 hours/360 degrees
            // As a result of the proportion we get the formula: hours*360/12 = hours*30
            // Therefore each hour passed shifts the hour hand by 30 degrees.

            // Now we can count the angle between the hands using the formula

            float angle = (hours + (minutes / 60)) * 30 - minutes * 6;

            // where hours + (minutes / 60) shows us the position of the hour hand.

            // The last step is making sure that we always show the lesser angle between clock hands

            if (angle > 180)
            {
                angle = 360 - angle;
            }

            Console.WriteLine("The lesser angle between clock hands is " + angle);


        }
    }
}
