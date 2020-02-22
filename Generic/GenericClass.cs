using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class GenericClass<T>
    {
        private T a;
        private T b;

        public  GenericClass(T a,T b) {
            this.a = a;
            this.b = b;
        }

        public T Add() {
            dynamic v1 = a;
            dynamic v2 = b;
            return v1 + v2;
        }
    }
}
