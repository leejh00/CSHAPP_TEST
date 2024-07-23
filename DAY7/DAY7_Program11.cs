namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM11
{
private int count = 0;
DAY3_PROGRAM11(int count){ // 인자는 count
    this.count = count; // 현재 this.count
    Console.WriteLine("생성자 호출 후 값 :{0}", count);
}
static void Main1(String []args)
{
    Console.WriteLine("this 키워드 - 클래스의 멤버변수, 함수의 매개변수를 구분 : ");
    DAY3_PROGRAM11 main = new DAY3_PROGRAM11(777);
    main.set_count(666);
    Console.WriteLine("카운트 변경 후 값 :{0}", main.count);
}
public void set_count(int count){ // 인자는 count
    this.count = count; // 현재 this.count
}
}