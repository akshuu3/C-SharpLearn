using System;

namespace ProjectPractice.Basic
{
    internal class dataType
    {
        internal void PDataType()
        {
            int a = 10; // Integer data type
            byte bt = 0; // Byte data type
            float f = 10.5f; // Float data type
            double d = 20.5; // Double data type
            bool b = true; // Boolean data type
            char ch = 'A'; // Character data type
            string str = "Hello, World!"; // String data type
            Console.WriteLine("a={0}, bt={1}, f={2}, d={3}, b={4}, ch={5}, str={6}", a, bt, f, d, b, ch, str);
        }
        internal void DDataType2()
        {

            Int32 a = 10; // Integer data type (int is the alias of Int32; Int16 is short)
            Byte bt = 0; // Byte data type
            Single f = 10.5f; // Float data type (float is the alias of Single)
            Double d = 20.5; // Double data type
            Boolean b = true; // Boolean data type
            Char ch = 'A'; // Character data type
            String Str = "Hello, World!"; // String data type
            Object o = 12;
            Console.WriteLine("a={0}, bt={1}, f={2}, d={3}, b={4}, ch={5}, str={6}", a, bt, f, d, b, ch, Str);
        }
    }
}
