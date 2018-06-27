using System;
using System.Linq;

namespace CSharp
{
    public class MessageService : IComparable<MessageService>
    {
        public string name;
        public int age;
        public MessageService(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MessageServices: Sending a text message... ");
        }
        public override bool Equals(object obj)
        {
            if (obj is MessageService)
            {
                return Equals((MessageService)obj);
            }
            else return false;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ age.GetHashCode();
        }

        public int CompareTo(MessageService other)
        {
           return this.name == other.name
        }
    }
}