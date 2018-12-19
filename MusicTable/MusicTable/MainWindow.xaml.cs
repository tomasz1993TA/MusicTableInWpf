using System;
using System.Data;
using System.Linq;
using System.Windows;
using MusicTable.Models;

namespace MusicTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MusicDatabaseEntities db = new MusicDatabaseEntities();
        public MainWindow()
        {
            InitializeComponent();                    
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridXaml.ItemsSource = db.MusicTable.ToList();
        }

        private void AddNewSongB_Click(object sender, RoutedEventArgs e)
        {
            
        }             
        
        private void ClearTextBoxesB_Click(object sender, RoutedEventArgs e)
        {
            IdNumberTB.Text = String.Empty;
            SongNameTB.Text = String.Empty;
            AlbumTB.Text = String.Empty;
            BandTB.Text = String.Empty;
            AuthorTB.Text = String.Empty;
            ReleaseDateTB.Text = String.Empty;
            LengthTB.Text = String.Empty;
        }               
    }
}
