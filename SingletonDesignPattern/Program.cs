using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj1 = Sample.CreateObject();
            Sample obj2 = Sample.CreateObject();
            Sample obj3 = Sample.CreateObject();
            obj1.SetData(1000);

            System.Console.WriteLine($"obj1-Data = {obj1.GetData()}");
            System.Console.WriteLine($"obj2-Data = {obj2.GetData()}");
            System.Console.WriteLine($"obj3-Data = {obj3.GetData()}");

            System.Console.WriteLine("----------------------");

            obj1.SetData(2000);

            System.Console.WriteLine($"obj1-Data = {obj1.GetData()}");
            System.Console.WriteLine($"obj2-Data = {obj2.GetData()}");
            System.Console.WriteLine($"obj3-Data = {obj3.GetData()}");

            System.Console.WriteLine();
            System.Console.WriteLine("Multi Thread Sample");
            System.Console.WriteLine();
            MultiThreadSample mobj1 = MultiThreadSample.CreateObject();
            MultiThreadSample mobj2 = MultiThreadSample.CreateObject();
            MultiThreadSample mobj3 = MultiThreadSample.CreateObject();
            mobj1.SetData(5000);

            System.Console.WriteLine($"mobj1-Data = {mobj1.GetData()}");
            System.Console.WriteLine($"mobj2-Data = {mobj2.GetData()}");
            System.Console.WriteLine($"mobj3-Data = {mobj3.GetData()}");

            System.Console.WriteLine("----------------------");

            mobj1.SetData(6000);

            System.Console.WriteLine($"mobj1-Data = {mobj1.GetData()}");
            System.Console.WriteLine($"mobj2-Data = {mobj2.GetData()}");
            System.Console.WriteLine($"mobj3-Data = {mobj3.GetData()}");
            System.Console.WriteLine();
            System.Console.WriteLine("Volatile Sample");
            System.Console.WriteLine();
            VolatileSample vobj1 = VolatileSample.CreateObject();
            VolatileSample vobj2 = VolatileSample.CreateObject();
            VolatileSample vobj3 = VolatileSample.CreateObject();
            vobj1.SetData(8888);

            System.Console.WriteLine($"vobj1-Data = {vobj1.GetData()}");
            System.Console.WriteLine($"vobj2-Data = {vobj2.GetData()}");
            System.Console.WriteLine($"vobj3-Data = {vobj3.GetData()}");

            System.Console.WriteLine("----------------------");

            vobj1.SetData(9999);

            System.Console.WriteLine($"vobj1-Data = {vobj1.GetData()}");
            System.Console.WriteLine($"vobj2-Data = {vobj2.GetData()}");
            System.Console.WriteLine($"vobj3-Data = {vobj3.GetData()}");


            /*
            obj1-Data = 1000
            obj2-Data = 1000
            obj3-Data = 1000
            ----------------------
            obj1-Data = 2000
            obj2-Data = 2000
            obj3-Data = 2000

            Multi Thread Sample

            mobj1-Data = 5000
            mobj2-Data = 5000
            mobj3-Data = 5000
            ----------------------
            mobj1-Data = 6000
            mobj2-Data = 6000
            mobj3-Data = 6000

            Volatile Sample

            vobj1-Data = 8888
            vobj2-Data = 8888
            vobj3-Data = 8888
            ----------------------
            vobj1-Data = 9999
            vobj2-Data = 9999
            vobj3-Data = 9999

            */

        }
    }
}
