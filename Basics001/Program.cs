using System;

namespace Basics001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            //Console.WriteLine("inverted number");
            //int z = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(z % 10 * 100 + z % 100 / 10 * 10 + z / 100);

            #endregion

            #region
            //Console.WriteLine("sum of numbers");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = a % 100;
            //int c = b / 10;
            //b = a / 100;
            //int y = a % 10;
            //int x = y + b + c;
            //Console.WriteLine(x);

            #endregion

            #region
            //Console.WriteLine("distance between points");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //double a = (Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2));
            //Console.WriteLine(Math.Sqrt(a));
            #endregion

            #region
            //Console.WriteLine("Определите, принадлежит ли точка xx  одному из выделенных отрезков BB или DD.");
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (x < -3 || x > 9)
            //{
            //    Console.WriteLine("NO");
            //}
            //else
            //{
            //    if (x > 1 && x < 5)
            //    {
            //        Console.WriteLine("NO");
            //    }
            //    else
            //    {
            //        Console.WriteLine("YES");
            //    }
            //}
            #endregion
            #region
            //Console.WriteLine("Даны действительные числа aa, bb, cc. Найдите все решения квадратного уравнения ax^2 + bx + c = 0ax2+ bx + c = 0.");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            //double D = Math.Pow(b, 2) - 4 * a * c;

            //if (D >= 0)
            //{
            //    if (D > 0)
            //    {
            //        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            //        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            //        Console.WriteLine(Math.Min(x1, x2));
            //        Console.WriteLine(Math.Max(x1, x2));
            //    }
            //    else
            //    {
            //        double x3 = -b / (2 * a);
            //        Console.WriteLine(x3);
            //    }
            //}
            #endregion
            #region
            //Console.WriteLine("По данному месяцу, определите количество дней в этом месяце.");
            //int a = Convert.ToInt32(Console.ReadLine());
            //switch (a)
            //{
            //    case 1: case 3: case 5: case 7: case 8: case 10: case 12: Console.WriteLine(31); break;
            //    case 2: Console.WriteLine(29); break;
            //    case 4: case 6: case 9: case 11: Console.WriteLine(30); break;

            //}
            #endregion
            #region

            // Console.WriteLine("По данному месяцу, определите количество дней в этом месяце.");
            //int a = Convert.ToInt32(Console.ReadLine());
            //switch (a)
            //{
            //    case 1: case 3: case 5: case 7: case 8: case 10: case 12: Console.WriteLine(31); break;
            //    case 2: Console.WriteLine(29); break;
            //    case 4: case 6: case 9: case 11: Console.WriteLine(30); break;

            //}

            #endregion
            #region
            // Console.WriteLine("По данным сторонам треугольника, определите, существует ли невырожденный треугольник.");

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());


            //if (((a + b) > c) && ((a + c) > b) && ((c + b) > a))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //    Console.WriteLine("NO");
            #endregion

            #region

            // Console.WriteLine("По данным числам, определите наличие нуля среди них.  ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int num = 0;
            //int sum = 0;
            //for (int i = 1; i <= x; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num == 0)
            //    {
            //        sum++;
            //    }

            //}
            //if (sum == 0)
            //{
            //    Console.WriteLine("NO");

            //}
            //else
            //    Console.WriteLine("YES");

            #endregion

            #region
            // Console.WriteLine("По данным двум целым числам aa и bb, вычислите произведение чисел на отрезке от aa до bb, оканчивающихся на 77 . ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int p = 1;
            //for (int i = a; i <= b; i++)
            //{
            //    if ((i % 10 == 7) || (i % 10 == -7))
            //    {
            //        p = i * p;

            //    }
            //}

            //Console.WriteLine(p);

            #endregion

            #region
            //Console.WriteLine("Наибольший общий делитель (НОД) двух чисел");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int y = Math.Max(a, b);
            //int x = Math.Min(a, b);
            //int c;
            //while (y - x != 0)
            //{

            //    c = y - x;
            //    y = Math.Max(x, c);

            //    x = Math.Min(x, c);
            //}

            //Console.WriteLine(x);
            #endregion

            #region
            //Console.WriteLine("Дано натуральное число N. Выведите количество единиц в его в двоичном представлении. ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int c;
            //while (n > 0)
            //{
            //    c = n % 2;
            //    if (c != 0)
            //    {
            //        sum = sum + 1;
            //    }

            //    n = n / 2;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region
            //Console.WriteLine("Последовательность состоит из целых чисел и завершается числом 0. Определите, сколько раз в этой последовательности меняется знак. Гарантируется, что последовательность не пустая.");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while ((n1 != 0) && (n2 != 0))
            //{
            //    if (((n1 > 0) && (n2 < 0)) || ((n1 < 0) && (n2 > 0)))
            //    {
            //        sum = sum + 1;
            //    }
            //    n1 = n2;
            //    n2 = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine(sum);
            #endregion

            #region
            //Console.WriteLine("Вывести представление целого числа NN в виде произведения простых чисел.");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int a = 2;
            //while (a < n)
            //{

            //    while (n % a == 0)
            //    {
            //        Console.Write(a + " ");
            //        n = n / a;


            //    }
            //    a++;
            //}
            //if (a == n)
            //{
            //    Console.Write(a + " ");
            //}
            #endregion


            #region
            Console.WriteLine("Найдите первое число от 11 до nn, кратное cc, но НЕ кратное dd.");

            //int n = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int i;
            //for (i = 1; i <= n; i++)
            //{
            //    if (i % c == 0 && i % d != 0)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

            #endregion

            #region
            //Console.WriteLine("По данным целым числам a, b, c, da,b,c,d и ee, найдите количество целых решений уравнения (ax^3 + bx^2 + cx + d) / (x - e) = 0(ax + bx2 + cx + d) / (x−e)= 0 на отрезке[0, 1000].[0,1000].");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int e = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (double x = 0; x <= 1000; x++)
            //{
            //    if ((((a * (Math.Pow(x, 3)) + b * (Math.Pow(x, 2)) + (c * x) + d) / (x - e)) == 0) && (x != e) && (((a * (Math.Pow(x, 3)) + b * (Math.Pow(x, 2)) + (c * x) + d) % (x - e)) == 0))
            //    {
            //        sum++;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region
            Console.WriteLine("Последовательность состоит из различных натуральных чисел и завершается числом 00. Определите значение второго по величине элемента в этой последовательности. Числа, следующие за числом 00, считывать не нужно.");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max1 = Math.Max(a, n);
            //int max2 = Math.Min(a, n);
            //while (true)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n == 0) { break; }
            //    if (n > max1)
            //    {
            //        max2 = max1;
            //        max1 = n;
            //    }
            //    if (n > max2 && n < max1)
            //    { max2 = n; }
            //}
            Console.WriteLine(max2);
            #endregion

            #region
            // Кажется, еще совсем недавно наступил новый 2013 год.
            //А знали ли Вы забавный факт о том, что 2013 год является первым годом после далекого 1987 года, в котором все цифры различны?
            //Теперь же Вам предлагается решить следующую задачу: задан номер года, найдите наименьший номер года,
            //который строго больше заданного и в котором все цифры различны.

            //int i = Convert.ToInt32(Console.ReadLine());
            //if (i >= 1000 && i <= 9000)
            //{
            //    int q = i / 1000;
            //    int w = i / 100 % 10;
            //    int e = i / 10 % 10;
            //    int r = i % 10;
            //    while (true)
            //    {
            //        i++;
            //        q = i / 1000;
            //        w = i / 100 % 10;
            //        e = i / 10 % 10;
            //        r = i % 10;
            //        if ((q != w) && (q != e) && (q != r) && (w != e) && (w != r) && (e != r))
            //        {
            //            Console.WriteLine(i); break;
            //        }
            //    }
            //}

            #endregion

            #region
            //Console.WriteLine("По заданной строчной букве латинского алфавита, выведите все строчные буквы латинского алфавита, начиная от заданной буквы до конца алфавита.");
            //char c = Convert.ToChar(Console.ReadLine());
            //for (char i = c; i <= 'z'; i++)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region
            //Console.WriteLine("Дана строка. Определите, какой символ в ней встречается раньше: 'x' или 'w'. Если таких символов нет, вывести  -1.");
            //string s = Console.ReadLine();
            //int b = s.Length;
            //int j = 0;
            //int a;
            //for (a = 0; a <= b - 1; a++)
            //{
            //    if (s[a] == 'x')
            //    {
            //        Console.WriteLine("x");
            //        a = b + 1;
            //        break;
            //    }
            //    else
            //        if (s[a] == 'w')
            //    {
            //        Console.WriteLine("w");
            //        a = b + 1;
            //        break;
            //    }
            //    if (a == b - 1)
            //    {
            //        Console.WriteLine("-1");
            //    }
            //}
            #endregion


            #region
            //Определить, является ли введенное слово идентификатором, т.е. начинается ли оно с английской буквы в любом регистре или со знака подчеркивания,
            // так же она НЕ должна содержать других символов, КРОМЕ букв английского алфавита (в любом регистре), цифр и знака подчеркивания.
            //string s = Console.ReadLine();
            //int d = s.Length;
            //int a = 0;
            //if (((s[0] >= 'A') && (s[0] <= 'Z')) || ((s[0] >= 'a') && (s[0] <= 'z')) || (s[0] == '_'))
            //{
            //    for (int i = 1; i <= d - 1; i++)
            //    {
            //        if (((s[i] >= 'A') && (s[i] <= 'Z')) || ((s[i] >= 'a') && (s[i] <= 'z')) || ((s[i] >= '0') && (s[i] <= '9')) || (s[i] == '_'))
            //        {
            //            continue;
            //        }
            //        else Console.WriteLine("NO"); a++; break;
            //    }
            //    if (a == 0)
            //        Console.WriteLine("YES");
            //}
            //else Console.WriteLine("NO");
            #endregion


            #region
            //Иногда некоторые слова вроде localization или internationalization настолько длинны, что их весьма утомительно писать много раз в каком либо тексте.
            // Будем считать слово слишком длинным, если его длина строго больше 1010 символов.Все слишком длинные слова можно заменить специальной аббревиатурой.
            //Эта аббревиатура строится следующим образом: записывается первая и последняя буква слова,
            //а между ними — количество букв между первой и последней буквой(в десятичной системе счисления и без ведущих нулей).
            //Таком образом, localization запишется как l10n, а «internationalization» как i18n.
            //Вам предлагается автоматизировать процесс замены слов на аббревиатуры.
            //При этом все слишком длинные слова должны быть заменены аббревиатурой, а слова, не являющиеся слишком длинными, должны остаться без изменений.


            //int x = Convert.ToInt32(Console.ReadLine());
            //string[] ArrStr = new string[x];
            //for (int i = 0; i < x; i++)
            //{
            //    ArrStr[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < x; i++)
            //{
            //    if (ArrStr[i].Length > 10)
            //    {
            //        Console.WriteLine($"{ArrStr[i][0]}{ArrStr[i].Length - 2}{ArrStr[i][ArrStr[i].Length - 1]}");
            //    }
            //    else Console.WriteLine(ArrStr[i]);
            //}
            #endregion


            #region
            //Console.WriteLine("Дан массив, состоящий из целых чисел. Напишите программу, которая определяет, есть ли в массиве пара соседних элементов с одинаковыми знаками.");
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] ss = Console.ReadLine().Split(' ');
            //int j = 0;
            //int x = 0;
            //int[] num = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    num[i] = Convert.ToInt32(ss[i]);
            //}
            //for (int i = 1; i < n; i++)
            //{
            //    j = i - 1;
            //    if ((num[i] > 0 && num[j] > 0) || (num[i] < 0 && num[j] < 0))
            //    {
            //        Console.WriteLine("YES"); x++; break;
            //    }
            //}
            //if (x == 0) Console.WriteLine("NO");
            #endregion

            #region
            //Console.WriteLine("Дан массив, состоящий из целых чисел. Напишите программу, которая определяет является ли массив палиндромом.");
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] ss = Console.ReadLine().Split(' ');
            //int k = n - 1;
            //int a = 0;
            //for (int i = 0; i <= n / 2; i++)
            //{
            //    if (ss[i] == ss[k])
            //    {
            //        k--; continue;
            //    }
            //    else Console.WriteLine("NO"); a = 1; break;
            //}
            //if (a == 0)
            //    Console.WriteLine("YES");
            #endregion

            #region
            //Console.WriteLine("Дан список. Выведите те его элементы, которые встречаются в списке только один раз.");
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] ss = Console.ReadLine().Split(' ');
            //int[] num = new int[n];
            //int i = 0;
            //for (i = 0; i < n; i++)
            //{
            //    num[i] = Convert.ToInt32(ss[i]);
            //}
            //for (i = 0; i < n; i++)
            //{
            //    int d = 0;
            //    for (int j = 0; j < n; j++)
            //    {
            //        if ((num[i] == num[j]) && (i != j))
            //        {
            //            d++; continue;
            //        }
            //    }
            //    if (d == 0) Console.Write(num[i] + " ");
            //}
            #endregion

            #region
            //Console.WriteLine("Даны два числа nn и mm. Создайте двумерный массив A[n,m]A[n,m], заполните его таблицей умножения A[i,j]=i \cdot jA[i,j]=i⋅j и выведите на экран.");
            //string s = Console.ReadLine();
            //string[] ss = s.Split(' ');
            //int n = Convert.ToInt32(ss[0]);
            //int m = Convert.ToInt32(ss[1]);
            //int[,] a = new int[n, m];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        a[i, j] = (i + 1) * (j + 1);
            //        Console.Write(a[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region
            //Дан список чисел.Определите, есть ли в нем два противоположных(то есть дающих в сумме 0) числа.
            //Если такие числа есть в массиве, выведите их индексы в порядке возрастания.Если таких чисел в массиве нет, ничего не выводите. 
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] nn = Console.ReadLine().Split(' ');
            //int[] ss = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    ss[i] = Convert.ToInt32(nn[i]);
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int x = 0; x < n; x++)
            //    {
            //        if ((ss[i] > ss[x]) && (ss[i] + ss[x] == 0))
            //        {
            //            Console.WriteLine(i + " " + x); break;
            //        }
            //    }
            //}
            #endregion

            #region
            //Console.WriteLine("Дано два натуральных числа. Найдите количество разрядов каждого из них и выведите их произведение.");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Funk(n) * Funk(m));
            #endregion

            #region
            //Напишите функцию для нахождения максимального элемента массива.
            //Необходимо вычислить произведение двух максимальных элементов массивов a и b.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string a = Console.ReadLine();

            //int m = Convert.ToInt32(Console.ReadLine());
            //string b = Console.ReadLine();

            //Console.WriteLine(Multiplication(n, a, m, b));
            #endregion

            #region
            //Console.WriteLine("Проверьте, является ли число простым.");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Fun(a));
            #endregion

        }
        static string Fun(int a)
        {
            for (int i = 2; i < a; i++)
            {

                if (a % i == 0)
                {
                    return "composite";
                }
            }
            return "prime";
        }
        static int Max(string x, int a)
        {
            string[] xx = x.Split(' ');
            int[] numbers = new int[a];
            int number;

            for (int i = 0; i < a; i++)
            {
                number = Convert.ToInt32(xx[i]);
                numbers[i] = number;
            }
            int max = numbers[0];
            for (int i = 1; i < a; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;

        }
        static int Multiplication(int n, string a, int m, string b)
        {
            return Max(a, n) * Max(b, m);
        }
        static int Funk(int x)
        {
            int r = 0;
            while (x != 0)
            {
                x = x / 10;
                r++;
            }
            return r;
        }
    }
}

