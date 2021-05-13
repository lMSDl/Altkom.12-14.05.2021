namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Builder
{
    public abstract class VehicleBuilderBase
    {
        protected Vehicle vehicle { get; set; }

        public VehicleBuilderBase() : this(new Vehicle())
        {
        }
        public VehicleBuilderBase(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)vehicle.Clone();
        }
    }
}
