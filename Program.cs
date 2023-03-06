
//işlem
//1-bakiye görüntüleme
//2-para çekme
//3-para yatırma limit koy 5000tl
//q bas çık

Console.WriteLine("welcome to atm");
Console.WriteLine("hoşgeldiniz");

int hesap = 3000;

Console.WriteLine("1-hesap bakiye miktarı :");
Console.WriteLine("2-para çek");
Console.WriteLine("3-para yatır");
Console.WriteLine("4 çıkış");
string secim = Console.ReadLine(); 
switch (secim)
{
    case "1":

        Console.WriteLine("hesapta ki bakiye" + hesap);
        Console.Read();
        break;

    case "2":

        Console.WriteLine("çekmek istediğiniz miktar");
        int cekilecek_deger=Convert.ToUInt16((Console.ReadLine()));

         if (cekilecek_deger>hesap)
        {
            Console.WriteLine("hesabınızda bulunan değerden fazla çekemezsiniz");
            Console.ReadLine();
           
        }
        
         else
        {
            int total = hesap - cekilecek_deger;
            Console.WriteLine("kalan tutar :" +total);
            Console.ReadLine();
        }
        break;

    case "3":
        Console.WriteLine("yatırmak istediğiniz tutar:");
        int para_yatır =Convert.ToUInt16((Console.ReadLine()));

        if (para_yatır > 5000)
        {
            Console.WriteLine("limit 5000 tl ' yi geçemez");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("hesaptaki toplam miktar: " + (para_yatır + hesap));
            Console.ReadLine();
        }
        break;
    case "4":
        Console.WriteLine("hesabınızdan çıkış yapılıyor teşekkürler");
        Console.ReadLine();

        break;

    default:
        Console.WriteLine("lütfen geçerli bir değer giriniz");
        Console.ReadLine();
        break;






}