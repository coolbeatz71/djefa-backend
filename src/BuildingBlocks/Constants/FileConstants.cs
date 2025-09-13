namespace Djefa.BuildingBlocks.Constants;

/// <summary>
/// Provides file-related constants including maximum field lengths for file names,
/// MIME types, storage URLs, and default values used for file entity validation
/// and business logic throughout application.
/// </summary>
public static class FileConstants
{
    /// <summary>
    /// Maximum allowed length for file names.
    /// </summary>
    public const int MaxNameLength = 255;

    /// <summary>
    /// Maximum allowed length for original file names.
    /// </summary>
    public const int MaxOriginalNameLength = 255;

    /// <summary>
    /// Maximum allowed length for MIME type strings.
    /// </summary>
    public const int MaxMimeTypeLength = 100;

    /// <summary>
    /// Maximum allowed length for storage URLs.
    /// </summary>
    public const int MaxStorageUrlLength = 2048;

    /// <summary>
    /// Default deletion status for new files.
    /// </summary>
    public const bool DefaultIsDeleted = false;
}
