using RightBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RightBuy.Repositorio.Repositorios
{
    public class Cliente
    {
       public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var usuario = new Usuario();

            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
