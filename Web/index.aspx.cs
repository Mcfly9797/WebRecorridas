using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Negocio;
using Entidades;

namespace Web
{
    public partial class index : System.Web.UI.Page
    {
        [System.ComponentModel.Browsable(false)]
        public bool IsPostback { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si no hay postback
            if (!IsPostback)
            {
                BtnNuevaRecorrida.Attributes.Add("onclick", "return confirm('Confirma los datos ingresados?')");
                LlenarSoportistas();
                LlenarSalones();
                Validate();  
            }
        }


        private void LlenarSalones()
        {
            if (Salones.Items.Count <= 0)
            {
                ListItem i = new ListItem();
                LlenarSalones NomSalonesBD = new LlenarSalones();
                int iAux = 1;
                foreach (string elemento in NomSalonesBD.TraerNombreSalones())
                {
                    //llenar checkboxlist salones manual
                    i = new ListItem("&nbsp" + elemento, iAux.ToString());
                    Salones.Items.Add(i);
                    iAux++;
                }
            }
        }


        private void LlenarSoportistas()
        {
            LlenarSoportistas llenar = new LlenarSoportistas();
            List<string> Lista = llenar.NomSoportistas();
            Lista.Sort();
            SoportistaDropDownList.DataSource = Lista;
            SoportistaDropDownList.DataBind();
        }



        //Enviar datos a base de datos
        protected void BtnNuevaRecorrida_Click(object sender, System.EventArgs e)
        {


            

            //agregar verificacion de los campos seleccionados

           List<Recorrida> listRecorrida = new List<Recorrida>(); 
            //Label1.Text = "Confirma los siguientes datos?<br /> Soportista: ";
            //Label1.Text += SoportistaDropDownList.SelectedValue + "<br />";
            //Label1.Text += "Zonas recorridas: <br />";
            foreach (ListItem li in Salones.Items)
            {

                //Label1.Text += li.Value + "<br />";
                
                //Instancio una lista de recorrida donde en cada nodo cargo: nombre soportista, id del salon, estado de ese salon (SI se recorrio o no) detalle de la recorrida
                Recorrida recorrida = new Recorrida();
                recorrida.NomSop = SoportistaDropDownList.SelectedValue;
                recorrida.IdSalon = int.Parse(li.Value);
                recorrida.Detalle = Txtdetalles.Text;
                if (li.Selected == true)
                {
                    //Label1.Text += li.Text + "<br />";
                    recorrida.Estado = true;
                }
                else
                {
                    recorrida.Estado = false;
                }
                listRecorrida.Add(recorrida);

            }
            //Label1.Text += "Detalles: " +  Txtdetalles.Text + "<br />";

            bool resultado = false;
            CrearRecorrida crearRecorrida = new CrearRecorrida();

            //Despues usar el resultado de esto para corroborar si salio todo bien, revisar las subfunciones que llama este metodo tambien
            resultado = crearRecorrida.AgregarRecorrida(listRecorrida);

           // string script = @"window.location = "http://google.pt;";

            //ScriptManager.RegisterStartupScript(this, typeof(Page), "invocarfuncion", script, true);

        }


    }
}