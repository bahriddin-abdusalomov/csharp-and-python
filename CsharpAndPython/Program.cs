using IronPython.Hosting;
using System;

namespace IronPython
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsolga "Hello Python" chiqarish
            Console.WriteLine("Hello Python");

            // Python skripti uchun muhitni yaratish
            var pythonEngine = Python.CreateEngine();
            var pythonScope = pythonEngine.CreateScope();

            // Foydalanuvchi kiritgan birinchi sonni olish
            Console.Write("First number: ");
            int num1 = int.Parse(Console.ReadLine());

            // Foydalanuvchi kiritgan ikkinchi sonni olish
            Console.Write("Second number: ");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                // PythonC#.py skriptini bajarish
                pythonEngine.ExecuteFile("C:\\Users\\USER\\Desktop\\C#ConnectPython\\pythonC#.py", pythonScope);

                // Python skriptidan "Sum" funksiyasini chaqirish
                dynamic pythonScript = pythonScope.GetVariable("Sum");
                int result = pythonScript(num1, num2);

                // Natijani chiqarish
                Console.WriteLine($"Sum result: {result}");
            }
            catch (Exception ex)
            {
                // Xato xabarini chiqarish
                Console.WriteLine(ex.Message);
            }
        }
    }
}
