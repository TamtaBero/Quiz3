using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz3
{
    internal class task3
    {
        class Solver
        {
            public static int SolveEquation(string eq)
            {
                int operand1 = 0;
                int operand2 = 0;
                char oper = ' ';

                bool haveOper1 = false;
                bool haveOper2 = false;

                for (int i=0; i < eq.Length; i++)
                {
                    char ci = eq[i];

                    if (ci == '(')
                    {
                        int bracketFinish = 0;
                        for (int j = i; j < eq.Length; j++)
                        {
                            if (eq[j] == ')')
                            {
                                bracketFinish = j;
                                break;
                            }
                        }
                       
                        if (!haveOper1)
                        {
                            operand1 = SolveEquation(eq.Substring(i+1, bracketFinish-1));
                            haveOper1 = true;
                        }
                        else if (!haveOper2)
                        {
                            operand2 = SolveEquation(eq.Substring(i+1, bracketFinish-1));
                            haveOper2 = true;
                        }
                    }
                    else if (Char.IsDigit(ci))
                    {
                        if (!haveOper1)
                        {
                            operand1 = Int16.Parse(ci.ToString());
                            haveOper1 = true;
                        }
                        else if (!haveOper2)
                        {
                            operand2 = Int16.Parse(ci.ToString());
                            haveOper2 = true;
                        }
                    }
                    else if (oper != ' ')
                    {
                        oper = ci;
                    }


                }

                switch (oper)
                {
                    case '+':
                        return operand1 + operand2;
                    case '-':
                        return operand1 - operand2;
                    case '*':
                        return operand1 * operand2;
                    default:
                        return 0;
                }
            }
        }

    }
}
