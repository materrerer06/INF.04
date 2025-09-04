using ConsoleApp2;

Class1 x = new Class1(50);
x.wyswietl();
Console.WriteLine("szukam 500, jest na pozycji: " + x.szukaj(500));
x.np();
int avg = x.srednia;
int min = x.min;
int max = x.max;

Console.WriteLine("Min: " + min);
Console.WriteLine("Max: " + max);
Console.WriteLine("AVG: " + avg);