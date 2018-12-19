using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
            Models.MusicTable mtdb = new Models.MusicTable()
            {
                IdNumber = IdNumberTB.Text,
                SongName = SongNameTB.Text,
                Album = AlbumTB.Text,
                Band = BandTB.Text,
                Author = AuthorTB.Text,
                ReleaseDate = ReleaseDateTB.Text,
                Length = LengthTB.Text
            };

            db.MusicTable.Add(mtdb);
            db.SaveChanges();
            DataGridXaml.ItemsSource = db.MusicTable.ToList();
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

        private void DeleteB_Click(object sender, RoutedEventArgs e)
        {
            Models.MusicTable rowSelected = (Models.MusicTable)DataGridXaml.SelectedItem;
            
            db.MusicTable.Remove(rowSelected);
            db.SaveChanges();
            DataGridXaml.ItemsSource = db.MusicTable.ToList();
        }

        private void DataGridXaml_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Models.MusicTable rowSelected = (Models.MusicTable)DataGridXaml.SelectedItem;

            if (rowSelected != null)
            {
                IdNumberTB.Text = rowSelected.IdNumber;
                SongNameTB.Text = rowSelected.SongName;
                AlbumTB.Text = rowSelected.Album;
                BandTB.Text = rowSelected.Band;
                AuthorTB.Text = rowSelected.Author;
                ReleaseDateTB.Text = rowSelected.ReleaseDate;
                LengthTB.Text = rowSelected.Length;
            }            
        }

        private void EditB_Click(object sender, RoutedEventArgs e)
        {
            Models.MusicTable rowSelected = (Models.MusicTable)DataGridXaml.SelectedItem;

            rowSelected.IdNumber = IdNumberTB.Text;
            rowSelected.SongName = SongNameTB.Text;
            rowSelected.Album = AlbumTB.Text;
            rowSelected.Band = BandTB.Text;
            rowSelected.Author = AuthorTB.Text;
            rowSelected.ReleaseDate = ReleaseDateTB.Text;
            rowSelected.Length = LengthTB.Text;

            DataGridXaml.ItemsSource = db.MusicTable.ToList();
        }
    }
}
