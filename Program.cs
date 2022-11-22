namespace methods;
class Program
{
   
    static void Main(string[] args)
    {
        //Method kullanımı
      int a=2;
      int b=3;
      Console.WriteLine(a+b);

      int sonuc = topla(a,b);
      Console.WriteLine(sonuc);

      metodlar metot=new metodlar();
      metot.yazdir(sonuc.ToString());

      int sonuc2 = metot.arttirvetopla(ref a,ref b);
      metot.yazdir(sonuc2.ToString());
      metot.yazdir(Convert.ToString(a+b));
    }

     static int topla(int a,int b){
        return a+b;
    }

}

class metodlar
{
    public void yazdir(string deger){
        Console.WriteLine(deger);
    }

    public int arttirvetopla(ref int d1,ref int d2){
        d1+=1;
        d2+=1;
        return d1+d2;
    }
}
