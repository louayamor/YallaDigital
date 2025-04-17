using YallaDigital.Models.Enum;

namespace YallaDigital.Extensions
{
    public static class RoleExtensions
    {
        public static string ToString(this RoleTypes role)
        {
            return role switch
            {
                RoleTypes.Admin => "Admin",
                RoleTypes.Client => "Client",
                _ => "Client" 
            };
        }

        public static RoleTypes ToRoleType(this string role)
        {
            return role switch
            {
                "Admin" => RoleTypes.Admin,
                "Client" => RoleTypes.Client,
                _ => RoleTypes.Client 
            };
        }
    }
}