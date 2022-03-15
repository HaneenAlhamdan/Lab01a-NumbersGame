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
          

                int[] resultArray = Populate(arr);
                int sum = GetSum(arr);


                int product = GetProduct(resultArray, sum);
                decimal quotient = GetQuotient(product);


                Console.WriteLine("Your arry is size " + arr.Length);
                Console.WriteLine("The number in the array are" );
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ",");
                }
                Console.WriteLine(" ");
                Console.WriteLine("The sum of the array is " + sum);
                Console.WriteLine(sum + " * " + (product / sum) + " = " + product);
                decimal division = Convert.ToDecimal(product) / quotient;
                Console.WriteLine(product + " / " + division + " = " + quotient);


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
                Console.WriteLine($"Please inter a number between 1 and {arr.Length}");
                String ranNum = Console.ReadLine();                                    
                int productNum = Convert.ToInt32(ranNum);
                int product = sum * arr[productNum - 1];
                return product;
            }
            catch (IndexOutOfRangeException e) 
            {                                 
                Console.WriteLine(e.Message);
                throw;
            }

            //    int num, product = 0;

            //      do
            //        {
            //              Console.WriteLine("Please select number  between  1 and " + arr.Length);
            //                num = Convert.ToInt32(Console.ReadLine());

            //              } while (num <= 1 || num > arr.Length);

            //                product = sum * arr[(num - 1)];

            //   return product;



            //}
            //catch (IndexOutOfRangeException e)
            //{
            //   Console.WriteLine(e.Message);
            //     throw e;
            // }

        }

        //Quotient 
        public static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Please enter a number to divide your product {product} by");  
                String divideNum = Console.ReadLine();
                decimal divide = Convert.ToDecimal(divideNum);

                decimal quotient = decimal.Divide(product, divide);
                return quotient;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;

                //  decimal result = 0;

                //Console.WriteLine("Please enter a number to divide " + product + " by");


                //result = decimal.Divide(product, Convert.ToInt32(Console.ReadLine()));

                //return result;
                // }
                //catch (DivideByZeroException e)
                //{
                //  Console.WriteLine(e.Message);
                //return 0;
            }


        }
    }
}
