using System;
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
            Console.WriteLine("1-Теорема Пифагора(нахождение катетов или гипотенузы).");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("2-Арифметический тест.");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("3-Занесенние введёных вами слов в массив и выведение только тех,которые удволетворяют условие.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("4-Угадай слово.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("5-Нахождение площади ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("6-Хочешь радугу?");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("7-Нахождение факториала");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("8-Нахождение синуса ,косинуса,тангенса,котангенса. ");
            Console.ResetColor();
            Console.WriteLine("*УКАЖИТЕ НОМЕР ОПЕРАЦИИ*");
            int thebeggining = 0;
            start:
            usersfalsesint(thebeggining,out thebeggining);
            switch (thebeggining)
            {
                case 1:
                    pif();
                    break;
                case 2:
                    arif();
                    break;
                case 3:
                    key();
                    break;
                case 4:
                    guess();
                    break;
                case 5:
                    Area.area();
                    break;
                case 6:
                    rainbowchoice();
                    break;
                case 7:
                    f();
                    break;
                case 8:
                    trigonometrya.trig();
                    break;
                default:

                    default_for_switchcase();
                    goto start;
                    break;
            }
            return0();
        }
        static void pif()
        {
            Console.WriteLine("1-операция нахождения гипотенузы " + "\n" + "2-операция нахождение катета ");
            int a = 0;
            usersfalsesint(a, out a);
            Console.WriteLine("уточните количество знаков после запятой ,если число окажется дробным вплоть до 14-ти" + "\n" + "1-хочу увидеть все вплоть до 14" + "\n" + "2-я задам количество знаков сам");
            int r = 0;
            usersfalsesint(r, out r);
            int m = 0;
            if (r == 1)
            {
                m = 14;
            }
            else if (r == 2)
            {
                Console.WriteLine("введите желаемое число знаков после запятой");
                m = Convert.ToInt32(Console.ReadLine());

            }
            if (m < 0 && m > 14)
            {
                controlstr0();
            }
            switch (a)


            {
                case 1:
                    {
                        start:
                        Console.WriteLine("введите длину первого катета ");
                        double b = 0;
                        usersfalses(b, out b);
                        controld(b);
                        Console.WriteLine("введите длину второго катета");
                        double c = 0;
                        usersfalses(c, out c);
                        controld(c);
                        double s = Math.Pow(b, 2);
                        double v = Math.Pow(c, 2);
                        double z = Math.Sqrt(s + v);
                        double i = Math.Round(z, m);
                        Console.WriteLine("гипотенза данного прямоугольного треугольника=" + i);
                        string u = "";
                        doyouwantmore(out u);
                        if (u=="y")
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
                        usersfalses(b, out b);
                        controld(b);
                        Console.WriteLine("введите длину одного из катетов");
                        double c = 0;
                        usersfalses(c, out c);
                        controld(c);
                        double s = Math.Pow(b, 2);
                        double v = Math.Pow(c, 2);
                        double z = Math.Sqrt(s - v);
                        double i = Math.Round(z, m);
                        Console.WriteLine("второй катет данного прямоугольного треугольника=" + i);
                        string u = "";
                        doyouwantmore(out u);
                        if (u=="y")
                        {
                            goto start;
                        }
                        return0();
                    }
                    break;
                default:

                    break;

            }

            Console.ReadLine();
        }
        public static void arif()
        {
            start:
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В МОЮ ПРОГРАММУ." + "\n" + "ВЫБЕРИТЕ ЖЕЛАЕМУЮ ПРОГРАММУ" + "\n" + "1-Вам дадут тест ,количество вопросов вы фиксируете сами " + "\n" + "2-Вам дадут тест и он будет длится до тех пор ,пока вы не ошибётесь или пока не выйдете");
            int answer = 0;
            usersfalsesint(answer, out answer);
            switch (answer)
            {
                case 1:
                    ar();                
                    break;
                case 2:
                    arc();               
                    break;
                default:
                    default_for_switchcase();
                    goto start;                    
            }            
        }


        public static void ar()
        {
            float v = 0;
            Random random = new Random();
            Console.WriteLine("Введите количестов вопросов в тесте");
            int answ = 0;
            usersfalsesint(answ, out answ);
            float i = 0;
            int[] result = varumn();
            int s = result[0];
            int c = result[1];
            while (i < answ)
            {
                i++;
                int randomNumber1 = random.Next(s, c);
                int randomNumber2 = random.Next(s, c);
                Console.WriteLine(randomNumber1 + "*" + randomNumber2 + "-ваш ответ");
                int sd = Convert.ToInt16(Console.ReadLine());
                if (sd == randomNumber1 * randomNumber2)
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
        public static void arc()
        {
            Console.WriteLine("Ну что ,погнали?");
            int[] result = varumn();
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

                Console.WriteLine(randomNumber1 + "*" + randomNumber2 + "-ваш ответ");
                usersfalsesint(sd, out sd);

            } while (randomNumber2 * randomNumber1 == sd);
            
        }

        public static void keyuni()
        {
            Console.WriteLine("выберите желаемую операцию" + "\n" + "1- Заранее заданные ключевые значения и количество букв " + "\n" + "2- Ключевые значения вы задаёте сами");
            int x = 0;
            usersfalsesint(x, out x);
            switch (x)
            {
                case 1:
                    key();                    
                    break;
                case 2:
                    keyyou();                  
                    break;
                default:
                    controlstr0();                   
                    break;
            }
            return0();
        }
        public static void key()
        {
            List<string> mas = new List<string>();
            Console.WriteLine("это массив в который я буду записывать все слова записанные тобой,которые содержат буквы а или состоит из 4 букв " + "\n" + "для выхода и просмотра содержимого массива напишите - stop");
            string yxrnumber = "";
            string key = "а";
            string g = "";
            int i = 0;
            while (yxrnumber != "stop")
            {


                Console.WriteLine("введите слово");
                yxrnumber = Console.ReadLine();
                if (yxrnumber.Length == 4 || yxrnumber.Contains(key) == true)
                {
                    i++;
                    mas.Add(yxrnumber);
                    g = g + " " + mas[i - 1];
                }
            }
            Console.WriteLine(g);
         
        }
        public static void keyyou()
        {
            List<string> mas = new List<string>();
            Console.WriteLine("Это массив в который я буду записывать все слова записанные тобой,которые содержат  заданные тобой ключевые значения или состоит из заданного тобой числа букв" + "\n" + "для выхода и просмотра содержимого массива напишите - stop");
            string yxrnumber = "";
            Console.WriteLine("Введите ключевое значение");
            string key = Console.ReadLine();
            Logs log = new Logs(key);
            Console.WriteLine("Введите количество букв для ключевого слова");
            int x = 0;
            usersfalsesint(x, out x);
            string g = "";
            int i = 0;
            while (yxrnumber != "stop")
            {


                Console.WriteLine("введите слово");
                yxrnumber = Console.ReadLine();
                Logs log1 = new Logs(yxrnumber);
                if (yxrnumber.Length == x || yxrnumber.Contains(key) == true)
                {
                    i++;
                    mas.Add(yxrnumber);
                    g = g + " " + mas[i - 1];
                }
            }
            Console.WriteLine(g);
            
        }

        public static void guess()
        {
            Console.WriteLine("введите желаемую операцию" + "\n" + "1-отгадай число,заданное компьютером" + "\n" + "2-за сколько попыток  компьютер отгадает ,заданное тобой число");
            int x = 0;
            usersfalsesint(x, out x);
            switch (x)
            {
                case 1:
                    guessI();                   
                    break;
                case 2:
                    guessyou();                   
                    break;
                default:
                    controlstr0();
                    break;
            }
            return0();
        }
        public static void guessI()
        {
            Random random = new Random();
            int z = 0;
            int v = 0;
            int[] result = varumn();
            int s = result[0];
            int c = result[1];
            int i = random.Next(s, c);
            do
            {
                v++;
                Console.WriteLine("Попытка " + v);
                usersfalsesint(z, out z);

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
            int[] result = varumn();
            int s = result[0];
            int c = result[1];
            int z = 0;
            Console.WriteLine("введите ваше число");
            int i = 0;
            usersfalsesint(i, out i);
            Console.WriteLine("Оставить логи открытыми(видеть какие числа перебирал компьютер )[y/n]");
            string r = Console.ReadLine();
            Logs log = new Logs(r);
            if (r == "y")
            {
                Console.WriteLine("хотите чтобы они были раскрашенны[y/n]");
                t = Console.ReadLine();
                controlstr(t);

            }           
            do
            {
                v++;
                z = random.Next(s, c);
                if (r == "y")
                {
                    if (t == "y")
                    {
                        randomcolorsf();
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
            usersfalsesint(i, out i);
            switch (i)
            {
                case 1:
                    rainbow2();                 
                    break;
                case 2:
                    rainbow3();                   
                    break;
                default:
                    default_for_switchcase();
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
                h = Console.ReadLine();
                Logs log = new Logs(h);
                if (h == "y")
                {
                    
                        string[] mass = new string[] { "Р", "А", "Д", "У", "Г", "А", "!", "У", "И", "И", "!" };
                        for (int z = 0; z < mass.Length; z++)
                        {
                            randomcolorsf();
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
                    controlstr0();
                }

           
        }
        static public void rainbow3()
        {

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
                usersfalsesint(g, out g);
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
                        default_for_switchcase();
                        goto start;                      
                }             
            }
            
            public static void simple()
            {
                Console.WriteLine("Что бы узнать площадь укажите:" + "\n" + "a-сторону");
                double a = 0;
                usersfalses(a, out a);
                Console.WriteLine("h-высоту");
                double h = 0;
                usersfalses(h, out h);
                double S = (a * h) / 2;
                intordouble(S);
            }

            public static void geronesformule()
            {

                Console.WriteLine("Что бы узнать площадь треугольника укажите:" + "\n" + "a-первая сторона");
                double a = 0;
                usersfalses(a, out a);
                Console.WriteLine("вторая сторона");
                double b = 0;
                usersfalses(b, out b);
                Console.WriteLine("третья сторона");
                double c = 0;
                usersfalses(c, out c);
                double p = (a + b + c) / 2;
                double s = p * (p - a) * (p - b) * (p - c);
                double S = Math.Sqrt(s);
                Console.ForegroundColor = ConsoleColor.Yellow;
                intordouble(S);
            }
            static void parallelogram()
            {
                Console.Write("Что бы узнать площадь параллелограмма укажите:");
                Console.WriteLine("a-основание");
                double a = 0;
                usersfalses(a, out a);
                Console.WriteLine("h-высоту");
                double h = 0;
                usersfalses(h, out h);
                double S = a * h;
                intordouble(S);
            }
            public static void square()
            {
                Console.Write("Что бы узнать площадь квадрата укажите:");
                Console.WriteLine("d-диагональ");
                double d = 0;
                usersfalses(d, out d);
                double D = Math.Pow(d, 2);
                double S = D / 2;
                intordouble(S);
            }
            public static void trapeze()
            {
                Console.Write("Что бы узнать площадь трапеции укажите:");
                Console.WriteLine("a-первое основание");
                double a = 0;
                usersfalses(a, out a);
                Console.WriteLine("b-второе основание");
                double b = 0;
                usersfalses(b, out b);
                Console.WriteLine("h-высота");
                double h = 0;
                usersfalses(h, out h);
                double S = (a + b) / 2 * h;
                intordouble(S);
            }
            public static void circle()
            {
                Console.Write("Что бы узнать площадь круга укажите:");
                Console.WriteLine("R-радиус");
                double r = 0;
                usersfalses(r, out r);
                double R = Math.Pow(r, 2);
                double S = 3.14 * R;
                intordouble(S);
            }
            public static void rhombus()
            {
                Console.Write("Что бы узнать площадь ромба укажите:");
                Console.WriteLine("d1-первая диагональ");
                double d1 = 0;
                usersfalses(d1, out d1);
                Console.WriteLine("d2-вторая диагональ");
                double d2 = 0;
                usersfalses(d2, out d2);
                double S = d1 * d2 / 2;
                intordouble(S);
            }
            public static void notsimple()
            {
                Console.Write("Что бы узнать площадь треугольника укажите:");
                Console.WriteLine("a- перва сторона");
                double a = 0;
                usersfalses(a, out a);
                Console.WriteLine("b- вторая сторона");
                double b = 0;
                usersfalses(b, out b);
                Console.WriteLine("c- третья сторона");
                double c = 0;
                usersfalses(c, out c);
                Console.WriteLine("R-радиус описанной окружности");
                double R = 0;
                usersfalses(R, out R);
                double S = (a + b + c) / 4 / R;
                intordouble(S);
            }
            public static void sintr()
            {
                Console.WriteLine("Чтобы узнать площадь укажите:");
                Console.Write("a-");
                double a = 0;
                usersfalses(a, out a);
                Console.Write("b-");
                double b = 0;
                usersfalses(b,out b);                
                Console.Write("sin-");
                double sin = 0;
                whatdoyouknow(out sin);
                double S = a*b*sin/2;
                intordouble(S);
            }
            public static void sinpar()
            {
                Console.WriteLine("Чтобы узнать площадь укажите:");
                Console.Write("a-");
                double a = 0;
                usersfalses(a, out a);
                Console.Write("b-");
                double b = 0;
                usersfalses(b, out b);
                Console.Write("sin-");
                double sin = 0;
                whatdoyouknow(out sin);
                double S = a * b * sin ;
                intordouble(S);
            }
            public static void sinrombus()
            {
                Console.WriteLine("Чтобы узнать площадь укажите:");
                Console.Write("a-");
                double a = 0;
                usersfalses(a, out a);
                Console.Write("sin-");
                double sin = 0;
                whatdoyouknow(out sin);
                double S = a *a * sin;
                intordouble(S);

            }
            public static void whatdoyouknow(out double fact)
            {
                fact = 0;
                start:
                Console.WriteLine("Что вы знаете ?"+"\n"+"1-Угол"+"\n"+"2-Синус");
                int i = 0;
                usersfalsesint(i,out i);
                switch(i)
                {
                    case 1:
                        Console.WriteLine("Введите значение угла");
                        int entering = 0;
                        usersfalsesint(entering,out entering);
                        fact = Math.Sin(Math.PI/(180/entering));
                        break;
                    case 2:
                        Console.WriteLine("Введите значение синуса");
                        fact = 0;
                        usersfalses(fact,out fact);
                        break;
                    default:
                        default_for_switchcase();
                        goto start;
                        
                }

            }
        }
        static void f()
        {
            Console.WriteLine("Введите число, факториал котого вы хотите узнать");
            int answer = 0;
            usersfalsesint(answer,out answer);
            int y = Fact(answer);
            Console.WriteLine(y);
            Console.ReadKey();
        }
        //}
        public static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
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
                usersfalsesint(answer, out answer);
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
                        default_for_switchcase();
                        goto start;
                       
                }
                Console.ResetColor();
                

            }
            public static void cosinus()
            {

                double radian = 0;
                ent(out radian);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Косинус=");
                Console.WriteLine(Math.Cos(radian));

            }
            public static void sinus()
            {
                double radian = 0;
                ent(out radian);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Синус=");
                Console.WriteLine(Math.Sin(radian));
            }
            public static void tan()
            {
                double radian = 0;
                ent(out radian);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Тангенс=");
                Console.WriteLine(Math.Tan(radian));
            }
            public static void cotan()
            {
                double radian = 0;
                ent(out radian);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Котангенс=");
                Console.WriteLine(1/Math.Tan(radian));
            }

            public static void ent(out double radian)
            {
                Console.WriteLine("Введите угол ");
                double entering = 0;
                usersfalses(entering, out entering);
                radian = Math.PI / (180 / entering);

            }

        }
        static int[] varumn()
        {
            int[] numbers = new int[2];
            Console.WriteLine("Введите наименьшее число ,которое будет в примере");
            int s = 0;
            usersfalsesint(s,out s);
            numbers[0] = s;
            Console.WriteLine("Введите наибольшее число,которое будет в примере");
            int c = 0;
            usersfalsesint(c,out c);
            numbers[numbers.Length - 1] = c;
            return numbers;

        }

        static void control(int e)
        {
            if (e < 0)
            {
                Console.WriteLine("вы ввели недопустимое значение-программма завершиться.TRY AGAIN!!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return0();
        }
        static void controld(double e)
        {
            if (e < 0)
            {
                Console.WriteLine("вы ввели недопустимое значение-программма завершиться.TRY AGAIN!!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return0();
        }
        static void controlstr(string e)
        {
            if (e != "y" && e != "n")
            {
                Console.WriteLine("вы ввели недопустимое значение-программма завершиться.TRY AGAIN!!!");
                return0();
            }
        }
        public static void controlstr0()
        {
            Console.WriteLine("вы ввели недопустимое значение.TRY AGAIN!!!");
            return0();
        }      
        public static void randomcolorsf()
        {
                    
                Random random = new Random();
                int y = random.Next(0, 10);
                switch (y) {
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
        }
        public void randomcolorsback()
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
        public static void intordouble(double S)
        {
            if (S % 1 != 0)
            {
                Console.WriteLine("Вывести в целочисленном виде?[y/n]");
                string answer = Console.ReadLine();
                Logs log = new Logs(answer);
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
        

        public static void usersfalses(double x, out double z)
        {
            
            start:
            string y = Console.ReadLine();
            Logs logs = new Logs(y);

            string manual = Convert.ToString(y);
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
            
            z = x;
        }
        public static void usersfalsesint(int x, out int z)
        {

            start:

            string y = Console.ReadLine();
            Logs logs = new Logs(y);

                string manual = Convert.ToString(y);
                if (manual == "man" || manual == "manual" || manual == "ман" || manual == "мануал")
                {
                 man();
                 }
                else if (manual == "q" || manual == "quit" || manual == "exit" || manual == "ex" || manual == "выход")
                 {
                  return0();
                 }
                else if (manual=="toor")
                 {
                Console.WriteLine("All logs here"+Logs.Log);
                 }
            try { 

                
             x = Convert.ToInt32(y);

               }
           catch (Exception)
              {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Неверное значение.Введите заново.");
                Console.ResetColor();
                goto start;
              }
              z = x;
            
        }
        public static void doyouwantmore(out string y )
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Хочешь попробовать ещё раз[y/n]");
            Console.ResetColor();
            y = Console.ReadLine();
        }   
        public static void return0()
        {
            Console.WriteLine("Хочешь вернутся в главное меню (в противном случае программа завершится)?[y/n]");
            string answer = Console.ReadLine();        
            Logs logs = new Logs(answer);          
            string ans = answer.ToLower();
            if (ans=="y"||ans=="н")
            {
                string[] mass = new string[0];
                Main(mass);
            }
            else if(ans=="toor")
            {

            }
            else if (ans=="n"||ans=="т")
            {
                Environment.Exit(0);
            }            
        }
        public static void man()
        {
            start:
            Console.WriteLine("мануал не готов/тестовая версия" +
                "\n"+"хотите продолжить[1] или вернуться в меню[2]");
            int answer = 0;
            usersfalsesint(answer,out answer);
            switch(answer)
            {
                case 1:
                    break;
                case 2:
                    return0();
                    break;
                default :
                    default_for_switchcase();
                    goto start;
                    

            }
        }
        public static void tellmeRound(double entering, out double output)
        {
            Console.WriteLine("Сколько знаков хотите видеть после запятой ?");
            int round = 0;
            usersfalsesint(round,out round);
            output = Math.Round(entering,round);
        }
        public static void default_for_switchcase()
        {
            Console.WriteLine("ВВЕДЁН НЕВЕРНЫЙ ВАРИАНТ.Попробовать снова[y] или вернуться в меню[n]");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "y":
                    break;
                case "n":
                    return0();
                    break;
                default:
                    default_for_switchcase();
                    break;
            }
        }
        class Logs
        {
            public static string Log;
            public Logs(string entering)
            {
                Log = Log + " " + entering;
            }
        }

    }
}
