using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosenTrabADV2
{
    public class Estudante
    {
        // Atributos
        private string nome;
        private int idade;
        private double nota;
        private string curso;
        private int ConhecimentoGerais = 0;
        public Dictionary<string, int> ConhecimentoMaterias = new Dictionary<string, int>();

        // Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        // Métodos
        public void Estudar()
        {
            ConhecimentoGerais++; // Incrementa o conhecimento geral
            Console.WriteLine("Conhecimento Gerais agora é " + ConhecimentoGerais);
        }

        // Sobrecarga do método Estudar
        public void Estudar(string materia)
        {
            materia = materia.ToUpper(); // Converte a matéria para maiúsculas
            if (!ConhecimentoMaterias.ContainsKey(materia))
            {
                ConhecimentoMaterias[materia] = 0;
            }
            ConhecimentoMaterias[materia]++;
            Console.WriteLine("Conhecimento em " + materia + " agora é " + ConhecimentoMaterias[materia]);
        }

        public void FazerExame()
        {
            // Cálculo da nota para Conhecimento Geral
            double notaConhecimentoGeral = 0 + ConhecimentoGerais;
            Console.WriteLine("Nota Conhecimento Geral: " + notaConhecimentoGeral);

            // Cálculo da nota para cada matéria
            foreach (var materia in ConhecimentoMaterias.Keys)
            {
                double notaMateria = 0 + ConhecimentoGerais * 0.5 + ConhecimentoMaterias[materia];
                Console.WriteLine("Nota " + materia + ": " + notaMateria);
            }
        }
    }
}

