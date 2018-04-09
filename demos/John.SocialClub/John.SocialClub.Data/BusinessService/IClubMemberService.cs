// -----------------------------------------------------------------------
// <copyright file="IClubMemberService.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.BusinessService
{
    using System.Data;
    using John.SocialClub.Data.DataModel;

    /// <summary>
    /// Interface IClubMemberService
    /// </summary>
    public interface IClubMemberService
    {
        /// <summary>
        /// Method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        DataRow GetClubMemberById(int Id);

        /// <summary>
        /// Service method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        DataTable GetAllClubMembers();

        /// <summary>
        /// Service method to search records by multiple parameters
        /// </summary>
        /// <param name="occupation">occupation value</param>
        /// <param name="maritalStatus">marital status</param>
        /// <param name="operand">AND OR operand</param>
        /// <returns>Data table</returns>
        DataTable SearchClubMembers(object occupation, object maritalStatus, string operand);       

        /// <summary>
        /// Service method to create new member
        /// </summary>
        /// <param name="clubMember">club member model</param>
        /// <returns>true or false</returns>
        bool RegisterClubMember(ClubMemberModel clubMember);

        /// <summary>
        /// Method to update club member details
        /// </summary>
        /// <param name="clubMember">club member</param>
        /// <returns></returns>
        bool UpdateClubMember(ClubMemberModel clubMember);

        /// <summary>
        /// Method to delete a club member
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>true / false</returns>
        bool DeleteClubMember(int id);
    }
}
