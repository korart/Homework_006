namespace TaxiOrder.Vehicles
{
	public class Truck : IVehicle
	{
		public void Drive()
		{
			Console.WriteLine("Грузовик тащится к клиенту");
		}
	}
}
