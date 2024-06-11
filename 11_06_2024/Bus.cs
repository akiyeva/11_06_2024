namespace _11_06_2024
{
    public class Bus : Vehicle
    {
        public int PassengerCount { get; set; }
        public Bus(int year) : base(year)
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Passenger count - {PassengerCount}, color - {Color}, year - {Year}");
        }
    }
}
