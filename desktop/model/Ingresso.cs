using desktop.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop.model
{
    class Ingresso
    {
        public long codIngresso { get; set; }
        public Lote lote { get; set; }
        public Evento evento { get; set; }
        public String codigoBarras { get; set; }

        public void gerarCodigoBarras()
        {
            Ean13 ean = new Ean13();
            Random random = new Random();
            ean.CountryCode = "12";
            ean.ManufacturerCode = evento.codEvento.ToString().Substring(0,5);
            ean.ProductCode = codIngresso.ToString().Substring(0,5);
            ean.ChecksumDigit = random.Next(1, 9).ToString();
            codigoBarras = (ean.CountryCode + ean.ManufacturerCode + ean.ProductCode + ean.ChecksumDigit);
        }
    }
}
