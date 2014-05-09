using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploDevmedia.Models
{
    public class ClienteRepositorio
    {
        private IList<Cliente> clientes;

        public ClienteRepositorio()
        {
            clientes = new List<Cliente>();
            clientes.Add(new Cliente()
            {
                Id = 1,
                Idade = 18,
                Nome = "Maria"

            });

            clientes.Add(new Cliente()
            {
                Id = 2,
                Idade = 25,
                Nome = "Pedro"

            }); 

            clientes.Add(new Cliente()
            {
                Id = 3,
                Idade = 19,
                Nome = "Ana"

            });
        }

        public void inserir(Cliente cliente)
        {
            if (clientes.Where(c => c.Id == cliente.Id).Count() == 0)
            {
                clientes.Add(cliente);
            }
            else
            {
                throw new Exception("Cliente já Existente!");
            }
        }

        public void alterar(Cliente cliente)
        {
            clientes.Where(cli => cli.Id == cliente.Id).First().Idade = cliente.Idade;
            clientes.Where(cli => cli.Id == cliente.Id).First().Nome = cliente.Nome;
        }

        public void excluir(Cliente cliente)
        {
            clientes.Remove(cliente);
        }

        public IList<Cliente> RetornarTodos()
        {
            return clientes;
        }

        public Cliente RetornarPorID(int id)
        {
            return clientes.Where(cli => cli.Id == id).FirstOrDefault();
        }

    }
}