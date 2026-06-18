using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Running(new DateTime(2022, 11, 5), 45, 4.5));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 15.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 6), 60, 20.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 20));
        activities.Add(new Swimming(new DateTime(2022, 11, 7), 45, 35));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
