namespace _11_06_2024
{
    public class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public Car(int year, string brand, string model) : base(year) {
            Brand = brand;
            Model = model;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Brand - {Brand}, model - {Model}, maximal speed - {MaxSpeed}, color - {Color}, year - {Year}");
        }
    }
}
