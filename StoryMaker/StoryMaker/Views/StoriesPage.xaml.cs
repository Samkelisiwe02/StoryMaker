using StoryMaker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryMaker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoriesPage : ContentPage
    {
        public StoriesPage()
        {
            InitializeComponent();
            Page_TitleLabel.Text = "StoryMaker";
            BindingContext = new StoriesPageViewModel();

        }
        private void OnDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }
        private void OnDragStarting(object sender, DragStartingEventArgs e)
        {
            var layout = (sender as Element).Parent as StackLayout;
            e.Data.Properties.Add("Layout", layout);
            UsersListView.IsVisible = true;
            ShowHide_Label.Text = "Background";
        }
        private void OnDrop(object sender, DropEventArgs e)
        {
            var backgroundLayout = (sender as Element).Parent as Grid;
            var storiesLayout = (StackLayout)e.Data.Properties["Layout"];
            if (storiesLayout.Children != null && storiesLayout.Children.Count > 0)
            {
                var label = storiesLayout.Children[1] as Label;
                var secondLabel = storiesLayout.Children[2] as Label;
                var gridImage = storiesLayout.Children[0] as Image;

                if (backgroundLayout != null && backgroundLayout.Children.Count > 0)
                {
                    var label1 = backgroundLayout.Children[1] as Label;
                    var label2 = backgroundLayout.Children[2] as Label;
                    var image = backgroundLayout.Children[3] as Image;

                    label1.Text = label.Text;
                    label1.IsVisible = true;
                    label2.Text = secondLabel.Text;
                    label2.IsVisible = true;
                    image.Source = gridImage.Source;
                }
            }
        }
        private void Label_Tapped(object sender, EventArgs e)
        {
            if (ShowHide_Label.Text.ToLower().Replace(" ", "") == "showbackground")
            {
                ShowHide_Label.Text = "Hide Background";
                UsersListView.IsVisible = true;
            }
            else
            {
                ShowHide_Label.Text = "Show Bakground";
                UsersListView.IsVisible = false;
            }
        }
    }

    public class StoriesPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<StoriesInfo> storyCollection;
        public ObservableCollection<StoriesInfo> StoryCollection
        {
            get { return storyCollection; }
            set { storyCollection = value; }
        }
        private ObservableCollection<BackgroundInfo> backgroundCollection;
        public ObservableCollection<BackgroundInfo> BackgroundCollection
        {
            get { return backgroundCollection; }
            set { backgroundCollection = value; }
        }
        public StoriesPageViewModel()
        {
            storyCollection = new ObservableCollection<StoriesInfo>();

            storyCollection.Add(new StoriesInfo() {StoryName = "The Boy", Image1 = ImageSource.FromFile("Boy.png")});
            storyCollection.Add(new StoriesInfo() {StoryName = "The Girl", Image1 = ImageSource.FromFile("Girl.png") });
            storyCollection.Add(new StoriesInfo() {StoryName = "The Alien", Image1 = ImageSource.FromFile("Alien.png") });
            storyCollection.Add(new StoriesInfo() {StoryName = "The Astonaut", Image1 = ImageSource.FromFile("Astronaut.png") });

            BackgroundCollection = new ObservableCollection<BackgroundInfo>();
            backgroundCollection.Add(new BackgroundInfo() { BackgroundName = "The Aquarium", ImageA = ImageSource.FromFile("Aquarium.png") });
            backgroundCollection.Add(new BackgroundInfo() { BackgroundName = "In Space", ImageA = ImageSource.FromFile("download.png") });
            backgroundCollection.Add(new BackgroundInfo() { BackgroundName = "The Playground", ImageA = ImageSource.FromFile("playground.png") });
            backgroundCollection.Add(new BackgroundInfo() { BackgroundName = "The Beach", ImageA = ImageSource.FromFile("Beach.png") });



        }


    }
}




