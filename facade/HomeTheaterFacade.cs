namespace facade
{

    public class HomeTheaterFacade
    {
        Screen Screen;

        DVDPlayer DVDPlayer;

        Light Light;

        Amplifier Amplifier;

        public HomeTheaterFacade(Screen screen, DVDPlayer dvdPlayer, Light light, Amplifier amplifier)
        {
            Screen = screen;
            DVDPlayer = dvdPlayer;
            Light = light;
            Amplifier = amplifier;
        }

        public void WatchMovie()
        {

            Screen.On();
            Screen.SetBrightness(50);
            Screen.SetContrast(60);

            Light.On();
            Light.SetBrightness(40);

            Amplifier.On();
            Amplifier.SetVolume(50);

            DVDPlayer.On();
        }

        public void EndMovie()
        {
            Screen.Off();
            Light.Off();
            DVDPlayer.Eject();
            DVDPlayer.Off();
            Amplifier.Off();
        }
    }

}