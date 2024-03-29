﻿using System.ComponentModel.DataAnnotations;


namespace Sistema.Entidades.Alamacen
{
    public class Categoria
    {
        public int idcategoria { get; set; }
        [Required]
        [
            StringLength(50, MinimumLength =3, ErrorMessage ="Mas de 3 y menos de 50")
        ]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
