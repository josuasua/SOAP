using GestionBibliotecaMVC.BBLL;
using System.Collections.Generic;
using System;
using GestionBibliotecaMVC.Models;

namespace WcfBiblioteca {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EjemplarService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EjemplarService.svc o EjemplarService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EjemplarService : IEjemplarrService {
        private GestionBibliotecaMVC.Models.Ejemplar aux = new GestionBibliotecaMVC.Models.Ejemplar();
        private EjemplarServiceImp eS = new EjemplarServiceImp();

        public string create(Ejemplar ejemplar) {
            String retorno = "";
            aux = ParseDatosABBDD(ejemplar);
            if (aux.CodEjemplar > 0) {
                retorno = "El ejemplar se ha creado correctamente";
            } else {
                retorno = "La creación del ejemplar ha fallado";
            }
            return retorno;
        }

        private GestionBibliotecaMVC.Models.Ejemplar ParseDatosABBDD(Ejemplar ejemplar) {
            aux.CodLibro = ejemplar.IdLibro;
            aux.ISBN = ejemplar.Isbn;
            aux.FPublicacion = ejemplar._FPublicacion;
            aux.NumPaginas = ejemplar.Numeropaginas;
            aux.Titulo = ejemplar.Titulo;
            aux.Editorial.CodEditorial = ejemplar.IdEditorial;
            aux = eS.create(aux);
            return aux;
        }

        public List<Ejemplar> getAll() {
            List<GestionBibliotecaMVC.Models.Ejemplar> ejemplares = null;
            ejemplares = eS.getAll();
            List<Ejemplar> ejemplaresSOAP= new List<Ejemplar>();
            Ejemplar ejem = new Ejemplar();
            foreach (GestionBibliotecaMVC.Models.Ejemplar ejemplar in ejemplares) {
                ejem=parsedatos(ejemplar);
                ejemplaresSOAP.Add(ejem);
            }
            
            return ejemplaresSOAP;
        }

        public Ejemplar getEjemplarById(int codigoEjemplar) {
            
            aux = eS.getEjemplarById(codigoEjemplar);
            Ejemplar ejemplar = new Ejemplar();
            ejemplar.IdLibro = aux.CodLibro;
            ejemplar.Isbn = aux.ISBN;
            ejemplar.Numeropaginas = aux.NumPaginas;
            ejemplar._FPublicacion = aux.FPublicacion;
            ejemplar.IdEditorial = 1;
            return ejemplar;
        }

        public string GetVersion() {
            return "v 1.0";
        }

        private Ejemplar parsedatos(GestionBibliotecaMVC.Models.Ejemplar aux) {
            Ejemplar ejemplar = new Ejemplar();
            ejemplar.IdLibro = aux.CodLibro;
            ejemplar.Isbn = aux.ISBN;
            ejemplar.Numeropaginas = aux.NumPaginas;
            ejemplar._FPublicacion = aux.FPublicacion;
            ejemplar.IdEditorial = 1;
            return ejemplar;
        }

        public string delete(int codigoEjemplar) {

            string retorno = "Borrado con exito";

            try {
                aux = eS.getEjemplarById(codigoEjemplar);

                if (aux.CodEjemplar > 0) {

                    eS.delete(codigoEjemplar);

                }
            } catch (Exception e) {
                retorno = "Algo ha salido mal";
            }
            return retorno;
        }
    }
}
