namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM17_Exam2
{
static void Main1(String []args)
{
    String[] name_array = new String[] {"아저씨", "김새나", "엄마", "아빠", "누나", "형", "동생", "김말아유", "홍길동", "개구리"};

    int tf = 0; 


    for(int j = 0;j<100;j++){
    Console.Write($"이름을 입력합니다 : ");
    String name_input = Console.ReadLine();
    int check = 0;    
    

    for(int i = 0; i<10;i++){
        
        

        if(String.Equals(name_array[i],name_input)){
            tf = 1; 
            check = i;
            break;
        }    

    }


    if(tf == 1){
        Console.WriteLine(name_input+$"의 위치는 "+check+"번에 숨어있습니다."); 
    }else{
        Console.WriteLine(name_input+$"은 존재하지 않습니다."); 
    }


    }

}
}
