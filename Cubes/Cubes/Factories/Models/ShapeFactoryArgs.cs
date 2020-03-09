using Cubes.Factories.Enums;

namespace Cubes.Factories.Models
{
    /// <summary>Factory settings to create a shape.</summary>
    public class ShapeFactoryArgs
    {
        public ShapeFactoryArgs(ShapeTypeEnum shapeType, int positionX, int positionY, int positionZ, int? sideSize = null)
        {
            ShapeType = shapeType;
            PositionX = positionX;
            PositionY = positionY;
            PositionZ = positionZ;
            SideSize = sideSize;
        }

        /// <summary>Gets or sets the type of the shape.</summary>
        /// <value>The type of the shape.</value>
        public ShapeTypeEnum ShapeType { get; set; }

        /// <summary>Gets or sets the position x.</summary>
        /// <value>The X position.</value>
        public int PositionX { get; set; }

        /// <summary>Gets or sets the position y.</summary>
        /// <value>The Y position.</value>
        public int PositionY { get; set; }

        /// <summary>Gets or sets the position z.</summary>
        /// <value>The Z position.</value>
        public int PositionZ { get; set; }

        /// <summary>Gets or sets the size of the side.</summary>
        /// <value>The size of the shape's side.</value>
        public int? SideSize { get; set; }
    }
}
