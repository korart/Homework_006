namespace TaxiOrder
{
	public abstract class VehicleFactory
	{
		public abstract string? Description { get; }
		public abstract IDriver CreateDriver();
		public abstract IVehicle CreateVehicle();
	}
}
