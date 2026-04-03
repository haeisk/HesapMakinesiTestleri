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



    [TestCase(5, 3, 8)]
    [TestCase(0, 0, 0)]
    [TestCase(-5, 3, -2)]
    [TestCase(100, 200, 300)]
    public void Topla_FarkliSayilar_DogruSonucDonmeli(int a, int b, int beklenen)
    {
         int sonuc = _hesapMakinesi.Topla(a, b);
         Assert.That(sonuc, Is.EqualTo(beklenen));
    }   

    [Test]
    public void Assert_Ornekleri()
    {
    // Eşitlik
    Assert.That(5 + 3, Is.EqualTo(8));

    // Büyük / küçük kontrolü
    Assert.That(10, Is.GreaterThan(5));
    Assert.That(3, Is.LessThan(7));

    // Null kontrolü
    string isim = null;
    Assert.That(isim, Is.Null);

    // Boolean kontrolü
    Assert.That(5 > 3, Is.True);
    Assert.That(5 < 3, Is.False);

    // Liste içerik kontrolü
    var sayilar = new List<int> { 1, 2, 3, 4, 5 };
    Assert.That(sayilar, Contains.Item(3));
    Assert.That(sayilar, Has.Count.EqualTo(5));
    }
    

    [TearDown]
    public void Teardown()
    {
    Console.WriteLine("Test bitti, temizlik yapılıyor...");
    }
}