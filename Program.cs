using static Module_10.Program;

namespace Module_10
{
    internal class Program
    {

        public interface IWathApp
        {
            public void SendMessage(string message);
        }
        public interface IViber
        {
            public void SendMessage(string message);
        }
        static void Main(string[] args)
        {
            NewMessage newMessage = new NewMessage();

            ((IWathApp)newMessage).SendMessage("Test1");
            ((IViber)newMessage).SendMessage("Test2");
        }
        
    }
    public class NewMessage : IWathApp, IViber
    {
        void IWathApp.SendMessage(string message)
        {
            Console.WriteLine("{ 0 } : { 1 }", "WathApp", message);
        }

        void IViber.SendMessage(string message)
        {
            Console.WriteLine("{ 0 } : { 1 }", "Viber", message);
        }
    }
}