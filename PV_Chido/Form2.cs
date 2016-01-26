using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV_Chido{
    public partial class Form2 : Form{

        LinkedList<String> ListaProductos;
        LinkedList<String> listaFormaPago;

        public Form2(){
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;//no modificar
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            LlenarListaProductos();
            LlenarFormaPago();
        }

        public void LlenarListaProductos(){//cargar items de productos

            ListaProductos = new LinkedList<String>();
            ListaProductos.AddFirst("computadora");
            ListaProductos.AddLast("calculadora");
            ListaProductos.AddLast("cacahuates");
            ListaProductos.AddLast("carro");

            for (int x = 0; x < ListaProductos.Count(); x++){
                comboBox2.Items.Add(ListaProductos.ElementAt(x).ToString());
            }
        }

        public void LlenarFormaPago(){//Carga items de forma de pago
            listaFormaPago = new LinkedList<String>();
            listaFormaPago.AddFirst("Contado");
            listaFormaPago.AddLast("50% anticipo");
            listaFormaPago.AddLast("30 días");
            listaFormaPago.AddLast("Otro");

            for (int x = 0; x < listaFormaPago.Count(); x++){
                comboBox1.Items.Add(listaFormaPago.ElementAt(x).ToString());
            }
        }

        bool ValidarPrecio(TextBox precio){
            try {
                Double pre = Convert.ToDouble(precio.Text);
                return true;
            } catch {
                precio.Text = "0.0";
                precio.Select(0, precio.Text.Length);
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e){
            Ventas venta = new Ventas();
            venta.setFormaDePago2(comboBox1.SelectedItem.ToString());

            MessageBox.Show(numericUpDown1.Value.ToString());

           
        }

        private void button1_Click(object sender, EventArgs e){
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            numericUpDown1.ResetText();
            textBox1.Clear();
            LlenarListaProductos();
            LlenarFormaPago();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e){
            ValidarPrecio((TextBox) sender);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
