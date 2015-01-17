using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esri.ArcGISRuntime.Geometry
{
    /// <summary>
    /// A common base class between all units, linear, area and angular units.
    /// </summary>
    /// <remarks>
    /// Custom <see cref="T:Esri.ArcGISRuntime.Geometry.Unit"/> implementations are not supported by ArcGIS Runtime.
    /// </remarks>
    public abstract class Unit
    {
        /// <summary>
        /// Gets the well-known ID of the unit.
        /// </summary>
        public abstract int Id { get; }

        /// <summary>
        /// Gets the name of the unit.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Returns the type of unit.
        /// </summary>
        public abstract UnitType UnitType { get; }

        static Unit()
        {

        }

        /// <summary>
        /// Creates a unit based on a unit ID
        /// 
        /// </summary>
        /// <param name="id"/>
        /// <returns/>
        public abstract Unit Create(int id);
    }
}
