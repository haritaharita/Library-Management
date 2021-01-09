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
    /// Interaction logic for ModifyMedia.xaml
    /// </summary>
    public partial class ModifyMedia : Page
    {
        object previousContent;
        public enum setAvaibility { Available, OrNot  };
        Media libraryList;
       

        public ModifyMedia(object _previousContent, Media list)
        {
            InitializeComponent();
            libraryList = list;
            previousContent = _previousContent;
            mediaBox.ItemsSource = typeof(BookType).GetEnumValues();
            //availablity.ItemsSource = typeof(setvaibility).GetEnumValues();
            TextBox.Text = libraryList.Title;
            mediaBox.Text = libraryList.Type.ToString();
        }

       /* public ModifyMedia(object currentContent, Media dataList)
        {
            this.currentContent = currentContent;
            this.DataList = dataList;
        }*/


        private void Update_Button(object sender, RoutedEventArgs e)
        {
            libraryList.Title = TextBox.Text;

            if (mediaBox.Text == "Book")
            {
                libraryList.Type = BookType.Book;
            }
            else if (mediaBox.Text == "Magazine")
            {
                libraryList.Type = BookType.Magazine;

            }
            else if (mediaBox.Text == "Movie")
            {
                libraryList.Type = BookType.Movie;

            }

            ((MainWindow)Application.Current.MainWindow).RefreshDataGrid();
            ((MainWindow)Application.Current.MainWindow).Content = previousContent;



        }

        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            this.Content = previousContent;

        }
    }
}
