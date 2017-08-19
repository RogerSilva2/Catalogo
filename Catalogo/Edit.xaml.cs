using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Catalogo
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Edit : Page
    {
        private int id;
        private Film currentFilm;

        public Edit()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.id = Convert.ToInt32(e.Parameter);
            var film = FilmsManager.Films.First(filmSearch => filmSearch.Id == this.id);
            this.currentFilm = film.Clone();
            this.DataContext = film;
        }
        
        private void Cancel(object sender, RoutedEventArgs e)
        {
            Film film = FilmsManager.Films.First(filmSearch => filmSearch.Id == this.currentFilm.Id);

            film.Name = this.currentFilm.Name;
            film.ImageUrl = this.currentFilm.ImageUrl;
            film.Popularity = this.currentFilm.Popularity;
            film.Synopsis = this.currentFilm.Synopsis;

            this.Frame.Navigate(typeof(Detail), this.currentFilm.Id);
        }
        
        private void EditFilm(object sender, RoutedEventArgs e)
        {
            // cleaning form
            required.Visibility = Visibility.Collapsed;
            invalidUrl.Visibility = Visibility.Collapsed;

            Film film = FilmsManager.Films.First(filmSearch => filmSearch.Id == this.currentFilm.Id);

            if (!IsValidForm(film))
            {
                required.Visibility = Visibility.Visible;
            }
            else if (!IsValidUrl(film.ImageUrl))
            {
                invalidUrl.Visibility = Visibility.Visible;
            }
            else
            {
                this.Frame.Navigate(typeof(Detail), this.currentFilm.Id);
            }
        }
        
        private Boolean IsValidForm(Film film)
        {
            return !(String.IsNullOrEmpty(film.Name) || String.IsNullOrEmpty(film.ImageUrl) || String.IsNullOrEmpty(film.Synopsis));
        }
        
        private Boolean IsValidUrl(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }

        private void OnKeyUpValue(Object sender, KeyRoutedEventArgs e)
        {
            var textBox = sender as TextBox;
        }

        private void OnKeyDownValue(Object sender, KeyRoutedEventArgs e)
        {
            if (!IsDigitKey(e.Key))
            {
                e.Handled = true;
            }
        }

        private bool IsDigitKey(VirtualKey keyValue)
        {
            return ((keyValue >= VirtualKey.Number0 && keyValue <= VirtualKey.Number9) ||
                (keyValue >= VirtualKey.NumberPad0 && keyValue <= VirtualKey.NumberPad9));
        }
    }
}
