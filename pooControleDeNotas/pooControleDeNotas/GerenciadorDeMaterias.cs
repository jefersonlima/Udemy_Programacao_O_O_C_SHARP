using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    public class GerenciadorDeMaterias
    {
        public GerenciadorDeMaterias()
        {
            this.Estudante = new Aluno();
            this.materias = new List<Materia>();
        }
        public GerenciadorDeMaterias(String nome, String email)
        {
            this.Estudante = new Aluno(nome, email);
            this.materias = new List<Materia>();
        }
        public Aluno Estudante { get; set; }

        private List<Materia> materias;

        public List<Materia> Materias 
        {
            get
            {
                return this.materias;
            }               
        }

        #region Metodos
        public void CadastrarMaterias(Materia materia)
        {
            try
            {
                materias.Add(materia);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao cadastrat matéria");
            }
        }

        public void ListarMaterias()
        {
            Console.WriteLine("**** Matérias ****");
            for (int i = 0; i < materias.Count; i++)
            {
                Materia m = materias[i];
                m.ExibirDados();
                Console.WriteLine("********");
            }
        }
        #endregion
    }
}
