using GestionDocumentalApp.Documentos;

namespace GestionDocumentalApp.Servicios
{
    // ============================
    // Polimorfismo
    // ============================
    public class GestorDocumentos
    {
        private List<Documento> documentos = new();

        public void AgregarDocumento(Documento doc)
        {
            documentos.Add(doc);
        }

        public void MostrarTodosLosResumenes()
        {
            foreach (var doc in documentos)
            {
                Console.WriteLine(doc.MostrarResumen());
            }
        }
    }
}
