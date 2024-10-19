using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdvinhacao
{
    public class NovaPergunta:PerguntaJogo
    {
        public NovaPergunta():base()
        {
            this.Dica = "";
        }

        public NovaPergunta(String pergunta,String resposta,String dica):base(pergunta,resposta)
        {
            this.Dica = dica;
            //base.Pergunta = pergunta;
        }

        private String dica;

		public String Dica
		{
			get { return dica; }
			set { dica = value.ToUpper(); }
		}

	}
}
