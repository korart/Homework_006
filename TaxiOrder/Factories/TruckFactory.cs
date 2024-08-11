using TaxiOrder.Drivers;
using TaxiOrder.Vehicles;

namespace TaxiOrder.Factories
{
	internal class TruckFactory : VehicleFactory
	{
		public override string? Description => "Грузовая машина";

		public override IDriver CreateDriver()
		{
			return new Trucker();
		}

		public override IVehicle CreateVehicle()
		{
			return new Truck();
		}
	}
}
