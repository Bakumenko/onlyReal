Opt12Visitor
������ ��������� if �� ��� ����� else � ������, ���� ������� �����. 

������:
var r = parser.root;    
r.Visit(new FillParentVisitor()); 
r.Visit(new Opt12Visitor());	
