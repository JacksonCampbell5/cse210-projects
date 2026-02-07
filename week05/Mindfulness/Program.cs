// Keeps a log of how long each activity is performed and is displayable to the user.
using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListeningActivity listeningActivity = new ListeningActivity();

        do
        {
            Console.Clear();
            Console.WriteLine(
@"Menu Options:
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. Show Stats
    5. Quit ");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

             if (choice == 1)
            {
                breathingActivity.Run();
            }
             else if (choice == 2)
            {
                reflectingActivity.Run();
            }
             else if (choice == 3)
            {
                listeningActivity.Run();
            }
            else if (choice == 4)
            {
                Console.Clear();
                int totalTime = breathingActivity.GetTotalDuration() + reflectingActivity.GetTotalDuration() + listeningActivity.GetTotalDuration(); 
                Console.WriteLine(
@$"Activity Stats:
    Breathing activity : {breathingActivity.GetTotalDuration()} seconds
    Reflecting activity : {reflectingActivity.GetTotalDuration()} seconds
    Listing activity : {listeningActivity.GetTotalDuration()} seconds
    Total Time : {totalTime} seconds!
Press enter to continue.");
Console.ReadLine();
            }

         } while (choice != 5);

            
        
    }
}