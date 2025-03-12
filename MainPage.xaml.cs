using MediaManager;
using System.Timers;
using MediaManager.Playback;
using Plugin.Maui.Audio;


namespace Music_Player
{
    public partial class MainPage : ContentPage
    {
        private IAudioPlayer _audioPlayer;

        public MainPage()
        {
            InitializeComponent();
            InitializeAudioPlayer();


        }
        private async void InitializeAudioPlayer()
        {
            var fileStream = await FileSystem.OpenAppPackageFileAsync("song.mp3");
            _audioPlayer = AudioManager.Current.CreatePlayer(fileStream);
        }

        private void PlayPause_Clicked(object sender, EventArgs e)
        {
            if (_audioPlayer.IsPlaying)
                _audioPlayer.Pause();
            else
                _audioPlayer.Play();
        }

        private void Stop_Clicked(object sender, EventArgs e)
        {
            _audioPlayer.Stop();
        }
    }

}
