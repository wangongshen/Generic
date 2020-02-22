using Generic.entity;
using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //int iValue = 123;
            //string sValue = "456";
            //DateTime dtValue = DateTime.Now;
            //object oValue = "789";

            ////泛型方法
            //CommonMethod.Show<int>(iValue);
            //CommonMethod.Show<string>(sValue);
            //CommonMethod.Show<DateTime>(dtValue);
            //CommonMethod.Show<object>(oValue);
            //Chinese chinese = new Chinese()
            //{
            //    Id = 001,
            //    Name = "赵日天",
            //    Country = "中国",
            //};
            //Japanese japanese = new Japanese()
            //{
            //    Id = 002,
            //    Name = "山本",
            //    Country = "日本",
            //};
            //CommonMethod.Introduce<People>(chinese);
            //CommonMethod.Introduce<People>(japanese);


            ////泛型类
            GenericClass<int> gcA = new GenericClass<int>(1,2);
            int sumA = gcA.Add();
            Console.WriteLine("int类型值："+sumA);
            GenericClass<string> gcB = new GenericClass<string>("字符", "串");
            string sumB = gcB.Add();
            Console.WriteLine("string类型值：" + sumB);



        }

    }
}
