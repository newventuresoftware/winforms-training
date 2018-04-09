// -----------------------------------------------------------------------
// <copyright file="ClubMemberService.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.BusinessService
{
    using System.Data;
    using John.SocialClub.Data.DataAccess;
    using John.SocialClub.Data.DataModel;

    /// <summary>
    /// class to query the DataAccess, implements IClubMemberService interface
    /// </summary>
    public class ClubMemberService : IClubMemberService
    {
        /// <summary>
        /// interface of ClubMemberAccess
        /// </summary>
        private IClubMemberAccess memberAccess;

        /// <summary>
        /// Initializes a new instance of the ClubMemberService class
        /// </summary>
        public ClubMemberService()
        {
            this.memberAccess = new ClubMemberAccess();
        }

        /// <summary>
        /// Service method to get club member by Id
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>Data row</returns>
        public DataRow GetClubMemberById(int id)
        {
            return this.memberAccess.GetClubMemberById(id);
        }

        /// <summary>
        /// Service method to get all club members
        /// </summary>
        /// <returns>Data table</returns>
        public DataTable GetAllClubMembers()
        {            
            return this.memberAccess.GetAllClubMembers();
        }

        /// <summary>
        /// Service method to search records by multiple parameters
        /// </summary>
        /// <param name="occupation">occupation value</param>
        /// <param name="maritalStatus">marital status</param>
        /// <param name="operand">AND OR operand</param>
        /// <returns>Data table</returns>
        public DataTable SearchClubMembers(object occupation, object maritalStatus, string operand)
        {
            return this.memberAccess.SearchClubMembers(occupation, maritalStatus, operand);
        }        

        /// <summary>
        /// Service method to create new member
        /// </summary>
        /// <param name="clubMember">club member model</param>
        /// <returns>true or false</returns>
        public bool RegisterClubMember(ClubMemberModel clubMember)
        {
            return this.memberAccess.AddClubMember(clubMember);
        }

        /// <summary>
        /// Service method to update club member
        /// </summary>
        /// <param name="clubMember">club member</param>
        /// <returns>true / false</returns>
        public bool UpdateClubMember(ClubMemberModel clubMember)
        {
            return this.memberAccess.UpdateClubMember(clubMember);
        }

        /// <summary>
        /// Method to delete a club member
        /// </summary>
        /// <param name="id">member id</param>
        /// <returns>true / false</returns>
        public bool DeleteClubMember(int id)
        {
            return this.memberAccess.DeleteClubMember(id);
        }
    }
}
