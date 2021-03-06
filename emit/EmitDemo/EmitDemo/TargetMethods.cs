﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitDemo
{
    public class TargetMethods
    {
        public class Fibonacci
        {
            public int Calc(int num)
            {
                if (num == 1 || num == 2)
                {
                    return 1;
                }
                else
                {
                    return Calc(num - 1) + Calc(num - 2);
                }
            }
        }

        public class Add
        {
            private int _a = 0;

            public int A

            {

                get { return _a; }

                set { _a = value; }

            }



            private int _b = 0;

            public int B

            {

                get { return _b; }

                set { _b = value; }

            }

            public Add(int a, int b)

            {

                _a = a;

                _b = b;

            }



            public int Calc()

            {

                return _a + _b;

            }
        }

        public class Iterator
        {
            public int ForMethod(int[] ints)
            {
                int sum = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    sum += ints[i];
                }
                return sum;
            }

            public int ForeachMethod(int[] ints)
            {
                int sum = 0;
                foreach (int i in ints)
                {
                    sum += i;
                }
                return sum;
            }
        }

        public class ExceptionHandler
        {
            public static int ConvertToInt32(string str)
            {
                int num = 0;
                try
                {
                    num = Convert.ToInt32(str);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return num;
            }
        }


        public class Base
        {
            string _a;
            bool _b;
            int _c;
            DateTime _d;
            public Base()
            {

            }


            public Base(string a, bool b, int c)
            {
                _a = a;
                _b = b;
                _c = c;
            }

            public Base(string a, bool b, int c, DateTime d) : this(a, b, c)
            {
                _d = d;
            }

            //public Base(string a, bool b, int c, DateTime d, int e, string fff)
            //{

            //}

            public override string ToString()
            {
                return string.Format("a:{0},b:{1},c:{2},d:{3}", _a, _b, _c, _d.ToString("yyyy-MM-dd"));
            }
        }

        public class Sub : Base
        {
            public Sub() { }
            public Sub(string a, bool b, int c) : base(a, b, c) { }
            public Sub(string a, bool b, int c, DateTime d) : base(a, b, c, d) { }
            //public Sub(string a, bool b, int c, DateTime d, int e, string fff) : base(a, b, c, d, e, fff) { }

        }
    }
}
