using System;
using System.Collections;
namespace exception

{
    class Myexception : Exception
    {
        public Myexception(string message):base(message)
        {
            //Console.WriteLine(message);
        }
    }
    class exceptions
    {
        public static void method()
        {
            int i = 100;
            try
            {
                int x = i/0;
            }
            catch(Exception e)
            {
                throw;
            }
        }
        public static void Main(string[] args)
        {
            int x = 100;
            int y = 0;
            try
            {
                int z = x / y;
                // Console.WriteLine("hello");
                //throw new DivideByZeroException("Exceptionnnnn");
                //exceptions.method();
                //throw new Myexception("UserDefined Exception");
            }
            catch (Myexception e)
            {
                Console.WriteLine("Exception occured ");
            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            }
            //catch
            //{
            //    Console.WriteLine("Exception");
            //}
            //finally
            //{
            //    Console.WriteLine("finally");
            //}

            Console.ReadKey();
        }
    }
}
