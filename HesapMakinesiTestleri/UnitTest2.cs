namespace HesapMakinesiTestleri;

public class Tests1
{

    private HesapMakinesi _hesapMakinesi;
    [SetUp]

    public void Setup()
    {
        _hesapMakinesi = new HesapMakinesi();
    }

    [Test]
  
     public void Cikarma_IkiPozitifSayi_DogruSonucDonmeli()
    {
        //Arrange
        int a = 5;
        int b = 10;
        //Act
        int sonuc = _hesapMakinesi.Cikarma(a, b);

        Assert.That(sonuc, Is.EqualTo(-5));
    }



    [TestCase(5, 3, 2)]
    [TestCase(0, 0, 0)]
    [TestCase(-5, 3, -8)]
    [TestCase(100, 200, -100)]
     public void Cikarma_FarkliSayilar_DogruSonucDonmeli(int a , int b, int beklenen)
    {
        //Arrange
        
        //Act
        int sonuc = _hesapMakinesi.Cikarma(a, b);

        Assert.That(sonuc, Is.EqualTo(beklenen));
    }



       [Test]
  
     public void Carp_IkiPozitifSayi_DogruSonucDonmeli()
    {
        //Arrange
        int a = 5;
        int b = 10;
        //Act
        int sonuc = _hesapMakinesi.Carp(a, b);

        Assert.That(sonuc, Is.EqualTo(50));
    }

    [TearDown]
    public void Teardown()
    {
    Console.WriteLine("Test bitti, temizlik yapılıyor...");
    }


}