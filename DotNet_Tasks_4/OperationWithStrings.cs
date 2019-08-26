using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Tasks_4
{
    public static class OperationWithStrings
    {
        public static List<string> Random()
        {
            List<string> randArr = new List<string>();
            char[] letters = "QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();

            for (int k = 0; k < 120; k++)
            {
                Random r = new Random();
                string random = "";
                for (int i = 0; i < 4; i++)
                {
                    random += letters[r.Next(0, 25)].ToString();
                    System.Threading.Thread.Sleep(1);
                }
                randArr.Add(random);
            }
            return randArr;
        }

        public static List<string> Find(List<string> arr)
        {
            List<string> newArr = new List<string>();
            for (int i = 0; i < arr.Count; i++)
            {   
                for (int j = i + 1; j < arr.Count; j++)
                {                    
                        
                        if (newArr.Count==0)
                        {
                            newArr.Add(arr[i]);
                        }
                        if (!(arr[i]==newArr[newArr.Count-1]))
                        {
                            if (!(arr[i].Substring(0,1)=="Z"))
                            { newArr.Add(arr[i]); }
                        }
                }
            }
            return newArr;
        }

        public static List<string> Sort (List<string> arr)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < arr.Count - 1; ++i)
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        string buf = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = buf;
                        flag = true;
                    }
            }
            arr.Reverse();
            return arr;
        }

        public static List<string> DisplayPage(List<string> arr, int pageNumber)
        {
            List<string> newArr = new List<string>();
            return newArr;
        }

    }
}
