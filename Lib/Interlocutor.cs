using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public abstract class Interlocutor
    {
		public abstract decimal conbinacao1 { get; }
		public abstract decimal conbinacao2 { get; }
		public decimal chavePublica
        {
			get {
				var _potencia = eleva (this.conbinacao1, this.chavePrivada);
				return _potencia % this.conbinacao2; 
			}
        }
		protected abstract decimal chavePrivada { get; }

		public decimal calculaChaveSimetrica(Interlocutor parceiro)
        {
            if(
                (this.conbinacao1 != parceiro.conbinacao1) ||
                (this.conbinacao2 != parceiro.conbinacao2)
            ){
                throw new InvalidOperationException("Valores das combinações não batem com as do parceiro");
            }      
			var _potencia = eleva (parceiro.chavePublica, this.chavePrivada);
			return _potencia % parceiro.conbinacao2;
        }

		private decimal eleva(decimal @base, decimal expoente){
			try {
				decimal _retrono = 1;
				for (int i = 0; i < expoente; i++)
					_retrono *= @base;
				return _retrono;
			} catch (OverflowException) {
				throw new OverflowException ("Exponenciação excede o limite");
			}
		}
    }
}
