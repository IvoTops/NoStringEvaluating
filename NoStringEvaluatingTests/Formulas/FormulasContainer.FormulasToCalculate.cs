﻿using System;
using System.Collections.Generic;
using NoStringEvaluatingTests.Model;

namespace NoStringEvaluatingTests.Formulas
{
    public static partial class FormulasContainer
    {
        public static IEnumerable<FormulaModel[]> GetFormulasToCalculate()
        {
            foreach (var val in GetCommonFormulas())
            {
                yield return val;
            }

            yield return CreateTestModel("2", 2);
            yield return CreateTestModel("add(5; 6; 9)", 20);
            yield return CreateTestModel("kov(1; 2; 3) - kovt(8; 9)", 7);
            yield return CreateTestModel("1/6 + 5/12 + 3/4 * 1/6 + 5/12 + 3/4 - 1/6 + 5/12 + 3/4- 78", -75.125);
            yield return CreateTestModel("(45^6 + (12 - (34*896^2) / 325) / 80000000) / 7^13 + 1.2", 1.286);
            yield return CreateTestModel("mean ([super power war]; 6; 6; 8; add(78;89;6;5;4;2;1;5;8;789;56;6;6)*7; 5; 2; 4; 87; 7; 89; 5; 4; 52; 3; 5; 4; 8; 78; 5; 4; 2; 3)",
                357.739, ("super power war", 456));
            yield return CreateTestModel("[Provider(\"My test provider\").Month(-1).Price] * [Consumer(\"My test consumer\").Month().Volume]", 48,
                ("Provider(\"My test provider\").Month(-1).Price", 6), ("Consumer(\"My test consumer\").Month().Volume", 8));
            yield return CreateTestModel("if([var1] > 5 || [var1] != [var2]; 56+3; 1-344)", 59, ("var1", 5), ("var2", 6));
            yield return CreateTestModel("if([var1] >= 5 && [var1] + 10 == 15; 1; 0)", 1, ("var1", 5));
            yield return CreateTestModel("if(and(5; 8; 6) && [var1] < 5; 1; 0)", 0, ("var1", 5));
            yield return CreateTestModel("15+24 != [var1] * 3", 1, ("var1", 5));
            yield return CreateTestModel("15+24 == [var1] * 3", 1, ("var1", 13));
            yield return CreateTestModel("15+24 == [var1] * 3", 1, ("var1", 13));
            yield return CreateTestModel("15+24 == [var1] * 2", 0, ("var1", -3));
            yield return CreateTestModel("(5*3)-1", 14);
            yield return CreateTestModel("5*3-1", 14);
            yield return CreateTestModel("5*(3-1)", 10);
            yield return CreateTestModel("if(-1; -6; -7)", -6);
            yield return CreateTestModel("5 - -6", 11);
            yield return CreateTestModel("if ([Arg1] > 0; - [Arg1]; 0)", -16, ("Arg1", 16));
            yield return CreateTestModel("if ([Arg1] != 0; -----[Arg1]; 0)", -16, ("Arg1", 16));

            yield return CreateTestModel("-(5+6)", -11);
            yield return CreateTestModel("- add(1;3) - add(1; 2; 3)", -10);
            yield return CreateTestModel("if(5 > 0; -(5+6); 0)", -11);
            yield return CreateTestModel("-(9 - 7 + -(5 + 3))", 6);
            yield return CreateTestModel("-((5 + 6) * -(9 - 7 - (5 + 3))) * -((5 + 6) * -(9 - 7 - (5 + 3)))", 4356);
            yield return CreateTestModel("5 * -add(1; 3) * -[Arg1] / -(-add(1; 3) *3)", 1480, ("Arg1", 888));
            yield return CreateTestModel("5 * -add(1;3) * - 88 / -(-add(1; 16; 23; -(7+12)) *3)", 27.937);
            yield return CreateTestModel("-(5* -(5 / (6-7)+3))", -10);
            yield return CreateTestModel("-(5* -(5 * -(5+16) - (6-7 * -(5+16 * -(3+6)))+3))", 4325);
            yield return CreateTestModel("(5* -(5 * (5+16) - (6-7 * (5+16 * -(3+6)))+3))", 4355);
            yield return CreateTestModel("(5* -(5 * (5+16) - (6-7 * (5+16 * (3+6)))+3))", -5725);
            yield return CreateTestModel("(5* (5 * (5+16) - (6-7 * (5+16 * (3+6)))+3))", 5725);

            yield return CreateTestModel("1.56 *56.89 +8.3", 97.048);
            yield return CreateTestModel("1,56 *56,89 +8,3", 97.048);

            yield return CreateTestModel("add + [add] * add(1; 4)", 18, ("add", 3));
            yield return CreateTestModel("add * -add(1; 4)", -15, ("add", 3));
            yield return CreateTestModel("-add", -3, ("add", 3));
            yield return CreateTestModel("add", 3, ("add", 3));
            yield return CreateTestModel("add + add(add(5; add))", 11, ("add", 3));
            yield return CreateTestModel("15+24 == var1 * 2", 0, ("var1", -3));
            yield return CreateTestModel("15+24 == var_1 * 3", 1, ("var_1", 13));
            yield return CreateTestModel("- (my_name_is / 15)", -3, ("my_name_is", 45));
            yield return CreateTestModel("[myVariable ♥]", 30, ("myVariable ♥", 30));

            yield return CreateTestModel("Pi*pI/[PI] + -pI", 0);
            yield return CreateTestModel("if([tau] > 6 == true; 5+6; -9)", 11);
            yield return CreateTestModel("if(tAu > 6 == false; 5+6; -9)", -9);
            yield return CreateTestModel("e + [E]", Math.Round(Math.E + Math.E, 3));
        }
    }
}
