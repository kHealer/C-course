// See https://aka.ms/new-console-template for more information
Console.WriteLine("*****atame ve işlemli atama operatörler");
int x = 3;
int y = 3;
y = y+2;

Console.WriteLine(y);
y += 2;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x *=2;
Console.WriteLine(x);

Console.WriteLine("*****mantıksal operatörler");
//mantıksal Operatörler
// ||, &&, !

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted) //2 condition have to be true
Console.WriteLine("Perfect!");

if(isSuccess || isCompleted) //1 condition have to be true to get result
Console.WriteLine("Great!");

if(isSuccess && ! isCompleted) //! with this we make 'false' to true its not operator
Console.WriteLine("Fine!");

Console.WriteLine("*****ilişkisel operatörler");
//ilişkisel Operatörler
// <, >, <= , >=, == ,!=

int a = 3;
int b = 4;
bool sonuc = a<b;

Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a<=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc);

Console.WriteLine("*****Aritmatik operatörler");
//aritmatik operatorler
// /,*,+,-

int sayi1 = 10;
int sayi2 =5;
int sonuc1 = sayi1/sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1*sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1+sayi2;
Console.WriteLine(sonuc1);
sonuc1 =sayi1++;
Console.WriteLine(sayi1);


// % mod alır kalanı bulan ifade
int sonuc2 = 20%3;
Console.WriteLine(sonuc2);


