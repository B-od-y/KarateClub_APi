﻿namespace Sport_Club_Bussiness.DTOs
{
    public class LoginResponseModel
    {
        public string? Username { get; set; }
        public string? AccessToken { get; set; }
        public int ExpiresIn { get; set; }

        public string? RefreshToken { get; set; }
    }
}
