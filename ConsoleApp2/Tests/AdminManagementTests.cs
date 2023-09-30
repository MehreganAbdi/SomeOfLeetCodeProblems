using ConsoleApp2;
using System.Reflection.Metadata;


namespace Tests
{
    public class AdminManagementTests
    {
        private User User1 { get; set; }
        [SetUp]
        public void SetUp()
        {
            User1 =  new User();
        }

        [Test]
        public void CanChangeSiteColorBG_UserIsNotAdmin_Returnfalse()
        {
            User1.IsAdmin = false;

            var result = AdminManagment.CanChangeSiteColorBG(User1);

            Assert.IsFalse(result);
        }

        [Test]
        public void CanChangeSiteColorBG_UserIsAdmin_ReturnTrue()
        {
            User1.IsAdmin = true;

            var result = AdminManagment.CanChangeSiteColorBG(User1);

            Assert.IsTrue(result);

        }


    }

    
}