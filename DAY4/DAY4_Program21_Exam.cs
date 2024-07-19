namespace C_SHARP_PROJECT1;
public class DAY4_PROGRAM21_Exam
{

static void program_start()
{
    Console.WriteLine("사칙 연산에 필요한 수이 개수는?");
    int total = int.Parse(Console.ReadLine());
    int[] arr = new int[total];
    int i, j;
    int total2 = 0;


    for(i = 0; i < total; i++){
        Console.WriteLine(i+"번째 데이터를 입력합니다 : ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    
    while(true){
        Console.WriteLine("계산기 메뉴 : 1. 더하기, 2. 곱하기, 3. 종료:");
        total2 = int.Parse(Console.ReadLine());
        if(total2 == 1){
            add(ref arr, total);
        }
        if(total2 == 2){
            mul(ref arr, total);
        }
        if(total2 == 3){
            Console.WriteLine("프로그램을 종료합니다.");
            break;
        }

    }
 }

 static void add(ref int[] arr, int total)
{
    int sum = 0;
    for(int i = 0; i < total; i++){
        sum +=arr[i];
    }
    Console.WriteLine("더하기 결과는 : "+sum);
 }

 static void mul(ref int[] arr, int total)
{
    int avg = 0;
    for(int i = 0; i < total; i++){
        avg *=arr[i];
    }
    Console.WriteLine("곱하기 결과는 : "+avg);
 }

static void Main1(string[] args) // 메인 멤버 함수
{

    program_start();

}

}