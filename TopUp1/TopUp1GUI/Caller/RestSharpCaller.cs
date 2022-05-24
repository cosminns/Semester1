using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
namespace TopUp1GUI.Caller
{
    public class RestSharpCaller
    {
        public RestClient client;
        public RestSharpCaller(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }
        //requests for MemberController
        public Member GetMemberBySSN(int ssn)
        {
            var request = new RestRequest("member/"+ssn,Method.GET);

            var response = client.Execute<Member>(request);

            return response.Data;
        }
        public bool CreateMember(int SSN, string campusAddress, bool isProfessor)
        {
            var request = new RestRequest("member/?ssn=" + SSN+"&campusAddress="+campusAddress+ "&isProfessor"+isProfessor, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public bool UpdateMember(int ssn, string campusAddress, DateTime joinDate, bool isProfessor, string homeAddress)
        {
            var request = new RestRequest("member/"+ssn+"?campusAddress="+campusAddress+"&joinDate="+joinDate+"isProfessor"+"&homeAddress="+homeAddress, Method.PUT);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        public bool DeleteMember(int ssn)
        {
            var request=new RestRequest("member/"+ssn, Method.DELETE);
            var response=client.Execute<bool>(request);
            return response.Data;
        }

        //Requests for BorrowBookController
        public BorrowBook GetBorrowBookById(string isbn, int volumeNumber, int ssn, DateTime lendDate)
        {
            var request = new RestRequest("borrowBook/"+isbn+"/"+volumeNumber+"/"+ssn+"/"+lendDate, Method.GET);

            var response = client.Execute<BorrowBook>(request);

            return response.Data;
        }
        public bool CreateBorrowBook(int memberSSN, string titleISBN, int volumeNumber)
        {
            var request = new RestRequest("borrowBook/?memberSSN=" + memberSSN+"&titleISBN="+titleISBN+ "&volumeNumber", Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;
        }

        //Requests for  StaffController
        public Staff GetStaffById(int ssn)
        {
            var request = new RestRequest("staff/"+ssn, Method.GET);

            var response = client.Execute<Staff>(request);

            return response.Data;

        }
        public bool CreateStaff(int SSN, int roleID)
        {
            var request = new RestRequest("staff/?ssn=" + SSN+"&roleID="+roleID, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        public bool UpdateStaff(int ssn, int roleID, string homeAddress)
        {
            var request = new RestRequest("staff/"+ssn+"?roleID="+roleID+"&homeAddress="+homeAddress, Method.PUT);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        public bool DeleteStaff(int ssn)
        {
            var request = new RestRequest("staff/"+ssn, Method.DELETE);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        //Requests for TitleController
        public Title GetTitleById(string isbn)
        {
            var request = new RestRequest("title/"+isbn, Method.GET);

            var response = client.Execute<Title>(request);

            return response.Data;

        }
        public bool CreateTitle(string iSBN, string titleDesc, string title, string publisher, string publishingDate, string subjectArea, string titleType, string titleStatus)
        {
            var request = new RestRequest("title/?isbn=" +iSBN+"&titleDesc="+titleDesc+"&publisher"+publisher+"&publishingDate="+publishingDate+"subjectArea"+subjectArea+"titleType"+titleType+"titleStatus"+titleStatus, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        public bool UpdateTitle(string isbn, string titleDesc, string title, string publisher, string publishingDate, string subjectArea, string titleType, string titleStatus)
        {
            var request = new RestRequest("title/"+isbn+"?titleDesc="+titleDesc+"&publisher"+publisher+"&publishingDate="+publishingDate+"subjectArea"+subjectArea+"titleType"+titleType+"titleStatus"+titleStatus, Method.PUT);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        public bool DeleteTitle(string isbn)
        {
            var request = new RestRequest("title/"+isbn, Method.DELETE);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        //Requests for Volume Controller
        public Volume GetVolumeById(string titleISBN, int volumeNumber)
        {
            var request = new RestRequest("volume/"+titleISBN+"/volumeNumber"+volumeNumber, Method.GET);

            var response = client.Execute<Volume>(request);

            return response.Data;

        }
        public bool CreateVolume(string titleISBN, int volumeNumber, byte borrowed)
        {
            var request = new RestRequest("volume/?titleISBN=" +titleISBN+"&volumeNumber="+volumeNumber+"&borrowed"+borrowed, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        public bool UpdateVolume(string titleISBN, int volumeNumber, byte borrowed)
        {
            var request = new RestRequest("volume/"+titleISBN+"?volumeNumber="+volumeNumber+"&borrowed"+borrowed, Method.PUT);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        public bool DeleteVolume(string titleISBN, int volumeNumber)
        {
            var request = new RestRequest("volume/"+titleISBN+"volumeNumber"+volumeNumber, Method.DELETE);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
    }
}
