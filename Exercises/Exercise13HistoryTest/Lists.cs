﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise13HistoryTest
{
    class Lists
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            var rando = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rando.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}