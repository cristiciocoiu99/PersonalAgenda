using Xamarin.Forms;

namespace PersonalAgenda
{
    internal class NavigationPage : Page
    {
        private AgendaPage agendaPage;

        public NavigationPage(AgendaPage agendaPage)
        {
            this.agendaPage = agendaPage;
        }
    }
}