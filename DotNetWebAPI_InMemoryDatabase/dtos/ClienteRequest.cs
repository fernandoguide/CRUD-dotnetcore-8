namespace DotNetWebAPI_InMemoryDatabase.dtos
{
    public record ClienteRequest(string Nome, string? Mensagem, string? Telefone, string? Email);
}