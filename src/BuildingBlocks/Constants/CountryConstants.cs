namespace Djefa.BuildingBlocks.Constants;

/// <summary>
/// Provides validation constraints and business rules for country entities
/// used in geographical data management throughout the application.
/// </summary>
public static class CountryConstants
{
    /// <summary>
    /// Maximum allowed length for country names.
    /// </summary>
    public const int MaxNameLength = 100;

    /// <summary>
    /// Maximum allowed length for country flag URLs.
    /// </summary>
    /// <remarks>
    /// The URL is a local file path pointing to the country's flag image.
    /// </remarks>
    public const int MaxFlagUrlLength = 500;

    /// <summary>
    /// Maximum allowed length for country ISO codes.
    /// </summary>
    public const int MaxIsoCodeLength = 3;

    /// <summary>
    /// Maximum allowed length for currency codes.
    /// </summary>
    public const int MaxCurrencyLength = 3;

    /// <summary>
    /// Maximum allowed length for country dial codes.
    /// </summary>
    public const int MaxDialCodeLength = 10;

    /// <summary>
    /// Default active status for new countries.
    /// </summary>
    public const bool DefaultIsActive = true;
}
