using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Agenda
    {
        private List<Contato> contatos = new List<Contato>();

        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }

        public void EditarContato(string nome, Contato novoContato)
        {
            Contato contatoExistente = contatos.Find(c=> c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contatoExistente != null)
            {
                contatoExistente.Nome = novoContato.Nome;
                contatoExistente.Telefone = novoContato.Telefone;
                contatoExistente.Email = novoContato.Email;
            }
        }

        public void ExcluirContato(string nome)
        {
            Contato contatoExistente = contatos.Find(c  => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contatoExistente != null)
            {
                contatos.Remove(contatoExistente);
            }
        }

        public void visualizarContatos()
        {
            foreach  (var contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome},  Telefone: {contato.Telefone}, Email: {contato.Email}");
            }
        }
    }
