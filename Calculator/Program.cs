using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    class Calculator
    {
        public static double Add(double a, double b)
        {
            return Math.Round(a + b, 3);
        }

        public static double Subtraction(double a, double b)
        {
            return Math.Round(a - b, 3);
        }

        public static double Multiplication(double a, double b)
        {
            return Math.Round(a * b, 3);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a;
                double b;
                string anum;
                string bnum;
                string oper;
                bool CheckPlus = false;
                bool CheckMinus = false;
                bool CheckMult = false;
                bool OperNeed = true;

                Console.WriteLine("a: ");
                anum = Convert.ToString(Console.ReadLine());
                if (anum.Contains('='))
                {
                    anum = anum.Remove(anum.Length - 1);
                }
                if (anum.Contains('.'))
                {
                    anum = anum.Replace('.', ',');
                }
                if (anum == null)
                {
                    Console.WriteLine("Введите число пожайлуста!");
                    Console.ReadLine();
                    continue;
                }
                bool isNum = double.TryParse(anum, out a);
                if (isNum)
                {
                    a = Convert.ToDouble(anum);
                }
                else
                {
                    if (anum.Contains('+'))
                    {
                        string a2 = anum.Substring(0, anum.IndexOf('+'));
                        a = Convert.ToDouble(a2);
                        CheckPlus = true;
                        OperNeed = false;
                        if (anum.Length > a2.Length + 1)
                        {
                            if (anum.Contains(' '))
                            {
                                string b2 = anum.Remove(0, anum.IndexOf('+') + 1);
                                b = Convert.ToDouble(b2);
                                Console.WriteLine(Calculator.Add(a, b));
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                string b2 = anum.Remove(0, anum.IndexOf('+') + 1);
                                b = Convert.ToDouble(b2);
                                Console.WriteLine(Calculator.Add(a, b));
                                Console.ReadKey();
                                continue;
                            }
                        }
                    }
                    if (anum.Contains('-'))
                    {
                        string a2 = anum.Substring(0, anum.IndexOf('-'));
                        a = Convert.ToDouble(a2);
                        CheckMinus = true;
                        OperNeed = false;
                        if (anum.Length > a2.Length + 1)
                        {
                            if (anum.Contains(' '))
                            {
                                string b2 = anum.Remove(0, anum.IndexOf('-') + 1);
                                b = Convert.ToDouble(b2);
                                Console.WriteLine(Math.Round(Calculator.Subtraction(a, b)));
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                string b2 = anum.Remove(0, anum.IndexOf('-') + 1);
                                b = Convert.ToDouble(b2);
                                Console.WriteLine(Calculator.Subtraction(a, b));
                                Console.ReadKey();
                                continue;
                            }
                        }
                    }
                    if (anum.Contains('*'))
                    {
                        string a2 = anum.Substring(0, anum.IndexOf('*'));
                        a = Convert.ToDouble(a2);
                        CheckMult = true;
                        OperNeed = false;
                        if (anum.Length > a2.Length + 1)
                        {
                            if (anum.Contains(' '))
                            {
                                string b2 = anum.Remove(0, anum.IndexOf('*') + 1);
                                b = Convert.ToDouble(b2);
                                Console.WriteLine(Calculator.Multiplication(a, b));
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                string b2 = anum.Remove(0, anum.IndexOf('*') + 1);
                                b = Convert.ToDouble(b2);
                                Console.WriteLine(Calculator.Multiplication(a, b));
                                Console.ReadKey();
                                continue;
                            }
                        }
                    }
                }

                if (OperNeed == true)
                {
                    Console.WriteLine("Operation (+, -, *): ");
                    oper = Convert.ToString(Console.ReadLine());
                    if (oper != "+" && oper != "-" && oper != "*" || oper == null)
                    {
                        Console.WriteLine("Вы ввели неправильный оператор или не ввели его вовсе!");
                        Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        if (oper == "+")
                        {
                            CheckPlus = true;
                        }
                        if (oper == "-")
                        {
                            CheckMinus = true;
                        }
                        if (oper == "*")
                        {
                            CheckMult = true;
                        }
                    }
                }

                Console.WriteLine("b: ");
                bnum = Convert.ToString(Console.ReadLine());
                if (bnum == null)
                {
                    Console.WriteLine("Введите число пожайлуста!");
                    Console.ReadLine();
                    continue;
                }
                bool isNum2 = double.TryParse(bnum, out b);
                if (isNum2)
                {
                    b = Convert.ToDouble(bnum);
                }
                else
                {
                    if (bnum.Contains('='))
                    {
                        string b2 = bnum.Substring(0, bnum.IndexOf('='));
                        b = Convert.ToDouble(b2);
                        if (bnum.Length > b2.Length + 1)
                        {
                            if (bnum.Contains(' '))
                            {
                                string equals = bnum.Remove(0, bnum.IndexOf('=') + 1);

                                Console.ReadKey();
                            }
                        }
                    }
                }

                if (CheckPlus == true)
                {
                    Console.WriteLine(Calculator.Add(a, b));
                }

                if (CheckMinus == true)
                {
                    Console.WriteLine(Calculator.Subtraction(a, b));
                }

                if (CheckMult == true)
                {
                    Console.WriteLine(Calculator.Multiplication(a, b));
                }

                Console.ReadKey();
            }
        }
    }
}