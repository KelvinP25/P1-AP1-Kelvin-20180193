
using P1_AP1_Kelvin_20180193.DAL;
using P1_AP1_Kelvin_20180193.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace P1_AP1_Kelvin_20180193.BLL
{
    public class AporteBLL
    {
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Aporte.Any(a => a.AporteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();

            }
            return encontrado;
        }

        public static bool Insertar(Aporte aporte)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Aporte.Add(aporte);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Aporte aporte)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entry(aporte).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Guardar(Aporte aporte)
        {
            if (!Existe(aporte.AporteId))
            {
                return Insertar(aporte);
            }
            else
            {
                return Modificar(aporte);
            }
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var aporte = contexto.Aporte.Find(id);
                if (aporte != null)
                {
                    contexto.Aporte.Remove(aporte);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Aporte Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Aporte aporte;

            try
            {
                aporte = contexto.Aporte.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return aporte;
        }
        public static List<Aporte> GetList(Expression<Func<Aporte, bool>> criterio)
        {
            List<Aporte> lista = new List<Aporte>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Aporte.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
        public static List<Aporte> GetAporte()
        {
            List<Aporte> lista = new List<Aporte>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Aporte.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
