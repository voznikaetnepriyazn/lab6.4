using lab6._4;
// class Main
{
    ITriangleArea area = new Isosceles();
    ITriangleArea trarea = new Other();
    var sender = new TriangleSender(area);
    sender.ProcessTriangle();
}