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
    public partial class Form1 : Form{

        Form2 frame2;

        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            if (frame2 == null){
                frame2 = new Form2();
                frame2.MdiParent = this.MdiParent;
                frame2.FormClosed += new FormClosedEventHandler(frame2_FormClosed);
                frame2.Show();
            } else {
                frame2.Activate();
            }
        }

        void frame2_FormClosed(object sender, EventArgs e){
            frame2 = null;
        }

        private void nuevoPresupuestoToolStripMenuItem_Click(object sender, EventArgs e){

        }

        private void nuevoPresupuestoToolStripMenuItem1_Click(object sender, EventArgs e){
            if (frame2 == null){
                frame2 = new Form2();
                frame2.MdiParent = this.MdiParent;
                frame2.FormClosed += new FormClosedEventHandler(frame2_FormClosed);
                frame2.Show();
            } else {
                frame2.Activate();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e){
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e){
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":V");
            MessageBox.Show("Universidad Politecnica del Estado de Chiapas\n proyecto IDE \nIntegrantes: Daniel Esteban Nandayapa Hernandez 143408 \n Jorge Enrique Penagos Espinoza 143401\n Victor Fernando Gil Calderon 143395\n 26/01/2015");
        }
    }
}
