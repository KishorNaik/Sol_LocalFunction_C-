using System;

namespace Sol_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LocalFunctionDemo localFunctionDemo = new LocalFunctionDemo();
            int result=localFunctionDemo.Add(2, 2);
            Console.WriteLine(result);

            localFunctionDemo.Demo();

        }
    }

    public class LocalFunctionDemo
    {
        public int Add(int value1,int value2)
        {
            int result = AddOperation();
            return result;

            // Local Function
            int AddOperation()
            {
                return value1 + value2;
            }
        }

        public void Demo()
        {
            //Call Local Function (Generic)
            LocalFuncGeneric<String>("Kishor Naik");

            int value = 0;
            //Call Local Function (out)
            LocalFuncOut(out value);
            Console.WriteLine(value);

            //Call Local Function (ref)
            LocalFuncRef(ref value);
            Console.WriteLine(value);

            // Call Local Function with Param
            LocalFuncParam(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            // call Local function with Optional and Named Parameter
            string fullName= LocalFuncOptionalWithNamePara(lastName: "naik", firstName: "kishor");
            Console.WriteLine(fullName);

            fullName = LocalFuncOptionalWithNamePara(lastName: "naik", firstName: "kishor",  age:35);
            Console.WriteLine(fullName);

            // local Static function
            LocalStaticFuncDemo();


            // Local Function With Generic
            void LocalFuncGeneric<T>(T item)
            {
                Console.WriteLine(item);
            }

            // local Function with Out Parameter
            void LocalFuncOut(out int value)
            {
                value = 10;
            }

            // local function with ref Parameter
            void LocalFuncRef(ref int value)
            {
                value = 11;
            }

            // local function with param parameter
            void LocalFuncParam(params int[] values)
            {
                foreach(var value in values)
                {
                    Console.WriteLine(value);
                }
            }

            // local function with optional and named parameter
            string LocalFuncOptionalWithNamePara(string firstName,string lastName,int age = default)
            {
                return $"{firstName} {lastName} {age}";
            }

            // Local Static Function
            static void LocalStaticFuncDemo()
            {
                Console.WriteLine("Local Static function");
            }

        }
    }
}
