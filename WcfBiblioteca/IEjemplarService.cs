using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfBiblioteca {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEjemplarService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEjemplarrService {

        [OperationContract]
        string GetVersion();
        [OperationContract]
        List<Ejemplar> getAll();
        [OperationContract]
        Ejemplar getEjemplarById(int codigoEjemplar);
        [OperationContract]
        String create(Ejemplar ejemplar);
        [OperationContract]
        string delete(int codigoEjemplar);


        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Ejemplar {

        string isbn = "";
        string titulo = "";
        int numeropaginas = 0;
        int idLibro = 0;
        int idEditorial = 0;
        DateTime FPublicacion = new DateTime();
        string errorMessage = "";

        [DataMember]
        public string Titulo {
            get {
                return titulo;
            }
            set {
                titulo = value;
            }
        }

        [DataMember]
        public string Isbn {
            get {
                return isbn;
            }
            set {
                isbn = value;
            }
        }

        [DataMember]
        public int Numeropaginas {
            get {
                return numeropaginas;
            }
            set {
                numeropaginas = value;
            }
        }

        [DataMember]
        public int IdLibro {
            get {
                return idLibro;
            }
            set {
                idLibro = value;
            }
        }

        [DataMember]
        public int IdEditorial {
            get {
                return idEditorial;
            }
            set {
                idEditorial = value;
            }
        }

        [DataMember]
        public DateTime _FPublicacion {
            get {
                return FPublicacion;
            }
            set {
                FPublicacion = value;
            }
        }

        [DataMember]
        public string ErrorMessage {
            get {
                return errorMessage;
            }
            set {
                errorMessage = value;
            }
        }
    }
}
