namespace GestionDocumentalApp.Documentos
{
    // ============================
    // Herencia y Encapsulamiento
    // ============================
    public class Informe : Documento
    {
        private string contenido;

        public Informe(string titulo, string contenido) : base(titulo)
        {
            this.contenido = contenido;
        }

        public void AgregarContenido(string texto)
        {
            if (!string.IsNullOrWhiteSpace(texto))
                contenido += "\n" + texto;
        }

        public override string MostrarResumen()
        {
            return $"[Informe] {Titulo}: {contenido.Substring(0, Math.Min(50, contenido.Length))}...";
        }
    }
}
