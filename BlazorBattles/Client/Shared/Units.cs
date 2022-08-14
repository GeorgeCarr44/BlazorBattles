namespace BlazorBattles.Client.Shared
{
    public class Units
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int HitPoints { get; set; } = 100;
        public int BananaCost { get; set; }
    }
}
