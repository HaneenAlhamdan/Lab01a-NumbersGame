using System;

namespace Numbers_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {


                StartSequence();


            }
            catch (Exception e)
            {
                Console.WriteLine("" + e.Message);
            }
            finally
            {
                Console.WriteLine("Program is Complete");
            }




        }

        public static void StartSequence()

        {
            try
            {
                Console.WriteLine("Welcome to my game ! Let's do some math!");
                Console.WriteLine("Enter a number greater than zero");

                int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
                Populate(arr);


                int sum = GetSum(arr);


                int multArr = GetProduct(arr, sum);


                decimal quot = GetQuotient(multArr);


                Console.WriteLine("Your arry is size " + arr.Length);
                Console.WriteLine("The number in the array are" + arr);
                Console.WriteLine("The sum of the array is " + sum);
                //  Console.WriteLine(sum + * + "=");
               // Console.WriteLine(product + / + + "=");


                
            }
            catch (IndexOutOfRangeException)
            {

                throw;
            }
            catch (FormatException f)
            {

                Console.WriteLine(f.Message);

            }
            catch (OverflowException o)
            {
                Console.WriteLine(o.Message);

            }





        
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
        //Populate 
        public static int[] Populate(int[] arr)
        {
            //int num1;
            //int num2 = 1;

            //Console.WriteLine("Welcome to my game ! Let's do some math!");
            //Console.WriteLine("Enter a number greater than zero");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < num1; i++)

            //{
            // Console.WriteLine("Please enter number :" + num2 + " of " + num1);
            //  num2++;
            // arr = new int[num1];
            //   arr[i] = int.Parse(Console.ReadLine());
            // }

            

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("Please enter a number :" + (i + 1) + " of " + arr.Length);
                String s = Console.ReadLine();
                arr[i] = Convert.ToInt32(s);

            }

            return arr;
        }

        //Sum
        public static int GetSum(int[] arr )
        {
            int sum = 0;
            try
            {


                foreach (int i in arr)
                {
                    sum += i;
                }

                return sum;
            }
            catch (Exception)
            {

                throw new Exception($"Value of {sum} is too low");
            }
        }

        //Product
        public static int GetProduct(int[] arr, int sum)
        {
            try
            {

                int num, product = 0;

                do
                {
                    Console.WriteLine("Please select number  between  1 and " + arr.Length);
                    num = Convert.ToInt32(Console.ReadLine());

                } while (num <= 1 || num > arr.Length);

                product = sum * arr[(num - 1)];

                return product;



            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        //Quotient 
        public static decimal GetQuotient(int product)
        {
            try
            {

                decimal result = 0;

                Console.WriteLine("Please enter a number to divide " + product + " by");


                result = decimal.Divide(product, Convert.ToInt32(Console.ReadLine()));
               
                return result;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }


        }
    }
}
