﻿using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindSmallestInt(int[] input)
        {
            if(input.Length < 1)
            {
                throw new ArgumentException();
            }
            if(input.Length > 1)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    for(int j = 0; j < input.Length - 1; j++)
                    {
                        if (input[j] > input[j + 1])
                        {
                            var temp = input[j];
                            input[j] = input[j + 1];
                            input[j + 1] = temp;
                        }
                    }
                }
            }
            return input[0];
        }

        public int FindClosestIntToZero(int[] input)
        {
            if (input.Length < 1)
            {
                throw new ArgumentException();
            }
            return input[0];
        }
    }
}
