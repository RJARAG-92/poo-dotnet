// ============================
// Programa principal
// ============================
using GestionDocumentalApp.Documentos;
using GestionDocumentalApp.Servicios;

var gestor = new GestorDocumentos();

var informe = new Informe("Informe de Ventas", "Ventas Q1 crecieron 10%.");
informe.AgregarContenido("Se proyecta crecimiento del 12% para Q2.");

var contrato = new Contrato("Contrato de Servicio", "Cláusula 1: Pago mensual.");

gestor.AgregarDocumento(informe);
gestor.AgregarDocumento(contrato);

gestor.MostrarTodosLosResumenes();