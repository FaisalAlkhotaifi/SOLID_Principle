using System;

namespace DIP
{
    public class BestPractice
    {
        public interface IMessage
        {
            string Address { get; set; }
            string from { get; set; }
            string to { get; set; }

            void Send();
        }

        public class Gmail : IMessage
        {
            string IMessage.Address { get; set; }
            string IMessage.from { get; set; }
            string IMessage.to { get; set; }

            public void Send() { /* Code */ }
        }

        public class Hotmail : IMessage
        {
            string IMessage.Address { get; set; }
            string IMessage.from { get; set; }
            string IMessage.to { get; set; }

            public void Send() { /* Code */ }
        }

        // Notice how many change should be done when I adding new things!

        // Added Later 
        public class Webmail : IMessage
        {
            string IMessage.Address { get; set; }
            string IMessage.from { get; set; }
            string IMessage.to { get; set; }

            public void Send() { /* Code */ }
        }

        public class Notification
        {
            private IMessage _mainService; // Till now you do not know which mail (gmail, hotmail or webmain)

            /* 
                To solve this issue we will use injection 
                (constructor injection, property injection or method injection) 
            */

            // This is the constructor injection
            public Notification(IMessage mainService) 
            {
                _mainService = mainService;
            }

            // This is to use it for property injection
            public IMessage mainServiceInject;

            // Lastly, use method parameter to inject it using method injection
            public void SendMail() { _mainService.Send(); }
        }
        public void Run()
        {
            Notification notification = new Notification(new Gmail()); // here you will till which one
            notification.mainServiceInject = new Hotmail(); // and here to inject it
            notification.SendMail();
        }
    }
}