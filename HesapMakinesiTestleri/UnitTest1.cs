namespace HesapMakinesiTestleri;

public class Tests
{

    private HesapMakinesi _hesapMakinesi;
    [SetUp]

    public void Setup()
    {
        _hesapMakinesi = new HesapMakinesi();
    }

    [Test]
    public void Topla_IkiPozitifSayi_DogruSonucDonmeli()
    {
        //Arrange
        int a = 5;
        int b = 10;
        //Act
        int sonuc = _hesapMakinesi.Topla(a, b);

        Assert.That(sonuc, Is.EqualTo(15));
    }

       [Test]
  
     public void Divide_IkiPozitifSayi_DogruSonucDonmeli()
    {
        
        //Arrange
        int a = 5;
        int b = 10;
        //Act
        double sonuc = _hesapMakinesi.Divide(a, b);
        Assert.That(sonuc, Is.EqualTo(0.5));
    }
    
       [Test]
     public void Divide_IkiPozitifSayi_YanlisSonucDonmeli()
    {
        
        //Arrange
        int a = 5;
        int b = 0;
        //Act
      
        Assert.Throws<DivideByZeroException>(() => _hesapMakinesi.Divide(a, 0));
       
    }
  
}