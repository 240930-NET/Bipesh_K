using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
namespace Bps.APP
{
public class Program
{
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Welcome to Drive,Earn,Live 0");
        
        int totalearn = 0;
        int rate = 5;
        List<String> numofpassengers = new List<String>();
        

      
        while (true)
        {
            Console.WriteLine("Do you need a ride?: ");

            string userInput = Console.ReadLine();
            
        

            if(userInput == "yes")
            {
                
                Console.WriteLine("ask more info !");
                Console.WriteLine("what's your name?; ");
                string nameinput = Console.ReadLine();
                Console.WriteLine("where are you going?: ");
                string placeinput = Console.ReadLine();

                Passenger passenger1 = new Passenger{Name = nameinput, Place = placeinput};
                string jsonString = JsonSerializer.Serialize(passenger1);
                Console.WriteLine(jsonString);
                Console.WriteLine(passenger1.Name +  " is going to " + passenger1.Place);
                totalearn = totalearn + rate;
                Console.WriteLine("Total earning as of now is " + totalearn);
                
                numofpassengers.Add(passenger1.Name);

                string jsonString1 = JsonSerializer.Serialize(passenger1);
                Console.WriteLine(jsonString1);

                Passenger deserializedJsonPassenger = JsonSerializer.Deserialize<Passenger>(jsonString);
                Console.WriteLine("Here is the deserialzed object: " + deserializedJsonPassenger.Name);

                FileReader reader = new FileReader();
                string filepath = "savedfiledata.txt";

                FileWriter writer = new FileWriter();
                string content = "This is a new text \n check it out!";
                writer.WriteToFile(filepath, content);
                writer.WriteToFile(filepath, jsonString);
                string ndataFromFile = reader.ReadFile(filepath);
                Console.WriteLine(ndataFromFile);


                
                

            }
    
            else
            {
                Console.WriteLine("say thank you, have a good one !");
            }
        
        }
        
    }
}
}