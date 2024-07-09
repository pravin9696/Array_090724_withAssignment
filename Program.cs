namespace Array_090724
{
    class student
    {
        public int roll;
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1= new student();

            //how to declare array
           
           
               int[] intArray = new int[10];
            // syntax
            //  datatype[] array_name=new dataType[size];

            //how to access Array Elements

            //randomly
            //write /store int into array
            intArray[9] = 2343;
            //read value from array
        
            int p=intArray[3];
            Console.WriteLine(p);
            Console.WriteLine(intArray[3]);

            //sequencital access
            //store numbers into array
            Console.WriteLine("enter 10 numbers");
            for (int i = 0; i < intArray.Length; i++)
            {
                p = int.Parse(Console.ReadLine());
                intArray[i] = p;
            }
            // sum to All array elements

            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i%2==0)
                {
                    sum = sum + intArray[i];
                }
                
            }

            Console.WriteLine("sum="+sum);


        }
    }
}
