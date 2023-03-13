﻿using System;
using static DependencyInjection.NumGenerator;

namespace DependencyInjection
{
    public class NumGenerator2 : INumGenerator2
    {
        public int RandomValue { get; }

        private readonly INumGenerator numGenerator;

        public NumGenerator2(INumGenerator numGenerator)
        {
            this.numGenerator = numGenerator;
            RandomValue = new Random().Next(1000);
        }

        public int GetNumGeneratorRandomNumber()
        {
            return numGenerator.RandomValue;
        }
    }

    public interface INumGenerator2
    {
        public int RandomValue { get; }

        public int GetNumGeneratorRandomNumber();
    }
}
