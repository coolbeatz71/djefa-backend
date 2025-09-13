namespace Djefa.BuildingBlocks.Constants;

/// <summary>
/// Provides validation constraints and business rules for the permission system
/// used in role-based access control throughout the application.
/// </summary>
public static class PermissionConstants
{
    /// <summary>
    /// Maximum allowed length for permission resource names.
    /// </summary>
    public const int MaxPermissionResourceLength = 15;

    /// <summary>
    /// Maximum allowed length for permission action names.
    /// </summary>
    public const int MaxPermissionActionLength = 15;

    /// <summary>
    /// Maximum allowed length for permission descriptions.
    /// </summary>
    public const int MaxPermissionDescriptionLength = 300;
}
