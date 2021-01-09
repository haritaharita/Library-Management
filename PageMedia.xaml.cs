using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for PageMedia.xaml
    /// </summary>
    public partial class PageMedia : Page
    {
        object previousContent;
        public PageMedia(object _previousContent, Media list)
        {
            InitializeComponent();
            previousContent = _previousContent;
            Text_MediaTitle.Text = list.Title;
            Text_Borrower.Text = list.Borrower;
            Text_Availiblity.Text = (list.Availability) ? "Avalable" : "Not available";
            //if(data.Availability)? Text_Availiblity.Text = "Avalable" : Text_Availiblity.Text = "Not Avalable";

            //mediainfo = data;
        }
    }
}
