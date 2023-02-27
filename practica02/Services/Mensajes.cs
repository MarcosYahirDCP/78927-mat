using System;
using System.ServiceModel;

namespace WSDL.mensajes
{
    [ServiceContract] //<------ Funciona para identificar como contrato
    /*
    Un contrato = WSDL ---> Se esta confiriendo a esta clase la posibilidad de convertirse un contrato
    */
    public interface Mensajes
    {
        [OperationContract]
        string Saludar(string nombre);
        [OperationContract]
        string Mostrar(int d);
    }
}