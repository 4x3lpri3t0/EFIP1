using System.Linq;

namespace EFIP1.Models
{
    public enum FormaPago
    {
        Efectivo = 1,
        Cheque = 2,
        TransferenciaBancaria = 3,
        TarjetaCredito = 4,
        TarjetaDebito = 5,
        PagoOnline = 6
    }
}