/*void Increment(ref int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

int number = 5;
Console.WriteLine($"Число до метода Increment: {number}");
Increment(ref number);
Console.WriteLine($"Число после методе Increment: {number}");*/

//Выходные параметры.Модификатор Out

/*void Sum(int x, int y, out int result, out int minus, out int umnosheniye, out int delenye)
{
    result = x + y;
    minus = x - y;
    umnosheniye = x * y;
    delenye = y / y;

}
Console.Write("Введите первое число");
double sum = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число");
double sum2 = Convert.ToDouble(Console.ReadLine());

int number;
int e_minus;
int u_umnoshenye;
int d_delenye;*/



////////////////////////////////////////////////////////
void GRD(in int width, in int height, out int rectArea, out int rectPerimetr)
{
    //width = 25; // нельзя изменить ,так как width - входной параметр
    rectArea = width * height;

    rectPerimetr = (width + height) * 2;
}

int W = 10;
int H = 20;
GRD(W, H, out var area, out var perimetr);

Console.WriteLine($"Площать прямоугольника: {area}");
Console.WriteLine($"Периметр прямоугольника: {perimetr}");




