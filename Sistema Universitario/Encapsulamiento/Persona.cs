using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
   public class Persona
    {
       public Persona()
       {

       }
       public Persona(int idPersona,string dni, string nombre,string apellidos,string email,
           string telefono,Boolean sexo,string direccion,byte edad,Boolean estadoCivil,DateTime fechaNacimiento)
       {
           this.idPersona = idPersona;
           this.dni = dni;
           this.nombre = nombre;
           this.apellidos = apellidos;
           this.email = email;
           this.telefono = telefono;
           this.sexo = sexo;
           this.direccion = direccion;
           this.edad = edad;
           this.estadoCivil = estadoCivil;
           this.fechaNacimiento = fechaNacimiento;
       }

       private int idPersona;

       public int IdPersona
       {
           get { return idPersona; }
           set { idPersona = value; }
       }
       private string dni;

       public string Dni
       {
           get { return dni; }
           set { dni = value; }
       }
       private string nombre;

       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }
       private string apellidos;

       public string Apellidos
       {
           get { return apellidos; }
           set { apellidos = value; }
       }
       private string email;

       public string Email
       {
           get { return email; }
           set { email = value; }
       }
       private string telefono;

       public string Telefono
       {
           get { return telefono; }
           set { telefono = value; }
       }
       private Boolean sexo;

       public Boolean Sexo
       {
           get { return sexo; }
           set { sexo = value; }
       }
       private string direccion;

       public string Direccion
       {
           get { return direccion; }
           set { direccion = value; }
       }
       private byte edad;

       public byte Edad
       {
           get { return edad; }
           set { edad = value; }
       }
       private Boolean estadoCivil;

       public Boolean EstadoCivil
       {
           get { return estadoCivil; }
           set { estadoCivil = value; }
       }
       private DateTime fechaNacimiento;

       public DateTime FechaNacimiento
       {
           get { return fechaNacimiento; }
           set { fechaNacimiento = value; }
       }

    }
}
