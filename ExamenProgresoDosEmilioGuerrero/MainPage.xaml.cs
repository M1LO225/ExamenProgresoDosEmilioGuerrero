using ExamenProgresoDosEmilioGuerrero.Interfaces;
using ExamenProgresoDosEmilioGuerrero.Modelos;
using ExamenProgresoDosEmilioGuerrero.Repositorio;

namespace ExamenProgresoDosEmilioGuerrero
{
    public partial class MainPage : ContentPage
    {
        IUsuarioRecarga _usuarioRecargaRepository;
        UsuarioRecarga usuario = new UsuarioRecarga();

        public MainPage()
        {
            _usuarioRecargaRepository = new UsuarioRecargaPorArchivoRepository();
            InitializeComponent();

            usuario = _usuarioRecargaRepository.DevuelveUsuario(1);
            BindingContext = usuario;
        }


        private async void GuardarUsuario_Clicked(object sender, EventArgs e)
        {
            UsuarioRecarga usuario = new UsuarioRecarga
            {
                Nombre = editor_nombre.Text,
                Numero = editor_numero.Text,
            };
            bool guardar_usuario = _usuarioRecargaRepository.CrearUsuarioRecarga(usuario);
            if (guardar_usuario) 
            {
                await DisplayAlert("Alerta", "La recarga se ha realizado con exito", "OK");
                Navigation.PushAsync(new MainPage());

            }
            else
            {
                await DisplayAlert("Alerta", "La recarga no se ha realizado con exito", "OK");
            }


        }
    }

}
