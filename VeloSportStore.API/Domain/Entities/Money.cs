namespace VeloSportStore.API.Domain
{
    public record class Money(decimal Amount, string Currency = "RUB");
}
