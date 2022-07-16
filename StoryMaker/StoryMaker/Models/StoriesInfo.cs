using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace StoryMaker.Models
{
    public partial class StoriesInfo 
    {
    public string StoryName { get; set; }


        public ImageSource Image1 { get; set; }
        public ImageSource Image2 { get; set; }
        public ImageSource Image3 { get; set; }
        public ImageSource Image4 { get; set; }



    }
    public class BackgroundInfo
    {
        public string BackgroundName { get; set; }
        public ImageSource ImageA { get; set; }
        public ImageSource ImageB { get; set; }
        public ImageSource ImageC { get; set; }
        public ImageSource ImageD { get; set; }

    }
}