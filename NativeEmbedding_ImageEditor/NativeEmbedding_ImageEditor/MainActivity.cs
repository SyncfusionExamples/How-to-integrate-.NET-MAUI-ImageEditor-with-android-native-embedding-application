using Microsoft.Maui.Embedding;
using Android.App;
using Android.OS;
using Microsoft.Maui.Platform;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.ImageEditor;

namespace NativeEmbedding_ImageEditor
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        MauiContext? _mauiContext;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            MauiAppBuilder builder = MauiApp.CreateBuilder();
            builder.UseMauiEmbedding<Microsoft.Maui.Controls.Application>();
            builder.ConfigureSyncfusionCore();
            MauiApp mauiApp = builder.Build();
            _mauiContext = new MauiContext(mauiApp.Services, this);

            SfImageEditor imageEditor = new SfImageEditor();
            imageEditor.Source = ImageSource.FromResource("NativeEmbedding_ImageEditor.Resources.Images.image.png");

            Android.Views.View view = imageEditor.ToPlatform(_mauiContext);
            SetContentView(view);
        }
    }
}