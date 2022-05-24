using System.Data;
using System.Data.SqlClient;
using TopUp1.DAL.Interfaces;

namespace TopUp1.DAL
{
    public class MemberDAO : IDAO<Member>
    {
        public static readonly string connectionString = "Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;";
        public bool Create(Member member)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertMember", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", member.SSN));
                cmd.Parameters.Add(new SqlParameter("@CampusAddress", member.CampusAddress));
                cmd.Parameters.Add(new SqlParameter("@JoinDate", DateTime.Today));
                cmd.Parameters.Add(new SqlParameter("@IsProfessor", member.IsProfessor));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        public bool Delete(Member member)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prDeleteMember", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", member.SSN));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        public Member GetById(Member m)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetMemberInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", m.SSN));
                SqlDataReader rdr;
                // execute the command
                rdr = cmd.ExecuteReader();
                Member member = new Member();
                while (rdr.Read())
                {
                    member.SSN = (int)rdr["SSN"];
                    member.Name = (string)rdr["Name"];
                    member.HomeAddress = (string)rdr["HomeAddress"];
                    member.BirthDate = ((DateTime)rdr["DoB"]).ToShortDateString();
                    member.CampusAddress = (string)rdr["CampusAddress"];
                    member.JoinDate = ((DateTime)rdr["JoinDate"]).ToShortDateString();
                    member.IsProfessor = (bool)rdr["IsProfessor"];
                }
                rdr.Close();

                //create a command to get the phone numbers and add them to the member

                cmd = new SqlCommand("prGetPersonPhoneNumbers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SSN", m.SSN));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    member.PhoneNumbers.Add((string)rdr["PhoneNumber"]);
                }
                rdr.Close();

                //create a command to get the card and add it to the member

                cmd = new SqlCommand("prGetMemberCard", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SSN", m.SSN));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Card card = new Card();
                    card.CardNumber = (int)rdr["CardNumber"];
                    card.ExpiryDate = ((DateTime)rdr["ExpiryDate"]).ToShortDateString();
                    card.Photo = (string)rdr["Photo"];
                    member.Card = card;
                }
                rdr.Close();

                return member;
            }
        }

        public bool Update(Member member)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prUpdateMember", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", member.SSN));
                cmd.Parameters.Add(new SqlParameter("@CampusAddress", member.CampusAddress));
                cmd.Parameters.Add(new SqlParameter("@JoinDate", member.JoinDate));
                cmd.Parameters.Add(new SqlParameter("@IsProfessor", member.IsProfessor));
                cmd.Parameters.Add(new SqlParameter("@HomeAddress", member.HomeAddress));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}