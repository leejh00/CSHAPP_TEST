namespace C_SHARP_PROJECT;
public class DAY7_PROGRAM14
{


partial class MyClass // partial 키워드로 분할, 선언과 정의 타입 일치 필요
{
public void Method1()
{
    Console.WriteLine("첫번쨰 분할 클래스의 메소드를 호출합니다.");
}
}


partial class MyClass // partial 키워드로 분할
{
public void Method2()
{
    Console.WriteLine("두번쨰 분할 클래스의 메소드를 호출합니다.");
}
}


class Program
{
static void Main1(string[] args)
{
    Console.WriteLine("분할 클래스 테스트");
    MyClass obj = new MyClass();
    obj.Method1();
    obj.Method2();
}
}
}