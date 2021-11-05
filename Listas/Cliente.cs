
namespace Listas
{
    struct Cliente
    {
        #region Campos
        public string Nombre;
        public byte Edad;
        #endregion
       

        #region Constructor de la estructuca
        /// <summary>
        /// Constructor que inicializa los campos Nombre y Edad
        /// </summary>
        /// <param name="Nombre">Nombre del cliente</param>
        /// <param name="Edad">Edad del cliente</param>
        public Cliente(string Nombre, byte Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }

        #endregion

    }
}
