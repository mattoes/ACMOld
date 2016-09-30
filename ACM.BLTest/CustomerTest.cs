using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {

            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Matt";
            customer.LastName = "Stephens";

            string expected = "Stephens, Matt";

            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Matt";
            string expected = "Matt";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Stephens";
            string expected = "Stephens";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {

            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "Matthew";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Hannah";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Millie";
            Customer.InstanceCount += 1;

            //--Act


            //--Assert
            Assert.AreEqual(Customer.InstanceCount, 3);

        }

        [TestMethod]
        public void ValidateValid()
        {

            //-- Arrange
            var customer = new Customer();
            customer.LastName = "Stephens";
            customer.EmailAddress = "matthew.stephens@reedonline.co.uk";

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange

           var customer = new Customer();
           customer.LastName = "";

            var expected = false;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(actual, expected);


        }

        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            //-Arrange
            var customer = new Customer();
            customer.EmailAddress = "";

            var expected = false;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(actual, expected);


        }
    }
}
