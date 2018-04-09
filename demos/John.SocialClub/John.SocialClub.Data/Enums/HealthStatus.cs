// -----------------------------------------------------------------------
// <copyright file="HealthStatus.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.Enum
{
    using System.ComponentModel;

    /// <summary>
    /// Enumerator for Health status
    /// </summary>
    public enum HealthStatus
    {
        /// <summary>
        /// HealthStatus - Excellent
        /// </summary>
        [Description("Excellent")]
        Excellent = 1,

        /// <summary>
        /// HealthStatus - Good
        /// </summary>
        [Description("Good")]
        Good,

        /// <summary>
        /// HealthStatus - Average
        /// </summary>
        [Description("Average")]
        Average,

        /// <summary>
        /// HealthStatus - Poor
        /// </summary>
        [Description("Poor")]
        Poor
    }
}
