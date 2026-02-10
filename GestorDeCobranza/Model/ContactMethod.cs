namespace GestorDeCobranza.Model
{
    public class ContactMethod
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IconClass { get; set; }
        
        public static List<ContactMethod> GetAllMethods() => new()
        {
            new() { Id = "phone", Name = "Llamada Telefónica", IconClass = "fas fa-phone" },
            new() { Id = "whatsapp", Name = "WhatsApp", IconClass = "fab fa-whatsapp" },
            new() { Id = "email", Name = "Email", IconClass = "fas fa-envelope" },
            new() { Id = "sms", Name = "SMS", IconClass = "fas fa-sms" },
            new() { Id = "visit", Name = "Visita Presencial", IconClass = "fas fa-user-check" }
        };
    }
}