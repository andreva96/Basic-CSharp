namespace CSharpTutorial
{
    // https://www.youtube.com/watch?v=gfkTfcpWqAY&ab_channel=ProgrammingwithMosh tutorial
    class BasicTutorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // all this variables can be initiated wit "var"
            byte number = 2;            // with var it goes as "int"
            int count = 10;
            float totalPrice = 20.95f;  // with var it goes as "single"
            char character = 'A';
            string firstName = "Andre";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            Console.WriteLine(Pi);

            int i = 255;
            byte a = (byte) ++i; // as it was incremented before assigning it gone to 256 wich is and overflow on byte 
            Console.WriteLine(a);

            try
            {
                var strNumber = "1234";
                byte f = Convert.ToByte(strNumber); // conversion of not compatible variables needs the "Convert."
                Console.WriteLine(f);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                var strBool = "true";
                bool b = Convert.ToBoolean(strBool); 
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a boolean.");
            }

            var x = 10;
            var y = 3;
            var z = 5;

            Console.WriteLine(x + y);
            Console.WriteLine(x / y);
            Console.WriteLine((float)x / (float)y);
            Console.WriteLine(x + y * z);
            Console.WriteLine((x + y) * z);

            Console.WriteLine(x > z);           // true
            Console.WriteLine(x == z);          // false
            Console.WriteLine(x != z);          // true
            Console.WriteLine(!(x != z));       // false
            Console.WriteLine(x > y && x > z);  // true
            Console.WriteLine(x > y && x == z); // false
            Console.WriteLine(x > y || x == z);  // true

        }
    }
}