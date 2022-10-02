using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.Sql;
using System.IO;

namespace AnalizadorLexico
{
    public partial class Form1 : Form
    {
        string[] Reservadas = new string[] { "ERROR PALABRA RESERVADA NO VALIDA", "ERROR DE IDENTIFICADOR VALIDO", "ERROR DE SINTAXIS" };
        int posicion = 0;
        int Lineas = 1;
        string CadenaAux = "";
        int TotalErrores;
        // lstTokens
        List<Identificador> lstIdentificadores = new List<Identificador>();
        List<String> lstErrores = new List<String>();
        DataTable dtMatriz = new DataTable();
        SaveFileDialog guardar = new SaveFileDialog();
        string CodigoFuente = "", strTipo="";

        public Form1()
        {
            InitializeComponent();
            SqlConnection cn = new SqlConnection("Server = DESKTOP-I00VTEK\\VALERIASERVER; database = LYA2; User ID = sa; Password=18100168");
            cn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM MatrizPrueba2", cn);
            adapter.Fill(dtMatriz);
            cn.Close();

            //SqlDataAdapter data2 = new SqlDataAdapter("SELECT * FROM GramaticasFinal WHERE NoTerminales = 'S'", cn);
            //data2.Fill(DT2);
            //SqlDataAdapter data3 = new SqlDataAdapter("SELECT * FROM GramaticasFinal WHERE NoTerminales != 'S'", cn);
            //data3.Fill(DT3);

        }
        private void btnCargarPrograma_Click(object sender, EventArgs e)
        {
            Lineas = 1;
            rtxLineas.Text = "";
            rtxLinea2.Text = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "(*.txt) | *.txt";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CodigoFuente = fileDialog.FileName;
                rtxFuente.LoadFile(CodigoFuente, RichTextBoxStreamType.PlainText);
                int ln = rtxFuente.Lines.Count();

                for (int i = 1; i <= ln; i++)
                {
                    rtxLinea2.Text += Lineas + "\n";                  
                    rtxLineas.Text += Lineas + "\n" ;
                    Lineas++;
                }
            }
        }

        private void GuardarPrograma_Click(object sender, EventArgs e)
        {
            guardar.Filter = "documento de texto|*.txt";
            guardar.Title = "GUARDAR";
            guardar.FileName = "Sin titulo";
            var resultado = guardar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach (object line in rtxFuente.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Lineas = 1;
            rtxLineas.Clear();
            rtxLinea2.Clear();
            rtxToken.Clear();
            rtxFuente.Clear();
            rtxLineas.Text = " ";
            rtxLinea2.Text = " ";
            rtxToken.Text = " ";
            rtxFuente.Text = " ";
        }

        private void btnGuardarTokens_Click(object sender, EventArgs e)
        {
            guardar.Filter = "documento de texto|*.txt";
            guardar.Title = "GUARDAR";
            guardar.FileName = "Sin titulo";
            var resultado = guardar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach (object line in rtxToken.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
        }

        private void btnAnalizador_Click(object sender, EventArgs e)
        {
            lstIdentificadores.Clear();
            TotalErrores = 0;
            rtxToken.Text = "";
            string TipoSimbolo = "";
            string[] ArrCodigo = new string[rtxFuente.Lines.Length];
            dgvErrores.Rows.Clear();
            dgvTablaSimbolos.Rows.Clear();
            //arreglo obtiene el largo de las lineas y su longitud
            string[] ArregloFuente = new string[rtxFuente.Lines.Length];
            //guarda cada caracter del texto 
            for (int i = 0; i <= rtxFuente.Lines.Length - 1; i++)
            {
                ArregloFuente[i] = Blanco(rtxFuente.Lines[i]);
            }
            // * Inicia recorrido de las líneas del código para encontrar cada uno de los tokens
            for (int j = 0; j <= ArregloFuente.Length - 1; ++j)
            {
                int intEstado = 0;
                // 28/09/2022 - cadena guarda el token armado
                string Cadena = "";
                // * Foreach que permite hacer un recorrido para analizar la cadena
                foreach (char chrCaracter in ArregloFuente[j])
                {
                    if (chrCaracter.ToString() != " ")
                    {
                        // * DataSet --> Huecos en memoria que almacenan base de datos, similar a access
                        // * DataTable --> Es un elemento de DataSet.La info que llega aqui, se manda en automatico a DataSet
                        // * Un DataTable contiene un DataColumn y DataRows
                        // * DataColumn --> Columnas de DataTable
                        // * DataRows --> Filas de DataTable

                        // * El DataAdapter conduce datos de la base de datos al DataSet y viceversa. Además se puede abrir y cerrar
                        // * una conexión por sí solo
                        Cadena += chrCaracter.ToString();
                        foreach (DataColumn Columna in dtMatriz.Columns)
                        {
                            //*Compara el caracter de arreglo con el caracter de la columna de la matriz
                            if (chrCaracter.ToString() == Columna.ColumnName)
                            {
                                if (dtMatriz.Rows[intEstado][Columna].ToString() != "FDC")
                                {
                                    String encabezado = Columna.ColumnName;
                                    intEstado = int.Parse(dtMatriz.Rows[intEstado][encabezado].ToString());
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if(intEstado == 0)
                        {
                            break;
                        }
                        //Se obtiene el estado final //Se quitan las ultias dos columnas por ser FDC y TOKEN
                        intEstado = int.Parse(dtMatriz.Rows[intEstado][dtMatriz.Columns.Count - 2].ToString());
                        string strToken = dtMatriz.Rows[intEstado][dtMatriz.Columns.Count - 1].ToString();
                        if(strToken=="ERROR")
                        {
                            dgvErrores.Rows.Add(j + 1, strToken, "ERROR EN LA LÍNEA " + Lineas);
                            rtxToken.Text += strToken + " ";
                            TotalErrores++;
                            lblNumErrores.Text = TotalErrores.ToString();
                            lstErrores.Add(strToken);
                        }
                        else if(strToken=="PR02")
                        {
                            strTipo = "ENTERO";
                            rtxToken.Text += strToken + " ";
                        }
                        else if(strToken=="PR08")
                        {
                            strTipo = "REAL";
                            rtxToken.Text += strToken + " ";
                        }
                        else
                        {
                            rtxToken.Text += strToken + " ";
                        }
                        //if (strToken == "IDEN" || strToken == "CORE" || strToken == "COEN")
                        //{
                        //    if (strToken == "CORE")
                        //    {
                        //        strTipo = "CONSTANTE REAL";
                        //    }
                        //    else if (strToken == "COEN")
                        //    {
                        //        strTipo = "CONSTANTE ENTERA";
                        //    }
                        //    dgvTablaSimbolos.Rows.Add(Cadena, strToken, strTipo);
                        //    //dgvTablaSimbolos.Rows.Add(Cadena, strTipo);
                        //}
                        /*LLENADO TABLA DE SÍMBOLOS
                        AQUI ENTRARA EN CASO DE SER UN IDENTIFICADOR, SE ASEGURARA MEDIANTE EL USO DE LA CADENAAUX QUE CONTENDRA EL
                        TIPO DE DATO
                        ENTERO VAR1 O REAL VAR2
                        */
                        if (strToken == "IDEN" && CadenaAux == "ENTERO" || CadenaAux == "REAL")
                        {
                            dgvTablaSimbolos.Rows.Add(Cadena, strToken, CadenaAux);
                        }
                        /*SINO EN CASO DE QUE EL TOKEN SEA COEN...*/                      
                        else if (strToken == "COEN")
                        {       
                            //LA COLUMNA VALOR SE LLENA CON UNA CADENA
                            dgvTablaSimbolos.Rows.Add(Cadena, strToken, "ENTERO");
                        }
                        /*SINO EN CASO DE QUE EL TOKEN SEA COEN...*/
                        else if (strToken == "CORE")
                        {         
                            dgvTablaSimbolos.Rows.Add(Cadena, strToken, "REAL");
                        }
                        // CadenaAux almacena el token que se haya armado
                        CadenaAux = Cadena;
                        // Cadena e intEstado
                        Cadena = "";
                        intEstado = 0;
                    }
                }
                rtxToken.Text += "\n";
                intEstado = 0;
     
            }
            this.rtxToken.SelectionStart = this.rtxToken.Text.Length;
            posicion = rtxToken.SelectionStart;
            RemoveDuplicate(dgvTablaSimbolos);
        }

        public static string Blanco(String Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }
            return (Cadena.Trim() + " ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvErrores.Columns.Add("Linea", "Linea");
            dgvErrores.Columns.Add("Error", "Error");
            dgvErrores.Columns.Add("Tipo", "Tipo");
            dgvTablaSimbolos.Columns.Add("Lexema", "Lexema");
            dgvTablaSimbolos.Columns.Add("Token", "Token");
            dgvTablaSimbolos.Columns.Add("Tipo", "Tipo");
            dgvMatriz.DataSource = dtMatriz;
        }

        string[] ArrCodigo;
        private void btnSintactico_Click(object sender, EventArgs e)
        {
            //string[] ArrCodigo = new string[rtxFuente.Lines.Length];
            //arreglo obtiene el largo de las lineas y su longitud
            //guarda cada caracter del texto 
            rtxTokenSintaxis.Text = AjustarTokensParaSintaxis(rtxToken.Text);
            string[] ArregloTokensSintaxis = new string[rtxToken.Lines.Length];
            for (int i = 0; i <= rtxTokenSintaxis.Lines.Length - 1; i++)
            {
                ArregloTokensSintaxis[i] = rtxTokenSintaxis.Lines[i].Trim(' '); //Guarda cada linea en una celda del arreglo - Tambien le quita los espacios al final de la cadena
                int numeroTokens = ArregloTokensSintaxis[i].Split(' ').Length; //Obtiene el numero de tokens en la linea - i -     
                string[] AuxiliarTokens = new string[numeroTokens]; //Inicializa el arreglo auxiliar con el numero de tokens        
                ArregloTokensSintaxis[i].Split(' ').CopyTo(AuxiliarTokens, 0); //Almacenar la linea - i - en un arreglo auxiliar (cada token en una celda)
            }
            #region
            //if (txtCinta.Text.Contains("ERROR"))
            //{
            //    MessageBox.Show("Arregle los errores en el lexico!");
            //}
            //else
            //{
            //    try
            //    {
            //        string auxLinea = "";
            //        txtCinta.Text = "";
            //        //CONTROL DE RECORRIDO DE LOS TOKENS PARA VERIFICAR EXISTENCIA DE GRAMATICA CORRECTA
            //        for (int i = 0; i <= ArrCodigo.Length - 2; i++)
            //        {
            //            bool entro = false;
            //            auxLinea = ArrCodigo[i];
            //            txtCinta.Text += ArrCodigo[i] + '\n';
            //            string[] TokensAuxiliares = auxLinea.Split(' ');

            //            for (int j = 0; j <= TokensAuxiliares.Length - 1; j++)
            //            {
            //                string ext = Existe(TokensAuxiliares[j]);
            //                if (ext != "NoExiste")
            //                {
            //                    ArrCodigo[i] = ArrCodigo[i].Replace(TokensAuxiliares[j], ext);
            //                    TokensAuxiliares = ArrCodigo[i].Split(' ');
            //                    txtCinta.Text += ArrCodigo[i] + '\n';
            //                    j = -1;
            //                    entro = true;
            //                }
            //                else if (j <= TokensAuxiliares.Length - 2 && entro == false)
            //                {
            //                    ext = Existe(TokensAuxiliares[j] + " " + TokensAuxiliares[j + 1]);
            //                    if (ext != "NoExiste")
            //                    {
            //                        ArrCodigo[i] = ArrCodigo[i].Replace(TokensAuxiliares[j] + " " + TokensAuxiliares[j + 1], ext);
            //                        TokensAuxiliares = ArrCodigo[i].Split(' ');
            //                        j = -1;
            //                        entro = true;
            //                        txtCinta.Text += ArrCodigo[i] + '\n';
            //                    }
            //                }
            //                if (j <= TokensAuxiliares.Length - 3 && entro == false)
            //                {
            //                    ext = Existe(TokensAuxiliares[j] + " " + TokensAuxiliares[j + 1] + " " + TokensAuxiliares[j + 2]);
            //                    if (ext != "NoExiste")
            //                    {
            //                        ArrCodigo[i] = ArrCodigo[i].Replace(TokensAuxiliares[j] + " " + TokensAuxiliares[j + 1] + " " + TokensAuxiliares[j + 2], ext);
            //                        TokensAuxiliares = ArrCodigo[i].Split(' ');
            //                        j = -1;
            //                        txtCinta.Text += ArrCodigo[i] + '\n';
            //                    }
            //                }

            //                entro = false;
            //            }
            //            if (ExisteF(ArrCodigo[i]))
            //            {
            //                txtCinta.Text += "S\n";
            //                ArrCodigo[i] = "S";
            //            }
            //            else
            //            {
            //                txtCinta.Text += "ERROR\n";
            //                ArrCodigo[i] = "ERROR";
            //                ListErroresGram.Add("ERROR");

            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message.ToString(), "Se encontro un error no definido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    CambiarColorErroresGram();
            //}
            #endregion
        }

        #region
        //List<String> ListErroresGram = new List<string>();
        //public void CambiarColorErroresGram()
        //{
        //    for (int i = 0; i < ListErroresGram.Count; i++)
        //    {
        //        int indexOf = 0;
        //        while (indexOf != -1)
        //        {
        //            indexOf = rtxCinta.Text.IndexOf(ListErroresGram[i], indexOf);

        //            if (indexOf != -1)
        //            {
        //                rtxCinta.Select(indexOf, ListErroresGram[i].Length);
        //                rtxCinta.SelectionColor = Color.Red;
        //                indexOf += ListErroresGram[i].Length;
        //            }
        //        }
        //    }
        //}

        //DataTable DT2 = new DataTable();//Para las producciones con S
        //DataTable DT3 = new DataTable();//Para las demas producciones
        //public string Existe(string s)
        //{
        //    for (int i = 0; i <= DT3.Rows.Count - 1; i++)
        //    {
        //        if (DT3.Rows[i][1].ToString() == s)
        //        {
        //            return DT3.Rows[i][0].ToString();
        //        }
        //    }
        //    return "NoExiste";
        //}

        //public bool ExisteF(string s)
        //{
        //    for (int i = 0; i <= DT2.Rows.Count - 1; i++)
        //    {
        //        if (DT2.Rows[i][1].ToString() == s)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        #endregion

        public string AjustarTokensParaSintaxis(string strCadena)
        {
            var reemplazos = new Dictionary<string, string>();
            reemplazos.Add("CORE", "CONS");
            reemplazos.Add("COEN", "CONS");
            reemplazos.Add("OR01", "OPRE");
            reemplazos.Add("OR02", "OPRE");
            reemplazos.Add("OR03", "OPRE");
            reemplazos.Add("OR04", "OPRE");
            reemplazos.Add("OR05", "OPRE");
            reemplazos.Add("OA01", "OPAR");
            reemplazos.Add("OA02", "OPAR");
            reemplazos.Add("OA03", "OPAR");
            reemplazos.Add("OA04", "OPAR");

            foreach (var reemplazo in reemplazos)
            {
                strCadena = strCadena.Replace(reemplazo.Key, reemplazo.Value);
            }

            return strCadena;
        }

        #region test
        public void RemoveDuplicate(DataGridView grv)
        {
            for (int currentRow = 0; currentRow < grv.Rows.Count - 1; currentRow++)
            {
                DataGridViewRow rowToCompare = grv.Rows[currentRow];

                for (int otherRow = currentRow + 1; otherRow < grv.Rows.Count; otherRow++)
                {
                    DataGridViewRow row = grv.Rows[otherRow];

                    bool duplicateRow = true;

                    for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                    {
                        if (!rowToCompare.Cells[cellIndex].Value.Equals(row.Cells[cellIndex].Value))
                        {
                            duplicateRow = false;
                            break;
                        }
                    }

                    if (duplicateRow)
                    {
                        grv.Rows.Remove(row);
                        otherRow--;
                    }
                }
            }
        }
        #endregion
    }
}
