using ExamenProgresoDosEmilioGuerrero.Interfaces;
using ExamenProgresoDosEmilioGuerrero.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgresoDosEmilioGuerrero.Repositorio
{
    public class UsuarioRecargaPorArchivoRepository : IUsuarioRecarga
    {
        private string _archivo = Path.Combine(FileSystem.AppDataDirectory, "EmilioGuerrero.txt");
        public bool ActualizarUsuarioRecarga(UsuarioRecarga usuario)
        {
            throw new NotImplementedException();
        }

        public bool CrearUsuarioRecarga(UsuarioRecarga usuario)
        {
            try
            {
                string jsondata = JsonConvert.SerializeObject(usuario);
                File.WriteAllText(_archivo, jsondata);
                return true;
            }
            catch(Exception) 
            {
                throw; 
            }
        }

        public IEnumerable<IUsuarioRecarga> DevuelveListadoUsuario()
        {
            throw new NotImplementedException();
        }

        public UsuarioRecarga DevuelveUsuario(int Numero)
        {
            UsuarioRecarga usuario = new UsuarioRecarga();
            if (File.Exists(_archivo))
            {
                string jsondata = File.ReadAllText(_archivo);
                usuario = JsonConvert.DeserializeObject<UsuarioRecarga>(jsondata);
            }
            return usuario;
            
        }

        public UsuarioRecarga DevuelveUsuario(object numero)
        {
            throw new NotImplementedException();
        }

        public bool EliminarUsuarioRecarga(int Numero)
        {
            throw new NotImplementedException();
        }
    }
}
