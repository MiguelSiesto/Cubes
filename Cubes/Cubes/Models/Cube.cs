using System.Numerics;
using Cubes.Factories.Enums;
using Cubes.Models.Abstracts;

namespace Cubes.Models
{
    /// <summary>Cube shape</summary>
    /// <seealso cref="Shape" />
    public class Cube : Shape
    {
        /// <summary>Gets the size of the side.</summary>
        /// <value>The size of the cube's sides.</value>
        public int SideSize { get; private set; }

        /// <summary>Initializes a new instance of the <see cref="Cube"/> class.</summary>
        /// <param name="coords">The shape's coordinates.</param>
        /// <param name="sideSize">Size of the cube's sides.</param>
        public Cube(Vector3 coords, int sideSize) : base(coords)
        {
            SideSize = sideSize;
        }
    }
}
