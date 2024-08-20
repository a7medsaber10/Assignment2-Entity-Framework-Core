using Assignment2_Entity_Framework_Core.Contexts;
using Assignment2_Entity_Framework_Core.Entities;

namespace Assignment2_Entity_Framework_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Operations on student table
            using ITIDbContext dbContext = new ITIDbContext();

            Student student1 = new Student()
            {
                FName = "Ahmed",
                LName = "Saber",
                Address = "october",
                Age = 20,
            };

            Student student2 = new Student()
            {
                FName = "Abdo",
                LName = "Saber",
                Address = "october",
                Age = 22,
            };

            #region Insert
            Console.WriteLine(dbContext.Entry(student1).State);  // Detached

            dbContext.Add(student1);
            dbContext.Add(student2);
            #endregion

            #region Select
            //var student = (from s in dbContext.Students
            //               where s.Id == 2
            //               select s).FirstOrDefault(); 
            #endregion

            #region Update

            //Console.WriteLine(dbContext.Entry(student).State); // unchanged

            //Console.WriteLine(student?.FName ?? "N/A");


            //student.FName = "mohamed";

            //Console.WriteLine(dbContext.Entry(student).State); // modified 
            #endregion

            #region Delete
            //dbContext.Students.Remove(student);
            //Console.WriteLine(dbContext.Entry(student).State); //Deleted
            #endregion

            //dbContext.SaveChanges();
            #endregion
        }
    }
}
