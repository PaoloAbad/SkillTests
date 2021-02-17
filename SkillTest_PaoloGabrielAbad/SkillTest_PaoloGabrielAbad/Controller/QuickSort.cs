using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest_PaoloGabrielAbad.Controller
{
    public class QuickSort : ISortCharacters
    {
        public void SortInputtedLetters(string[] input)
        {
            if (myStr == null || myStr.length() == 0 || myStr.length() == 1)
            {
                return null;
            }
            int length = input.Length();
            int low = 0, high = length - 1;
            this.myArray = myStr.toCharArray();

            quickSort(low, high);
            return new String(myArray);
        }
    }
}
