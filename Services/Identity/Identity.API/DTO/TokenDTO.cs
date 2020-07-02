﻿using System;

namespace Identity.API.DTO
{
    /// <summary>
    /// User authentication token DTO.
    /// </summary>
    public class TokenDTO
    {
        /// <summary>
        /// Account Identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// User role in application.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Authentication token.
        /// </summary>
        public string Token { get; set; }
    }
}