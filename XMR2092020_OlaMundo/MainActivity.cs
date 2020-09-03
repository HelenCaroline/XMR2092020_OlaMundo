using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace XMR2092020_OlaMundo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView txtOla;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            //Define qual layout esta classe (MainActivity) vai Controlar
            SetContentView(Resource.Layout.activity_main);

            //Capturando os objetos do layout para serem manipulados aqui
            txtOla = FindViewById<TextView>(Resource.Id.TxtOla);
            TextView btnMostrar = FindViewById<TextView>(Resource.Id.BtnMostrar);

            //Criar o método de click do botão BtnMostrar
            btnMostrar.Click += BtnMostrar_Click;
        }

        private void BtnMostrar_Click(object sender, System.EventArgs e)
        {
            txtOla.Text = "Olá Mundo";
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}