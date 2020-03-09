using Cubes.Controllers;
using Cubes.Controllers.Interfaces;
using Cubes.Models;
using Cubes.Models.Abstracts;
using Moq;
using NUnit.Framework;
using System.Numerics;

namespace Cubes.Test.ControllersTests
{
    [TestFixture]
    public class ColliderControllerTests
    {
        private ColliderController _colliderController;

        [SetUp]
        public void SetUp()
        {
            var cubeColliderControllerMock = new Mock<ICubeColliderController>();
            cubeColliderControllerMock.Setup(x => x.CheckCubeShapeCollision(It.IsAny<Cube>(), It.IsAny<Shape>()))
                .Returns(true);

            _colliderController = new ColliderController(cubeColliderControllerMock.Object);
        }

        [Test]
        public void ValidateShapeCollider()
        {
            var c1 = new Cube(new Vector3(10, 10, 10), 50);
            var c2 = new Cube(new Vector3(20, 20, 20), 50);

            var result = _colliderController.CheckCollision(c1, c2);
            Assert.IsTrue(result);
        }
    }
}
