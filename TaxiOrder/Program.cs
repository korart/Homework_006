using TaxiOrder.Factories;

namespace TaxiOrder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IDriver driver;
			IVehicle vehicle;
			VehicleFactory factory;

			Console.WriteLine("СЛУЖБА ЗАКАЗА ТАКСИ:");
			Console.WriteLine();
			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("Выберите тип транспортного средства для заказа или введите 0 для выхода:");
				Console.WriteLine("1. Гужевая повозка");
				Console.WriteLine("2. Грузовая машина");
				Console.WriteLine("3. Легковая машина");
				Console.WriteLine("4. Мотоцикл");
				Console.WriteLine("0. Выход");

				int userChoice = Convert.ToInt32(Console.ReadLine());

				switch (userChoice)
				{
					case 1: factory = new WagonFactory(); break;
					case 2: factory = new TruckFactory(); break;
					case 3: factory = new CarFactory(); break;
					case 4: factory = new BikeFactory(); break;
					default: return;
				}

				driver = factory.CreateDriver();
				vehicle = factory.CreateVehicle();

				Console.WriteLine();
				vehicle.Drive();
				Console.WriteLine("Водитель: {0}", driver.DriverType);
			}
		}
	}
}
