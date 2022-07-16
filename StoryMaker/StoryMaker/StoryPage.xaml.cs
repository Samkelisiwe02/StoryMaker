using System;
using System.Collections.Generic;
using System.Linq;
using StoryMaker.Models;
using StoryMaker.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryMaker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoryPage : ContentPage
    {
        public StoryPage()
        {
            InitializeComponent();
        }
        private void ListView_SelectionChanged(object sender, Syncfusion.ListView.XForms.ItemSelectionChangedEventArgs e)
        {
            if (e != null && e.AddedItems != null && e.AddedItems.Count > 0)
            {
                string name = (e.AddedItems[0] as StoriesInfo).StoryName;
                App.Current.MainPage.Navigation.PushAsync(new StoryPage());
            }
            storyListView.SelectedItems.Clear();
        }
    }

}

    public class StoryPageViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<StoriesInfo> storyCollection;
        public ObservableCollection<StoriesInfo> StoryCollection
        {
            get { return storyCollection; }
            set { storyCollection = value; }

        }





        public StoryPageViewModel()
        {
            {
                StoryCollection = new ObservableCollection<StoriesInfo>();
                StoryCollection.Add
                    (
                    new StoriesInfo()
                    {
                        StoryName = "Boy",
                        Image1 = ImageSource.FromFile("Boy.png")
                    }
                    );
                StoryCollection.Add
                    (
                    new StoriesInfo()
                    {
                        StoryName = "Girl",
                        Image2 = ImageSource.FromFile("Girl.png")
                    }
                    );
                StoryCollection.Add
                   (
                   new StoriesInfo()
                   {
                       StoryName = "Astronaut",
                       Image3 = ImageSource.FromFile("Astonaut.png")
                   }
                   );
                StoryCollection.Add
                   (
                   new StoriesInfo()
                   {
                       StoryName = "Alien",
                       Image4 = ImageSource.FromFile("Alien.png")
                   }
                   );
            
            }
        }
    }


