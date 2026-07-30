class Lasagna
{
   public int ExpectedMinutesInOven() => 40;

   public int RemainingMinutesInOven(int time) => ExpectedMinutesInOven() - time;

   public int PreparationTimeInMinutes(int time) => 2 * time;

   public int ElapsedTimeInMinutes(int layers, int minutes) => PreparationTimeInMinutes(layers) + minutes;
}
