using System.Collections.Generic;
using System.Collections.Specialized;

namespace LocadoraDeCarros.Models.Base
{
    public class BaseModelView
    {
        private string alert;


        public bool TemErro { get; set; }

        public string Alert
        {
            get { return alert; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    TemErro = true;
                    alert = value;
                }
                else
                {
                    TemErro = false;
                    alert = value;
                }
                TemErro = !string.IsNullOrEmpty(value);
            }

        }

        public TipoAlerta Tipo { get; set; }
    }
}