using static Module_10.Program;

namespace Module_10
{
    internal class Program   //Задание 10.3.1
    {
        public interface IWriter
        {
            void Write();
        }

        public interface IReader
        {
            void Read();
        }

        public interface IMailer
        {
            void SendEmail();
        }

        static void Main(string[] args)
        {

            FileManager fileMeneger = new FileManager();

            ((IWriter)fileMeneger).Write();
            ((IReader)fileMeneger).Read();
            ((IMailer)fileMeneger).SendEmail();

        }
    }
    public class FileManager : IWriter, IReader, IMailer
    {
        void IWriter.Write()
        {
            Console.WriteLine("Метод Write !write");
        }
        void IReader.Read()
        {
            Console.WriteLine("Метод Read IReader");
        }
        void IMailer.SendEmail()
        {
            Console.WriteLine("Метод SendEmail IMailer");
        }
    }
}