// -----------------------------------------------------------------------
// <copyright file="Scripts.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.Sql
{
    /// <summary>
    /// DBConstants static class contains sql string constants
    /// </summary>
    public static class Scripts
    {
        /// <summary>
        /// Sql to get a club member details by Id
        /// </summary>
        public static readonly string sqlGetClubMemberById = "Select" +
            " Id, Name, DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren" +
            " From ClubMember Where Id = @Id";

        /// <summary>
        /// Sql to get all club members
        /// </summary>
        public static readonly string SqlGetAllClubMembers = "Select" +
            " Id, Name, DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren" +
            " From ClubMember";

        /// <summary>
        /// sql to insert a club member details
        /// </summary>
        public static readonly string SqlInsertClubMember = "Insert Into" +
            " ClubMember(Name, DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren)" +
            " Values(@Name, @DateOfBirth, @Occupation, @MaritalStatus, @HealthStatus, @Salary, @NumberOfChildren)";

        /// <summary>
        /// sql to search for club members
        /// </summary>
        public static readonly string SqlSearchClubMembers = "Select " +
            " Id, Name, DateOfBirth, Occupation, MaritalStatus, HealthStatus, Salary, NumberOfChildren" +
            " From ClubMember Where (@Occupation Is NULL OR @Occupation = Occupation) {0}" +
            " (@MaritalStatus Is NULL OR @MaritalStatus = MaritalStatus)";

        /// <summary>
        /// sql to update club member details
        /// </summary>
        public static readonly string sqlUpdateClubMember = "Update ClubMember " +
            " Set [Name] = @Name, [DateOfBirth] = @DateOfBirth, [Occupation] = @Occupation, [MaritalStatus] = @MaritalStatus, " +
            " [HealthStatus] = @HealthStatus, [Salary] = @Salary, [NumberOfChildren] = @NumberOfChildren Where ([Id] = @Id)";

        /// <summary>
        /// sql to delete a club member record
        /// </summary>
        public static readonly string sqlDeleteClubMember = "Delete From ClubMember Where (Id = @Id)";
    }
}
