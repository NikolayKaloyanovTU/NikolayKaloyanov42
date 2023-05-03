using Datalayer.Database;

namespace Datalayer
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(" Hello !");

            using (var db = new MyDbContext())
            {
                db.Database.EnsureCreated();

                var users = db.Users.ToList();
                Console.ReadKey();
            }
        }
    }
}