﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {                        
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                  ДОБРО ПОЖАЛОВАТЬ В ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                |||    |||  ||||||   ||||||||||     ||||     ");
            Console.WriteLine("                ||||  ||||  ||          ||||       ||  ||    ");
            Console.WriteLine("                ||  ||  ||  ||||||      ||||      ||    ||   ");
            Console.WriteLine("                ||      ||  ||          ||||     ||||||||||  ");
            Console.WriteLine("                ||      ||  ||||||      ||||    ||        || ");
            Console.ResetColor();
            Console.WriteLine("\n" + "\n" + "\n" + "привет ! это программа имеет арсенал подпрограмм ,с которыми ты можешь работать." + "\n" + "P.S-программист начинающий ,поэтому не будь слишком строг.");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Вы всегда можете вызвать мануал словом man или help или выйти с помощью quit ,exit и подобного ");
            Console.ResetColor();
            Console.WriteLine("                 ПОДПРОГРАММЫ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1-Математические задачи");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("2-");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("3-Занесенние введёных вами слов в массив и выведение только тех,которые удволетворяют условие.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("4-Угадай слово.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("5- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("6-Хочешь радугу?");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("7-Нахождение факториала");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("8-Нахождение синуса ,косинуса,тангенса,котангенса. ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("9-Bruteforse в мирных целях");
            Console.ResetColor();
            Console.WriteLine("*УКАЖИТЕ НОМЕР ОПЕРАЦИИ*");
            int thebeggining = 0;
            start:
            Entering_or_Convertation.UsersFalsesIntenger(ref thebeggining) ;
            switch (thebeggining)
            {
                case 1:
                    Mathematic mathematic= new Mathematic();
                    break;
                case 2:
                    
                    break;
                case 3:
                    key();
                    break;
                case 4:
                    guess();
                    break;
                case 5:
                    
                    break;
                case 6:
                    rainbowchoice();
                    break;
                case 7:
                    f();
                    break;
                case 8:
                    
                    break;
                case 9:
                    Bruteforce bruteforce = new Bruteforce();
                    
                    break;
                case 0:
                    Experiments experiments = new Experiments();
                    break;
                default:
                    FalseCondition();
                    goto start;
                    
            }
            return0();
        }
        class Mathematic
        {
            public Mathematic()
            {
                start:
                Console.WriteLine("Выберите математическую задачу , которую вы хотите решить \n 1-Теорема Пифагора(нахождение катетов или гипотенузы). \n 2-Арифмитический тест  \n" +
                    " 3-Нахождение площади \n 4-Нахождение синуса , косинуса , тангенса , котангенса \n 5-Нахождение факториала ");
                int choice = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref choice);
                switch(choice)
                {
                    case 1:
                        pif();
                        break;
                    case 2:
                        Arifmetic.Arif();
                        break;
                    case 3:
                        Area.area();
                        break;
                    case 4:
                        trigonometrya.trig();
                        break;
                    case 5:
                        Factorial.EnterFactorial();
                        break;
                    default:
                        FalseCondition();
                        goto start;
                        
                }

            }
            static void pif()
            {
                Console.WriteLine("1-операция нахождения гипотенузы " + "\n" + "2-операция нахождение катета ");
                int Choice = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref Choice);
                Console.WriteLine("уточните количество знаков после запятой ,если число окажется дробным вплоть до 14-ти" + "\n" + "1-хочу увидеть все вплоть до 14" + "\n" + "2-я задам количество знаков сам");
                int NumberOfCharacters = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref NumberOfCharacters);
                int m = 0;
                if (NumberOfCharacters == 1)
                {
                    m = 14;
                }
                else if (NumberOfCharacters == 2)
                {
                    Console.WriteLine("введите желаемое число знаков после запятой");
                    m = Convert.ToInt32(Console.ReadLine());

                }
                if (m < 0 && m > 14)
                {
                    Tools.ControlValue();
                }
                switch (Choice)


                {
                    case 1:
                        {
                            start:
                            Console.WriteLine("введите длину первого катета ");
                            double b = 0;
                            Entering_or_Convertation.UsersFalsesDouble(ref b);
                            Tools.ControlDouble(b);
                            Console.WriteLine("введите длину второго катета");
                            double c = 0;
                            Entering_or_Convertation.UsersFalsesDouble(ref c);
                            Tools.ControlDouble(c);
                            double s = Math.Pow(b, 2);
                            double v = Math.Pow(c, 2);
                            double z = Math.Sqrt(s + v);
                            double i = Math.Round(z, m);
                            Console.WriteLine("гипотенза данного прямоугольного треугольника=" + i);
                            string u = "";
                            doyouwantmore(out u);
                            if (u == "y")
                            {
                                goto start;
                            }
                        }
                        break;
                    case 2:
                        {
                            start:
                            Console.WriteLine("введите длину гипотенузы");
                            double b = 0;
                            Entering_or_Convertation.UsersFalsesDouble(ref b);
                            Tools.ControlDouble(b);
                            Console.WriteLine("введите длину одного из катетов");
                            double c = 0;
                            Entering_or_Convertation.UsersFalsesDouble(ref c);
                            Tools.ControlDouble(c);
                            double s = Math.Pow(b, 2);
                            double v = Math.Pow(c, 2);
                            double z = Math.Sqrt(s - v);
                            double i = Math.Round(z, m);
                            Console.WriteLine("второй катет данного прямоугольного треугольника=" + i);
                            string u = "";
                            doyouwantmore(out u);
                            if (u == "y")
                            {
                                goto start;
                            }
                            return0();
                        }
                        break;
                    default:
                        FalseCondition();
                        break;

                }

                Console.ReadLine();
            }
            class Arifmetic
            {
                private static char Char;
                public static void Arif()
                {
                    start:
                    Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В МОЮ ПРОГРАММУ." + "\n" + "ВЫБЕРИТЕ ЖЕЛАЕМУЮ ПРОГРАММУ" + "\n" +
                        "1-Вам дадут тест ,количество вопросов вы фиксируете сами " + "\n" + "2-Вам дадут тест и он будет длится до тех пор ,пока вы не ошибётесь или пока не выйдете");
                    int answer = 0;
                    Entering_or_Convertation.UsersFalsesIntenger(ref answer);
                    switch (answer)
                    {
                        case 1:
                            ArifmeticTest();
                            break;
                        case 2:
                            TestBeforeError();
                            break;
                        default:
                            FalseCondition();
                            goto start;
                    }
                }
                static void ArifmeticTest()
                {
                    ChooseChar();
                    float v = 0;
                    Random random = new Random();
                    Console.WriteLine("Введите количестов вопросов в тесте");
                    int answ = 0;
                    Entering_or_Convertation.UsersFalsesIntenger(ref answ);
                    float i = 0;
                    int[] result = Tools.Varumn();
                    int s = result[0];
                    int c = result[1];
                    while (i < answ)
                    {
                        i++;
                        int randomNumber1 = random.Next(s, c);
                        int randomNumber2 = random.Next(s, c);
                        Console.WriteLine(randomNumber1 + " "+Char+" " + randomNumber2 + "-ваш ответ");
                        int sd = Convert.ToInt16(Console.ReadLine());
                        if (sd == randomNumber1 +Char+ randomNumber2)
                        {

                            Console.WriteLine("верно");
                            v++;
                        }

                        else
                        {
                            Console.WriteLine("неверно");
                        }
                    }
                    Console.WriteLine(v + " верных ответов из " + i + " вопросов" + "\n" + "Ваша оценка-");
                    if (v / i > 0.95)
                    {
                        Console.WriteLine("замечательно");
                    }
                    else if (v / i > 0.80 && v / i < 0.95)
                    {
                        Console.WriteLine("отлично");
                    }
                    else if (v / i > 0.6 && v / i < 0.8)
                    {
                        Console.WriteLine("хорошо");
                    }
                    else if (v / i > 0.4 && v / i < 0.6)
                    {
                        Console.WriteLine("удволетворительно");
                    }
                    else
                    {
                        Console.WriteLine("ужасно");
                    }


                }
                static void TestBeforeError()
                {
                    ChooseChar();
                    Console.WriteLine("Ну что ,погнали?");
                    int[] result = Tools.Varumn();
                    int s = result[0];
                    int c = result[1];
                    Random random = new Random();
                    int randomNumber1 = 0;
                    int randomNumber2 = 0;
                    int sd = 0;
                    do

                    {
                        int i = 0;
                        i++;
                        randomNumber1 = random.Next(s, c);
                        randomNumber2 = random.Next(s, c);

                        Console.WriteLine(randomNumber1 + " " +Char+ " " + randomNumber2 + "-ваш ответ");
                        Entering_or_Convertation.UsersFalsesIntenger(ref sd);

                    } while (randomNumber2 + Char+ randomNumber1 == sd);
                }
                static void ChooseChar()
                {
                    start:
                    Console.WriteLine("Введите операцию , которая будет в тесте");
                    char YourOperation = ' ';
                    Entering_or_Convertation.UsersFalsesChar(ref YourOperation);
                    if (YourOperation != '+' && YourOperation != '-' && YourOperation != '/' && YourOperation != '*')
                    {
                        Console.WriteLine("Вы ввели неверное значение");
                        //Console.WriteLine(YourOperation);
                        goto start;

                    }
                    Char = YourOperation;
                    
                }

            }
            class Area
            {
                public static void area()
                {
                    start:
                    Console.WriteLine("Привет,если ты сюда попал значит ты хочешь найти площадь.Ну что ж выбери способ" + "\n" + "1-Найдём площадь по высоте и основанию(треугольник)");
                    Console.ForegroundColor = ConsoleColor.Green;
                    //!!! а может заюзать метод с рандомными цветами(когда сделаю)
                    Console.WriteLine("S= 1/2 * h * a");
                    Console.ResetColor();
                    Console.WriteLine("2 - Найдём площадь по формуле Герона.(треугольник)");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("S=√p(p-a)(p-b)(p-c)");
                    Console.ResetColor();
                    Console.WriteLine("3-Нахождение площади квадрата по диагонали");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("S=d^2/2");
                    Console.ResetColor();
                    Console.WriteLine("4-Нахождение площади круга");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("S=П*R^2");
                    Console.ResetColor();
                    Console.WriteLine("5-Нахождение площади параллелограмма");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("S=a*h");
                    Console.ResetColor();
                    Console.WriteLine("6-Нахождение площади трапеции");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("S=(a+b)/2*h");
                    Console.ResetColor();
                    Console.WriteLine("7-Нахождение площади");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("S=a*b*sin(между ними)");
                    Console.WriteLine("Условные обозначения");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("a,b-стороны");
                    Console.WriteLine("d-диагональ");
                    Console.WriteLine("p-полупериметр");
                    Console.WriteLine("R-радиус");
                    Console.WriteLine("h-высота");
                    Console.WriteLine("П-число Пи(округлённое до 3,14)");
                    Console.ResetColor();
                    int g = 0;
                    Entering_or_Convertation.UsersFalsesIntenger(ref g);
                    switch (g)
                    {
                        case 1:
                            simple();
                            break;
                        case 2:
                            geronesformule();
                            break;
                        case 3:
                            square();
                            break;
                        case 4:
                            circle();
                            break;
                        case 5:
                            parallelogram();
                            break;
                        case 6:
                            trapeze();
                            break;
                        case 7:

                            break;
                        default:
                            FalseCondition();
                            goto start;
                    }
                }

                private static void simple()
                {
                    Console.WriteLine("Что бы узнать площадь укажите:" + "\n" + "a-сторону");
                    double a = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref a);
                    Console.WriteLine("h-высоту");
                    double h = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref h);
                    double S = (a * h) / 2;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }

                private static void geronesformule()
                {

                    Console.WriteLine("Что бы узнать площадь треугольника укажите:" + "\n" + "a-первая сторона");
                    double a = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref a);
                    Console.WriteLine("вторая сторона");
                    double b = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref b);
                    Console.WriteLine("третья сторона");
                    double c = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref c);
                    double p = (a + b + c) / 2;
                    double s = p * (p - a) * (p - b) * (p - c);
                    double S = Math.Sqrt(s);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }
                private static void parallelogram()
                {
                    Console.Write("Что бы узнать площадь параллелограмма укажите:");
                    Console.WriteLine("a-основание");
                    double a = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref a);
                    Console.WriteLine("h-высоту");
                    double h = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref h);
                    double S = a * h;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }
                private static void square()
                {
                    Console.Write("Что бы узнать площадь квадрата укажите:");
                    Console.WriteLine("d-диагональ");
                    double d = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref d);
                    double D = Math.Pow(d, 2);
                    double S = D / 2;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }
                private static void trapeze()
                {
                    Console.Write("Что бы узнать площадь трапеции укажите:");
                    Console.WriteLine("a-первое основание");
                    double a = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref a);
                    Console.WriteLine("b-второе основание");
                    double b = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref b);
                    Console.WriteLine("h-высота");
                    double h = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref h);
                    double S = (a + b) / 2 * h;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }
                private static void circle()
                {
                    Console.Write("Что бы узнать площадь круга укажите:");
                    Console.WriteLine("R-радиус");
                    double r = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref r);
                    double R = Math.Pow(r, 2);
                    double S = 3.14 * R;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }
                private static void rhombus()
                {
                    Console.Write("Что бы узнать площадь ромба укажите:");
                    Console.WriteLine("d1-первая диагональ");
                    double d1 = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref d1);
                    Console.WriteLine("d2-вторая диагональ");
                    double d2 = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref d2);
                    double S = d1 * d2 / 2;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }
                private static void notsimple()
                {
                    Console.Write("Что бы узнать площадь треугольника укажите:");
                    Console.WriteLine("a- перва сторона");
                    double a = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref a);
                    Console.WriteLine("b- вторая сторона");
                    double b = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref b);
                    Console.WriteLine("c- третья сторона");
                    double c = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref c);
                    Console.WriteLine("R-радиус описанной окружности");
                    double R = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref R);
                    double S = (a + b + c) / 4 / R;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }
                private static void sintr()
                {
                    Console.WriteLine("Чтобы узнать площадь укажите:");
                    Console.Write("a-");
                    double a = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref a);
                    Console.Write("b-");
                    double b = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref b);
                    Console.Write("sin-");
                    double sin = 0;
                    whatdoyouknow(ref sin);
                    double S = a * b * sin / 2;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }
                private static void sinpar()
                {
                    Console.WriteLine("Чтобы узнать площадь укажите:");
                    Console.Write("a-");
                    double a = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref a);
                    Console.Write("b-");
                    double b = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref b);
                    Console.Write("sin-");
                    double sin = 0;
                    whatdoyouknow(ref sin);
                    double S = a * b * sin;
                    Entering_or_Convertation.IntengerOrDouble(S);
                }
                private static void sinrombus()
                {
                    Console.WriteLine("Чтобы узнать площадь укажите:");
                    Console.Write("a-");
                    double a = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref a);
                    Console.Write("sin-");
                    double sin = 0;
                    whatdoyouknow(ref sin);
                    double S = a * a * sin;
                    Entering_or_Convertation.IntengerOrDouble(S);

                }
                private static void whatdoyouknow(ref double fact)
                {
                    fact = 0;
                    start:
                    Console.WriteLine("Что вы знаете ?" + "\n" + "1-Угол" + "\n" + "2-Синус");
                    int i = 0;
                    Entering_or_Convertation.UsersFalsesIntenger(ref i);
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Введите значение угла");
                            int entering = 0;
                            Entering_or_Convertation.UsersFalsesIntenger(ref entering);
                            fact = Math.Sin(Math.PI / (180 / entering));
                            break;
                        case 2:
                            Console.WriteLine("Введите значение синуса");
                            fact = 0;
                            Entering_or_Convertation.UsersFalsesDouble(ref fact);
                            break;
                        default:
                            FalseCondition();
                            goto start;

                    }

                }
            }
            class trigonometrya
            {
                public static void trig()
                {
                    start:
                    Console.WriteLine("Что вы хотите найти?");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Косинус-");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Синус-");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Тангенс-");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Котангенс(В программе БАГГ)");
                    Console.ResetColor();
                    int answer = 0;
                    Entering_or_Convertation.UsersFalsesIntenger(ref answer);
                    switch (answer)
                    {
                        case 1:
                            cosinus();
                            break;
                        case 2:
                            sinus();
                            break;
                        case 3:
                            tan();
                            break;
                        case 4:
                            cotan();
                            break;
                        default:
                            FalseCondition();
                            goto start;

                    }
                    Console.ResetColor();


                }
                static void cosinus()
                {

                    double radian = 0;
                    ent(ref radian);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Косинус=");
                    Console.WriteLine(Math.Cos(radian));

                }
                static void sinus()
                {
                    double radian = 0;
                    ent(ref radian);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Синус=");
                    Console.WriteLine(Math.Sin(radian));
                }
                static void tan()
                {
                    double radian = 0;
                    ent(ref radian);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("Тангенс=");
                    Console.WriteLine(Math.Tan(radian));
                }
                static void cotan()
                {
                    double radian = 0;
                    ent(ref radian);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Котангенс=");
                    Console.WriteLine(1 / Math.Tan(radian));
                }

                static void ent(ref double radian)
                {
                    Console.WriteLine("Введите угол ");
                    double entering = 0;
                    Entering_or_Convertation.UsersFalsesDouble(ref entering);
                    radian = Math.PI / (180 / entering);

                }
            }
            class Factorial
            {
                public static void EnterFactorial()
                {
                    Console.WriteLine("Введите число, факториал котого вы хотите узнать");
                    int answer = 0;
                    Entering_or_Convertation.UsersFalsesIntenger(ref answer);
                    int y = Fact(answer);
                    Console.WriteLine(y);
                    Console.ReadKey();
                }

                private static int Fact(int num)
                {
                    if (num == 1)
                    {
                        return 1;
                    }
                    return num * Fact(num - 1);
                }
            }
        }  
        public static void keyuni()
        {
            Console.WriteLine("выберите желаемую операцию" + "\n" + "1- Заранее заданные ключевые значения и количество букв " + "\n" + "2- Ключевые значения вы задаёте сами");
            int x = 0;
            Entering_or_Convertation.UsersFalsesIntenger (ref x);
            switch (x)
            {
                case 1:
                    key();                    
                    break;
                case 2:
                    keyyou();                  
                    break;
                default:
                    FalseCondition();                   
                    break;
            }
            return0();
        }
        public static void key()
        {
            List<string> mas = new List<string>();
            Console.WriteLine("Это список в который я буду записывать все слова записанные тобой,которые содержат буквы а или состоит из 4 букв " + "\n" + "Для выхода и просмотра содержимого массива напишите - stop");
            string Yornumber = "";
            string key = "а";
            string result = "";
            int i = 0;
            while (Yornumber != "stop")
            {


                Console.WriteLine("введите слово");
                Yornumber = Console.ReadLine();
                if (Yornumber.Length == 4 || Yornumber.Contains(key) == true)
                {
                    i++;
                    mas.Add(Yornumber);
                    result = result + " " + mas[i - 1];
                }
            }
            Console.WriteLine(result);
         
        }
        public static void keyyou()
        {
            List<string> mas = new List<string>();
            Console.WriteLine("Это массив в который я буду записывать все слова записанные тобой,которые содержат  заданные тобой ключевые значения или состоит из заданного тобой числа букв" + "\n" + "для выхода и просмотра содержимого массива напишите - stop");
            string Yournumber = "";
            Console.WriteLine("Введите ключевое значение");
            string key = "";
            Entering_or_Convertation.UsersNeverFalsesAtStr (ref key);
            Console.WriteLine("Введите количество букв для ключевого слова");
            int x = 0;
            Entering_or_Convertation.UsersFalsesIntenger (ref  x);
            string result = "";
            int i = 0;
            while (Yournumber != "stop")
            {


                Console.WriteLine("введите слово");
                Yournumber = "";
                Entering_or_Convertation.UsersNeverFalsesAtStr (ref Yournumber);
                if (Yournumber.Length == x || Yournumber.Contains(key) == true)
                {
                    i++;
                    mas.Add(Yournumber);
                    result = result + " " + mas[i - 1];
                }
            }
            Console.WriteLine(result);
            
        }

        public static void guess()
        {
            Console.WriteLine("введите желаемую операцию" + "\n" + "1-отгадай число,заданное компьютером" + "\n" + "2-за сколько попыток  компьютер отгадает ,заданное тобой число");
            int x = 0;
            Entering_or_Convertation.UsersFalsesIntenger (ref x);
            switch (x)
            {
                case 1:
                    guessI();                   
                    break;
                case 2:
                    guessyou();                   
                    break;
                default:
                    FalseCondition();
                    break;
            }
            return0();
        }
        public static void guessI()
        {
            Random random = new Random();
            int s = 0;
            int v = 0;
            int[] result = Tools.Varumn();
            int z = result[0];
            int c = result[1];
            int i = random.Next(s, c);
            do
            {
                v++;
                Console.WriteLine("Попытка " + v);
                Entering_or_Convertation.UsersFalsesIntenger (ref z);

            } while (i != z);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вами было отгадано число " + i);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы отгадали с " + v + " попытки");         
        }
        public static void guessyou()
        {
            string t = "";
            Random random = new Random();
            int v = 0;
            int[] result = Tools.Varumn();
            int s = result[0];
            int c = result[1];
            int z = 0;
            Console.WriteLine("введите ваше число");
            int i = 0;
            Entering_or_Convertation.UsersFalsesIntenger (ref i);
            Console.WriteLine("Оставить логи открытыми(видеть какие числа перебирал компьютер )[y/n]");
            string r = "";
            Entering_or_Convertation.UsersNeverFalsesAtStr(ref r);
            if (r == "y")
            {
                Console.WriteLine("хотите чтобы они были раскрашенны[y/n]");
                t = Console.ReadLine();
                Tools.ControlString(t);

            }           
            do
            {
                v++;
                z = random.Next(s, c);
                if (r == "y")
                {
                    if (t == "y")
                    {
                        Tools.RandomColorsForeghround();
                    }
                    Console.WriteLine("Выбрано число " + z);
                    Console.ResetColor();
                }
                else if (r == "n")
                {

                }

            } while (z != i);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вами было загаданно число " + i);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Компьютер отгадал твоё число за " + v + " попыток");
            if (v > c - s)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Компьютер сделал больше попыток чем есть всего вариантов!" + "\n" + "Такое случается он просто заново перебирал уже использованные числа");
            }
           
        }
        
        public static void rainbowchoice()
        {
            start:
            Console.WriteLine("выберите версию программы" + "\n" + "1-первая версия (красим буквы)" + "\n" + "2-вторая версия(задний фон)" + "\n" + "3-третья версия");
            int i = 0;
            Entering_or_Convertation.UsersFalsesIntenger(ref i);
            switch (i)
            {
                case 1:
                    rainbow2();                 
                    break;
                case 2:
                    rainbow3();                   
                    break;
                default:
                    FalseCondition();
                    goto start;
                    
            }
        }

        public static void rainbow2()
        {
            int[] i = new int[11];
            Console.Write("Нажимай y и перед тобой будет новораскрашенное слово радуга ");
            string h = "";
            Random random = new Random();
           
                Console.WriteLine("Ваш вердикт");
                start:
                h = "";
                Entering_or_Convertation.UsersNeverFalsesAtStr(ref h);
                if (h == "y")
                {
                    
                        string[] mass = new string[] { "Р", "А", "Д", "У", "Г", "А", "!", "У", "И", "И", "!" };
                        for (int z = 0; z < mass.Length; z++)
                        {
                            Tools.RandomColorsForeghround();
                            Console.Write(mass[z]);
                            Console.ResetColor();

                        }
                       goto start;

                    
                }
                else if (h == "n")
                {
                    Console.Write("пока,пока");
                    Console.ReadLine();
                   
                }
                else
                {
                    Tools.ControlValue();
                }

           
        }
        static public void rainbow3()
        {

        }
        
        static void f()
        {
            Console.WriteLine("Введите число, факториал котого вы хотите узнать");
            int answer = 0;
            Entering_or_Convertation.UsersFalsesIntenger(ref answer);
            int y = Fact(answer);
            Console.WriteLine(y);
            Console.ReadKey();
        }
        
        public static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }
       
        class Bruteforce
        {
            public Bruteforce()
            {
                start:
                Console.WriteLine("Введите номер операции \n 1-Составные и простые числа \n 2-Проверка чисел на кратность");
                int choose = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref choose);
                switch(choose)
                {
                    case 1:
                        SimpleOrComposite();
                        break;
                    case 2:
                        AllMultiples();
                        break;
                    case 3:
                        ExampleOfBruteForce0();
                        break;
                    case 4:
                        ExampleOfBruteForce1();
                        break;
                    case 5:
                        ExampleOfBruteforce2();
                        break;
                    default:
                        FalseCondition();
                        goto start;                        
                }

            }
            private void SimpleOrComposite()
            {
                Console.WriteLine("Зелёным цветом помечены составные числа, красным простые,цикл бесконечен,чтобы закончить выйдете из программы,введите любую кнопку ,чтобы начать");
                Console.ReadLine();
                double hash = 0;
                int g = 0;
                bool check =false;
                while (true)
                {
                    g++;
                    for (int i=2;i<g;i++)
                    {
                        //Алгоритм0 g/i<hash || g/i
                        //Алгоритм1 проблема алгоритма находится в том,что при единственном получении дроби числу присваивается значение составное , а так будет постоянно начиная с трёх 
                        hash = ((double)g) / ((double)i);
                        if (hash==g/i)
                        {
                            check = true;                           
                        }                                              
                    }
                    if (check)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;                       
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;                                              
                    }
                    Console.WriteLine(g);
                    check = false;
                }
            }
            private void AllMultiples()
            {
                
                int i = 0;
                Console.WriteLine("Введите число,кратность к которому будем проверять.Зелёный кратно,красный нет.");
                double multiple =0;
                Entering_or_Convertation.UsersFalsesDouble(ref multiple);
                while(true)
                {
                    
                    i++;
                    if ( i / multiple == (int) (i/multiple) )
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    
                    Console.WriteLine(i);
                   
                }
            }
            private void ExampleOfBruteForce0()
            {
                Console.WriteLine("Здесь приведён пример простого переборщика паролей(только цифры).Введите предполагаемый пароль.");
                int password = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref password);
                string password0=password.ToString();
                string enumeration="";
                int i = 0;
                string summer = "";
                do
                {
                    for (int g = 0; ; g++ )
                    {
                        for (; i < 10; i++)
                        {
                            enumeration = summer + i;
                            if (enumeration ==password0) break;
                        }
                        //enu
                    }                   
                }
                while (enumeration!=password0);

            }
            private void ExampleOfBruteForce1()
            {
                Console.WriteLine("Введите ваш пароль");
                int password = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref password);
                int key = 0;
                Console.ForegroundColor = ConsoleColor.DarkRed;

                while (key != password) key++; Console.WriteLine(key);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ваш пароль "+key);
            }
            private void ExampleOfBruteforce2()
            {
                
            }
        }
        class Experiments
        {
            public Experiments()
            {
                Console.WriteLine("Эксперименты для лучшего понимания языка \n 1-Приведение типов выражения");
                int choose = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref choose);
                switch (choose)
                {
                    case 1:
                        Convertation();
                        break;
                    case 2:
                        break;
                }
            }
            private void Convertation()
            {
                int v = 9;
                double t = 82;
                Console.WriteLine(t+" "+v+" t/v "+t/v);
                Console.ReadLine();
            }

        }
        class Tools
        {
            public static int[] Varumn()
            {
                int[] numbers = new int[2];
                Console.WriteLine("Введите наименьшее число ,которое будет в примере");
                int s = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref s);
                numbers[0] = s;
                Console.WriteLine("Введите наибольшее число,которое будет в примере");
                int c = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref c);
                numbers[numbers.Length - 1] = c;
                return numbers;

            }

            public static void ControlIntenger(int entering)
            {
                if (entering < 0)
                {
                    Console.WriteLine("вы ввели недопустимое значение-программма завершиться.TRY AGAIN!!!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                return0();
            }
            public static void ControlDouble(double e)
            {
                if (e < 0)
                {
                    Console.WriteLine("вы ввели недопустимое значение-программма завершиться.TRY AGAIN!!!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                return0();
            }
            public static void ControlString(string e)
            {
                if (e != "y" && e != "n")
                {
                    Console.WriteLine("вы ввели недопустимое значение-программма завершиться.TRY AGAIN!!!");
                    return0();
                }
            }
            public static void ControlValue()
            {
                Console.WriteLine("вы ввели недопустимое значение.TRY AGAIN!!!");
                return0();
            }
            public static string RandomColorsForeghround()
            {

                Random random = new Random();
                int y = random.Next(0, 10);
                switch (y)
                {
                    case 0:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        break;
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        }
                        break;
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }
                        break;
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        break;
                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        break;
                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        break;
                    case 6:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        break;
                    case 7:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        break;
                    case 8:
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        break;
                    case 9:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        }
                        break;

                    default:

                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        break;


                }
                return "";
            }
            public void RandomcolorsBackground()
            {
                Random random = new Random();
                int y = random.Next(0, 13);

                switch (y)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;

                    case 3:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        }
                        break;
                    case 4:
                        {
                            Console.BackgroundColor = ConsoleColor.Magenta;
                        }
                        break;
                    case 5:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                        }
                        break;
                    case 6:
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        }
                        break;
                    case 7:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                        }
                        break;
                    case 8:
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        break;
                    case 9:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                        }
                        break;
                    case 10:
                        {
                            Console.BackgroundColor = ConsoleColor.Cyan;
                        }
                        break;
                    case 11:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                        }
                        break;
                    case 12:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            //он вообще нужен?!
                        }
                        break;
                    default:
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;

                }
            }
            public static string ResetColor()
            {
                Console.ResetColor();
                return "";
            }
        }
        class Entering_or_Convertation
        {
            public Entering_or_Convertation()
            {

            }
            public static void IntengerOrDouble(double S)
            {
                if (S % 1 != 0)
                {
                    Console.WriteLine("Вывести в целочисленном виде?[y/n]");
                    string answer = "";
                    Entering_or_Convertation.UsersNeverFalsesAtStr(ref answer);
                    if (answer == "y")
                    {
                        int sc = Convert.ToInt32(S);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("S=" + sc);

                    }
                    else
                    {

                        double sc = S;
                        tellmeRound(sc, out sc);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("S=" + sc);

                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("S=" + S);
                }
                Console.ReadLine();
            }
            //class UsersFalses
            //{
            //    public UsersFalses()
            //    {

            //    }
            //}


            public static void UsersFalsesDouble(ref double x)
            {

                start:
                string y = "";
                Entering_or_Convertation.UsersNeverFalsesAtStr(ref y);
              //  Logs logs = new Logs(y);
                
                try
                {

                    x = Convert.ToInt32(y);

                }
                catch (Exception)
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Неверное значение.Введите заново.");
                    Console.ResetColor();
                    goto start;
                }
            }
            public static void UsersFalsesIntenger(ref int x)
            {

                start:
                string y = "";
                Entering_or_Convertation.UsersNeverFalsesAtStr(ref y);
               // Logs logs = new Logs(y);               
               
                try
                {


                    x = Convert.ToInt32(y);

                }
                catch (Exception)
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Неверное значение.Введите заново.");
                    Console.ResetColor();
                    goto start;
                }
                
            }
            public static void UsersFalsesChar(ref char newCharSymbol)
            {
                start:
                string check = "";
                UsersNeverFalsesAtStr(ref check);
                try
                {
                    newCharSymbol = Convert.ToChar(check);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Неверное значение.Введите заново.");
                    Console.ResetColor();
                    goto start;
                }
            }
            public static void UsersNeverFalsesAtStr(ref string x)
            {
                x =Console.ReadLine();
                Logs logs =new Logs(x);
                string manual = x.ToLower();
                CheckSU(manual);
                
            }
            private static void CheckSU(string manual)
            {
                if (manual == "man" || manual == "manual" || manual == "ман" || manual == "мануал")
                {
                    man();
                }
                else if (manual == "q" || manual == "quit" || manual == "exit" || manual == "ex" || manual == "выход")
                {
                    return0();
                }
                else if (manual == "toor")
                {
                    Console.WriteLine("All logs here" + Logs.Log);                    
                }
            }
            private static void man()
            {
                start:
                Console.WriteLine("мануал не готов/тестовая версия" +
                    "\n" + "хотите продолжить[1] или вернуться в меню[2]");
                int answer = 0;
                UsersFalsesIntenger(ref answer);
                switch (answer)
                {
                    case 1:
                        break;
                    case 2:
                        return0();
                        break;
                    default:
                        FalseCondition();
                        goto start;


                }
            }
            public static void tellmeRound(double entering, out double output)
            {
                Console.WriteLine("Сколько знаков хотите видеть после запятой ?");
                int round = 0;
                UsersFalsesIntenger(ref round);
                output = Math.Round(entering, round);
            }
            
            class Logs
            {
                public static string Log;
                public Logs(string entering)
                {
                    Log = Log + " " +entering ;
                   
                }
            }
        }
        public static void doyouwantmore(out string y )
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Хочешь попробовать ещё раз[y/n]");
            Console.ResetColor();
            y = Console.ReadLine();
        }   
        private static void return0()
        {
            start:
            Console.WriteLine("Хочешь вернутся в главное меню (в противном случае программа завершится)?[y/n]");
            string answer = "";
            Entering_or_Convertation.UsersNeverFalsesAtStr(ref answer);          
            string ans = answer.ToLower();
            
            if (ans=="y"||ans=="н")
            {
                string[] mass = new string[0];
                Main(mass);
            }
           
            else if (ans=="n"||ans=="т")
            {
                Environment.Exit(0);
            }            
            else
           {
                Tools.ControlValue();
                goto start;
            }
        }
       
        
        public static void FalseCondition()
        {
            Console.WriteLine("ВВЕДЁН НЕВЕРНЫЙ ВАРИАНТ.Попробовать снова[y] или вернуться в меню[n]");
            string answer = "";
            Entering_or_Convertation.UsersNeverFalsesAtStr(ref answer);
            switch (answer)
            {
                case "y":
                    break;
                case "n":
                    return0();
                    break;
                default:
                    FalseCondition();
                    break;
            }
        }
        class Tasks
        {
            public Tasks()
            {
                start:
                Console.WriteLine("Введите номер задачи ,которую вы хотите выполнить 1-Сортировка списков в порядке возрастания");
                int choice = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref choice);
                switch(choice)
                {
                    case 1:                       
                        Lists();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        FalseCondition();
                       
                        goto start;
                        
                }
            }
            void Lists()
            {
                Console.WriteLine("Введите количество списков");
                int  sizeOfSteppedArray = 0;
                Entering_or_Convertation.UsersFalsesIntenger(ref sizeOfSteppedArray);
                string[][] Massives = new string [sizeOfSteppedArray] [];
                for(int NumbersOfMassives=0; NumbersOfMassives<Massives.Length;NumbersOfMassives ++)
                {
                    Console.WriteLine("Введите размер "+(NumbersOfMassives+1)+" массива");
                    int sizeOfArray = 0;
                    Entering_or_Convertation.UsersFalsesIntenger(ref sizeOfArray);
                    Massives[NumbersOfMassives] = new string[sizeOfArray];
                    for (int ValueOfMassive = 0; ValueOfMassive < Massives[NumbersOfMassives].Length; ValueOfMassive++)
                    {
                        Console.WriteLine("Введите значение " + ValueOfMassive + " члена " + NumbersOfMassives + " массива");
                        string Value = "";
                        Entering_or_Convertation.UsersNeverFalsesAtStr(ref Value);
                        Massives[NumbersOfMassives][ValueOfMassive] = Value;
                    }                                       

                }
            }
        }
        class SuperSu
        {

            public static void Beauty()
            { 
                
            }
        }

            
        

    }
}
