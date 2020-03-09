using Cubes.Factories.Enums;
using System.Numerics;

namespace Cubes.Models.Abstracts
{
    /// <summary>Shape base abstract class</summary>
    public abstract class Shape
    {
        /// <summary>Gets the coordinates.</summary>
        /// <value>The shape's coordinates.</value>
        public Vector3 Coordinates { get; private set; }

        /// <summary>Initializes a new instance of the <see cref="Shape"/> class.</summary>
        /// <param name="shapeType">Type of the shape.</param>
        /// <param name="coords">The shape's coordinates.</param>
        protected Shape(Vector3 coords)
        {
            Coordinates = coords;
        }

    }
}
