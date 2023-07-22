﻿using FitnessTracker.Enums;
using System.Xml.Serialization;

namespace FitnessTracker.Model
{
    [XmlRoot(ElementName = "UserDTO")]
    public class UserModel
    {
        #region Attributes of User
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public CommonStatusEnum Status { get; set; }
        #endregion
    }
}
