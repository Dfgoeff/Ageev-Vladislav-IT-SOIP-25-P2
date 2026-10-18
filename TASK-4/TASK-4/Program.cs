using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Net;

namespace TASK_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<INotifier> notifiers = new List<INotifier>
            {
                new EmailNotifer("yahoo.gl"),
                new SmsNotifer(),
                new TelegramNotifer()
            };
            foreach (var notifier in notifiers)
            {
                notifier.Send("interfaces is cool", "Tom");
            }

        }

    }
    public interface INotifier
    {
        public void Send(string message, string reciver);
    }
    public class EmailNotifer : INotifier
    {
        private string service;
        public EmailNotifer(string service)
        {
            this.service = service;
        }
        public void Send(string message, string reciver)
        {
            Console.WriteLine($"Message: '{message}' was sent to inbox - {reciver}@{service}");
        }
    }
    public class SmsNotifer : INotifier
    {
        public void Send(string message, string reciver)
        {
            Console.WriteLine($"SMS: '{message}' was sent to the number {reciver}");
        }
    }
    public class TelegramNotifer : INotifier
    {
        public void Send(string message, string reciver)
        {
            Console.WriteLine($"Message: '{message}' was sent to a user {reciver} via Telegram Team Network");
        }
    }
}
