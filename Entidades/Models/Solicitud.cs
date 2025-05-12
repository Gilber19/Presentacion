namespace Entidades.Models;
public class Solicitud
{
    public int Id { get; set; }
    public string NombreEvento { get; set; }
    public DateTime FechaSalida { get; set; }
    public DateTime FechaRegreso { get; set; }
    public float Costo { get; set; }
    public string Lugar { get; set; }
    public byte[] ReporteFinal { get; set; }
    public byte[] OficioSellado { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

}

