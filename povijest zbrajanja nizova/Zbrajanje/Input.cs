using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbrajanje
{
    class Input
    {
        private int sum { get; set; }
        private int[] numberArray;
        private string originalText { get; set; }
        public string[] Text { get; set; }
        public Input (string t)
        {
            originalText = t;
            Text = originalText.Split(',');
            numberArray = new int[Text.Length];
            for (int i = 0; i < Text.Length; i++)
                numberArray[i] = int.Parse(Text[i]);
        }
        public int getSum()
        {
            for (int i = 0; i < numberArray.Count(); i++)
                sum += numberArray[i];
            return sum;
        }
        public override string ToString()
        {
            string s = originalText.Replace(',', '+');
            return s;
        }
    }
}
