using System.Collections.Generic;

namespace frmInicio.Classes
{
    class Musica
    {
        string Nome { get; set; }
        string Autor { get; set; }
        string Letra { get; set; }

        public Musica()
        {

        }

        public Musica(string Nome, string autor, string Letra)
        {
            this.Nome = Nome;
            this.Autor = autor;
            this.Letra = Letra;
        }

        public List<Musica> CriarUmaPorradaDeMusica()
        {
            List<Musica> musicsReturn = new List<Musica>();

            #region FestaNoAp
            musicsReturn.Add( new Musica("TUDO IGUAL1", "LATINO", 
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê        "+
                                                                "tem birita até o amanhecer        "+
                                                                "                                  "+
                                                                "Chega aí, pode entrar             "+
                                                                "quem ta aqui, tá em casa          "+
                                                                "chega aí, pode entrar             "+
                                                                "quem ta aqui, tá em casa          "+
                                                                "                                  "+
                                                                "Olá, prazer                       "+
                                                                "a noite hum.. é nossa             "+
                                                                "garçom, por favor venha aqui      "+
                                                                "e sirva bem a visita              "+
                                                                "                                  "+
                                                                "Tá bom, tá é bom                  "+
                                                                "aqui ninguém fica só              "+
                                                                "entra aí e toma um drink          "+
                                                                "porque a noite é uma criança      "+
                                                                "                                  "+
                                                                "Hoje é festa lá no meu apê        "+
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê        "+
                                                                "tem birita até o amanhecer        "+
                                                                "                                  "+
                                                                "Hoje é festa lá no meu apê        "+
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê        "+
                                                                "tem birita até o amanhecer        "+
                                                                "                                  "+
                                                                "Tesão                             "+
                                                                "sedução                           "+
                                                                "libido                            "+
                                                                "no ar                             "+
                                                                "no meu quarto tem gente até fazendo orgia" +
                                                                "                                  "+
                                                                "Tá bom, ta é bom                  "+
                                                                "tudo é festa!                     "+
                                                                "pegação                           "+
                                                                "vou zoar o mulherio               "+
                                                                "e a chapa vai esquentar           "+
                                                                "                                  "+
                                                                "Hoje é festa lá no meu apê        "+
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê        "+
                                                                "tem birita até o amanhecer        "+
                                                                "                                  "+
                                                                "Hoje é festa lá no meu apê        "+
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê        "+
                                                                "tem birita até o amanhecer        "+
                                                                "                                  "+
                                                                "Chegaí, pode entrar               "+
                                                                "quem ta aqui tá em casa           "+
                                                                "chegaí, pode entrar               "+
                                                                "quem ta aqui tá em casa           "+
                                                                "chegaí pode entrar                "+
                                                                "quem ta aqui tá em casa           "+
                                                                "                                  "+
                                                                "Hoje é festa lá no meu apê        "+
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê        "+
                                                                "tem birita até o amanhecer        "+
                                                                "                                  "+
                                                                "Hoje é festa lá no meu apê        "+
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê        "+
                                                                "tem birita até o amanhecer        "+
                                                                "                                  "+
                                                                "Hoje é festa lá no meu apê        "+
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê        "+
                                                                "tem birita até o amanhecer        "+
                                                                "                                  "+
                                                                "Hoje é festa lá no meu apê        "+
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê        "+
                                                                "tem birita até o amanhecer        "+
                                                                "                                  "+
                                                                "Hoje é festa lá no meu apê        "+
                                                                "pode aparecer, vai rolar bundalele"+
                                                                "hoje é festa lá no meu apê" +
                                                                "tem birita até o amanhecer"));
            #endregion Fim da festa no ap
            musicsReturn.Add( new Musica("TUDO IGUAL2", "LATINO", "Cátia Catchaça"));
            musicsReturn.Add( new Musica("TUDO IGUAL3", "LATINO", "Meu gol de placa"));
            musicsReturn.Add( new Musica("TUDO IGUAL4", "LATINO", ""));
            musicsReturn.Add( new Musica("TUDO IGUAL5", "LATINO", ""));
            musicsReturn.Add( new Musica("TUDO IGUAL6", "LATINO", ""));
            musicsReturn.Add( new Musica("TUDO IGUAL7", "LATINO", ""));
            musicsReturn.Add( new Musica("TUDO IGUAL8", "LATINO", ""));
            musicsReturn.Add( new Musica("TUDO IGUAL9", "LATINO", ""));

            return musicsReturn;
        }
    }
}
