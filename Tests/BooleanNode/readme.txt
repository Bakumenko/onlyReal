BooleanNode

5 ���������� ��������� < > and or true false

�� �������� ������������, ���������� ���������� �����:

ThreeAddressCodeVisitor treeCod2e = new ThreeAddressCodeVisitor();
r.Visit(treeCod2e);
AutoThreeCodeOptimiser ap2p = new AutoThreeCodeOptimiser();
ap2p.Add(new SimpleLang.ThreeCodeOptimisations.DistributionOfConstants());
ap2p.Add(new SimpleLang.ThreeCodeOptimisations.EvalConstExpr());
ap2p.Add(new SimpleLang.ThreeCodeOptimisations.DeadOrAliveOptimizationAdapter());
var blockwss = ap2p.Apply(treeCod2e);

Console.WriteLine(ThreeAddressCodeVisitor.ToString(blockwss));
