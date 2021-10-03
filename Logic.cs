using System;

namespace labGUI1_2
{
    class Logic
    {
        public static string Solution(string str, uint n)
        {
            string answer = "";
            for (int i = 0; i <= str.Length - n; i++)
            {
                bool output = true;
                for (int j = i + 1; j < i + n; j++)
                {
                    if (str[i] != str[j])
                    {
                        output = false;
                        break;
                    }
                }

                if (!output && i == str.Length - n)
                {
                    answer = "Соседние цифры отсутствуют";
                }
                else if (output)
                {
                    answer = "Индексы первых соседних цифр: ";
                    for (int j = i; j < i + n; j++)
                    {
                        answer += j + 1 + " ";
                    }
                    break;
                }
            }
            return answer;
        }
    }
}
