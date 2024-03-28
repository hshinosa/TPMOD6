using TPMOD6;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Hashfi Hadyan");
        video.PrintVideoDetails();

        for (int i = 0; i < 215; i++)
        {
            video.IncreasePlayCount(10000000);
        }
    }
}