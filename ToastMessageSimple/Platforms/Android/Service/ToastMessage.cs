using Android.Widget;
using ToastMessageSimple.Platforms.Android.Service;
using ToastMessageSimple.Services;
using Application = Android.App.Application;
[assembly: Dependency(typeof(ToastMessage))]
namespace ToastMessageSimple.Platforms.Android.Service;

public class ToastMessage : IToastMessage
{

    public void LongToast(string message)
    {
        Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
    }

    public void ShortToast(string message)
    {
        Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
    }
}

