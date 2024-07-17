namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM12
{
static void Main1(String []args)
{
    int[] bread = new int[] { 4, 6, 11, 55, 34, 9, 12,2,1,32 };
    int count = 0;

    Array.Sort(bread);

    //확인용 
    // for(int i=0; i < bread.Length; i++){
    //     Console.WriteLine("배열 값 출력 : {0}", bread[i]);
    // }

    // 최소 최대 빵 값을 제거한 남은 빵의 합
    for(int i=1; i < bread.Length-1; i++){
        count += bread[i];
    }
    Console.WriteLine("최소 빵의 개수 : {0}", bread[0]);
    Console.WriteLine("최대 빵의 개수 : {0}", bread[bread.Length-1]);
    Console.WriteLine("남은 빵의 전체 개수 : {0}", count);


    

    
    
}
}