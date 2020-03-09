using Cubes.Models.Abstracts;

namespace Cubes.Controllers.Interfaces
{
    interface IColliderController
    {
        /// <summary>Checks the collision.</summary>
        /// <param name="shape1">The shape 1.</param>
        /// <param name="shape2">The shape 2.</param>
        /// <returns></returns>
        bool CheckCollision(Shape shape1, Shape shape2);
    }
}
