
using System.Net.NetworkInformation;

namespace Apartments.Domain.Apartments
{
    public record Currency
    {
        internal static readonly Currency None = new(string.Empty);
        public static readonly Currency Usd = new("USD");
        public static readonly Currency Eur = new("EUR");
        public static readonly Currency Sek = new("SEK");
        private Currency(string code) => code = code;
        
        public string Code { get; init; }

        public static Currency FromCode(string code)
        {
            return All.FirstOrDefault(c => c.Code == code) ??
                throw new ApplicationException($"Currency with code {code} is not supported");
        }

        public static readonly IReadOnlyCollection<Currency> All = new[]
        {
            Usd,
            Eur,
            Sek
        };
    }
}
