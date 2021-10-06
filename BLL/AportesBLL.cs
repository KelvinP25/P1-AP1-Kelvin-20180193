using P1_AP1_Kelvin_20180193.DAL;
using P1_AP1_Kelvin_20180193.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace P1_AP1_Kelvin_20180193.BLL
{
    public class AportesBLL
    {
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.aportes.Any(async => async.AporteId == id);
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

        public static bool Insertar(Aportes aportes)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.aportes.Add(aportes);
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

        public static bool Modificar(Aportes aportes)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entry(aportes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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

        public static bool Guardar(Aportes aportes)
        {
            if (!Existe(aportes.AporteId))
            {
                return Insertar(aportes);
            }
            else
            {
                return Modificar(aportes);
            }
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var aporte = contexto.aportes.Find(id);
                if (aporte != null)
                {
                    contexto.aportes.Remove(aporte);
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

        public static Aportes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Aportes aportes;

            try
            {
                aportes = contexto.aportes.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return aportes;
        }
        public static List<Aportes> GetList(Expression<Func<Aportes, bool>> criterio)
        {
            List<Aportes> lista = new List<Aportes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.aportes.Where(criterio).ToList();
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
        public static List<Aportes> GetAportes()
        {
            List<Aportes> lista = new List<Aportes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.aportes.ToList();
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
