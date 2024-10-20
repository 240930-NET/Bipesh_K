using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace Bps.APP
{
public class Program
{
    
    public static void Main(string[] args)
    {
       

      
       
       Greetings.StartWithGreet();
       


        // can I put the following variables in a class and bring them here?
        
        double totalearn = 0;
        double rate = 5;

       


        

        /*string filepath = "savefiledata.txt";
        FileReader reader = new FileReader();
        string dataFromFile = reader.ReadFile(filepath);
        # trying to convert the following file reader and file writer code to class
        */
        
        StreamReader reader1 = File.OpenText( "savefiledata.txt");
        string datafromfile = reader1.ReadToEnd();

    
        



        List<Passenger> numofpassengers = JsonSerializer.Deserialize<List<Passenger>>(datafromfile);
        reader1.Close();

      
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
                
                
                Console.WriteLine(passenger1.Name +  " is going to " + passenger1.Place);

                totalearn= RunTotal.RunningTotal(totalearn, rate);

                

               
                Console.WriteLine("Total earning as of now is $" + totalearn);
                
                numofpassengers.Add(passenger1);
                foreach( Passenger x in numofpassengers){
                    Console.WriteLine(x.Name);
                }

                string filepath = "savefiledata.txt";

                /*
                1. program starts
                2. load information from the file to a list
                3. program loop
                4. before the program ends , save the information
                5. program terminates




                */
                
                

                string jsonString1 = JsonSerializer.Serialize(numofpassengers);
                Console.WriteLine(jsonString1);
                try{
                StreamWriter writer = new StreamWriter(filepath);
                writer.WriteLine(jsonString1);
                
    
                writer.Close();
                }
                catch(Exception ex){
 
                Console.WriteLine(ex.Message);
                }
 

          
                Console.WriteLine("We are arrived at " + passenger1.Place + " .Thank you for travelling with us!");

                
                

            }
    
            else
            {
                Console.WriteLine("say thank you, have a good one !");
            }
        
        }
        
    }
}



public  class RunTotal
{
    public static double RunningTotal(double TotalEarn, double Rate)
    {
        return TotalEarn += Rate;
    }
}
public class FileReader{

    public string ReadFile(string pathname){

        //To automatically release our resources we use the keyword "using" 
        using(StreamReader sr = File.OpenText(pathname)){
        
            return sr.ReadToEnd();
        }

    }
}
public class FileWriter{

    public void WriteToFile(string pathname, string content){

        using(StreamWriter writer = new StreamWriter(pathname)){
            writer.WriteLine(content);
        }
    }
}
}