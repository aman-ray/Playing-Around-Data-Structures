using System;
using System.Diagnostics;
using System.Linq;

namespace DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] test= new string[1]{"Nemo"};
            // FindingNemo(test);
            Man Aman = new Man();
            Aman.FindingAman(new string[]{"Aman"});
            //Finding if Array Consists of similar letter
        }

        public bool SimilarElementInArray(string[] Array1,string[] Array2)
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    if(Array1[i]==Array2[2])
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public void FindingNemo(Array arrayContent)
        {
            foreach (string item in arrayContent)
            {
                if(item=="Nemo")
                {
                    Console.WriteLine("Nemo Found");
                }
            }
        }
    }

    public class Man
    {
        public void FindingAman(Array arrayList)
        {
            var arrayContent1=Enumerable.Repeat("Aman",10000).ToArray();
            //int counter=1;
            

            // //Time Complexity
            // Stopwatch st =Stopwatch.StartNew();
            // foreach (string item in arrayContent1)
            // {
            //     ++counter;
            //     //Console.WriteLine(item);
            //     if(item=="Aman")
            //     {
            //         Console.WriteLine("You found Aman "+counter);
            //     }
            // }
            // st.Stop();
            // Console.WriteLine("Time Taken "+ st.Elapsed.Milliseconds);

            //Space Complexity
            SpaceComplexity sc = new SpaceComplexity();
            // sc.Space_1_Complexity(new int[]{1,2,3,5,6});
            sc.Space_N_Complexity(new int[]{1,2,3,5,6});
        }
    }

    public class SpaceComplexity
    {
        public void Space_1_Complexity(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("hi");
            }
        }

        public void Space_N_Complexity(int [] array)
        {
            int[] arrayAdd = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                arrayAdd.Append(array[i]+1);
                Console.WriteLine(arrayAdd[i].ToString());
                
            }
            Console.WriteLine(arrayAdd.Length);
        }
    }
}


