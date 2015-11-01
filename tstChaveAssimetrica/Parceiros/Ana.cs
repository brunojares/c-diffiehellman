using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tstChaveAssimetrica.Parceiros
{
    public class Ana :Interlocutor
    {
		public override decimal conbinacao1
		{
			get { return 11; }
		}

		public override decimal conbinacao2
		{
			get { return 7; }
		}
			
		protected override decimal chavePrivada
        {
			get {
				return 5;
			}
        }
    }
}
