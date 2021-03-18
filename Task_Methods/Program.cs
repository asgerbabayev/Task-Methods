using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            #region 1. Random eded teyin edilsin (0,100) arasi.
            //int guess = 0;
            //int counter = 0;
            //int temp;
            //Random rnd = new Random();
            //temp = rnd.Next(1, 100);
            //while (guess != temp)
            //{
            //    counter++;
            //    Console.WriteLine("Enter the number");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    if (guess > temp)
            //    {
            //        Console.WriteLine("Kicik eded daxil edin.");
            //    }
            //    else if (guess < temp)
            //    {
            //        Console.WriteLine("Boyuk eded daxil edin.");
            //    }
            //}
            //Console.WriteLine("Tapdiniz.");
            #endregion

            #region 2. Class yaradın və daxilində toplama, çıxma, vurma, bölmə əməllərini icra edən və geriyə dəyər qaytaran methodlar yazın.
            //Calculate calc = new Calculate();
            //Console.Write("Enter the first value: ");
            //int value1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second value: ");
            //int value2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Sum: {calc.Sum(value1, value2)}");
            //Console.WriteLine($"Difference: {calc.Difference(value1, value2)}");
            //Console.WriteLine($"Multiplication: {calc.Multiplication(value1, value2)}");
            //Console.WriteLine($"Section: {calc.Section(value1, value2)}");
            #endregion

            #region 3. Method parameter olaraq int array qəbul etsin və geriyə arrayin elementləri cəmini qaytarsin.
            //Console.Write("Enter the size of the array: ");
            //int arrSize = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[arrSize];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter the elements of the array:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(pr.SumOfList(arr));
            #endregion

            #region 4. Metodlardan 1-cisi 2 string parameter qəbul etsin və geriyə stringləri birləşdirərək dəyər qaytarsın.
            //Combining cm = new Combining();
            //string result1 = cm.StringMethod("Visual","Studio");
            //string result2 = cm.StringMethod("Visual","Studio","C#");
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            #endregion

            #region 5. Metod daxilində 10 ədəd random ədəd generasiya edib list-ə yığın və həmən listi geri qaytarin.
            //List<int> rnList = pr.RandomList();
            //foreach (var item in rnList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6. Animal adlı public class yaradın və class daxilində animala aid ola biləcək 3-dən çox field yaradın.
            //Animal animal = new Animal();
            //animal.Name = "Cat";
            //animal.Age = 2;
            //animal.FeedName = "Meat";
            //animal.Health = "Normal";
            //Console.WriteLine($"\n {animal.Name} \n {animal.Age} \n {animal.FeedName} \n {animal.Health}");
            #endregion

            #region 7. Class yaradın və 3 fieldi olsun. Class daxilin 3 parameter qəbul edən constructor yaradın.
            //Employee emp = new Employee("name", "surname", "salary");
            //Console.WriteLine(emp.Name);
            //Console.WriteLine(emp.Surname);
            //Console.WriteLine(emp.Salary);
            #endregion

            #region 8. Key-lerinde “test” sözü keçən value lar ekrana yazdırılsın.
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //string value;
            //string key;
            //for (int i = 0; i < 4; i++)
            //{
            //        Console.WriteLine("Enter the Key:");
            //        key = Console.ReadLine();
            //        Console.WriteLine("Enter the Value:");
            //        value = Console.ReadLine();
            //        dic.Add(key, value);
            //}
            //foreach (KeyValuePair<string, string> el in dic)
            //{
            //    if (el.Key == "test")
            //    {
            //        Console.WriteLine(el.Value);
            //    }
            //}
            #endregion

            Console.ReadKey();
        }

        public int SumOfList(int[] list)
        {
            int sum = 0;
            foreach (var el in list)
            {
                sum += el;
            }
            return sum;
        }

        public List<int> RandomList()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(0, 10));
            }
            return list.ToList();
        }
    }

}
