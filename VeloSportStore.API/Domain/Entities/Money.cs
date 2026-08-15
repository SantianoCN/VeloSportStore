namespace VeloSportStore.API.Domain.Entities
{
    public record class Money(decimal Amount, string Currency = "RUB");
}
