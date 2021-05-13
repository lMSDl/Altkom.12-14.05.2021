using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Builder
{
    public class VehicleBuildeFacade : VehicleBuilderBase
    {
        public VehicleBuildeFacade()
        {
        }

        protected VehicleBuildeFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Components => new VehicleBuilder(vehicle);
        public VehicleModelInfoBuilder Info => new VehicleModelInfoBuilder(vehicle);
    }
}
