// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//while
// 1 den başlayarak console dan girilen sayıya kadar (sayı dahil)ortalama hesaplayıp console a yazdıran program.
Console.Write("Lütfen bir sayı giriniz:");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while (sayac <=sayi)
{
    toplam+= sayac;
    sayac++;
}
Console.WriteLine(toplam/sayi);

// a dan z ye kadar türm harfleri console a yazdır.

char character = 'a';
while (character < 'z')
{
    Console.Write(character);
    character++;
}

Console.Write("*****foreach*****");

string[] arabalar = {"BMW","Ford","Toyata","Nissan"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}