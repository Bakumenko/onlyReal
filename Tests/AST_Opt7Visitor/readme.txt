Opt7Visitor
���������� � AST-������ ���������� ���������, ��� �������� �������� �������� ������� �� ����� ���������� � �������� �� �� ���������� ����������� ���� ����������.


������:
var r = parser.root;    
r.Visit(new FillParentVisitor()); 
r.Visit(new Opt7Visitor());