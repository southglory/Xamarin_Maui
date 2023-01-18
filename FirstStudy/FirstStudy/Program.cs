using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace FirstStudy
{
    class Program
    {
        static Thread thread1;
        static Thread thread2;
        static string name = "BBB";
     
        enum Enemy { Attack,Dead,Sleep,Run};

        delegate string ConcatMsg(string str, int num);
        delegate void DelegateMethod();
        delegate void DelegateMethod2(string str);
        delegate int DelegateMultiply(int x, int y);
        delegate int Calc(int x, int y);
        delegate void DelegateLambda();
        static public void handlerTest(string testMsg)
        {
            Console.WriteLine(testMsg);
        }
        struct person
        {
            public string name;
            public int age;
            public int empId;
            public person(string name, int age, int empId)
            {
                this.name = name;
                this.age = age;
                this.empId = empId;
            }
        }
            
        static void Main(string[] args)
        {
            thirtiethforth();
            #region 34번째 강의 스레드 Thread
            void thirtiethforth()
            {
                thread1 = new Thread(test1);
                thread1.Start();
                thread2 = new Thread(test2);
                thread2.Start();
            }
            void test1()
            {
                int i = 0;
                while (true)
                {
                    if (i > 10) thread1.Abort();
                    Console.WriteLine("첫번째 쓰레드 {0}",i );
                    Thread.Sleep(1000);
                    i++;
                }
            }
            void test2()
            {
                while (true)
                {
                    Console.WriteLine("두번째 쓰레드");
                    Thread.Sleep(500);
                }
            }

            #endregion
            //thirtieththird();
            #region 33번째 강의 Func 대리자 Action 대리자
            void thirtieththird()
            {
                Func<int,int,int> _func1 = (int x, int y) => x + y;
                Console.WriteLine(_func1(3,6));
                Func<int> _func2 = () => 50;
                Console.WriteLine(_func2());
                Func<int, string> _func3 = (int x) => x + "입니다.";
                Console.WriteLine(_func3(5));

                Action<int, int> action = (x, y) =>
                 {
                     Console.WriteLine("액션대리자 값 : " + x * y);
                 };
                action(3, 7);



            }
            #endregion
            //thirtiethsecond();
            #region 32번째 강의 링큐 Linq
            void thirtiethsecond()
            {
                Ch_32[] ch =
                {
                    new Ch_32(){ name = "핑크퐁" ,age = 5 , addrerss = "뉴욕"},
                    new Ch_32(){ name = "뽀로로" ,age = 15 , addrerss = "시카고"},
                    new Ch_32(){ name = "태권브이" ,age = 50 , addrerss = "한국"},
                    new Ch_32(){ name = "타요" ,age = 50 , addrerss = "베를린"},

                };

                foreach(var a in ch)
                {
                    if(a.age >= 10) Console.WriteLine("이름: {0}, 나이: {1}, 주소: {2}", a.name, a.age, a.addrerss);

                }
                Console.WriteLine("Linq 사용");
                var linq = from ddd in ch where ddd.age >= 10 select ddd;
                foreach (var a in linq) Console.WriteLine("이름: {0}, 나이: {1}, 주소: {2}", a.name, a.age, a.addrerss);



            }
            #endregion

            //thirtiethfirst();
            #region 31번째 강의 람다식 Lambda
            void thirtiethfirst()
            {
                //delegate int Calc(int x, int y);
                Calc cal = (int x, int y) => x + y;
                Console.WriteLine("람다식 방식: " + cal(5,10));
                Calc cal2;
                cal2 = delegate (int a, int b)
                {
                    return a + b;
                };
                Console.WriteLine("익명메소드 방식: " + cal2(5, 10));
                DelegateLambda dl = () =>
                {
                    Console.WriteLine("문형식 람다입니다");
                };
                dl();
                
            }
            #endregion
            //thirtieth();
            #region 30번째 강의 콜렉션 Collection 딕셔너리 Dictionary
            void thirtieth()
            {
                ArrayList aL = new ArrayList();
                aL.Add("첫번째");
                aL.Add("두번째");
                aL.Add(1);
                aL.Add(2);
                Console.WriteLine("총 갯수 : " + aL.Count);
                aL.Remove("두번째");
                Console.WriteLine("총 갯수2 : " + aL.Count);

                foreach (var a in aL) Console.WriteLine(a);

                Console.WriteLine("--------스택---------");
                Stack stack = new Stack();
                stack.Push("1스택");
                stack.Push("2스택");
                stack.Push(1);
                stack.Push(2);
                Console.WriteLine(stack.Count);
                foreach (var a in stack) Console.WriteLine(a);

                Console.WriteLine("--------큐---------");

                int[] array = { 10, 20, 30, 40, 50, 60, 70 };
                Queue q = new Queue(array);
                foreach (var a in q) Console.WriteLine(a);
                // 이름 : 핑크퐁 , 주소 : 뉴욕
                Console.WriteLine("--------해쉬테이블---------");
                Hashtable ht = new Hashtable();
                ht.Add("이름", "핑크퐁");
                ht.Add("주소", "뉴욕");
                ht.Add("나이", 10);
                ht.Add("고향", "한국");
                Console.WriteLine(ht["주소"]);
                foreach (var a in ht.Keys) Console.WriteLine("키값 : " + a);
                foreach (var a in ht.Values) Console.WriteLine("벨류 : " + a);
                foreach (var a in ht.Keys) Console.WriteLine("키값: {0}  벨류: {1}",a,ht[a]);
                Console.WriteLine("--------딕셔너리---------");
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("이름", "타요");
                dict.Add("주소", "시카고");
                dict.Add("나이", "5");
                dict.Add("고향", "한국");
                foreach (var a in dict.Keys) Console.WriteLine("키값 : " + a);
                foreach (var a in dict.Values) Console.WriteLine("벨류 : " + a);
                foreach (var a in dict.Keys) Console.WriteLine("키값: {0}  벨류: {1}", a, dict[a]);
                Console.WriteLine("--------솔티드 리스트---------");
                SortedList sL = new SortedList();
                sL.Add("이름", "뽀로로");
                sL.Add("주소", "런던");
                sL.Add("나이", 7);
                sL.Add("고향", "한국");
                foreach (var a in sL.Keys) Console.WriteLine("키값 : " + a);
                foreach (var a in sL.Values) Console.WriteLine("벨류 : " + a);
                foreach (var a in sL.Keys) Console.WriteLine("키값: {0}  벨류: {1}", a, sL[a]);
                for (int i=0; i < sL.Count; i++)
                {
                    Console.WriteLine("인덱스 {0} 값 {1}" ,i,sL.GetByIndex(i));
                }






            }
            #endregion
            //twentyninth();
            #region 29번째 강의 문자열 다루기
            void twentyninth()
            {
                string str = "ABCDEFGH,IJKLMN,AOPQR";
                Console.WriteLine("특정문자위치 : " + str.IndexOf('C'));
                Console.WriteLine("A의 마지막 위치 : " + str.LastIndexOf('A'));
                Console.WriteLine("6번째 추출 : " + str.Substring(5));
                Console.WriteLine("1번째 ~ 4번째 추출 : " + str.Substring(1,4));

                string[] splitStr = str.Split(',');
                foreach(string a in splitStr) Console.WriteLine("특정문자 기준 : " + a);
                string str2 = " Republic of Korea ";
                Console.WriteLine("국가:" + str2.Trim() + "입니다.");
                Console.WriteLine("국가:" + str2.Replace("Korea","대한민국") + "입니다.");



            }
            #endregion
            //twentyeighth();
            #region 28번째 강의 이벤트 event
            void twentyeighth()
            {
                Ch_28 ch = new Ch_28();
                ch.EV += new EventHandler(handlerTest);
                ch.eventTest("28번째 강의");
                
            }
            #endregion
            //twentyseventh();
            #region 27번째 강의 대리자 delegate
            void twentyseventh()
            {
                string name = "핑크퐁";
                int age = 10;
                ConcatMsg concat = new ConcatMsg(msg);
                Console.WriteLine(concat(name,age));
                Console.WriteLine("delegate 멀티 캐스팅");
                DelegateMethod dm = msg1;
                dm += msg2;
                dm += msg3;
                dm();
                Console.WriteLine("메소드 삭제");
                dm -= msg2;
                dm();
                Console.WriteLine("콜백");
                DelegateMethod2 result = msg_Callback;
                sumMethod(10, 5, result);
                Console.WriteLine("익명메소드");
                DelegateMultiply dmMulti;
                dmMulti = delegate (int a, int b)
                {
                    return a * b;
                };
                Console.WriteLine("익명메소드 결과 : {0}", dmMulti(5,10));

            }
            string msg(string str, int num)
            {
                return "이름: " + str + "나이: " + num;
            }
            void msg1()
            {
                Console.WriteLine("1");
            }
            void msg2()
            {
                Console.WriteLine("2");
            }
            void msg3()
            {
                Console.WriteLine("3");
            }
            void msg_Callback(string _msg)
            {
                Console.WriteLine(_msg);
            }
            void sumMethod(int x, int y, DelegateMethod2 dm2)
            {
                int sum = x + y;
                dm2("합계: " + sum);
            }
            #endregion
            //twentysixth();
            #region 26번째 강의 interface 인터페이스, 네임스페이스
            void twentysixth()
            {
                FirstStudy2.Ch_26 ch = new FirstStudy2.Ch_26();
                ch.InterFaceVoid();
                ch.InterFaceStr();
                ch.InterFaceInt(10);
                ch.InterFaceVoid();
                ch.msg(ch.InterFaceStr(),ch.InterFaceInt(15));
            }
            #endregion
            //twentyfifth();
            #region 25번째 강의 static 정적클래스
            void twentyfifth()
            {
                Ch_25.name = "정적클래스";
                Ch_25.message();
            }
            #endregion
            //twentyforth();
            #region 24번째 강의 abstract 추상클래스
            void twentyforth()
            {
                Ch_24_child ch = new Ch_24_child();
                ch.parentMessage();
                ch.message();
                Ch_24_child ch2 = new Ch_24_child();
                ch2.message();
                ch2.message("홍길동");
            }
            #endregion
            //twentythird();
            #region 23번째 강의 partial 분활
            void twentythird()
            {
                Ch_23 ch = new Ch_23();
                ch.message("첫번째");
                ch.message2();

                Ch_23_1 ch_1 = new Ch_23_1();
                ch_1.message("분활");
                ch_1.message2();

            }
            #endregion

            //twentysecond();
            #region 22번째 강의 오버라이딩
            void twentysecond()
            {
                Ch_22_1 ch_1 = new Ch_22_1();
                ch_1.message();
                Ch_22_2 ch_2 = new Ch_22_2();
                ch_2.message();

                Ch_22_1 ch_over = (Ch_22_1)ch_2;
                ch_over.message();
            }
            #endregion


            //twentyfirst();
            #region 21번째 강의 상속, protected
            void twentyfirst()
            {
                Ch_21_2 ch = new Ch_21_2();
                ch.methd();
                Ch_21_1 ch_21_1 = new Ch_21_1();
                
            }
            #endregion
            //twentieth();
            #region 20번째 강의 클래스 생성자, 오버로딩
            void twentieth()
            {
                Ch_20 ch_20 = new Ch_20();
                Console.WriteLine(ch_20.name);
                Console.WriteLine(ch_20.age);
                Ch_20 ch = new Ch_20("뽀로로",10);
                Console.WriteLine(ch.name);
                Console.WriteLine(ch.age);

            }
            #endregion

            //nineteenth();
            #region 19번째 강의 속성 정의
            void nineteenth()
            {
                Ch_19 ch = new Ch_19();
                ch.Name = "뽀로로";
                ch.Age1 = 5;
                ch.Age2 = 3;

                Console.WriteLine("이름: {0} 나이1:{1} 나이2: {2}  ",ch.Name,ch.Age1,ch.Age2);
            }
            #endregion
            //eighteenth();
            #region 18번째 강의 클래스 정적메소드, 메소드, 참조형, out
            void eighteenth()
            {
                Ch_18 ch_18 = new Ch_18();
                ch_18.time1();
                Ch_18.time2();

                Ch_17 ch_17 = new Ch_17();
                Ch_18.time3(ref ch_17);

                Ch_17 ch_17_out = null;
                Ch_18.time4(out ch_17_out);
                Console.WriteLine(ch_17_out.name + "나이 : " + ch_17_out.age);


            }
            #endregion
            //seventeenth();
            #region 17번째 강의 클래스 정적필드 static, 상수 const
            void seventeenth()
            {
                Ch_17 staff1 = new Ch_17();
                Ch_17 staff2 = new Ch_17();
                staff1.name = "핑크퐁";
                staff1.age = 10;
                
                staff2.name = "폴리";
                staff2.age = 9;
                
                Ch_17.address = "뉴욕";
           
                Console.WriteLine("staff1 이름: " 
                    + staff1.name + " 나이: " + staff1.age + " 주소: "+Ch_17.address + " 고향:" + Ch_17.homeTown);
                Console.WriteLine("staff2 이름: "
                    + staff2.name + " 나이: " + staff2.age + " 주소: " + Ch_17.address + " 고향:" + Ch_17.homeTown);


            }
            #endregion

            // sixteenth();
            #region 16번째 강의 클래스 class
            void sixteenth()
            {
                Ch_16 staff1 = new Ch_16();
                staff1.name = "핑크퐁";
                staff1.age = 10;
                Console.WriteLine(staff1.name);
                Ch_16 staff2 = new Ch_16();
                staff2.name = "폴리";
                staff2.age = 9;
                Console.WriteLine(staff2.name);
            }
            #endregion

            //fifteenth();
            #region 15번째 강의 foreach문
            void fifteenth()
            {
                string[] str = { "사과", "배", "오렌지", "포도", "딸기" };
                foreach(string a in str)
                {
                    Console.WriteLine("과일종류: " + a);
                }
            }
            #endregion
            //fourteenth();
            #region 14번째 강의 While문 do While문

            void fourteenth()
            {
                int i = 0;
                //while (true)
                //{
                //    Console.WriteLine(i++);
                //}
                while(i < 10)
                {
                    Console.WriteLine(i);
                    i++; 
                }
                Console.WriteLine("반복문종료: " + i);
                do
                {
                    Console.WriteLine("do:" + i);
                    i += 1;
                } while (i > 10 && i < 20);
            }
            
            #endregion


            //thirteenth();
            #region 13번째 강의 스위치문 switch
            void thirteenth()
            {
                //int number;
                //number = Convert.ToInt32(Console.ReadLine());
                //switch (number)
                //{
                //    case 1: Console.WriteLine("1번이 입력되었습니다."); break; 
                //    case 2: Console.WriteLine("2번이 입력되었습니다."); break; 
                //    case 3: Console.WriteLine("3번이 입력되었습니다."); break;
                //    default: Console.WriteLine("알수없습니다."); break;
                //}

                Enemy enemy = new Enemy();
                enemy = Enemy.Dead;
                switch (enemy)
                {
                    case Enemy.Run: Console.WriteLine("적이 도망갔습니다.");break;
                    case Enemy.Attack: Console.WriteLine("적이 공격합니다.");break;
                    case Enemy.Dead: Console.WriteLine("적이 죽었습니다.");break;
                    default: Console.WriteLine("적이 잠들었습니다.");break;

                }
            }
            
            #endregion

            //twelfth();
            #region 12번째 강의 구조체 struct
            void twelfth()
            {
                person _person = new person("철수",25,20210401);
                Console.WriteLine("이름:{0}   나이:{1}  사번:{2}",_person.name,_person.age,_person.empId);
            }
            #endregion

            //eleventh("CCC");
            #region 11번째 강의 전역변수 지역변수 열거형Enum

            void eleventh(string name)
            {
                //string name = "AAA";
                Console.WriteLine(name);
                Enemy _status;
                _status = Enemy.Sleep;
                Console.WriteLine(_status);
                _status = (Enemy)Enum.Parse(typeof(Enemy), "Run");
                Console.WriteLine("변경된 상태는:" + _status);
                _status = Enemy.Attack;
                Console.WriteLine("두번째 변경된 상태는:" + _status);

            }


            #endregion

            #region 10번째 강의 메소드 , For문
            //string ten_name = tenth_str();
            //Console.WriteLine(ten_name);
            ////int ten_age = tenth_int();
            ////Console.WriteLine(ten_age);
            ////tenth_param("철수",50);
            ////string ten_param = tenth_param2("영희",40);
            ////Console.WriteLine(ten_param);
            //tenth_araay("청수", "영희", "홍길동", "마징가");
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
            void tenth_param(string name,int age)
            {
                Console.WriteLine("이름은 " + name);
                Console.WriteLine("나이는 " + age);
            }
            string tenth_param2(string name, int age)
            {


                return "입력한 이름은" + name + "나이는 " + age + "입니다";
            }
            void tenth_araay(params string[] names)
            {
                for(int i =0;i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);//0 1 2 3
                    //names[0]
                    //names[1]
                    //names[2]
                    //names[3]
                }
            }

            #endregion

            #region 1강~9강
            //First();
            //Second();
            //Third();
            //Forth();
            //Fifth();
            //sixth();
            //seventh();
            //eighth();
            //ninth();
            void ninth()
            {
                double pie = 3.141592635;
                Console.WriteLine("정수만 표현: {0:F0}",pie);
                Console.WriteLine("소수점 한자리 표현: {0:F1}",pie);
                Console.WriteLine("소수점 두자리 표현: {0:F2}",pie);
                Console.WriteLine("소수점 세자리 표현: {0:F3}",pie);
                //   \n  줄바꾸기
                //   \r  캐리지리턴
                //   \t  tab 키 눌렀을 경우와 동일
                //   \'  화면에 싱글쿼터
                //   \"  화면에 더블쿼터
                //   \\  백슬래쉬표시
                //   @   @(골뱅이)다음의 문자를 문자열로 인식
                //   +   문자열을 연결
                string str1 = "안녕하세요";
                string str2 = "C:\\Study";
                string str3 = @"C:\Study";

                Console.WriteLine(str1);
                Console.WriteLine("\"" + str1 + "\"");
                Console.WriteLine("경로는 " + str2 + "입니다");
                Console.WriteLine("경로는 " + str3 + "입니다");
            }
            void eighth()
            {
                /*
                 타입         자동변환되는 유형
                byte        short,ushort,int,uint,long,ulong,float,double,decimal
                sbyte       short,int,long,float,double,decimal
                short       int,long,float,double,decimal
                ushort      int,uint,long,ulong,float,double,decimal
                int         long,float,double,decimal
                uint        long,ulong,float,double,decimal
                long        float,double,decimal
                ulong       float,double,decimal
                float       double
                char        ushort,int,uint,long,ulong,float,double,decimal
                var         암시적 변환 타입                
                */
                char a1 = 'a';
                char a2 = 'A';
                Console.WriteLine("a1의 값:" + a1);
                Console.WriteLine("a2의 값:" + a2);

                ushort change_a1, change_a2;
                change_a1 = a1;
                change_a2 = a2;
                Console.WriteLine("change_a1의 값:" + change_a1);
                Console.WriteLine("change_a2의 값:" + change_a2);

                byte ch_byte_a1, ch_byte_a2;
                ch_byte_a1 = (byte)a1;
                ch_byte_a2 = Convert.ToByte(a2);
                Console.WriteLine("ch_byte_a1의 값:" + ch_byte_a1);
                Console.WriteLine("ch_byte_a2의 값:" + ch_byte_a2);
                

            }
            void seventh()
            {
                /*
                   관계 연산자         <,>,==,!=,<=,>=
                   논리 연산자         &&,||,!
                   */
                int a = 3;
                if (a == 1)
                {
                    Console.WriteLine("1과 같음");
                }
                else if(a >= 1)
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
                if(b ==100 && c == 300)
                {
                    Console.WriteLine("1");
                }
                if (b == 100 || c == 300)
                {
                    Console.WriteLine("2");
                }
                if(b >100 || c == 300)
                {
                    Console.WriteLine("3");
                }
                if( b != 100 || c != 300)
                {
                    Console.WriteLine("4");
                }

            }
            void sixth()
            {
                /*
                  연산자 종류
                  증감연산자           ++,--       
                  산술 연산자          +,-,*,/,%
               */
                int a = 1;
                int b = 2;
                int c;
                c = ++a;
                Console.WriteLine("선행연산자 a의값 {0}  c의값{1}",a,c);
                a = 1;
                c = a++;
                Console.WriteLine("후행연산자 a의값 {0}  c의값{1}", a, c);
                a = 1;
                c = --a;
                Console.WriteLine("선행연산자 a의값 {0}  c의값{1}", a, c);
                c = a--;
                Console.WriteLine("후행연산자 a의값 {0}  c의값{1}", a, c);

                Console.WriteLine("나머지값 {0}", 5%2);

            }
            void Fifth()
            {
                //object aa = 11;
                ////aa = "a";
                //int a = Convert.ToInt32(aa);                
                //object aaa = "a";
                //Console.WriteLine("a값은: {0}",a);
                //var bb = 22;
                ////bb = "b";
                //int b = bb;
                //var bbb = "b";
                //Console.WriteLine("b값은: {0}", b);
                //dynamic cc = 33;
                //cc = "한글";
                //int c = cc;       

                //Console.WriteLine("c값은: {0}", c);
                //Console.ReadLine();
                int a = 10;
                int b = 5;
                int c = a + b;
                Console.WriteLine("a+b={0}", c);
                Console.WriteLine("a+b={0}", a + b);

                Console.WriteLine("a-b={0}", a - b);
                Console.WriteLine("a*b={0}", a * b);
                Console.WriteLine("a/b={0}", a / b);
                Console.ReadLine();

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
                g = 5.5f;
                //g = 5f / 2f;
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
                // str = "aaa";



            }
            void Third()
            {
                //            타입                    범위
                //            bool                    true,false
                //            char                    2바이트 길이의 유니코드 문자 1개
                //            sbyte                   정수 -128~127 사이의 값.
                //            byte                    정수 0~255 사이값
                //            short                   정수 -32768 ~32767 사이값
                //            ushort                  정수 0~65535 사이값
                //            int                     정수 -2147483648~2147483647 사이값
                //            unit                    정수 0~4294967295 사이값
                //            long                    정수 -9223372036854775808~9223372036854775808 사이값
                //            ulong                   정수 0~18446744073709551615 사이값
                //            float                   1.5 X(10의 - 45승) - 3.4 X(-10의 38승)
                //            double                  5 X(10의 - 324승) - 1.7 X(-10의 308승)
                //            decimal                 ±1.0 X(10의 28승) - ±7.9 X(-10의 28승)
                //            string                  문자열
                //            DateTime                날짜와 시간
                //            object                  모든 타입의 유형을 포함.
                //            var                     암시적 타입 지역변수
                //            dynamic                 암시적 타입이지만, 유연성이 좋음
                // ALU-정수   FPU-부동소수점
                Console.WriteLine("Int의 저장공간 크기 {0}", sizeof(int));
                Console.WriteLine("char의 저장공간 크기 {0}", sizeof(char));
                Console.WriteLine("long의 저장공간 크기 {0}", sizeof(long));
                Console.ReadLine();


            }

            void Second()
            {
                Console.WriteLine("안녕하세요. {0} 님.", Console.ReadLine());

                Console.WriteLine("안녕하세요. {0} 님 {1}.", Console.ReadLine(), "어서오세요.");
                //0,1,2,3


                Console.ReadLine();
            }

            void First()
            {
                Console.WriteLine("안녕하세요.");
                Console.WriteLine("C#에 오신것을 환영합니다.");
                Console.Write("Hello");
                Console.Write("World");
                Console.ReadLine();
            }
            #endregion
        }

    }
}
