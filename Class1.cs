namespace isklbibli
{
    public class Class1
    {
        public static void CalculateAndPrint(double N, double k)
        {

            for (double x = 0; x <= k; x += 0.1)
            {
                try
                { 
                    if (Math.Abs(x - N) < 1e-10) { throw new DivideByZeroException(); } // Проверка деления на 0 и вызов дивидебайзиро

                    // Например ошибка деления на 0 вызовется при N = 2, k = 3, в строчке f(2,0)

                    double result = 1 / (x - N);
                    Console.WriteLine($"f({x:N1}) = {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"f({x:N1}) = Деление на ноль!");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"f({x:N1}) = Ошибка: {ex.Message}"); // Какие то другие ошибки
                }
                finally
                {
                    Console.WriteLine("Успешно, идем дальше!"); // Вывод об успехе
                }
            }
        }


    }
}