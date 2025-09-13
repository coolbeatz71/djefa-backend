namespace Djefa.BuildingBlocks.Constants;

/// <summary>
/// Provides a centralized collection of API route constants, serving as a single source of truth for endpoint paths.
/// This ensures consistency across the application, reduces duplication, and simplifies future maintenance.
/// </summary>
public static class RouteConstants
{
    public static class V1
    {
        private const string BaseUrl = "/api/v1";

        /// <summary>
        /// Contains administrative API routes (users, roles, authentication).
        /// </summary>
        public static class Admin
        {
            /// <summary>
            /// Route for managing users (create, update, delete, list).
            /// </summary>
            public const string Users = $"{BaseUrl}/admin/users";

            /// <summary>
            /// Route for managing roles and permissions.
            /// </summary>
            public const string Roles = $"{BaseUrl}/admin/roles";

            /// <summary>
            /// Route for administrative authentication (i.e., login, forgot-password, etc.).
            /// </summary>
            public const string Auth = $"{BaseUrl}/admin/auth";
        }

        /// <summary>
        /// Contains provider-specific API routes for service providers.
        /// </summary>
        public static class Provider
        {
            private const string Base = $"{BaseUrl}/provider";

            /// <summary>
            /// Route for provider authentication (login, register).
            /// </summary>
            public const string Auth = $"{Base}/auth";

            /// <summary>
            /// Route for accessing and updating provider profiles.
            /// </summary>
            public const string Profile = $"{Base}/profile";
        }

        /// <summary>
        /// Contains customer-specific API routes for end users.
        /// </summary>
        public static class Customer
        {
            private const string Base = $"{BaseUrl}/customer";

            /// <summary>
            /// Route for customer authentication (login, register).
            /// </summary>
            public const string Auth = $"{Base}/auth";

            /// <summary>
            /// Route for accessing and updating customer profiles.
            /// </summary>
            public const string Profile = $"{Base}/profile";
        }
    }
}
