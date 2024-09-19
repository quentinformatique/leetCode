using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        IList<int> result = new List<int>();

        for (int i = 0 ; i < expression.Length ; i ++) 
        {
            char operation = expression[i];
            if (operation == '+' || operation == '*' || operation == '-')
            {
                IList<int> s1 = DiffWaysToCompute(expression.Substring(0, i));
                IList<int> s2 = DiffWaysToCompute(expression.Substring(i + 1));
                foreach (int a in s1) 
                {
                    foreach(int b in s2) 
                    {
                        result.Add(operation == '+' ? a + b : operation == '*' ? a * b : a - b);
                    }
                }
            }
        }
        if (result.Count == 0) result.Add(Int32.Parse(expression));
        return result;
    }
}