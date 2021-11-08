using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using ProyctoMVC.Models;
using System.Collections;
namespace ProyctoMVC.appGet
{
    public class gestion
    {
        public string insertar(alumno es)
        {
            conexion con = new conexion();
            NpgsqlConnection mys = con.getConnexion();
            String msjR = "";
            if (mys != null)
            {

                NpgsqlCommand cmd = new NpgsqlCommand("insetaralumno", mys);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idalu", es.idAlu);
                cmd.Parameters.AddWithValue("@nom", es.nom);
                cmd.Parameters.AddWithValue("@ape", es.ape);
                cmd.Parameters.AddWithValue("@s", es.s);
                cmd.Parameters.AddWithValue("@gra", es.gra);
                cmd.Parameters.AddWithValue("@se", es.se);
                cmd.Parameters.AddWithValue("@dir", es.dir);
                cmd.Parameters.AddWithValue("@tel", es.tel);
                cmd.Parameters.AddWithValue("@corele", es.corEle);
                cmd.Parameters.AddWithValue("@areaocu", es.areaOcu);
               try
                {
                    cmd.ExecuteNonQuery();
                    mys = null;
                    con.desconectar();
                }
                catch (Exception ex)
                {
                    msjR = "No se pudo realizar la operacion " + ex.ToString();
                    mys = null;
                    con.desconectar();
                }
                finally
                {
                    mys = null;
                    con.desconectar();
                }
            }
            return msjR;
        }

        public string modificar(alumno es)
        {
            conexion con = new conexion();
            NpgsqlConnection mys = con.getConnexion();
            String msjR = "";
            if (mys != null)
            {

                NpgsqlCommand cmd = new NpgsqlCommand("modificaralumno", mys);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idalu", es.idAlu);
                cmd.Parameters.AddWithValue("@nom", es.nom);
                cmd.Parameters.AddWithValue("@ape", es.ape);
                cmd.Parameters.AddWithValue("@s", es.s);
                cmd.Parameters.AddWithValue("@gra", es.gra);
                cmd.Parameters.AddWithValue("@se", es.se);
                cmd.Parameters.AddWithValue("@dir", es.dir);
                cmd.Parameters.AddWithValue("@tel", es.tel);
                cmd.Parameters.AddWithValue("@corele", es.corEle);
                cmd.Parameters.AddWithValue("@areaocu", es.areaOcu);
                try
                {
                    cmd.ExecuteNonQuery();
                    mys = null;
                    con.desconectar();
                }
                catch (Exception ex)
                {
                    msjR = "No se pudo realizar la operacion " + ex.ToString();
                    mys = null;
                    con.desconectar();
                }
                finally
                {
                    mys = null;
                    con.desconectar();
                }
            }
            return msjR;
        }


        public ArrayList mostrarEstudiante()
        {
            conexion con = new conexion();
            NpgsqlConnection mys = con.getConnexion();
            ArrayList arrayCartelera = new ArrayList();
            if (mys != null)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("buscaralumno", mys);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                NpgsqlDataReader da;
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    alumno es = new alumno();
                    cmd.Parameters.Clear();
                    es.idAlu = Convert.ToString(da.GetString(0));
                    es.nom = Convert.ToString(da.GetString(1));
                    es.ape = Convert.ToString(da.GetString(2));
                    es.s = Convert.ToString(da.GetString(3));
                    es.gra = Convert.ToString(da.GetString(4));
                    es.se = Convert.ToString(da.GetString(5));
                    es.dir = Convert.ToString(da.GetString(6));
                    es.tel = Convert.ToString(da.GetString(7));
                    es.corEle = Convert.ToString(da.GetString(8));
                    es.areaOcu = Convert.ToString(da.GetString(9));
                    arrayCartelera.Add(es);
                }
                con.desconectar();
                mys.Close();
            }
            return arrayCartelera;
        }


        public alumno mostrarEstudiante2(String cod)
        {
            conexion con = new conexion();
            NpgsqlConnection mys = con.getConnexion();
            ArrayList arrayCartelera = new ArrayList();
            alumno es = new alumno();
            if (mys != null)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("buscaralumno2", mys);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idalu2",cod);
                NpgsqlDataReader da;
                da = cmd.ExecuteReader();
                while (da.Read())
                {
                    cmd.Parameters.Clear();
                    es.idAlu = Convert.ToString(da.GetString(0));
                    es.nom = Convert.ToString(da.GetString(1));
                    es.ape = Convert.ToString(da.GetString(2));
                    es.s = Convert.ToString(da.GetString(3));
                    es.gra = Convert.ToString(da.GetString(4));
                    es.se = Convert.ToString(da.GetString(5));
                    es.dir = Convert.ToString(da.GetString(6));
                    es.tel = Convert.ToString(da.GetString(7));
                    es.corEle = Convert.ToString(da.GetString(8));
                    es.areaOcu = Convert.ToString(da.GetString(9));
                    arrayCartelera.Add(es);
                }
                con.desconectar();
                mys.Close();
            }
            return es;
        }
        public string eliminar(String es)
        {
            conexion con = new conexion();
            NpgsqlConnection mys = con.getConnexion();
            String msjR = "";
            if (mys != null)
            {

                NpgsqlCommand cmd = new NpgsqlCommand("elimnaralumno", mys);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idalu", es);
                try
                {
                    cmd.ExecuteNonQuery();
                    mys = null;
                    con.desconectar();
                }
                catch (Exception ex)
                {
                    msjR = "No se pudo realizar la operacion " + ex.ToString();
                    mys = null;
                    con.desconectar();
                }
                finally
                {
                    mys = null;
                    con.desconectar();
                }
            }
            return msjR;
        }
    }
}