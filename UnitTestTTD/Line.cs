using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDProject;

namespace UnitTestTTD
{
    [TestClass]
    public class Line
    {
        
        [TestMethod]
        public void Arrow_Correct_create_length()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (5, 5);
            string colour = "Green";
            var line = new Arrow(a,b,colour);
            Assert.AreEqual((float)Math.Sqrt(50), line.Length(a, b));
        }
        [TestMethod]
        public void Arrow_Correct_throw_method()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 0);
            string colour = "Green";
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Arrow(a, b, colour));
        }
        [TestMethod]
        public void Arrow_Change_colour()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (5, 5);
            string colour = "Green";
            var line = new Arrow(a, b, colour);
            var Col = new Colour();
            string red = "red";
            Col.ReColour(line, red);
            Assert.AreEqual(red , line.Colour);
        }
        [TestMethod]
        public void Arrow_Change_position()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (5, 5);
            string colour = "Green";
            var line = new Arrow(a, b, colour);
            var pos = new Moving();
            (line.A, line.B) = pos.Move(line.A, line.B, (1, 0));
            Assert.AreEqual(line.A, (1, 0));
            Assert.AreEqual(line.B, (6, 5));
        }
        [TestMethod]
        public void Arrow_Change_Scale1()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (5, 5);
            string colour = "Green";
            var line = new Arrow(a, b, colour);
            var scl = new Scale();
            (line.A, line.B) = scl.Scaling(line.A, line.B, 1);
            Assert.AreEqual(line.A, (-1, -1));
            Assert.AreEqual(line.B, (6, 6));
        }
        [TestMethod]
        public void Arrow_Change_Scale2()
        {
            (float X, float Y) a = (0, 0);
            (float X, float Y) b = (0, 5);
            string colour = "Green";
            var line = new Arrow(a, b, colour);
            var scl = new Scale();
            (line.A, line.B) = scl.Scaling(line.A, line.B, 1);
            Assert.AreEqual(line.A, (0, -1));
            Assert.AreEqual(line.B, (0, 6));
        }
        [TestMethod]
        public void Arrow_Change_Scale3()
        {
            (float X, float Y) a = (0, 5);
            (float X, float Y) b = (5, 5);
            string colour = "Green";
            var line = new Arrow(a, b, colour);
            var scl = new Scale();
            (line.A, line.B) = scl.Scaling(line.A, line.B, 1);
            Assert.AreEqual(line.A, (-1, 5));
            Assert.AreEqual(line.B, (6, 5));
        }
        [TestMethod]
        public void Arrow_Change_Scale4()
        {
            (float X, float Y) a = (2, 2);
            (float X, float Y) b = (-5, 5);
            string colour = "Green";
            var line = new Arrow(a, b, colour);
            var scl = new Scale();
            (line.A, line.B) = scl.Scaling(line.A, line.B, 1);
            Assert.AreEqual(line.A, (3, 1));
            Assert.AreEqual(line.B, (-6, 6));
        }
        [TestMethod]
        public void Arrow_Change_Scale5()
        {
            (float X, float Y) a = (3, 4);
            (float X, float Y) b = (3, 0);
            string colour = "Green";
            var line = new Arrow(a, b, colour);
            var scl = new Scale();
            (line.A, line.B) = scl.Scaling(line.A, line.B, 1);
            Assert.AreEqual(line.A, (3, 5));
            Assert.AreEqual(line.B, (3, -1));
        }
        [TestMethod]
        public void Arrow_Change_Rotate()
        {
            (float X, float Y) a = (3, 0);
            (float X, float Y) b = (3, 4);
            string colour = "Green";
            var line = new Arrow(a, b, colour);
            var rot = new Rotate();
            (line.A, line.B) = rot.RotateFigure(line.A, line.B, 90);
            Assert.AreEqual(line.A, (5, 2));
            Assert.AreEqual(line.B, (1, 2));
        }
    }
}
