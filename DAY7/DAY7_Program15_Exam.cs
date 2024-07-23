namespace C_SHARP_PROJECT;
public class DAY7_PROGRAM15_Exam // 20쪽 11, 12쪽 중요 
{

static void Main(String []args)
{


Console.WriteLine("로그인 필요, 페스워드를 입력하세오 : ");
int login = int.Parse(Console.ReadLine()); // 로그인

String stname = "GUEST"; 
int stnum = 0;

int sum = 0;
std_get1 std = new std_get1(); // 객체 인스턴스 생성
DAY7_PROGRAM15_Exam.login1 login_pass = new DAY7_PROGRAM15_Exam.login1();

int[] arrnum = new int[3];
String[] arrname = new string[3];

for(int i = 0; i < 10;i++){
    
    if(login == login_pass.get_pass()){
        
            Console.WriteLine("메뉴 선택하세요 : 1. 학생 점수 입력, 2. 학생 점수 출력, 3. 프로그램 종료");
            int ott = int.Parse(Console.ReadLine()); // 메뉴 선택
            
            if(ott == 1){
                for(int j = 0; j < 3; j++){
                    Console.WriteLine(j+"번째 학생의 이름은? :");
                    stname = Console.ReadLine();
                    std.set(stname);
                    arrname[j] = stname;

                    Console.WriteLine(j+"번째 학생의 점수는? :");
                    stnum = int.Parse(Console.ReadLine());
                    std.set(stnum);
                    arrnum[j] = stnum;    

                }
            }
            if(ott == 2){
                for(int j = 0; j < 3; j++){
                    Console.WriteLine(j+"번째 학생의 이름 : {0}, 점수 : {1}", arrname[j], arrnum[j]);
                    sum += arrnum[j];
                }
                Console.WriteLine("학생 3명의 평균 점수는 {0}점", sum/3);
            }
            if(ott == 3){
                Console.WriteLine("프록그램을 종료합니다.");
                break;
            }
    }
    else{
        Console.Write("패스워드가 맞지 않습니다. 다시 입력해주세요.");
    }


}

}

//중첩 클래스
class login1{
    int admin_num = 123123;//set get 으로 불러오기 

    public int get_pass()
    { // public 으로 지정
        return admin_num;
    }
}
}


class std_get1{

private int stnum = 0; // private 으로 설정, 외부 차단!
private string stname = "GUEST"; // private 으로 설정, 외부 차단!


public std_get1(){
    stname = "guest";
    Console.WriteLine("생성자를 호출합니다.");
}


public int get_stnum(int j)
    { // public 으로 지정
    return stnum;
}
public String get_stname(int j)
    { // public 으로 지정
    return stname;
}
public void set(int set_stnum){ // public 으로 지정, 함수 오버로딩
    stnum = set_stnum;
}
public void set(String set_name){ // public 으로 지정
    stname = set_name;
}

}