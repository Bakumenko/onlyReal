AssignVisitor
�������� ��������� ���� a = a �� null.
����� �������� ��� ����������� ����� ��������� AST, � ��������� ��������� ���:
var r = parser.root;    // ������ AST
r.Visit(new FillParentVisitor());   // ��������� ������ �� ��������� �� AST
r.Visit(new AssignVisitor());	// ���������� ������� �����������