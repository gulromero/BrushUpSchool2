using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brush2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brush2.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange
            var teacher = new Teacher { Id = 1, Name = "Gulsum Erd", Salary = 50000 };

            // Act
            string result = teacher.ToString();

            // Assert
            Assert.AreEqual("1 + Gulsum Erd + 50000", result);
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            // Arrange
            var teacher = new Teacher { Name = "G" };

            // Act and assert

            teacher.ValidateName();
            
           
        }

        [TestMethod()]
        public void ValidateSalaryTest()
        {
            // Arrange
            var teacher = new Teacher { Salary = -1000 }; // Using a negative salary

            // Act & Assert

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.ValidateSalary());
        }

        [TestMethod()]
        public void ValidateTest()
        {
          
        }
    }
}