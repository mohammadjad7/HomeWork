using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 25, 30, 25, 40, 50, 70, 75, 80, 30, 50 };
            //التكرارية
            
            CountOccurrencesIterative(array);
            //العودية
            
            int[] occurrences = new int[51]; // 75 - 25 + 1 = 51
            CountOccurrencesRecursive(array, 0, occurrences);

            // طباعة النتائج
            for (int i = 0; i < occurrences.Length; i++)
            {
                if (occurrences[i] > 0)
                {
                    Console.WriteLine($"القيمة {i + 25} تتكرر {occurrences[i]} مرة(s).");
                }
            }
        }
        // التكرارية
        static void CountOccurrencesIterative(int[] arr)
        {
            // مصفوفة لتخزين التكرارات من 25 إلى 75
            int[] occurrences = new int[51]; // 75 - 25 + 1 = 51

            // المرور على كل عنصر في المصفوفة
            foreach (int num in arr)
            {
                // التحقق من أن الرقم ضمن النطاق المطلوب
                if (num >= 25 && num <= 75)
                {
                    occurrences[num - 25]++; // تخزين التكرار
                }
                else
                {
                    Console.WriteLine($"خطأ: القيمة {num} ليست ضمن النطاق 25 إلى 75.");
                }
            }

            // طباعة النتائج
            for (int i = 0; i < occurrences.Length; i++)
            {
                if (occurrences[i] > 0)
                {
                    Console.WriteLine($"القيمة {i + 25} تتكرر {occurrences[i]} مرة(s).");
                }
            }
        }
        ///////////////
        //العودية
        static void CountOccurrencesRecursive(int[] arr, int index, int[] occurrences)
        {
            // التحقق من انتهاء المصفوفة
            if (index >= arr.Length)
            {
                return;
            }

            int num = arr[index];

            // التحقق من أن الرقم ضمن النطاق المطلوب
            if (num >= 25 && num <= 75)
            {
                occurrences[num - 25]++; // تخزين التكرار
            }
            else
            {
                Console.WriteLine($"خطأ: القيمة {num} ليست ضمن النطاق 25 إلى 75.");
            }

            // استدعاء التابع بشكل تكراري للعنصر التالي
            CountOccurrencesRecursive(arr, index + 1, occurrences);
        }
    }
}
