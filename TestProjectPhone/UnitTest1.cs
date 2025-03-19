using ClassLibrary;


namespace TestProjectPhone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Konstruktor_Dane_Poprawne_Dzia�anie_OK()
        {
            //AAA

            //Araange
            var wlasciciel = "Molenda";
            var numerTelefonu = "123456789";
            //Act
            var phone = new Phone(wlasciciel, numerTelefonu);
            //Assert
            Assert.AreEqual(wlasciciel, phone.Owner);
            Assert.AreEqual(numerTelefonu, phone.PhoneNumber);
            Assert.AreEqual(100, phone.PhoneBookCapacity);
           
        }
    }
}