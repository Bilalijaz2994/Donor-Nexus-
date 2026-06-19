namespace DonorNexus.Models
{
    public class LoginResult
    {
        public bool IsSuccess { get; set; }

        public int DonorID { get; set; }

        public string Role { get; set; }

        public LoginResult(
            bool isSuccess,
            int donorID,
            string role)
        {
            IsSuccess = isSuccess;
            DonorID = donorID;
            Role = role;
        }
    }
}
