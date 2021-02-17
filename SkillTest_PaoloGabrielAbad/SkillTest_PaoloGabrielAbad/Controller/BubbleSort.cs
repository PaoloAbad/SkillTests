using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest_PaoloGabrielAbad.Controller
{
    public class BubbleSort : ISortCharacters
    {
        public void SortInputtedLetters(string[] input)
        {
            bool swap;
            string temp;

            do
            {
                swap = false;

                for (int index = 0; index < (input.Length - 1); index++)
                {
                    if (string.Compare(input[index], input[index + 1]) < 0) //if first number is greater then second then swap
                    {
                        temp = input[index];
                        input[index] = input[index + 1];
                        input[index + 1] = temp;
                        swap = true;
                    }
                }
            }
            while (swap == true);
        }
    }
}
