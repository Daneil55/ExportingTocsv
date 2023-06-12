namespace ExportingTocsv;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	    MainPage.Navigation.PushAsync(new SavingPage());
	}
}
