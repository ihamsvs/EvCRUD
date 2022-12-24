using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Usuario
    {
        [Required(AllowEmptyStrings =false, ErrorMessage = "Ingrese su Rut")]
        [Display(Name ="Ingrese su RUT:")]
        public string Rut { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un nombre ")]
        [Display(Name = "Ingrese su Nombre:")]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un Apellido ")]
        [Display(Name = "Ingrese su Apellido:")]
        public string Apellido { get; set; }
        [Display(Name = "Correo electronico")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)", ErrorMessage = "Correo inválido")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Debe ingresar su correo electrónico")]
        public string Email {get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un número telefónico ")]
        [Display(Name = "Ingrese su número telefónico")]
        [DataType(DataType.PhoneNumber)]
        public int NumTelefono { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage = "Ingrese una edad entre 18 y 80 años")]
        [Display(Name = "Ingrese su edad:")]
        [Range(18, 100, ErrorMessage = "Debe estar entre 18 y 100 años")]
        public int Edad { get; set; }
        [Display(Name = "Ingrese su estatura (M)")]
        public float Estatura  {get; set; }
        [Display(Name = "Ingrese su peso (KG)")]
        public float Peso { get; set; }

        public Usuario( string rut, string nombre, string apellido, string email, int numtelefono, int edad, float estatura, float peso) {
        
            this.Rut = Rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.NumTelefono= numtelefono;
            this.Edad = edad;
            this.Estatura = estatura;
            this.Peso = peso;
        
        }
        


    }
}