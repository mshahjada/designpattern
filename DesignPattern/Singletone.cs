using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    /*
        In singletone pattern 
        
     */
    public class Singletone
    {
        private static Singletone singletone = new Singletone();
        private Singletone() { }

        public static Singletone GetObject() { return singletone; }

        public double Length { get; set; }
        public double Width { get; set; }
        public double GetArea()
        {
            return this.Length * this.Width;
        }
    }
}
