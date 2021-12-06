namespace BeboerWeb.Mvc.Authorization.Constants
{
    public static class Policies
    {
        public static readonly string EmployeeOnly = "EmployeeOnly";
        public static readonly string ActiveTenantOnly = "ActiveTenantOnly";
        public static readonly string InActiveTenantOnly = "InActiveTenantOnly";
    }
}
