﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20MoodAnalyzer
{
    public class MoodAnalysisException: Exception
    {
        public MoodAnalysisException(string message) : base(message)
        {

        }
    }
}
