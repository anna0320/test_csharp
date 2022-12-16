using System;

namespace test_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserContext())
            {
                // добавляем пользователей в бд
                db.Users.Add(new User { IDU = 1, Name = "Tom", Amount = 33 });
                db.Users.Add(new User { IDU = 2, Name = "Sam", Amount = 26 });
                db.Users.Add(new User { IDU = 3, Name = "Anna", Amount = 87 });
                db.Users.Add(new User { IDU = 4, Name = "Rick", Amount = 20 });
                db.Users.Add(new User { IDU = 5, Name = "Kate", Amount = 39 });
                db.Users.Add(new User { IDU = 6, Name = "Jonh", Amount = 28 });
                db.Users.Add(new User { IDU = 7, Name = "Alex", Amount = 42 });
                db.Users.Add(new User { IDU = 8, Name = "Mary", Amount = 75 }); 
                db.Users.Add(new User { IDU = 9, Name = "Alex", Amount = 21 });
                db.Users.Add(new User { IDU = 10, Name = "Poul", Amount = 13 });
                db.SaveChanges();

                // получаем объекты из бд и выводим на консоль
                Console.WriteLine("Список объектов:");
                foreach (var user in db.Users)
                {
                    if (user.Name == "Alex")
                    {
                        int num =  user.IDU* 5/(user.IDU - 3);
                        user.Amount = num;
                    }
                    Console.WriteLine("{0} - {1}р", user.Name, user.Amount);
                    
                }
                
                db.SaveChanges();
                db.Users.RemoveRange(db.Users);
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
