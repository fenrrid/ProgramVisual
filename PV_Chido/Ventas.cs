using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Chido{
    class Ventas{
        int a = 0;
        int formadepago = 0;
        int cantidad = 0;
        String formadepago2 = "";
        String productos = "";
        Double precio = 0.0;

      public  Ventas() { }

        public void setFormaDePago2(String forma2){
            this.formadepago2 = forma2;
        }

        public void setFormaDePago(int forma){
            this.formadepago = forma;
        }
        public void setProductos(String pro){
            this.productos = pro;
        }
        public void setCantidad(int can){
            this.cantidad = can;
        }
        public void setPrecio(Double pre){
            this.precio = pre;
        }

        public int getFormaDePago(){
            return this.formadepago;
        }
        public String getProductos(){
            return this.productos;
        }
        public int getCantidad(){
            return this.cantidad;
        }
        public Double getPrecio(){
            return this.precio;
        }
        public String setFormaDePago2(){
            return this.formadepago2;
        }

        public String getToString(){
            return formadepago2 + "\t\t" + productos + "\t\t" + cantidad + "\t" + precio + "\n";
        }
    }
}
