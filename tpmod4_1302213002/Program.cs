public class KodePos
{
    public string getKodePos_1302213002(string kelurahan)
    {
        switch (kelurahan)
        {
            case "Batununggal":
                return "40266";
            case "Kujangsari":
            case "Cijaura":
                return "40287";
            case "Mengger":
                return "40267";
            case "Wates":
                return "40256";
            case "Jatisari":
            case "Margasari":
            case "Sekejati":
                return "40286";
            case "Kebonwaru":
                return "40272";
            case "Maleer":
                return "40274";
            case "Samoja":
                return "40273";
            default:
                return "Kode pos tidak ditemukan";
        }
    }
}
class DoorMachine_1302213002
{
    private State currentState;

    public DoorMachine_1302213002()
    {
        currentState = new LockedState();
    }

    public void SetState(State state)
    {
        currentState = state;
        currentState.DisplayState_1302213002();
    }
}

interface State
{
    void DisplayState_1302213002();
}

class LockedState : State
{
    public void DisplayState_1302213002()
    {
        Console.WriteLine("Pintu dikunci");
    }
}

class UnlockedState : State
{
    public void DisplayState_1302213002()
    {
        Console.WriteLine("Pintu tidak dikunci");
    }
}

public class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();


        Console.WriteLine($" Batununggal dengan kode pos {kodePos.getKodePos_1302213002("Batununggal")}");
        Console.WriteLine($" Kujangsari dengan kode pos {kodePos.getKodePos_1302213002("Kujangsari")}");
        Console.WriteLine($" Mengger dengaan kode pos {kodePos.getKodePos_1302213002("Mengger")}");
        Console.WriteLine($" Wates dengaan kode pos{kodePos.getKodePos_1302213002("Wates")}");
        Console.WriteLine($" Cijaura dengaan kode pos{kodePos.getKodePos_1302213002("Cijaura")}");
        Console.WriteLine($" Jatisari dengaan kode pos {kodePos.getKodePos_1302213002("Jatisari")}");
        Console.WriteLine($" Margasari dengaan kode pos {kodePos.getKodePos_1302213002("Margasari")}");
        Console.WriteLine($" Sekejati dengaan kode pos{kodePos.getKodePos_1302213002("Sekejati")}");
        Console.WriteLine($" Kebonwaru dengaan kode pos{kodePos.getKodePos_1302213002("Kebonwaru")}");
        Console.WriteLine($" Maleer dengaan kode pos{kodePos.getKodePos_1302213002("Maleer")}");
        Console.WriteLine($" Samoja dengaan kode pos{kodePos.getKodePos_1302213002("Samoja")}");

        DoorMachine_1302213002 DoorMachine_1302213002 = new DoorMachine_1302213002();
        DoorMachine_1302213002.SetState(new UnlockedState());
        DoorMachine_1302213002.SetState(new LockedState());

    }
}