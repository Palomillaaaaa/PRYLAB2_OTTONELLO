using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRYLAB2_OTTONELLO
{
    internal class clsArchivo
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Articulos.mdb";
        private String TablaArt = "ARTICULOS";
        private String TablaRub = "RUBROS";


        public void CargarCombo(ComboBox combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = TablaRub;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, TablaRub);

                combo.Items.Clear();

                if (DS.Tables[TablaRub].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[TablaRub].Rows)
                    {
                        combo.Items.Add(fila["Nombre"].ToString());
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void RecorrerGrilla(DataGridView Grilla, Int32 IdRubrosSel)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = TablaArt;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, TablaArt);

                Grilla.Rows.Clear();
                if (DS.Tables[TablaArt].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[TablaArt].Rows)
                    {
                        if (Convert.ToInt32(fila["IdRubro"]) == IdRubrosSel)
                        {
                            decimal costo = Convert.ToDecimal(fila["Costo"]);
                            Int32 stock = Convert.ToInt32(fila["Stock"]);
                            decimal valorStock = costo * stock;
                            Grilla.Rows.Add(fila["IdCodArticulo"], fila["Descripcion"], costo, stock, valorStock);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void CantidadArticulos(Label lblCant, Int32 IdRubroSel) 
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = TablaArt;

                OleDbDataReader DR = comando.ExecuteReader();
                Int32 cont = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(3) == IdRubroSel)
                            cont++;
                    }
                }
                lblCant.Text = cont.ToString();
                conexion.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void TotalGeneral(Label lblTotal, Int32 IdRubroSel)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = TablaArt;

                OleDbDataReader DR = comando.ExecuteReader();
                decimal total = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(3) == IdRubroSel)
                            total += Convert.ToDecimal(DR[2]) * Convert.ToInt32(DR[4]);
                    }
                }
                lblTotal.Text = total.ToString();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ExportarDatos(Int32 IdRubroSel, string NombreArch)
        {

            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = TablaArt;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, TablaArt);

                StreamWriter ArchiReporte = new StreamWriter(NombreArch, false, Encoding.UTF8);
                ArchiReporte.WriteLine("REPORTE DE ARTICULOS SEGUN RUBRO");
                ArchiReporte.WriteLine();
                ArchiReporte.WriteLine("Código;Descripción;Costo;Stock;Valor en Stock");

                Int32 cont = 0;
                decimal total = 0;

                if (DS.Tables[TablaArt].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[TablaArt].Rows)
                    {
                        if (Convert.ToInt32(fila["IdRubro"]) == IdRubroSel)
                        {
                            decimal costo = Convert.ToDecimal(fila["Costo"]);
                            Int32 stock = Convert.ToInt32(fila["Stock"]);
                            decimal valorStock = costo * stock;

                            ArchiReporte.Write(fila["IdCodArticulo"]);
                            ArchiReporte.Write(";");
                            ArchiReporte.Write(fila["Descripcion"]);
                            ArchiReporte.Write(";");
                            ArchiReporte.Write(costo);
                            ArchiReporte.Write(";");
                            ArchiReporte.Write(stock);
                            ArchiReporte.Write(";");
                            ArchiReporte.WriteLine(valorStock);

                            cont++;
                            total += valorStock;
                        }
                    }
                }
                ArchiReporte.WriteLine();
                ArchiReporte.Write("CANTIDAD DE ARTICULOS:;;");
                ArchiReporte.WriteLine(cont);
                ArchiReporte.Write("TOTAL DE STOCK:;;");
                ArchiReporte.WriteLine(total);

                ArchiReporte.Close();
                ArchiReporte.Dispose();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Imprimir(PrintPageEventArgs reporte, Int32 IdRubroSel, string NombreRubro)
        {
            try
            {
                Font LetraTitulo1 = new Font("Arial", 20);
                Font LetraTitulo2 = new Font("Arial", 12);
                Font LetraTexto = new Font("Arial", 8);
                Int32 f = 200;
                //Titulos
                reporte.Graphics.DrawString("REPORTE DE ARTICULOS POR RUBRO", LetraTitulo1, Brushes.Red, 100, 80);
                reporte.Graphics.DrawString("Rubro: " + NombreRubro, LetraTitulo2, Brushes.Blue, 100, 120);
                //Encabezados
                reporte.Graphics.DrawString("Código", LetraTitulo2, Brushes.Black, 30, 155);
                reporte.Graphics.DrawString("Descripción", LetraTitulo2, Brushes.Black, 130, 155);
                reporte.Graphics.DrawString("Costo", LetraTitulo2, Brushes.Black, 430, 155);
                reporte.Graphics.DrawString("Stock", LetraTitulo2, Brushes.Black, 510, 155);
                reporte.Graphics.DrawString("Valor Stock", LetraTitulo2, Brushes.Black, 580, 155);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = TablaArt;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, TablaArt);

                Int32 cont = 0;
                decimal total = 0;
                if (DS.Tables[TablaArt].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[TablaArt].Rows)
                    {
                        if (Convert.ToInt32(fila["IdRubro"]) == IdRubroSel)
                        {
                            decimal costo = Convert.ToDecimal(fila["Costo"]);
                            Int32 stock = Convert.ToInt32(fila["Stock"]);
                            decimal valorStock = costo * stock;

                            reporte.Graphics.DrawString(fila["IdCodArticulo"].ToString(), LetraTexto, Brushes.Black, 30, f);
                            reporte.Graphics.DrawString(fila["Descripcion"].ToString(), LetraTexto, Brushes.Black, 130, f);
                            reporte.Graphics.DrawString(costo.ToString(), LetraTexto, Brushes.Black, 430, f);
                            reporte.Graphics.DrawString(stock.ToString(), LetraTexto, Brushes.Black, 510, f);
                            reporte.Graphics.DrawString(valorStock.ToString(), LetraTexto, Brushes.Black, 580, f);

                            f += 20;
                            cont++;
                            total += valorStock;
                        }
                    }
                }
                f += 10;
                reporte.Graphics.DrawString("Cantidad de artículos: " + cont.ToString(), LetraTitulo2, Brushes.Black, 100, f);
                f += 20;
                reporte.Graphics.DrawString("Total valor en stock: " + total.ToString(), LetraTitulo2, Brushes.Black, 100, f);

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
            
           
            
                
 
