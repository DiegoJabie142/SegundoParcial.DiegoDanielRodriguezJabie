﻿namespace Entidades
{
    public class Administrador : Usuario
    {
        #region CONSTRUCTOR
        public Administrador(int dni, string nombre, string apellido, string contraseña) : base(dni, nombre, apellido, contraseña, TipoUsuario.Administrador)
        {

        }
        public Administrador()
        {

        }

        #endregion

        public override int DNI { get { return this.dni; } }

        public override string Nombre { get { return this.nombre; } }

        public override string Apellido { get { return this.apellido; } }

        public override string Contraseña { get { return this.contraseña; } }

        public override TipoUsuario IdTipo { get { return this.idTipo; } }
    }
}
