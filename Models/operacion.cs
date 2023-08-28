using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace practica1.Models
{
    [Serializable]
    public class operacion
    {
        [Display(Name ="nom")]
         public string nom { get; set; }

         [Display(Name ="ape")]
         public string ape { get; set; }

         [Display(Name ="edad")]
         public string edad { get; set; }

         public string genero { get; set; }

         [Display(Name ="equipo")]
         public string equipo { get; set; }

        [Display(Name ="cat")]
         public string cat { get; set; }

         public string temp { get; set; }

        public string numfalta { get; set; }

        [Display(Name ="nufalta")]
         public string nufalta { get; set; }

         public string msjF(){

            double costoT = 0;
            double impuesto = 0.19;
            double inscrip = 300;

            if (!string.IsNullOrEmpty(nom)){
              if (!string.IsNullOrEmpty(ape)){
                if (!string.IsNullOrEmpty(edad)){
                    if (!string.IsNullOrEmpty(equipo)){
                
                            if("1"==temp){
                                costoT = inscrip+(inscrip*impuesto);
                            }else if("2"==temp){
                                costoT = 2*inscrip+(2*inscrip*impuesto);
                            }else if("3"==temp){
                                costoT = 3*inscrip+(3*inscrip*impuesto);
                            }else if("4"==temp){
                                costoT = 4*inscrip+(4*inscrip*impuesto);
                            }

                    }else{
                        throw new ArgumentException("Ingrese el equipo");
                    }
                }else{
                    throw new ArgumentException("Ingrese la edad");
                }
            }else{
                throw new ArgumentException("Ingrese el apellido");
            }  
            }else{
                throw new ArgumentException("Ingrese el nombre");
            }

            
            if("SI"==numfalta){
            return 
            " Nombre y apellido:" +nom+" "+ape+
            "\nEdad:" +edad+ 
            "\nGenéro:" +genero+
            "\nEquipo:" +equipo+
            "\nCategoria:" +cat+
            "\nTemporadas:" +temp+
            "\nfaltas:" +numfalta+
            "\nCantidad de faltas:" +nufalta+
            "\nCosto total: s/." +costoT.ToString();
         }else{
            return 
             " Nombre y apellido:" +nom+" "+ape+
            "\nEdad:" +edad+ 
            "\nGenéro:" +genero+
            "\nEquipo:" +equipo+
            "\nCategoria:" +cat+
            "\nTemporadas:" +temp+
            "\nfaltas:" +numfalta+
            "\nCosto total: s/." +costoT.ToString();
         }

    }

    
}
}