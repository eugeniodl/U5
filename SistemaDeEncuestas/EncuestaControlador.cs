public class EncuestaControlador
{
    public List<SeccionEncuesta> Secciones {  get; set; }

    public EncuestaControlador()
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
                        Estado = false
                    },
                    new Pregunta {
                        Texto = "¿En qué rango de edad se encuentra?",
                        TipoRespuesta = TipoRespuesta.Unica, 
                        Estado = false 
                    }
                }
            }
        };
    }
}

