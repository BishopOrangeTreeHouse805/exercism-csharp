var tryout = new Lasagna();
tryout.RemainingMinutesInOven(45);

public class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    
    public int RemainingMinutesInOven(int minutesInOven)=> ExpectedMinutesInOven() - minutesInOven;
    
    public int PreparationTimeInMinutes(int numberOfLayers)=> numberOfLayers * 2;
    
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven)=> PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
    
}
