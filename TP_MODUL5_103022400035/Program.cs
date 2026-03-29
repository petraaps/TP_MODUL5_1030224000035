using System;

namespace ModulGeneric
<<<<<<< HEAD
{ 
    public class HaloGeneric
    {
        public void SapaUser<T>(T input)
        {
            Console.WriteLine($"Halo user {input}");
=======
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
>>>>>>> generic-class
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            HaloGeneric halo = new HaloGeneric();

            string namaPraktikan = "Petra"; 
            halo.SapaUser(namaPraktikan);
=======

            string nimPraktikan = "103022400035";
            DataGeneric<string> dataNim = new DataGeneric<string>(nimPraktikan);

            dataNim.PrintData();
>>>>>>> generic-class
        }
    }
}