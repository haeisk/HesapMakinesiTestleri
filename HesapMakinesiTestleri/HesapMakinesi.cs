namespace HesapMakinesiTestleri;

public class HesapMakinesi
{

    public int Topla(int a,int b)
    {
        checked
        {
        return a + b;
        }

    }

    public int Cikarma(int a,int b)
    {
           checked
        {
        return a - b;
        }
    }

     public double Divide(int a,int b)
    {
            if (b == 0)
            {
                throw new DivideByZeroException("Sıfıra bölünemez!");
            }
                   checked
                        {
                        return (double)a / b;
                        }

    }
    
    public int Carp(int a,int b)
    {
           checked
        {
        return a * b;
        }
    }

    

}