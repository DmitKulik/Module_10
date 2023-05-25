using static Module_10.Program;

namespace Module_10
{
    internal class Program   //Задание 10.3.3
    {
        public interface IBook
        {
            void Read();
        }

        public interface IDevice
        {
            void TurnOn();
            void TurnOff();
        }

        static void Main(string[] args)
        {

            ElectronicBook fileMeneger = new ElectronicBook();

            ((IBook)fileMeneger).Read();
            ((IDevice)fileMeneger).TurnOff();
            ((IDevice)fileMeneger).TurnOn();

        }
    }
    public class ElectronicBook : IBook, IDevice
    {
        void IBook.Read()
        {
            Console.WriteLine("BOOK");
        }
        void IDevice.TurnOn()
        {
            Console.WriteLine("TurnOn");
        }
        void IDevice.TurnOff()
        {
            Console.WriteLine("TurnOff");
        }
    }
}