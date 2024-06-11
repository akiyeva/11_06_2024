namespace _11_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new(2017, "Subaru", "Forester");
            Bus bus = new(2019);

            Vehicle[] vehicles = { car, bus };

            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }

            #region SendMessage

            //EmailSender emailSender = new EmailSender();
            //SmsSender smsSender = new SmsSender();

            //Console.WriteLine("Please write a message that you want to send:");
            //string message = Console.ReadLine();

            //Console.WriteLine("Please select a command (1, 2, or 0):");
            //Console.WriteLine("1. Send message by email");
            //Console.WriteLine("2. Send message by sms");
            //Console.WriteLine("0. Exit");

            //int command = int.Parse(Console.ReadLine());

            //switch (command)
            //{
            //    case 0:
            //        break;
            //    case 1:
            //        emailSender.SendMessage(message);
            //        break;
            //    case 2:
            //        smsSender.SendMessage(message);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid command");
            //        break;
            //}
            #endregion
        }
    }
}


