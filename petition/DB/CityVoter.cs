using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class CityVoter
    {
        public string LVoterUniqueId { get; set; }
        public string SAffNumber { get; set; }
        public string SzStateVoterId { get; set; }
        public string SVoterTitle { get; set; }
        public string SzNameLast { get; set; }
        public string SzNameFirst { get; set; }
        public string SzNameMiddle { get; set; }
        public string SNameSuffix { get; set; }
        public string SGender { get; set; }
        public string SzSitusAddress { get; set; }
        public string SzSitusCity { get; set; }
        public string SSitusState { get; set; }
        public string SSitusZip { get; set; }
        public string SHouseNum { get; set; }
        public string SUnitAbbr { get; set; }
        public string SUnitNum { get; set; }
        public string SzStreetName { get; set; }
        public string SStreetSuffix { get; set; }
        public string SPreDir { get; set; }
        public string SPostDir { get; set; }
        public string SzMailAddress1 { get; set; }
        public string SzMailAddress2 { get; set; }
        public string SzMailAddress3 { get; set; }
        public string SzMailAddress4 { get; set; }
        public string SzMailZip { get; set; }
        public string SzPhone { get; set; }
        public string SzEmailAddress { get; set; }
        public string DtBirthDate { get; set; }
        public string SBirthPlace { get; set; }
        public string DtRegDate { get; set; }
        public string DtOrigRegDate { get; set; }
        public string DtLastUpdateDt { get; set; }
        public string SStatusCode { get; set; }
        public string SzStatusReasonDesc { get; set; }
        public string SUserCode1 { get; set; }
        public string SUserCode2 { get; set; }
        public string IDuplicateIdflag { get; set; }
        public string SzLanguageName { get; set; }
        public string SzPartyName { get; set; }
        public string SzAvstatusAbbr { get; set; }
        public string SzAvstatusDesc { get; set; }
        public string SzPrecinctName { get; set; }
        public string SPrecinctId { get; set; }
        public string SPrecinctPortion { get; set; }
        public string SDistrictId0 { get; set; }
        public string ISubDistrict0 { get; set; }
        public string SzDistrictName0 { get; set; }
        public string SDistrictId1 { get; set; }
        public string ISubDistrict1 { get; set; }
        public string SzDistrictName1 { get; set; }
        public string SDistrictId2 { get; set; }
        public string ISubDistrict2 { get; set; }
        public string SzDistrictName2 { get; set; }
        public string SDistrictId3 { get; set; }
        public string ISubDistrict3 { get; set; }
        public string SzDistrictName3 { get; set; }
        public string SDistrictId4 { get; set; }
        public string ISubDistrict4 { get; set; }
        public string SzDistrictName4 { get; set; }
        public string SDistrictId5 { get; set; }
        public string ISubDistrict5 { get; set; }
        public string SzDistrictName5 { get; set; }
    }
}
