namespace C_SHARP_PROJECT;

public class DAY5_PROGRAM_Challenge
{


static int Rnumberck(String result)
{
    String result1 = result.Substring(0,6);
    String result2 = result.Substring(6,6);
    int resultint11 = Convert.ToInt32(result1);
    int resultint1 = int.Parse(result1);
    int resultint22 = Convert.ToInt32(result2);
    int resultint2 = int.Parse(result2);
    Console.WriteLine(resultint1);
    Console.WriteLine(resultint2);
    int Rck = 0;
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
        Rck = 1;
    }

    return Rck;
}

static void Main(String []args)
{
    String result = "";
    for(;;){
        Console.Write("주민등록번호를 입력하세요 : ");
        String Rnumber = Console.ReadLine();
        String ck = Rnumber.Substring(6,1);
        Console.WriteLine(Rnumber);

        if(Rnumber.Length == 14 || Rnumber.Length == 13){
            String[] result1 = Rnumber.Split('-',' ');
            foreach(var word in result1){
                result += word;
            }
            //-와 뛰어쓰기 체크
            if(String.Equals(ck,"-") || String.Equals(ck," ")){
                
                int Rck = Rnumberck(result); //주민번호 검증식

                String re = result.Substring(6,1);
                int re11 = Convert.ToInt32(re);
                int re1 = int.Parse(re);

                //성별 체크
                if(Rck == 1){

                    if(re1%2==1){
                        Console.WriteLine("정상 주민번호입니다. 남자");
                    }
                    if(re1%2==0){
                        Console.WriteLine("정상 주민번호입니다. 여자");
                    }

                }else{
                    Console.WriteLine("주민번호가 틀립니다.");
                }
                break;
            }
        }else{
            Console.WriteLine("입력이 틀였습니다.");
        }

        
    }
    
    





}
} 