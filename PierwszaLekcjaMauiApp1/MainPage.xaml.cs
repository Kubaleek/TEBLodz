namespace PierwszaLekcjaMauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void WyswietlKomunikat(object sender, EventArgs e)
        {
            string numer = EntryNumber.Text;
            string imie = EntryFirst.Text;
            string nazwisko = EntrySecond.Text;

            if (numer == null || imie == null || nazwisko == null)
            {
                DisplayAlert("Brak Danych Uzupełnionych", "Uzupełnij Dane", "OK");
            }
            else
            {
                DisplayAlert("Dane", $"{numer} {imie} {nazwisko}", "OK");
            }
        }


    }

}
