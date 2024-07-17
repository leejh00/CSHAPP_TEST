namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM17_Exam1
{
static void Main1(String []args)
{
    Console.Write($"문자열을 2개 입력해주세요 : ");
    String message = Console.ReadLine();

    String[] arr1 = message.Split(' '); // ' 따옴표와 공백 기준 자르기

    foreach(var arr in arr1){ // 분리된 문자열 반복 중요!!! String 반복문은 foreach
        Console.WriteLine($"문자열 자르기 : {arr}");
    }




    //첫 번째
    if(String.Equals(arr1[0].Length, 4)){

        Console.WriteLine(arr1[0]+$"은 문자열의 길이 및 숫자 포함 검사 결과 {(int.TryParse(arr1[0], out int result1))}");

        

    } else if(String.Equals(arr1[0].Length, 6)){
        Console.WriteLine(arr1[0]+$"은 문자열의 길이 및 숫자 포함 검사 결과 {(int.TryParse(arr1[0], out int result2))}");
    }




    //두 번째
    if(String.Equals(arr1[1].Length, 4)){

        Console.WriteLine(arr1[1]+$"은 문자열의 길이 및 숫자 포함 검사 결과 {(int.TryParse(arr1[1], out int result1))}");

        

    } else if(String.Equals(arr1[1].Length, 6)){
        Console.WriteLine(arr1[1]+$"은 문자열의 길이 및 숫자 포함 검사 결과 {(int.TryParse(arr1[1], out int result2))}");
    }

    
    

    
}
}
