using Cubes.Factories.Enums;
using Cubes.Factories.Models;
using Cubes.Models.Abstracts;

namespace Cubes.Factories.Interfaces
{
    /// <summary>Shape Factory contract.</summary>
    public interface IShapeFactory
    {
        /// <summary>Creates a shape.</summary>
        /// <param name="args">Shape parameters</param>
        /// <returns></returns>
        public Shape CreateShape(ShapeFactoryArgs args);
    }
}
