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

            usuario = _usuarioRecargaRepository.DevuelveUsuario();
            BindingContext = usuario;
        }


        private void GuardarUsuario_Clicked(object sender, EventArgs e)
        {


        }
    }

}
