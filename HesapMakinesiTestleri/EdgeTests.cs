namespace HesapMakinesiTestleri;
public class EdgeTests
{
    private HesapMakinesi _hesapMakinesi;

    [SetUp]
    public void Setup()
    {
        _hesapMakinesi = new HesapMakinesi();
    }

    [Test]
    public void Divide_SifiraBolme_HataFirlatmali()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _hesapMakinesi.Divide(a, b));
    }

      [Test]
  
     public void Toplama_MaxValue_Overflown_hataFirlatmali()
    {
        //Arrange
        int a = int.MaxValue;
        int b = 1;
        //Act
        Assert.Throws<OverflowException>(() => _hesapMakinesi.Topla(a, b));
    }

        [Test]
     public void Toplama_Yanlis_Degerler_hataFirlatmali()
    {
        //Arrange
        int a = int.MaxValue;
        int b = 1;
        //Act
        Assert.Throws<OverflowException>(() => _hesapMakinesi.Topla(a, b));
    }


    [Test]
    public void Cikarma_MinValue_Overflow_HataFirlatmali()
    {
    // Arrange
    int a = int.MinValue;
    int b = 1;

    // Act & Assert
    Assert.Throws<OverflowException>(() => _hesapMakinesi.Cikarma(a, b));
    }


    [Test]
    public void Carp_MaxValue_Overflow_HataFirlatmali()
    {
    // Arrange
    int a = int.MaxValue;
    int b = 2;

    // Act & Assert
    Assert.Throws<OverflowException>(() => _hesapMakinesi.Carp(a, b));
    }


    [Test]
    public void Carp_SifirIle_SifirDonmeli()
    {
    // Arrange
    int a = 999;
    int b = 0;

    // Act
    int sonuc = _hesapMakinesi.Carp(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(0));
    }

    [Test]
    public void Carp_IkiNegatif_PozitifDonmeli()
    {
    // Arrange
    int a = -5;
    int b = -3;

    // Act
    int sonuc = _hesapMakinesi.Carp(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(15));
    }

    [Test]
    public void Carp_NegatifVePozitif_NegatifDonmeli()
    {
    // Arrange
    int a = -5;
    int b = 3;

    // Act
    int sonuc = _hesapMakinesi.Carp(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(-15));
    }


    [Test]
    public void Divide_NegatifBoluPozitif_NegatifDonmeli()
    {
    // Arrange
    int a = -10;
    int b = 2;

    // Act
    double sonuc = _hesapMakinesi.Divide(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(-5.0));
    }

    [Test]
    public void Topla_IkiNegatif_NegatifDonmeli()
    {
    // Arrange
    int a = -5;
    int b = -3;

    // Act
    int sonuc = _hesapMakinesi.Topla(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(-8));
    }

    [Test]
    public void Divide_OndalikliSonuc_DogruDonmeli()
    {
    // Arrange
    int a = 10;
    int b = 3;

    // Act
    double sonuc = _hesapMakinesi.Divide(a, b);

    // Assert
    Assert.That(sonuc, Is.EqualTo(10.0 / 3.0));
    }

}