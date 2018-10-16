using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCSharp
{
   public class StringUtility
    {
      public  static string SummarizeText(string text, int maxLength = 20)
        {


            if (text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalcharcters = 0;
            var summaryWords = new List<String>();
            foreach (var word in words)
            {
                summaryWords.Add(word);
                //+1 for the space
                totalcharcters += word.Length + 1;
                if (totalcharcters > maxLength)
                    break;
            }
            //join string with space

            return String.Join(" ", summaryWords) + "....."; ;


        }

    }
}
