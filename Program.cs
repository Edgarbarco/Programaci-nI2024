using System;
public interface INotificable
{
    // Método para enviar notificaciones
    void Notificar(string mensaje);
}

// Notificación por correo electrónico
public class NotificacionEmail : INotificable
{
    // Atributo específico para esta implementación
    private string direccionCorreo;

    // Constructor que recibe la dirección de correo electrónico
    public NotificacionEmail(string correo)
    {
        direccionCorreo = correo;
    }

    // Notificar para enviar correo electrónico
    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando correo electrónico a {direccionCorreo}: {mensaje}");
    }
}

// Notificación por WhatsApp
public class NotificacionWhatsapp : INotificable
{
    // Atributo específico para esta implementación
    private string numeroTelefono;

    // Constructor que recibe el número de teléfono
    public NotificacionWhatsapp(string numero)
    {
        numeroTelefono = numero;
    }

    // Notificar para enviar mensaje por WhatsApp
    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje por WhatsApp al número {numeroTelefono}: {mensaje}");
    }
}

// Notificación por SMS
public class NotificacionSMS : INotificable
{
    // Atributo específico para esta implementación
    private string numeroTelefono;

    // Constructor que recibe el número de teléfono
    public NotificacionSMS(string numero)
    {
        numeroTelefono = numero;
    }

    // Notificar para enviar mensaje por SMS
    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando SMS al número {numeroTelefono}: {mensaje}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de cada una de las implementaciones
        NotificacionEmail emailNotificacion = new NotificacionEmail("prueba2@gmail.com");
        NotificacionWhatsapp whatsappNotificacion = new NotificacionWhatsapp("+554123891");
        NotificacionSMS smsNotificacion = new NotificacionSMS("554123891");

        // Ejemplo de uso: enviar notificaciones
        emailNotificacion.Notificar("¡Hola! Esto es un correo de prueba.");
        whatsappNotificacion.Notificar("¡Hola! Esto es un mensaje de prueba.");
        smsNotificacion.Notificar("¡Hola! Esto es un SMS de prueba.");
    }
}
