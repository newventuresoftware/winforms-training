// -----------------------------------------------------------------------
// <copyright file="ConnectionAccess.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.DataAccess
{
    using System.Configuration;

    /// <summary>
    /// ConnectionAccess class
    /// </summary>
    public abstract class ConnectionAccess
    {
        /// <summary>
        /// Gets connection string
        /// </summary>
        protected string ConnectionString
        {
            get 
            { 
                return ConfigurationManager
                    .ConnectionStrings["SocialClubDBConnection"]
                    .ToString(); 
            }
        }
    }
}
