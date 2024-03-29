﻿using System.ComponentModel.DataAnnotations;

namespace WebApi01.Models
{
    public class Equipos
    {
        [Key]
        public int id_equipos { get; set; }
        public string name { get; set; }
        public string descripcion { get; set; }
        public int? tipo_equipo_id { get; set; }
        public int? marca_id { get; set; }
        public string modelo { get; set; }
        public int? anio_compra { get; set;}
        public double? costo { get; set; }
        public string vida_util {  get; set; }
        public int? estado_equipo_id { get; set;}
        public string estado {  get; set; }
    }
}
