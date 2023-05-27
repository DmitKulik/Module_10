
namespace Module_10
{
   
    class Program //Задание 10.4.4
    {
        
        static void Main()
        {
            // Создание объектов классов User и Account 

            var user = new User();
            var account = new Account();

            // Создание объекта класса UserService с использованием интерфейса IUpdater<Account>
            IUpdater<Account> updater = new UserService();

            // Создание объекта класса UserService и вызов его метода Update
            var userService = new UserService();
            userService.Update(user);
        }
    }

    // Определение интерфейса IUpdater, принимающего в качестве параметра тип T, с модификатором входного параметра in для контравариантности
    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    // Определение класса UserService, реализующего интерфейс IUpdater для типа User
    public class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }

    public class User
    {

    }

    public class Account : User
    {

    }
}