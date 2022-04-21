// See https://aka.ms/new-console-template for more information
try
{
    try
    {
      Console.WriteLine("Bir sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girmiş oldugunuz sayi :" +sayi);  
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hata:" + ex.Message.ToString());
        throw;
    }
}
finally
{
    Console.Write("İşlem tamamlandı.");
}



try
{
    //int a = int.Parse(null);
    int a = int.Parse("test");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
}
catch(FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil");
    Console.WriteLine(ex);
}
catch(OverflowException ex)
{
    Console.WriteLine("Cok kücück yada cok büyük bir değer girdiniz.");
    Console.WriteLine(ex);
}
finally{
    Console.WriteLine("İşlem başarıyla tammalandı.");
}