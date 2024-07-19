namespace C_SHARP_PROJECT1;
 public class DAY4_PROGRAM25
 {
 static void Main1(string[] args){ // 메인 멤버 함수
    int readonlyArgument = 44;
    InArgExample(readonlyArgument); // 출력 함수
    
    void InArgExample(in int number) // in 키워드 적용
    {
        Console.WriteLine("in 인자값 출력 {0}: ", readonlyArgument);
        // number = 19; // 전달한 인자 값 수정 x
    }
 }
 }