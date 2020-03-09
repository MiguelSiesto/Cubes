using Cubes.Controllers.Interfaces;
using Cubes.Models;
using Cubes.Models.Abstracts;
using System;

namespace Cubes.Controllers
{
    /// <summary>Implementation of the Collider Controller.</summary>
    /// <seealso cref="IColliderController" />
    public class ColliderController : IColliderController
    {
        /// <summary>The cube collider controller</summary>
        private readonly ICubeColliderController cubeColliderController;

        /// <summary>Initializes a new instance of the <see cref="ColliderController"/> class.</summary>
        /// <param name="cubeColliderController">The cube collider controller.</param>
        public ColliderController(ICubeColliderController cubeColliderController)
        {
            this.cubeColliderController = cubeColliderController;
        }

        /// <summary>Checks the collision between two shapes.</summary>
        /// <param name="shape1">The shape 1.</param>
        /// <param name="shape2">The shape 2.</param>
        /// <returns>Shapes collide or not.</returns>
        /// <exception cref="TypeLoadException">One of the shape's has an invalid type.</exception>
        public bool CheckCollision(Shape shape1, Shape shape2)
        {
            return shape1 switch
            {
                Cube c1 => cubeColliderController.CheckCubeShapeCollision(c1, shape2),
                _ => throw new TypeLoadException("The shape 1 has an invalid type."),
            };
        }
    }
}
