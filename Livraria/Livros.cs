using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Livros
    {
        private int codigocategoria;
        private int codigoautor;
        private string livro1 = "\n\nTítulo: A gente mira no amor e acerta na solidão\nAno de lançamento: 2022\nEditora: Paidós\nNúmero de páginas: 160\nValor: R$31,66\nDisponíveis: 7\n";
        private string livro2 = "\n\nTítulo: Boa Noite Punpun - Vol. 1\nAno de lançamento: 2022\nEditora: Editora JBC\nNúmero de páginas: 422\nValor: R$37,40\nDisponíveis: 20\n";
        private string livro3 = "\n\nTítulo: Cabeça Fria, Coração Quente\nAno de Lançamento: 2022\nEditora: Garoa Livros\nNúmero de páginas: 408\nValor: R$74,90\nDisponíveis: 10\n";
        private string livro4 = "\n\nTítulo: O Seminário, livro 11: Os quatro conceitos fundamentais da psicanálise\nAno de Lançamento: 1985\nEditora: Zahar\nNúmero de Páginas: 280\nValor: R$50,90\nDisponíveis: 15\n";
        private string livro5 = "\n\nTítulo: Chainsaw Man Vol. 3\nAno de Lançamento: 2022\nEditora: Panini\nNúmero de páginas: 192\nValor: $19,90\nDisponíveis: 20\n";
        private string livro6 = "\n\nTítulo: Galileu e os navegadores da ciência\nAno de lançamento: 2021\nEditora: Record\nNúmero de páginas: 308\nValor: R$32,33\nDisponíveis: 2\n";
        private string saude;
        private string manga;
        private string biografia;


       public int AcessarCodigoAutor
        {
            get
            {

                return codigoautor;

            }
            set
            {

                this.codigoautor = value;

            }
        }// Fim método AcessarCodigoAutor

       public string AcessarBiografia
        {
            get
            {

                return biografia;

            }
            set
            {

                this.biografia = "";

            }
        }// Fim método AcessarBiografia 
        
        public string AcessarManga
        {
            get
            {

                return manga;

            }
            set
            {

                this.manga = "";

            }
        }// Fim método AcessarManga

        public int AcessarCodigoCategoria
        {
            get
            {

                return codigocategoria;

            }
            set
            {

                this.codigocategoria = value;

            }

        }// Fim método AcessarCodigoCategoria

        public string AcessarSaude
        {
            get
            {

                return saude;

            }
            set
            {

                this.saude = "";

            }

        }// Fim método AcessarSaude


        public string AcessarLivro1
        {
            get
            {

                return livro1;

            }

            set
            {

                this.livro1 = "";

            }

        }// Fim método AcessarLivros1

        public string AcessarLivro2
        {
            get
            {

                return livro2;

            }

            set
            {

                this.livro2 = "";

            }

        }// Fim método AcessarLivros2

        public string AcessarLivro3
        {
            get
            {

                return livro3;

            }

            set
            {

                this.livro3 = "";

            }

        }// Fim método AcessarLivros3

        public string AcessarLivro4
        {
            get
            {

                return livro4;

            }
            set
            {

                this.livro4 = "";

            }
        }// Fim método AcessarLivros4

        public string AcessarLivro5
        {
            get
            {

                return livro5;

            }
            set
            {

                this.livro5 = "";

            }
        }// Fim método AcessarLivros5

        public string AcessarLivro6
        {
            get
            {

                return livro6;

            }
            set
            {

                this.livro6 = "";

;           }
        }// Fim método AcessarLivros6

        public string ConsultarLivros()
        {
           



            return "Livro1: "       + AcessarLivro1  +
                   "\nLivro2: "     + AcessarLivro2  +
                   "\nLivro3: "     + AcessarLivro3  +
                   "\nLivro4:"      + AcessarLivro4  +
                   "\nLivro5:"      + AcessarLivro5  +
                   "\nLivro6:"      + AcessarLivro6;


        }// Fim método ConsultarLivros 

        public string Categorias(int codigocategoria)
        {
           
            saude = livro1 +livro4;
            manga = livro2 +livro5;
            biografia = livro3 +livro6;
            AcessarCodigoCategoria = codigocategoria;
            if(AcessarCodigoCategoria == 1)
            {
                return saude;
            }
            if(AcessarCodigoCategoria == 2)
            {
                return manga;
            }
            if (AcessarCodigoCategoria == 3)
            {
                return biografia;
            }
            else
            {
                return "Código inválido";
            }

        }// Fim método Categorias
        
        public string Autor(int codigoautor)
        {   
            AcessarCodigoAutor = codigoautor;
            if(AcessarCodigoAutor == 0)
            {
                return "";
            }
            if(AcessarCodigoAutor == 1)
            {
                return "\nLivros disponíveis desse(a) autor(a):\n"+livro1;
            }
            if(AcessarCodigoAutor == 2)
            {
                return "\nLivros disponíveis desse(a) autor(a):\n"+livro2;
            }
            if(AcessarCodigoAutor == 3)
            {
                return "\nLivros disponíveis desse(a) autor(a):\n"+livro3;
            }
            else
            {
                return "Autor inválido";
            }
        }// Fim método Autor




    }// fim class

}// fim projeto
