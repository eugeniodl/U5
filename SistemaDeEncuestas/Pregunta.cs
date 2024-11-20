public class Pregunta
{
    public string Texto { get; set; }
    public TipoRespuesta TipoRespuesta { get; set; }
    public bool Estado { get; set; }
}
public enum TipoRespuesta
{
    Unica,
    Multiple
}
