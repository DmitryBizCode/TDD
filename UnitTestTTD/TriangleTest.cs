using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDProject;

namespace UnitTestTTD
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle_Correct_create_length()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (1, 2);
            (float X, float Y) c = (2, 0);
            string colour = "Green";
            var tri = new Triangle(a, b, c, colour);
            Assert.AreEqual((float)Math.Sqrt(5), tri.Length(a, b));
            Assert.AreEqual((float)Math.Sqrt(5), tri.Length(c, b));
            Assert.AreEqual(2, tri.Length(c, a));
        }
        [TestMethod]
        public void Triangle_Correct_throw_method()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (5, 0);
            (float X, float Y) c = (11, 0);
            string colour = "Green";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Triangle(a, b, c, colour));
        }
        [TestMethod]
        public void Triangle_Correct_throw_method2()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 5);
            (float X, float Y) c = (0, 11);
            string colour = "Green";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Triangle(a, b, c, colour));
        }
        [TestMethod]
        public void Triangle_S()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (1, 2);
            (float X, float Y) c = (2, 0);
            string colour = "Green";
            var tri = new Triangle(a, b, c, colour);
            Assert.AreEqual(2, tri.S());
        }
        [TestMethod]
        public void Triangle_P()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 3);
            (float X, float Y) c = (3, 0);
            string colour = "Green";
            var tri = new Triangle(a, b, c, colour);
            Assert.AreEqual(3 + 3 + (float)(Math.Sqrt(18)), tri.P());
        }
        [TestMethod]
        public void Triangle_Change_colour()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (1, 2);
            (float X, float Y) c = (2, 0);
            string colour = "Green";
            var tri = new Triangle(a, b, c, colour);
            var Col = new Colour();
            string red = "red";
            Col.ReColour(tri, red);
            Assert.AreEqual(red, tri.Colour);
        }
        [TestMethod]
        public void Triangle_Change_position()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (1, 2);
            (float X, float Y) c = (2, 0);
            string colour = "Green";
            var tri = new Triangle(a, b, c, colour);
            var pos = new Moving();
            (tri.A, tri.B, tri.C) = pos.Move(tri.A, tri.B, tri.C, (1, 0));
            Assert.AreEqual(tri.A, (1, 0));
            Assert.AreEqual(tri.B, (2, 2));
            Assert.AreEqual(tri.C, (3, 0));
        }
        [TestMethod]
        public void Rectangle_Change_Scale()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (1, 2);
            (float X, float Y) c = (2, 0);
            string colour = "Green";
            var tri = new Triangle(a, b, c, colour);
            var scl = new Scale();
            (tri.A, tri.B, tri.C) = scl.Scaling(tri.A, tri.B, tri.C, 1);
            Assert.AreEqual(tri.A, (-1, -1));
            Assert.AreEqual(tri.B, (1, 3));
            Assert.AreEqual(tri.C, (3, -1));
        }
        [TestMethod]
        public void Rectangle_Change_Rotate()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (1, 2);
            (float X, float Y) c = (2, 0);
            string colour = "Green";
            var tri = new Triangle(a, b, c, colour);
            var rot = new Rotate();
            (tri.A, tri.B, tri.C) = rot.RotateFigure(tri.A, tri.B, tri.C, 90);
            Assert.AreEqual(tri.A, ((float)1.67, (float)-0.33));
            Assert.AreEqual(tri.B, ((float)-0.33, (float)0.67));
            Assert.AreEqual(tri.C, ((float)1.67, (float)1.67));
        }
    }
}
