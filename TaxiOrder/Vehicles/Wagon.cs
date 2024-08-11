namespace TaxiOrder.Vehicles
{
	public class Wagon : IVehicle
	{
		public void Drive()
		{
			Console.WriteLine("Повозка скачет к клиенту");
		}
	}
}
