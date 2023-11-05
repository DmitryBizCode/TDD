using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDProject;

namespace UnitTestTTD
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void Rectangle_Correct_create_length()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 2);
            (float X, float Y) c = (4, 2);
            (float X, float Y) d = (4, 0);
            string colour = "Green";
            var rec = new Rectangle(a, b, c, d, colour);
            Assert.AreEqual(2, rec.Length(a, b));
            Assert.AreEqual(4, rec.Length(c, b));
            Assert.AreEqual(2, rec.Length(c, d));
            Assert.AreEqual(4, rec.Length(d, a));
        }
        [TestMethod]
        public void Rectangle_Correct_throw_method()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 2);
            (float X, float Y) c = (2, 2);
            (float X, float Y) d = (4, 0);
            string colour = "Green";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Rectangle(a, b, c, d, colour));
        }
        [TestMethod]
        public void Rectangle_S()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 2);
            (float X, float Y) c = (4, 2);
            (float X, float Y) d = (4, 0);
            string colour = "Green";
            var rec = new Rectangle(a, b, c, d, colour);
            Assert.AreEqual(8, rec.S());
        }
        [TestMethod]
        public void Rectangle_P()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 2);
            (float X, float Y) c = (4, 2);
            (float X, float Y) d = (4, 0);
            string colour = "Green";
            var rec = new Rectangle(a, b, c, d, colour);
            Assert.AreEqual(12, rec.P());
        }
        [TestMethod]
        public void Rectangle_Change_colour()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 2);
            (float X, float Y) c = (4, 2);
            (float X, float Y) d = (4, 0);
            string colour = "Green";
            var rec = new Rectangle(a, b, c, d, colour);
            var Col = new Colour();
            string red = "red";
            Col.ReColour(rec, red);
            Assert.AreEqual(red, rec.Colour);
        }
        [TestMethod]
        public void Rectangle_Change_position()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 2);
            (float X, float Y) c = (4, 2);
            (float X, float Y) d = (4, 0);
            string colour = "Green";
            var rec = new Rectangle(a, b, c, d, colour);
            var pos = new Moving();
            (rec.A, rec.B, rec.C, rec.D) = pos.Move(rec.A, rec.B, rec.C, rec.D, (1, 0));
            Assert.AreEqual(rec.A, (1, 0));
            Assert.AreEqual(rec.B, (1, 2));
            Assert.AreEqual(rec.C, (5, 2));
            Assert.AreEqual(rec.D, (5, 0));
        }
        [TestMethod]
        public void Rectangle_Change_Scale()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 2);
            (float X, float Y) c = (4, 2);
            (float X, float Y) d = (4, 0);
            string colour = "Green";
            var rec = new Rectangle(a, b, c, d, colour);
            var scl = new Scale();
            (rec.A, rec.B, rec.C, rec.D) = scl.Scaling(rec.A, rec.B, rec.C, rec.D, 1);
            Assert.AreEqual(rec.A, (-1, -1));
            Assert.AreEqual(rec.B, (-1, 3));
            Assert.AreEqual(rec.C, (5, 3));
            Assert.AreEqual(rec.D, (5, -1));
        }
        [TestMethod]
        public void Rectangle_Change_Rotate()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 2);
            (float X, float Y) c = (4, 2);
            (float X, float Y) d = (4, 0);
            string colour = "Green";
            var rec = new Rectangle(a, b, c, d, colour);
            var rot = new Rotate();
            (rec.A, rec.B, rec.C, rec.D) = rot.RotateFigure(rec.A, rec.B, rec.C, rec.D, 90);
            Assert.AreEqual(rec.A, (3, -1));
            Assert.AreEqual(rec.B, (1, -1));
            Assert.AreEqual(rec.C, (1, 3));
            Assert.AreEqual(rec.D, (3, 3));
        }
    }
}
