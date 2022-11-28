using System;
using System.Collections.Generic;
using System.Text;
using ts = Tekla.Structures;
using tsm = Tekla.Structures.Model;

namespace StartUp
{

    class TeklaConnection
    { 
      private static tsm.Model model;
        public static tsm.Model Model
        {
            get
            {
                if (model is null)
                {
                    model = new tsm.Model();
                }
                return model;
            }
        }
    }
}
