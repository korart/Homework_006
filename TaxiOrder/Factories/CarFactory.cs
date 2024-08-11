using TaxiOrder.Drivers;
using TaxiOrder.Vehicles;

namespace TaxiOrder.Factories
{
	internal class CarFactory : VehicleFactory
	{
		public override string? Description => "Легковая машина";

		public override IDriver CreateDriver()
		{
			return new Racer();
		}

		public override IVehicle CreateVehicle()
		{
			return new Car();
		}
	}
}
