namespace _11_06_2024
{
    public class SmsSender : MessageSender
    {
        public override void SendMessage(string msg)
        {
            Console.WriteLine("Message is sent by SMS");
        }
    }
}
