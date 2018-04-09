// -----------------------------------------------------------------------
// <copyright file="MaritalStatus.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.Enum
{
    using System.ComponentModel;

    /// <summary>
    /// Enumerator for Marital status
    /// </summary>
    public enum MaritalStatus
    {
        /// <summary>
        /// MaritalStatus - Married
        /// </summary>
        [Description("Married")]
        Married = 1,

        /// <summary>
        /// MaritalStatus - Single
        /// </summary>
        [Description("Single")]
        Single
    }
}
