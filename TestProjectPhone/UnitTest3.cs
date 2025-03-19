using ClassLibrary;

public class UnitTest3
{
    [TestMethod]
    public void Test_Private_Set_Phone_Number_Null()
    {
        var wlasciciel = "Molenda";
        Assert.ThrowsException<ArgumentException>(() => new Phone(wlasciciel, null));
    }
    public void Test_Private_Set_Phone_Number_correct()
    {
        var wlasciciel = "Molenda";
        Assert.ThrowsException<ArgumentException>(() => new Phone(wlasciciel, "1234567890"));
        Assert.ThrowsException<ArgumentException>(() => new Phone(wlasciciel, "12345"));
        Assert.ThrowsException<ArgumentException>(() => new Phone(wlasciciel, "aaaaaaaaa"));
    }
}
