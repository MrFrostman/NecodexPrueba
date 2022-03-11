using ConsoleApp1.Data;
int Response1;
string ListName



//asignate the  value of process name

Console.WriteLine("what you do it? 1.- make a process or 2 delete a process or 3 make a new list ");  Response1 = Console.Read();
if (Response1 ==1)
{
    Process NewListProcess = new Process();
    Console.WriteLine("Insert the name of the Process");
    NewListProcess.Name=Console.ReadLine();
    Console.WriteLine("Inser the Proximity time for the process");
    NewListProcess.AproxTime=Console.Read();
   
}
else if (Response1 == 2)
{
    Console.WriteLine("Inserte el nombre de la Lista");
    ListName = Console.ReadLine();
}
else if(Response1 == 3)
{
    Console.WriteLine("Inserte el nombre de la Lista");
    ListName=Console.ReadLine();

}

