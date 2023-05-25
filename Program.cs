using static Module_10.Program;

namespace Module_10
{
    internal class Program
    { 
        // Определяется интерфейс IViber со методом SendMessage
        public interface IViber
        {
            public void SendMessage(string message);
        }
        // Определяется интерфейс IWathApp со методом SendMessage
        public interface IWathApp
        {
            public void SendMessage(string message);
        }

        static void Main(string[] args)
        {
            // Создается новый объект класса NewMessage
            NewMessage newMessage = new NewMessage();

            // Вызывается метод SendMessage из интерфейса IWathApp
            ((IWathApp)newMessage).SendMessage("Test1");

            // Вызывается метод SendMessage из интерфейса IViber
            ((IViber)newMessage).SendMessage("Test2");
        }
    }

    // Класс NewMessage реализует интерфейсы IWathApp и IViber
    public class NewMessage : IWathApp, IViber
    {
        // ЯВНАЯ реализация метода SendMessage из интерфейса IWathApp
        void IWathApp.SendMessage(string message)
        {
            Console.WriteLine("{ 0 } : { 1 }", "WathApp", message);
        }

        // НЕ ЯВНАЯ реализация метода SendMessage из интерфейса IViber
        public void SendMessage(string message)
        {
            Console.WriteLine("{ 0 } : { 1 }", "Viber", message);
        }
    }
}