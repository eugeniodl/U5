public class Pregunta
{
    public string Texto {  get; set; }
    public TipoRespuesta TipoRespuesta { get; set; }
    public bool Estado { get; set; } // Si la pregunta fue respondida
    public int Ponderacion { get; set; } // Valor ajustable con el TrackBar
}

public enum TipoRespuesta
{
    Unica,
    Multiple
}