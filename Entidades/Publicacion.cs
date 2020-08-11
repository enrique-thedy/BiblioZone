using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public enum TipoPublicacion
  {
    Indefinido,
    Libro,
    Revista
  }

  public class Publicacion
  {
    public Publicacion()
    {
      ContadorInstancias++;
    }

    public int Clave { get; set; }

    public static int ContadorInstancias { get; set; }

    public static void MostrarInstancias()
    {
      Console.WriteLine($"Instancias generadas hasta el momento {ContadorInstancias}");
    }

    //  TRADUCCION DE PROPIEDAD AUTOMATICA
    //
    private string _ISBN13;

    public string ISBN13
    {
      get { return _ISBN13; }
      set { _ISBN13 = value; }  //  value es una pseudovariable que asume siempre el valor del lado derecho
                                //  de la expresion de asignacion
    }

    public string Titulo { get; set; }

    public int? Paginas { get; set; }

    public TipoPublicacion Tipo { get; set; }
  }

  public class Autor
  {
    public int ID { get; set; }
    public string Nombre { get; set; }
  }
}
