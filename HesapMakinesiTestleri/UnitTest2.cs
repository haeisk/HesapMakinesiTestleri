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
}