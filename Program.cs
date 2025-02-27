using Microsoft.EntityFrameworkCore;

namespace Assignment_Entity01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ITIDbContext ITIDb = new ITIDbContext();
            //ITIDb.Database.Migrate();


            using ITIDbContext context = new ITIDbContext();

            //Create

            //Student student01 = new Student() { FName = "Gamal", LName = "Tolan", Address = "Tanta", Age = 20, Dep_Id = 1 };

            //context.Students.Add(student01);
            //context.SaveChanges();

            //Read

            //var student = context.Students.Where(x => x.ID == 1).FirstOrDefault();
            //Console.WriteLine(student.FName);

            //Update

            //var student = (from s in context.Students
            //               where s.Dep_Id == 1
            //               select s).FirstOrDefault();
            //student.LName = "Ali";
            //Console.WriteLine(student.LName);
            //context.SaveChanges();

            //Remove

            var student = (from s in context.Students
                           where s.Dep_Id == 1
                           select s).FirstOrDefault();
            context.Students.Remove(student);
            context.SaveChanges();
        }
    }
}
