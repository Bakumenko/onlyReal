Opt11Visitor
11 �������� �������� if �� ��� ������ ����� (st1) � ������, ���� ������� �������.
if (true) st1; else st2; st1

����� �������� ��� ����������� ����� ��������� AST � ��������� ��������� ���:
var r = parser.root;    // ������ AST
r.Visit(new FillParentVisitor());   // ��������� ������ �� ��������� �� AST
r.Visit(new Opt11Visitor());	// ���������� ������ �����������
