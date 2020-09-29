using System;

namespace NoDIP
{
    public class BadPractice
    {
        public class Gmail
        {
            public string Address = "address";
            public string from = "from";
            public string to = "to";

            public void Send() { /* Code */ }
        }

        public class Hotmail
        {
            public string Address = "address";
            public string from = "from";
            public string to = "to";

            public void Send() { /* Code */ }
        }

        // Notice how many change should be done when I adding new things!

        // Added Later 
        public class Webmail
        {
            public string Address = "address";
            public string from = "from";
            public string to = "to";

            public void Send() { /* Code */ }
        }

        public class Notification
        {
            private Gmail _gmail = new Gmail();
            private Hotmail _hotmail = new Hotmail();

            // Added Later 
            private Webmail _webmail = new Webmail();

            public void SendGmail() { _gmail.Send(); }
            public void SendHotmail() { _hotmail.Send(); }

            // Added Later 
            public void SendWebmail() { _webmail.Send(); }
        }

        public void Run()
        {
            Notification notification = new Notification();
            notification.SendGmail();
            notification.SendHotmail();

            // Added Later 
            notification.SendWebmail();
        }
    }
}