using ProgramW8;

Employee employee0 = new Employee("Arek", "Dziar", "30");
Employee employee1 = new Employee("Edek", "Fredek", "32");
Employee employee2 = new Employee("Marek", "Kamil", "18");

employee0.AddPoints(10);
employee0.AddPoints(10);
employee0.AddPoints(10);
employee0.AddPoints(10);
employee0.AddPoints(10);
employee0.AddPoints(10);

employee1.AddPoints(4);
employee1.AddPoints(4);
employee1.AddPoints(4);
employee1.AddPoints(4);
employee1.AddPoints(4);

employee2.AddPoints(6);
employee2.AddPoints(6);
employee2.AddPoints(6);
employee2.AddPoints(6);
employee2.AddPoints(6);

if(employee0.Result > employee1.Result)
{
    Console.WriteLine(employee0.Result + " " + "Arek", "Dziar", "30");
}    
else if(employee1.Result > employee2.Result)
{
    Console.WriteLine(employee1.Result + " " + "Edek", "Fredek", "32");
}
else
{
    Console.WriteLine(employee2.Result + " " + "Edek", "Fredek", "32");
}

