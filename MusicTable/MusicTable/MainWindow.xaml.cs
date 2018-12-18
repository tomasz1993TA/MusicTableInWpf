﻿using System.Windows;

namespace MusicTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Song song1 = new Song()
            {
                IdNumber = "01",
                SongName = "I want to break free",
                Album = "The Works",
                Band = "Queen",
                Author = "John Deacon",
                ReleaseDate = "1984",
                Length = "3:20"
            };

            DataGridXaml.Items.Add(song1);
        }

        public class Song
        {
            public string IdNumber { get; set; }
            public string SongName { get; set; }
            public string Album { get; set; }
            public string Band { get; set; }
            public string Author { get; set; }
            public string ReleaseDate { get; set; }
            public string Length { get; set; }

        }
    }
}
