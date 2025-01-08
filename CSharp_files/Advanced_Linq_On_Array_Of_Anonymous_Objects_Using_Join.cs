using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        // Array of employees, anonymous objects
        var employees = new[]
        {
            new { Id = 1, Name = "Alice", Salary = 5000m,DepartmentId = 2 },
            new { Id = 2, Name = "Bob",Salary= 7000m, DepartmentId = 1 }
        };

        // Array of departments
        var departments = new[]
        {
            new { DepartmentIdId = 1, DepartName = "Human Resources" },
            new { DepartmentIdId = 2, DepartName = "Development" }
        };

       
        // Joining employees with departments and projecting the result
        var employeeDetails = employees.Join(departments,
                                             e => e.DepartmentId,
                                             d => d.DepartmentIdId,
                                             (e, d) => new { e.Name,e.Salary, d.DepartName });

        // Displaying the results
         foreach (var detail in employeeDetails)
         {
             Console.WriteLine($"Employee: {detail.Name},{detail.Salary:C}, Department: {detail.DepartName}");
         }


        var Students = new[]
        {
            new {Name ="Mohamed1",Field =1, Average = 17.8m},
            new {Name ="Mohamed1",Field =2, Average = 15.03m},
            new {Name ="Mohamed1",Field =3, Average = 12.05m},
         };

        var Fields = new[]
        {
            new {FieldID=1, ModulName ="Math"},
            new {FieldID=2, ModulName ="Physic"},
            new {FieldID=3, ModulName ="Sport"}
        };

        var studentDetails = Students.Join(Fields, e => e.Field, f => f.FieldID, (e, f) => new { e.Name, e.Average,Field= f.ModulName });

        foreach(var detail in studentDetails)
        {
            Console.WriteLine($"\nStudent:Name = {detail.Name} Average = {detail.Average}, Field:{detail.Field}");
        }


        var players = new[]
        {
            new {id=1, FullName="Koko1", teamId=2, Salary=20000m},
            new {id=2, FullName="Koko2", teamId=3, Salary=22000m},
            new {id=3, FullName="Koko3", teamId=1, Salary=29000m}
        };

        var teams = new[]
        {            
            new {id=1, teamName="Barça"},
            new {id=2, teamName="Real"},
            new {id=3, teamName="Bayer"}
        };

        var palyersDetails = players.Join(teams,
                                        p => p.teamId,
                                        t => t.id,
                                        (p, t) => new { p.FullName, p.Salary, t.teamName });

        foreach (var player in palyersDetails)
            Console.WriteLine($"Player: {player.FullName}, Salary: {player.Salary}, Team: {player.teamName}");

        Console.ReadLine();

    }

   

  
    
}

