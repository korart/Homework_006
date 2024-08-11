using TaxiOrder.Drivers;
using TaxiOrder.Vehicles;

namespace TaxiOrder.Factories
{
	internal class BikeFactory : VehicleFactory
	{
		public override string? Description => "Мотоцикл";
		public override IDriver CreateDriver()
		{
			return new Biker();
		}

		public override IVehicle CreateVehicle()
		{
			return new Bike();
		}
	}
}
