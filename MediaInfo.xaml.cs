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
    /// Interaction logic for MediaInfo.xaml
    /// </summary>
    public partial class MediaInfo : Page
    {
        private object previousContent;

        public MediaInfo(object _previousContent, Media list)
        {
            InitializeComponent();
                    previousContent = _previousContent;
                    MediaTitle.Text = list.Title;
                    TextBorrower.Text = list.Borrower;
                    TextAvailiblity.Text = (list.Availability) ? "Available" : "Not Available";
                    //if(data.Availability)? Text_Availiblity.Text = "Avalable" : Text_Availiblity.Text = "Not Avalable";

                    //mediainfo = data;
                }

                private void Button_Closes(object sender, RoutedEventArgs e)
                {
                    Application.Current.MainWindow.Content = previousContent;

                }
            }
        }
    

