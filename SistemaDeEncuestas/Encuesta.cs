public class Encuesta
{
    List<SeccionEncuesta> Secciones { get; set; }

    public Encuesta()
    {
        Secciones = new List<SeccionEncuesta>
        {
            new SeccionEncuesta
            {
                Nombre = "Demografía",
                Preguntas = new List<Pregunta>
                {
                    new Pregunta
                    {
                        Texto = "¿Cuál es su país de residencia?",
                        TipoRespuesta = TipoRespuesta.Unica,
                        Estado = false,
                    }
                }
            }
        };
    }
}

