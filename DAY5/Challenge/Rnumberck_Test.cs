namespace C_SHARP_PROJECT;
public class DAY5_PROGRAM_Challenge_Rnumberck_Test
{
static void Main1(String []args)
{
    String result = "7906082552416";
    String result1 = result.Substring(0,6);
    String result2 = result.Substring(6,6);
    // int Rck = 0;
    int resultint11 = Convert.ToInt32(result1);
    int resultint1 = int.Parse(result1);
    int resultint22 = Convert.ToInt32(result2);
    int resultint2 = int.Parse(result2);
    Console.WriteLine(resultint1);
    Console.WriteLine(resultint2);
    int i = 12;
    int a = 1;
    int sum = 0;
    int numck = 0; 
    int[] arr = new int[12];

    for(i = 5;i>=0;i--){
        
        arr[i] = resultint1 / a % 10;
        
        a *= 10;
    }
    a = 1;
    for(i = 5;i>=0;i--){
        
        arr[i+6] = resultint2 / a % 10;
        
        a *= 10;
    }

    //곱셈+ 덧셈
    int c = 2;
    for(i = 0;i<12;i++){
        
        if(c<10){
            sum += arr[i] * c;
            ++c;
        }else{
            c = 2;
            sum += arr[i] * c;
            ++c;
        }
    }
    

    numck = sum%11;
    if(numck == arr[11]){
        Console.WriteLine("1");
    }else{
        Console.WriteLine("0");
    }

}
}