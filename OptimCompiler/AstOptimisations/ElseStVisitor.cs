﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramTree;

namespace SimpleLang.Visitors
{
    public class ElseStVisitor : AutoApplyVisitorInterface
    {
        public override void VisitIfNode(IfNode ifn)
        {
            if (ifn.Cond is BooleanNode boolVal && !boolVal.Val)
            {
                ifn.Else.Visit(this);
                ReplaceStat(ifn, ifn.Else);
            }
        }
    }
}
