class Lasagna
{
   public int ExpectedMinutesInOven() => 40;

   public int RemainingMinutesInOven(int time)
   {
       return ExpectedMinutesInOven() - time;
   }

   public int PreparationTimeInMinutes(int time)
   {
       return 2 * time;
   }

   public int ElapsedTimeInMinutes(int layers, int minutes)
   {
       return PreparationTimeInMinutes(layers) + minutes;
   }
}
