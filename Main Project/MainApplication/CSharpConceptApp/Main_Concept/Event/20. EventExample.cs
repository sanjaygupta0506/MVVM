using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Delegates
{
    // Define a delegate for the event handler
    public delegate void EventHandler(object sender, EventArgs e);
    public class Publisher
    {
        // Define an event based on the delegate
        public event EventHandler MyEvent;

        // Method to raise the event
        public void RaiseEvent()
        {
            // Check if there are any subscribers
            if (MyEvent != null)
            {
                // Raise the event
                MyEvent(this, EventArgs.Empty);
            }
        }
    }
    public class Subscriber
    {
        // Event handler method
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event handled by Subscriber");
            Console.ReadLine();
        }
    }
    class EventExample
    {
        //static void Main(string[] args)
        //{
        //    Publisher publisher = new Publisher();
        //    Subscriber subscriber = new Subscriber();

        //    // Subscribe to the event
        //    publisher.MyEvent += subscriber.HandleEvent;

        //    // Raise the event
        //    publisher.RaiseEvent();
        //}

    }
}
