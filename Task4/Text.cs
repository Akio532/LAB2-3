﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace Task4
{
    public class Text
    {
        private SortedDictionary<string, int> Dict; //словарь
        private HashSet<string> Set;//все слова
        private double Length; //количество слов


        public Text()
        {
            Length = 0;
            Dict = new SortedDictionary<string, int>();
            Set = new HashSet<string>();
        }


        /// <param name="fileName"></param>
        public Text(string fileName)
        {
            Dict = new SortedDictionary<string, int>();
            Set = new HashSet<string>();
            Length = 0;
            Add(fileName);
        }


        /// <param name="filename"></param>
        /// добавление текста из файла
        public void Add(string filename)
        {
            StreamReader input = new StreamReader(filename);
            while (!input.EndOfStream)
            {
                string text = input.ReadLine();
                string[] textArr = Regex.Replace(
               new string(text.Where(x => char.IsWhiteSpace(x) || char.IsLetter(x)).Select(char.ToLower)
                   .ToArray()), @"\s+", " ").Split();
                Length += textArr.Length;
                foreach (string word in textArr)
                {
                    if (Dict.ContainsKey(word))
                        Dict[word]++;
                    else
                        Dict[word] = 1;
                    Set.Add(word);
                }
            }
            input.Close();
        }


        /// <param name="first"></param>
        /// <param name="second"></param>
        /// 
        // косинус
        public static double Cos(Text first, Text second)
        {
            List<double> temp1 = new List<double>();
            List<double> temp2 = new List<double>();
            foreach (var word in first.Set.Intersect(second.Set).ToHashSet())
            {
                temp1.Add(first.Dict[word]);
                temp2.Add(second.Dict[word]);
            }
            foreach (var word in first.Set.Except(second.Set).ToHashSet())
            {
                temp1.Add(first.Dict[word]);
                temp2.Add(0);
            }
            foreach (var word in second.Set.Except(first.Set).ToHashSet())
            {
                temp1.Add(0);
                temp2.Add(second.Dict[word]);
            }
            var vector1 = new Vector(temp1, first.Length);
            var vector2 = new Vector(temp2, second.Length);
            return Vector.Cos(vector1, vector2);
        }
        public int Count => Dict.Count;
    }
}

