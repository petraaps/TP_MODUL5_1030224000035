using System;

namespace ModulGeneric
{
    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string nimPraktikan = "103022400035";
            DataGeneric<string> dataNim = new DataGeneric<string>(nimPraktikan);

            dataNim.PrintData();
        }
    }
}