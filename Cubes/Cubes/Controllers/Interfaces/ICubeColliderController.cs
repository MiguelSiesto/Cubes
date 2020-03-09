using Cubes.Models;
using Cubes.Models.Abstracts;

namespace Cubes.Controllers.Interfaces
{
    public interface ICubeColliderController
    {
        public bool CheckCubeShapeCollision(Cube c1, Shape shape2);
    }
}
