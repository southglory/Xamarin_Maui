internal class Program
{
    private static void Main(string[] args)
    {
        //First();
        //Second();
        //Third();
        Forth();

        void Forth()
        {
            string name = "홍길동";
            name = "1";
            name = "0.5";
            char letter = 'A';
            int price = 100;
            double b = 0.05;
            decimal sale = 1;
            decimal sale2 = Convert.ToDecimal(0.25);
            decimal sale_price;
            sale_price = price - (price * sale2);
            Console.WriteLine("할인된 가격은 {0}", sale_price);
            Console.ReadLine();
            const string str = "홍길동";
            //str = "aaa";
        }


        void Third()
        {
            Console.WriteLine("int의 저장공간의 크기 {0}", sizeof(int));
            Console.WriteLine("char의 저장공간의 크기 {0}", sizeof(char));
            Console.WriteLine("long의 저장공간의 크기 {0}", sizeof(long));
            Console.ReadLine();
        }

        void Second()
        {
            Console.WriteLine("안녕하세요. {0} 님.", Console.ReadLine() );

            Console.WriteLine("안녕하세요. {0} 님. {1}", Console.ReadLine(), "어서오세요." );

            Console.ReadLine();

        }

        void First()
        {
            Console.WriteLine("안녕하세요.");
            Console.WriteLine("C#에 오신 것을 환영합니다.");
            Console.Write("Hello");
            Console.Write("World");
            Console.Write("World");
            Console.ReadLine();
        }

    }
}