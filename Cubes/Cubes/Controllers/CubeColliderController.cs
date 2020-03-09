using Cubes.Controllers.Interfaces;
using Cubes.Models;
using Cubes.Models.Abstracts;
using System;

namespace Cubes.Controllers
{
    /// <summary>Validates if a cube collides with another shape.</summary>
    /// <seealso cref="ICubeColliderController" />
    public class CubeColliderController : ICubeColliderController
    {

        /// <summary>Checks the cube shape collision.</summary>
        /// <param name="c1">The shape 1 as cube.</param>
        /// <param name="shape2">The shape2.</param>
        /// <returns>The shapes collide or not.</returns>
        public bool CheckCubeShapeCollision(Cube c1, Shape shape2)
        {
            return shape2 switch
            {
                Cube c2 => CheckCubesCollision(c1, c2),
                _ => throw new TypeLoadException("The shape 2 has an invalid type."),
            };
        }

        /// <summary>Checks the cubes collision.</summary>
        /// <param name="a">The cube 1.</param>
        /// <param name="b">The cube 2.</param>
        /// <returns>The cubes collide or not.</returns>
        private bool CheckCubesCollision(Cube a, Cube b) =>
            //check the X axis
            Math.Abs(a.Coordinates.X - b.Coordinates.X) < a.SideSize + b.SideSize
            //check the Y axis
            && Math.Abs(a.Coordinates.Y - b.Coordinates.Y) < a.SideSize + b.SideSize
            //check the Z axis
            && Math.Abs(a.Coordinates.Z - b.Coordinates.Z) < a.SideSize + b.SideSize;
    }
}
