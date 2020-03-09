using Cubes.Controllers;
using Cubes.Controllers.Interfaces;
using Cubes.Models;
using NUnit.Framework;
using System.Numerics;

namespace Cubes.Test.ControllersTests
{
    [TestFixture]
    public class CubeColliderControllerTests
    {
        private ICubeColliderController _cubeColliderController;

        [SetUp]
        public void SetUp()
        {
            _cubeColliderController = new CubeColliderController();
        }

        [Test]
        public void CollideTwoCubes()
        {
            var c1 = new Cube(new Vector3(10, 10, 10), 50);
            var c2 = new Cube(new Vector3(20, 20, 20), 50);

            var result = _cubeColliderController.CheckCubeShapeCollision(c1, c2);
            Assert.IsTrue(result);
        }

        [Test]
        public void CubesNotColliding()
        {
            var c2 = new Cube(new Vector3(20, 20, 20), 50);
            var c3 = new Cube(new Vector3(90, 90, 90), 10);

            var result = _cubeColliderController.CheckCubeShapeCollision(c2, c3);
            Assert.IsFalse(result);
        }
    }
}
