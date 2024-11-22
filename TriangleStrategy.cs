namespace lab6._4
{
    /*public class TriangleStrategy
    {
        public double a {  get; }
        public double b { get; }
        public double c { get; }
        private ITriangleArea area;//приватный, потому что будет потом метод, устанавливающий стратегию \\или приватный потому что нельзя установить нужную стратегию извне и мы должны ее внутри класса утанавливать?????
        public TriangleStrategy( double a, double b, double c, ITriangleArea area)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.area = area;
        }
        public void SetStrategy(ITriangleArea area )//хз зачем если конструктор делает по сути тоже самое
        {
            this.area = area;
        }
        public double AnFindArea(double a, double b, double c)//в классах с конкретной стратегией реализуется метод с таким же названием, но реализация разная везде. 
            //мы поидее вызываем сначала findarea c реализацией из этого класса
            //я назвала метод здесь по другому, поидее ошибок не выдает, тем бболее функционал у них разный
        {
            if (a <=0 || b <=0 || c <=0)
            {
                throw new ArgumentException("The sides of thetriangle must be positive.");
            }
            if ((a + b <= c) || (b + c <= a) || (a + c <= b)) 
            {
                throw new ArgumentException("The sides of triangle don't form a triangle");
            }
            if (area == null)//проверка не была ли передана никакая стратегия
            {
                if (a*a + b*b == c*c || a*a +c*c == b*b || b*b + c*c == a * a)
                {
                    ITriangleArea area = new Isosceles();
                    return area.FindArea(a, b, c);
                }
                else
                {
                    ITriangleArea area = new Other();
                    return area.FindArea(a, b, c);
                }
            }
            else
            {
                return area.FindArea(a, b, c);
            }
        }


    }*/

    public class TriangleSender
    {
        public double a;
        public double b;
        public double c;
        ITriangleArea area;
        public TriangleSender(ITriangleArea area)
        {
            this.area = area ?? throw new ArgumentNullException(nameof(area));
        }
        public void ProcessTriangle()
        {
            this.area.FindArea(a, b, c);
        }
    }
}
