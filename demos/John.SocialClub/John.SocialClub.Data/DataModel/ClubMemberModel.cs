// -----------------------------------------------------------------------
// <copyright file="ClubMemberModel.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.DataModel
{
    using System;
    using John.SocialClub.Data.Enum;

    /// <summary>
    /// Member model
    /// </summary>
    public class ClubMemberModel
    {
        /// <summary>
        /// Gets or sets member id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets member name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets occupation
        /// </summary>
        public Occupation Occupation { get; set; }
            
        /// <summary>
        /// Gets or sets marital status
        /// </summary>
        public MaritalStatus MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets health status
        /// </summary>
        public HealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Gets or sets salary
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Gets or sets number of children
        /// </summary>
        public int NumberOfChildren { get; set; }
    }
}
