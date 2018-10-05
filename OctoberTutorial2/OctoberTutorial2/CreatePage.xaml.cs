using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OctoberTutorial2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreatePage : ContentPage
	{
		public CreatePage ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
            Measurements measurement = new Measurements()
            {
                UserName = nameEntry.Text,
                SessionNumber = sessionEntry.Text,
                TimeStamp = DateTime.Now,
                Pressure = pressureEntry.Text,
                Duration = durationEntry.Text

            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Measurements>();
                var numberOfRows = conn.Insert(measurement);

                if (numberOfRows > 0)
                {
                    DisplayAlert("Success", "You have added a measurment!", "Dismiss");
                }
                else
                {
                    DisplayAlert("Failure", "Measurement failed to be inserted!", "Dismiss");
                }
            }



        }
    }
}