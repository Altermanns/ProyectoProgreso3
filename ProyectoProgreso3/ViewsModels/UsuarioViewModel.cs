
using System.Windows.Input;

namespace ProyectoProgreso3.ViewsModels
{
    public class UsuarioViewModel
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public ICommand RegistrarVendedorCommand { get; set; }

        public UsuarioViewModel()
        {
            Nombre = string.Empty;
            Correo = string.Empty;
            RegistrarVendedorCommand = new Command(RegistrarUsuario);
        }

        private void RegistrarUsuario()
        {
            System.Diagnostics.Debug.WriteLine($"Vendedor registrado: {Nombre}, {Correo}");
        }
    }

}
