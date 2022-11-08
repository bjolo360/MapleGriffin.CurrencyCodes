# MapleGriffin.CurrencyCodes
Simple .Net library providing enums for countries and currencies and methods for getting the official currency for a specific country.
The enum names and numbers match the ISO standard.

## Usage

```csharp

var allCountryCodes = Enum.GetValues(typeof(CountryCode)); // List of country enums
var countryName = CountryCode.SE.Name(); // Sweden
var countryCode = Countries.FromName("Sweden"); // CountryCode.SE = 752

var allCurrencies = Enum.GetValues(typeof(CurrencyCode)); // List of currency enums
var currencyName = CurrencyCode.EUR.Name(); // Euro
var currencyCode = Currencies.FromName("Euro"); // CurrencyCode.EUR = 978

var germanCurrency = CountryCode.DE.Currency(); // CurrencyCode.EUR = 978
var euroCountries = CurrencyCode.EUR.Countries(); // List of euro countries
```
