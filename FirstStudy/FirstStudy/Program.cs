internal class Program
{
    private static void Main(string[] args)
    {


        #region 10번째 강의 메소드, For문
        string ten_name = tenth_str();
        Console.WriteLine(ten_name);
        //int ten_age = tenth_int();
        //Console.WriteLine(ten_age);
        //tenth_param("철수", 50);
        //string ten_param = tenth_param2("영희", 40);
        //Console.WriteLine(ten_param);
        tenth_array("철수", "영희", "홍길동", "마징가");
        string tenth_str()
        {
            return "홍길동";
        }
        int tenth_int()
        {
            Console.WriteLine("나이를 입력해주세요.");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        void tenth_param(string name, int age)
        {
            Console.WriteLine("이름은 " + name);
            Console.WriteLine("나이는 " + age);
        }
        string tenth_param2(string name, int age)
        {

            return "입력한 이름은" + name + "나이는 " + age + "입니다";
        }
        void tenth_array(params string[] names)
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);//0 1 2 3
            }
        }

        #endregion

        #region 1강 ~9강
        //First();
        //Second();
        //Third();
        //Forth();
        //Fifth();
        //Sixth();
        //Seventh();
        //Eighth();
        //Ninth();



        void Ninth()
        {
            double pie = 3.141592635;
            Console.WriteLine("정수만 표현: {0:F0}", pie);
            Console.WriteLine("소수점 한자리 표현: {0:F1}", pie);
            Console.WriteLine("소수점 두자리 표현: {0:F2}", pie);
            Console.WriteLine("소수점 세자리 표현: {0:F3}", pie);
            // \n 줄바꾸기
            // \r 캐리지리턴
            // \t tab키 눌렀을 경우와 동일
            // \' 화면에 싱글쿼터
            // \" 화면에 더블쿼터
            // \\ 백슬래쉬표시
            // @ @(골뱅이)다음의 문자를 문자열로 인식
            // + 문자열을 연결
            string str1 = "안녕하세요";
            string str2 = "C:\\Study";
            string str3 = @"C:\Study";

            Console.WriteLine(str1);
            Console.WriteLine("\"" + str1 + "\"");
            Console.WriteLine("경로는 " + str2 + "입니다");
            Console.WriteLine("경로는 " + str3 + "입니다");
        }


        void Eighth()
        {
            char a1 = 'a' ;
            char a2 = 'A';
            Console.WriteLine("a1의 값 :" + a1);
            Console.WriteLine("a1의 값 :" + a2);

            ushort change_a1, change_a2;
            change_a1 = a1; change_a2 = a2 ;
            Console.WriteLine("change_a1의 값 :" + change_a1);
            Console.WriteLine("change_a2의 값 :" + change_a2);

            byte ch_byte_a1, ch_byte_a2;
            ch_byte_a1 = (byte)a1;
            ch_byte_a2 = Convert.ToByte(a2);
            Console.WriteLine("ch_byte_a1의 값 :" + ch_byte_a1);
            Console.WriteLine("ch_byte_a2의 값 :" + ch_byte_a2);

        }

        void Seventh()
        {
            /*
                관계 연산자 <, >, ==, !-, <=, >=
                논리 연산자 &&, ||, !
             */
            int a = 3;
            if (a == 1)
            {
                Console.WriteLine("1과 같음");
            }
            else if (a >= 1)
            {
                Console.WriteLine("1보다 크거나 같음");
            }
            else if (a < 1)
            {
                Console.WriteLine("1보다 작음");
            }
            else
            {
                Console.WriteLine("해당없음");
            }
            int b, c;
            b = 100;
            c = 200;
            if (b==100 && c == 300)
            {
                Console.WriteLine("1");
            }
            else if (b==100 || c == 300)
            {
                Console.WriteLine("2");
            }
            else if(b > 100 || c == 300)
            {
                Console.WriteLine("3");
            }
            else if(b !=100 || c != 300)
            {
                Console.WriteLine("4");
            }
        }

        void Sixth()
        {
            /*
             연산자 종류
            증감 연산자   ++, --
            산술 연산자   +,-,*,/,%
             */
            int a = 1;
            int b = 2;
            int c;
            c = ++a;
            Console.WriteLine("선행연산자 a의 값 {0}, c의 값 {1}", a, c);
            a = 1;
            c = a++;
            Console.WriteLine("후행연산자 a의 값 {0}, c의 값 {1}", a, c);
            a = 1;
            c = --a;
            Console.WriteLine("선행연산자 a의 값 {0}, c의 값 {1}", a, c);
            c = a--;
            Console.WriteLine("후행연산자 a의 값 {0}, c의 값 {1}", a, c);

            Console.WriteLine("나머지값 {0}", 5%2);


        }

        void Fifth() 
        {
            //object aa = 11;
            ////aa = "a";
            //int a = Convert.ToInt32(aa);
            //object aaa = "a";
            //var bb = 22;
            ////bb = "b";
            //int b = bb;
            //var bbb = "b";
            //dynamic cc = 33;
            //cc = "c";
            //dynamic ccc = 33;

            int a = 10;
            int b = 5;
            int c = a + b;
            Console.WriteLine("a+b={0}", c);
            Console.WriteLine("a+b={0}", a+b);
            Console.WriteLine("a-b={0}", a-b);
            Console.WriteLine("a*b={0}", a*b);
            Console.WriteLine("a/b={0}", a/b);

            int d;
            d = 5 / 2;
            Console.WriteLine("d의 값은? {0}", d);

            double e;
            e = 5 / 2;
            Console.WriteLine("e의 값은? {0}", e);

            double f;
            f = 5.0 / 2;
            Console.WriteLine("f의 값은? {0}", f);

            float g;
            g = 5f / 2f;
            Console.WriteLine("g의 값은? {0}", g);
            Console.ReadLine();


        }


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
        #endregion
    }
}