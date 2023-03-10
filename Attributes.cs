using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JawTek.Web
{
    /// <summary>
    /// Apply to a WebApp method to only allow access if Request.IsAuthenticated
    /// </summary>
    [global::System.AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class WebAppLoginRequiredAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public WebAppLoginRequiredAttribute()
        {
        }
    }

    [global::System.AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class WebAppRoleRequiredAttribute : Attribute
    {
        readonly string role;

        public WebAppRoleRequiredAttribute(string role)
        {
            this.role = role;
        }

        public string Role { get { return this.role; } }
    }
}
