using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        // Add
        [Test]
        public void Add_ValidMatthews()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_InvalidMatthews()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_NullMatthews()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Subtract
        [Test]
        public void Subtract_ValidMatthews()
        {
            Assert.AreEqual(0, Program.Subtract("2", "2"));
            Assert.AreEqual(2, Program.Subtract("3", "1"));
            Assert.AreEqual(-1, Program.Subtract("6", "7"));
        }

        [Test]
        public void Subtract_InvalidMatthews()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_NullMatthews()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
        // Multiply 
        [Test]
        public void Multiply_ValidMatthews()
        {
            Assert.AreEqual(4, Program.Multiply("2", "2"));
            Assert.AreEqual(14, Program.Multiply("7", "2"));
            Assert.AreEqual(42, Program.Multiply("6", "7"));
        }

        [Test]
        public void Multiply_InvalidMatthews()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_NullMatthews()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }
        // Divide
        [Test]
        public void Divide_ValidTestMatthews()
        {
            Assert.AreEqual(1.0, Program.Divide("4", "4"));
            Assert.AreEqual(2, Program.Divide("4", "2"));
            Assert.AreEqual(0.7142857, Program.Divide("5", "7"), 0.0000001);
        }

        [Test]
        public void Divide_InvalidMatthews()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_NullMatthews()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
    }
}
