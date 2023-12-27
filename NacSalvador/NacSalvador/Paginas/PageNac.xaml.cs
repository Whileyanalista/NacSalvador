
using MediaManager;
using MediaManager.Library;
using MediaManager.Playback;
using MediaManager.Queue;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NacSalvador.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageNac : TabbedPage
    {
        public bool isPlaying { get; set; }

        //string url = "https://stream-149.zeno.fm/fmx19gk8ewiuv";       
      
        /*  */
        
        public PageNac()
        {
            var songList = new List<string>() {
                "https://files.freemusicarchive.org/storage-freemusicarchive-org/music/no_curator/Yung_Kartz/July_2019/Yung_Kartz_-_02_-_Levels.mp3",
                "https://files.freemusicarchive.org/storage-freemusicarchive-org/music/Creative_Commons/Ketsa/Raising_Frequency/Ketsa_-_08_-_Multiverse.mp3",
                "https://files.freemusicarchive.org/storage-freemusicarchive-org/music/Oddio_Overplay/Carl_Phaser/End_Of_The_Dark/Carl_Phaser_-_02_-_Porcelain.mp3",
                "https://files.freemusicarchive.org/storage-freemusicarchive-org/music/blocSonic/Flex_Vector/Born_Ready/Flex_Vector_-_Born_Ready.mp3",
                "https://files.freemusicarchive.org/storage-freemusicarchive-org/music/no_curator/Elephant/The_Art_of_Living_Part_2/Elephant_-_09_-_The_Final_Crusade.mp3",
            };
            string title = CrossMediaManager.Current.Queue.Current.Title;
            string artist = CrossMediaManager.Current.Queue.Current.Artist;
            string album = CrossMediaManager.Current.Queue.Current.Album;



            InitializeComponent();
            BindingContext = this;
            //CrossMediaManager.Current.Play(url);
            isPlaying = true;
            OnPropertyChanged(nameof(isPlaying));
           
        }

        private async void play_pouse(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            OnPropertyChanged(nameof(isPlaying));
          
            if (isPlaying)
            {  
                
                Btplay_pouse.Source = "pause_icon.png";
                await CrossMediaManager.Current.Play();
                lblmusic.Text = "On line";      
            }
            else
            {         
                Btplay_pouse.Source = "play_icon.png";                
                await CrossMediaManager.Current.Pause();
                lblmusic.Text = "Off line";
            }                    

        }


    }
}