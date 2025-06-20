namespace GestionDocumentalApp.Documentos
{
    public class Contrato : Documento
    {
        private string clausulas;

        public Contrato(string titulo, string clausulas) : base(titulo)
        {
            this.clausulas = clausulas;
        }

        public void ModificarClausulas(string nuevasClausulas)
        {
            clausulas = nuevasClausulas;
        }

        public override string MostrarResumen()
        {
            return $"[Contrato] {Titulo}: {clausulas.Substring(0, Math.Min(50, clausulas.Length))}...";
        }
    }
}
