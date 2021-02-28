using System;

namespace FrequencyOfEachElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UserInput;
            int[] Frequency;
            int NumberOfElements, i;
            
            Console.Write("Enter the number of elements to be stored in array : ");
            NumberOfElements = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in to the array :\n");
            //Store the Length of Array in UserInput and Frequency
            UserInput = new int[NumberOfElements];
            Frequency = new int[NumberOfElements];
            for(i = 0; i < NumberOfElements; i++)
            {
                Console.Write("Element - [{0}] : ", i);
                UserInput[i] = Convert.ToInt32(Console.ReadLine());
                Frequency[i] = -1;
            }
            for (i = 0; i < NumberOfElements; i++)
            {
                int ctr = 1;
                for(int j = i + 1; j < NumberOfElements; j++)
                {
                    if (UserInput[i] == UserInput[j])
                    {
                        ctr++;
                        //To avoid counting same element
                        Frequency[j] = 0;
                    }
                }
                if(Frequency[i] != 0)
                {
                    Frequency[i] = ctr;
                }
            }
            Console.Write("\nThe Frequency of all elements in the array : \n");
            for (i = 0; i < NumberOfElements; i++)
            {
                if (Frequency[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", UserInput[i], Frequency[i]);
                }
            }
        }
    }
}
