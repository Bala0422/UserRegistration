using Newtonsoft.Json.Linq;
using Registration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Bala")]
        [DataRow("Sai")]
        public void FirstNameHappyTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.FirstName();

                //assert
                Assert.IsTrue(actual);
            }
        }




        [TestMethod]
        [DataRow("bala")]
        [DataRow("sai")]

        public void FirstNameSadTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.FirstName();

                //assert
                Assert.IsFalse(actual);
            }
        }


        [TestMethod]
        [DataRow("Murugan")]
        [DataRow("Padmash")]
        public void LastNameHappyTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.LastName();

                //assert
                Assert.IsTrue(actual);
            }
        }

        [TestMethod]
        [DataRow("murugan")]
        [DataRow("padmesh")]

        public void LastNameSadTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.LastName();

                //assert
                Assert.IsFalse(actual);
            }
        }

        [TestMethod]
        [DataRow("bala@gmail.com")]
        [DataRow("bal@gml.cm")]
        [DataRow("Bala.B@ge.co.in")]

        public void EmailHappyTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.Email();

                //assert
                Assert.IsTrue(actual);
            }
        }


        [TestMethod]
        [DataRow("balagmail.com")]
        [DataRow("bal@gmcm")]
        [DataRow("@ge.co.in")]

        public void EmailSadTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.Email();

                //assert
                Assert.IsFalse(actual);
            }
        }


        [TestMethod]
        [DataRow("91 1234567890")]
        [DataRow("09 1234567890")]
        

        public void MobileNumberHappyTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.Mobile();

                //assert
                Assert.IsTrue(actual);
            }
        }

        [TestMethod]
        [DataRow("911234567890")]
        [DataRow("09 12345678")]
        [DataRow(" 12345678")]

        public void MobileNumberSadTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.Mobile();

                //assert
                Assert.IsFalse(actual);
            }
        }

        [TestMethod]
        [DataRow("#baLa1234")]
        [DataRow("#12Bala34")]
        [DataRow("Bala#1234")]

        public void PasswordHappyTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.Password();

                //assert
                Assert.IsTrue(actual);
            }
        }

        [TestMethod]
        [DataRow("baLa1234")]
        [DataRow("#12ala34")]
        [DataRow("B")]
        [DataRow("1234")]

        public void PasswordSadTesting(string value)
        {
            using (var reader = new StringReader(value))
            {
                Console.SetIn(reader);

                // arrange
                Register register = new Register();

                // act
                bool actual = register.Password();

                //assert
                Assert.IsFalse(actual);
            }
        }


    }
}