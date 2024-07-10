using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_090724
{
    internal class ArrayAssignment //class   
    {
        public void InsertArrayElement()
        {
            Console.WriteLine("insert element called...");
        }
        public void sorGivenArray() //method
        {
            int[]arr=new int[5];
        


            Console.WriteLine("enter 5 elements:");
            for(int i=0;i<arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Given Array is....");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // Array sort logic

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    Console.WriteLine($"****i={i} and j={j}");
                    Console.WriteLine($"****value of arr[i]={arr[i]} AND arr[j]={arr[j]}");
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
               
            }
            Console.WriteLine("Sorted Array is....");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

    }
}
