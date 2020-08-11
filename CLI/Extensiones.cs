using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace CLI
{
  public static class Extensiones
  {
    public static (int? min, int? max, double? prom) Estadisticas<T>(this IEnumerable<T> src, Func<T, int?> selector)
    {
      var minimo = src.Min(selector);
      var maximo = src.Max(selector);
      var promedio = src.Average(selector);

      return (minimo, maximo, promedio);
    }
  }
}
