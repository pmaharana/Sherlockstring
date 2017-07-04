using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlockstring
{
    class Program
    {
        static void Main(string[] args)
        {

            //string s = Console.ReadLine();
            string s = "aabbcd";
            string result = isValid(s);
            Console.WriteLine(result);






        }


        static string isValid(string s)
        {
            string answer = new string(s.Distinct().ToArray());

            var myDic = new Dictionary<char, int>();
            foreach (var letter in answer)
            {
                myDic.Add(letter, s.Count(c => c == letter));
            }
            var countList = new List<int>();
           
            foreach (var x in myDic)
            {
                countList.Add(x.Value);
            }
            int countMin = countList.Min();
            int countMax = countList.Max();

            // new part trial
            int countMinCount = countList.Count(d => d == countMin);
            int countMaxCount = countList.Count(d => d == countMax);

            bool yugi = false;


            if (countMaxCount == 1 )
            {
                yugi = true;
            }
           
            //

            if (countList.Distinct().Count() == 1 || 
                (countMax - 1 == countMin && (countMinCount < 2 || yugi == true)) 
                )
            {
                return "YES";
            }
           

            //if (countList.Distinct().Count() == 1 || (countMax - 1 == countMin && (countList.Count(c => c == countMin) < 2 || yugi == true)))
            //{
            //    return "YES";
            //}
            //if ((countMax % countMin == 0 || (countMax - 1) % countMin == 0) && (countMinCount < 2 || yugi == true))
            //{
            //    return "YES";
            //}
            else
            {
                return "NO";
            }
        }
    }
}
