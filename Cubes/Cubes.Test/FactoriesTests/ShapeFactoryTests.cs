using Cubes.Factories;
using Cubes.Factories.Enums;
using Cubes.Factories.Interfaces;
using Cubes.Factories.Models;
using Cubes.Models;
using NUnit.Framework;
using System;

namespace Cubes.Test.FactoriesTests
{
    [TestFixture]
    public class ShapeFactoryTests
    {
        private IShapeFactory _shapeFactory;

        [SetUp]
        public void SetUp()
        {
            _shapeFactory = new ShapeFactory();
        }

        [Test]
        public void CreateCubeTest()
        {
            var args = new ShapeFactoryArgs(ShapeTypeEnum.Cube, 10, 10, 10, 20);
            var result = _shapeFactory.CreateShape(args);

            Assert.IsTrue(result.GetType() == typeof(Cube));
            Assert.IsTrue(result.Coordinates.X == 10 && result.Coordinates.Y == 10 && result.Coordinates.Z == 10);
        }

        [Test]
        public void CreateCubeWithInvalidSizeTest()
        {
            var args = new ShapeFactoryArgs(ShapeTypeEnum.Cube, 0, 0, 0, 0);
            Assert.Throws<ArgumentNullException>(()=>_shapeFactory.CreateShape(args));
        }
    }
}
