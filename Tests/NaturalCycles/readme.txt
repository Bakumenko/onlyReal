NaturalCycles
����������� ���� ������������ ������ � CFG � ����������� �� �� �����������

����������� ��� ������� �����, ����� ������������ ����� � �������� � List. �� ������� ��������� ���������� � ���, ����� ����� � ����� �������.

������:
var blocks = new Block(treeCode).GenerateBlocks();
CFG controlFlowGraph = new CFG(blocks);
var cycles = NaturalCycles.SearchNaturalCycles(controlFlowGraph);