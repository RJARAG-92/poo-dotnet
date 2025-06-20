namespace GestionDocumentalApp.Documentos
{
    // ============================
    // Abstracción
    // ============================
    public abstract class Documento
    {
        public string Titulo { get; set; }

        protected Documento(string titulo)
        {
            Titulo = titulo;
        }

        public abstract string MostrarResumen();
    }
}
