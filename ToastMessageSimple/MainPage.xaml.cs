using ToastMessageSimple.Services;

namespace ToastMessageSimple;

public partial class MainPage : ContentPage
{
    private readonly IToastMessage _toastMessage;

    public MainPage()
	{
		InitializeComponent();
		_toastMessage = DependencyService.Get<IToastMessage>();
	}

	private void OnShortToast(object sender, EventArgs e)
	{
		_toastMessage.ShortToast("Welcome to .Net MAUI");
	}
	private void OnLongToast(object sender, EventArgs e)
	{
		_toastMessage.LongToast("Welcome to .Net MAUI");
	}
}

