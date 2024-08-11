namespace TaxiOrder.Vehicles
{
	public class Car : IVehicle
	{
		public void Drive()
		{
			Console.WriteLine("Машина едет к клиенту");
		}
	}
}
