������:
var blocks = new Block(treeCode).GenerateBlocks(); //���������� ������� �����
CFG controlFlowGraph = new CFG(blocks); //������ CFG (using CFG = SimpleLang.ControlFlowGraph.ControlFlowGraph;)
var DefUse = new DefUseBlocks(controlFlowGraph); //� ���� ������ ��� ���� - DefBs � UseBs = new List<HashSet<string>>();
var InOut = new InOutActiveVariables(DefUse, controlFlowGraph);