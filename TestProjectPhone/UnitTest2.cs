using ClassLibrary;

public class UnitTest2
{
    [TestMethod]
    public void Test_Private_Set_Owner()
    {
        var numerTelefonu = "123456789";
        Assert.ThrowsException<ArgumentException>(() => new Phone(null, numerTelefonu));
    }
}
