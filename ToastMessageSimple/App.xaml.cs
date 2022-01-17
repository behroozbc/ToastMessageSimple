using ToastMessageSimple.Services;

namespace ToastMessageSimple;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		DependencyService.Register<IToastMessage>();
		MainPage = new MainPage();
	}
}
