using ClassLibrary;


namespace TestProjectPhone
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Test_PhoneBook_Add_Contact()
        {
            var phone = new Phone("Molenda", "123456789");
            Assert.AreEqual(0, phone.Count);
            phone.AddContact("Kaczynski", "987654321");
            Assert.AreEqual(1, phone.Count);
            Assert.IsFalse(phone.AddContact("Kaczynski", "987654322"));
        }
        [TestMethod]
        public void Test_Add_Contact_Limit()
        {
            var phone = new Phone("Molenda", "123456789");

            for (int i = 0; i < 101; i++)
            {
                if (phone.Count >= phone.PhoneBookCapacity)
                {
                    Assert.ThrowsException<InvalidOperationException>(() => phone.AddContact($"Kowalski{i}", "000000000"));
                    break;
                }
                phone.AddContact($"Kowalski{i}", $"000000000");
            }
        }
    }
}
