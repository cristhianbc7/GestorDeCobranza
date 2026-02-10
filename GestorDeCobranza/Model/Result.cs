using System;

namespace GestorDeCobranza.Model
{
    public class Result
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IconClass { get; set; }

        public static List<Result> GetAllResults() => new()
        {
          new() { Id="success", Name="Contacto Exitoso", IconClass="fas fa-check-circle" },
          new() { Id="no anwser", Name="Sin Respuesta", IconClass="fas fa-phone-slash" },
          new() { Id="promise", Name="Promesa de Pago", IconClass="fas fa-handshake" },
          new() { Id="rejected", Name="Rechazó Pagar", IconClass="fas fa-times-circle" },
          new() { Id="wrong number", Name="Número Incorrecto", IconClass="fas fa-exclamation-triangle" },
          new() { Id="extension", Name="Solicitó Extensión", IconClass="fas fa-calendar-plus" },
          new() { Id="quarrel", Name="En Disputa", IconClass="fas fa-gavel" }
        };
    }
}
