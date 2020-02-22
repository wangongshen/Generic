using Generic.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class CommonMethod
    {
        public static void Show<T>(T tParameter)
        {
            Console.WriteLine("类型是：{0},值是：{1}",tParameter.GetType().Name, tParameter);
        }

        public static void Introduce<T>(T tParameter) where T : People
        {
            Console.WriteLine("我是："+tParameter.Country+"人");
            Console.WriteLine("姓名：" + tParameter.Name);

        }
    }
}
