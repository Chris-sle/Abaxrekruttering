namespace Abaxrekruttering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Car("NF123456", 147, 200, "Grønn", "Lett kjøretøy"),
                new Car("NF654321", 150, 195, "Blå", "Lett kjøretøy")
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.PrintInformation();
            }

            var plain1 = new Plane("LN1234", 1000,  30, 2, 10);
            plain1.PrintInformation();
            plain1.Run();


        }
    }
}
