��������� ����������� �����������.

��������� ��������� ���������� Use-Def ����.

����������:
var cfg = new CFG(treeCode);
var av = new AttainableVariables(cfg);
var att_vars = av.GenerateAttainableVariables();
Console.WriteLine(att_vars);

