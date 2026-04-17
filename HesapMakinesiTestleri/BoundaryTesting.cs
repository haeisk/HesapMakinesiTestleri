namespace HesapMakinesiTestleri;

public class BoundaryTesting
{

    private HesapMakinesi _hesapMakinesi;
    [SetUp]

    public void Setup()
    {
        _hesapMakinesi = new HesapMakinesi();
    }

    [Test]
    public void Topla_SifirIleSifir_SifirDonmeli()
    {
    // Arrange
    int a = 0;
    int b = 0;

    // Act
    int sonuc = _hesapMakinesi.Topla(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(0));
    }

    [Test]
    public void Cikarma_SifirEksiSifir_SifirDonmeli()
    {
    // Arrange
    int a = 0;
    int b = 0;

    // Act
    int sonuc = _hesapMakinesi.Cikarma(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(0));
    }

    [Test]
    public void Topla_MinValueVeMaxValue_EksibirDonmeli()
    {
    // Arrange
    int a = int.MinValue;
    int b = int.MaxValue;

    // Act
    int sonuc = _hesapMakinesi.Topla(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(-1));
    }

    [Test]
    public void Divide_BirineBolme_AyniSayiDonmeli()
    {
    // Arrange
    int a = 99;
    int b = 1;

    // Act
    double sonuc = _hesapMakinesi.Divide(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(99.0));
    }

    [Test]
    public void Cikarma_AynıSayilar_SifirDonmeli()
    {
    // Arrange
    int a = int.MaxValue;
    int b = int.MaxValue;

    // Act
    int sonuc = _hesapMakinesi.Cikarma(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(0));
    }
    
    [Test]
    public void Carp_BirIle_AyniSayiDonmeli()
    {
    // Arrange
    int a = 999;
    int b = 1;

    // Act
    int sonuc = _hesapMakinesi.Carp(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(999));
    }

    [Test]
    public void Topla_SifirEkleme_AyniSayiDonmeli()
    {
    // Arrange
    int a = 999;
    int b = 0;

    // Act
    int sonuc = _hesapMakinesi.Topla(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(999));
    }

    [Test]
    public void Cikarma_MinValueEksiMinValue_SifirDonmeli()
    {
    // Arrange
    int a = int.MinValue;
    int b = int.MinValue;

    // Act
    int sonuc = _hesapMakinesi.Cikarma(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(0));
    }   

}