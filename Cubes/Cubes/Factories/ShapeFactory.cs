using Cubes.Factories.Enums;
using Cubes.Factories.Interfaces;
using Cubes.Factories.Models;
using Cubes.Models;
using Cubes.Models.Abstracts;
using System;
using System.Numerics;

namespace Cubes.Factories
{
    /// <summary></summary>
    /// <seealso cref="Cubes.Factories.Interfaces.IShapeFactory" />
    public class ShapeFactory : IShapeFactory
    {
        public Shape CreateShape(ShapeFactoryArgs args)
        {
            switch (args.ShapeType)
            {
                case ShapeTypeEnum.Cube:
                    if (!args.SideSize.HasValue || args.SideSize.Value<=0)
                        throw new ArgumentNullException("It was not possible to create a Cube, side size is null, negative or 0.");

                    var coords = new Vector3(args.PositionX, args.PositionY, args.PositionZ);
                    return new Cube(coords, args.SideSize.Value);

                default:
                    throw new ArgumentOutOfRangeException("The specified shape cannot be found.");
            }
        }
    }
}
