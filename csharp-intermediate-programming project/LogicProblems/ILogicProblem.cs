using System;
using System.Collections.Generic;

namespace LogicProblems
{
 /*
 ***********************************************************
 ***********************************************************
 ***********************************************************
 **************DO NOT CHANGE THIS INTERFACE!!!**************
 ***********************************************************
 ******** EXCEPTION: TO ADD XML STRUCTURED COMMENTS ********
 ******************TO THE PUBLIC METHODS********************
 ***********************************************************
 ***********************************************************
 */

    public interface ILogicProblem
    {
        double Average(int[] scores);

        int LastWordLength(string text);

        decimal DistinctLadderPaths(int rungs);

        List<List<string>> GroupStrings(string[] strs);
    }
}
