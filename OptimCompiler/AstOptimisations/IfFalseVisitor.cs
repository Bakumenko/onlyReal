﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramTree;

namespace SimpleLang.Visitors
{
    public class IfFalseVisitor : AutoApplyVisitorInterface
    {
        public override void VisitIfNode(IfNode ifn)
        {
            if (ifn.Cond is BooleanNode boolVal && !boolVal.Val)
            {
                ReplaceStat(ifn, ifn.Else);
            }
        }
    }
}
