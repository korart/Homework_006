using TaxiOrder.Drivers;
using TaxiOrder.Vehicles;

namespace TaxiOrder.Factories
{
	internal class WagonFactory : VehicleFactory
	{
		public override string? Description => "Гужевая повозка";
		public override IDriver CreateDriver()
		{
			return new Сoachman();
		}

		public override IVehicle CreateVehicle()
		{
			return new Wagon();
		}
	}
}
