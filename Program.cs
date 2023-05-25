using static Module_10.Program;

namespace Module_10
{
    internal class Program   //Задание 10.3.2
    {
        public interface ICreatable
        {
            void Create();
        }

        public interface IDeletable
        {
            void Delete();
        }

        public interface IUpdatable
        {
            void Update();
        }

        static void Main(string[] args)
        {

            FileManager fileMeneger = new FileManager();

            ((ICreatable)fileMeneger).Create();
            ((IDeletable)fileMeneger).Delete();
            ((IUpdatable)fileMeneger).Update();

        }
    }
    public class FileManager : ICreatable, IDeletable, IUpdatable
    {
        public void Create()
        {
            Console.WriteLine("Метод Write !write");
        }
        public void Delete()
        {
            Console.WriteLine("Метод Read IReader");
        }
        public void Update()
        {
            Console.WriteLine("Метод SendEmail IMailer");
        }
    }
}