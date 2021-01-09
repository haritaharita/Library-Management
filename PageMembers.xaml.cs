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
    /// Interaction logic for PageMembers.xaml
    /// </summary>
    public partial class PageMembers : Page
    {
        object previousContent;
       
       public PageMembers(object _previousContent, LibraryMembers list)
        {
            InitializeComponent();
            previousContent = _previousContent;
            MemberName.Text = list.Name;
            //if(data.Availability)? Text_Availiblity.Text = "Avalable" : Text_Availiblity.Text = "Not Avalable";

            //mediainfo = data;
        
    }


       private void CloseMembersInfo(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = previousContent;

        }
    }
}
