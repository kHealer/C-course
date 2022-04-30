// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// sort
int[] sayiDizisi = {23,12,4,86,72,3,11,17};

Console.WriteLine("****sırasız dizi****"); 
foreach (var sayi in sayiDizisi)
{
   Console.WriteLine(sayi); 
}
Console.WriteLine("****sıralı dizi****");
Array.Sort(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//Clear
Console.WriteLine("****Array Clear****");
// sayidizisi elemanlarını kullanarak 2.indexten itaberen 2 tane elemanı 0 lar.
Array.Clear(sayiDizisi,2,2);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//reverse
Console.WriteLine("****Array reverse****");
Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
//indexof
Console.WriteLine("****index of****");
Console.WriteLine(Array.IndexOf(sayiDizisi,23));

//resize
Console.WriteLine("****re size****");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8] = 99;

foreach (var sayi  in sayiDizisi)
{
    Console.WriteLine(sayi);
}