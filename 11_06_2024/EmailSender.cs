namespace _11_06_2024
{
    public class EmailSender : MessageSender
    {
        public override void SendMessage(string msg)
        {
            Console.WriteLine("Message is sent by Email");

        }
    }
}
