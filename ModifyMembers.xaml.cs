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
    /// Interaction logic for ModifyMembers.xaml
    /// </summary>
    /// 
    public partial class ModifyMembers : Page
    {
        object previousContent;
        //public enum setvaibility { Available, Not  };
        LibraryMembers libraryMember;
        public ModifyMembers(object _previousContent, LibraryMembers data)
        {
            InitializeComponent();
            libraryMember = data;
            previousContent = _previousContent;
           TextBox.Text = libraryMember.Name;
        }

        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            this.Content = previousContent;
        }


        private void Update_Button(object sender, RoutedEventArgs e)
        {
            libraryMember.Name = TextBox.Text;



            ((MainWindow)Application.Current.MainWindow).RefreshMemberNameGrid();
            ((MainWindow)Application.Current.MainWindow).Content = previousContent;

        }
    }
}
