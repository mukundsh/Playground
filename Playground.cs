namespace Playground
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Playground
    {
        public static void BringAllZerosToEnd(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    count++;
                }
            }

            int front = 0;
            int end = array.Length - 1;

            while (front < end)
            {
                while (array[front] != 0)
                {
                    front++;
                }

                while (array[end] == 0)
                {
                    end--;
                }

                if (front < end)
                {
                    int temp = array[front];
                    array[front] = array[end];
                    array[end] = temp;
                }

                front++;
                end--;
            }
        }

        public static string AddBinaryStrings(string num1, string num2)
        {
            List<char> chars1 = num1.ToCharArray().ToList();
            List<char> result = new List<char>();
            chars1.Reverse();

            List<char> chars2 = num2.ToCharArray().ToList();
            chars2.Reverse();

            int bitValue1, bitValue2, carryOver = 0;
            while (chars1.Count > 0 || chars2.Count > 0)
            {
                bitValue1 = 0;
                bitValue2 = 0;
                if (chars1.Count > 0)
                {
                    char c1 = chars1[0]; 
                    chars1.RemoveAt(0);

                    bitValue1 = c1 == '1' ? 1 : 0;
                }

                if (chars2.Count > 0)
                {
                    char c2 = chars2[0];
                    chars2.RemoveAt(0);

                    bitValue2 = c2 == '1' ? 1 : 0;
                }

                int sum = bitValue1 + bitValue2 + carryOver;
                char sumValue = '0';
                switch (sum)
                {
                    case 1:
                        sumValue = '1';
                        break;
                    case 2:
                        carryOver = 1;
                        break;

                    case 3:
                        carryOver = 1;
                        sumValue = '1';
                        break;
                }

                result.Add(sumValue);
            }

            if (carryOver > 0)
            {
                result.Add('1');
            }

            result.Reverse();
            var finalResult = new string(result.ToArray());
            return finalResult;
        }
    }
}
