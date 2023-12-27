Console.Write("Введите вещественное число X: ");
double X = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите целое число N (> 0): ");
int N = Convert.ToInt32(Console.ReadLine());

double result = 0;

for (int i = 0; i <= N; i++)
{
    double numerator = Math.Pow(-1, i) * Math.Pow(X, 2 * i);
    double denominator = 2 * i;

    result += numerator / denominator;
}

Console.WriteLine("Значение выражения: " + result);