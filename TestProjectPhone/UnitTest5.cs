using ClassLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestPlatform.Utilities;
namespace TestProjectPhone
{
    [TestClass]
    public class PhoneCall
    {
        [TestMethod]
        public void Test_Phone_Call()
        {
            var phone = new Phone("Molenda", "123456789");
            string name = "Molenda 2";
            string number = "987654321";
            phone.AddContact(name, number);
            Assert.ThrowsException<InvalidOperationException>(() => phone.Call("Molenda 3"));
            Assert.AreEqual(phone.Call("Molenda 2"), $"Calling {number} ({name}) ...");
        }
    }
}