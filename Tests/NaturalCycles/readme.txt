NaturalCycles
����������� ���� ������������ ������ � CFG � ����������� �� �� �����������

����������� ��� ������� �����, ����� ������������ ����� � �������� � List. �� ������� ��������� ���������� � ���, ����� ����� � ����� �������.

������:
var blocks = new Block(treeCode).GenerateBlocks();
CFG controlFlowGraph = new CFG(blocks);
int cycles = NaturalCycles.SearchNaturalCycles(controlFlowGraph);