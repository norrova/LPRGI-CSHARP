using System;
namespace csharp
{
    public static class Exercise
    {
        public static void One()
        {
            int v_variable = 2;
            int v_index = 0;
            while(v_index <= v_variable)
            {
                Console.WriteLine(v_index);
                ++v_index;
            }
        }

        public static void Two()
        {
            int v_variable = 2;
            int v_index = 0;
            while (v_index <= v_variable)
            {
                if (v_index % 2 == 0)
                    Console.WriteLine(v_index);
                ++v_index;
            }
        }

        public static void Three()
        {
            int v_number;
            do
            {
                Console.WriteLine("Saisir un nombre entre 1 et 100");
                Int32.TryParse(Console.ReadLine(), out v_number);
            } while (v_number > 100 || v_number < 1);
            int v_suggestion, v_min = 1, v_max = 100;
            do
            {
                v_suggestion = (int)Math.Round((v_max + v_min) / 2f);
                if (v_number < v_suggestion)
                    v_max = v_suggestion;
                else
                    v_min = v_suggestion;
            } while (v_suggestion != v_number);
            Console.WriteLine(v_suggestion);
        }
    }
}
