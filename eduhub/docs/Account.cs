using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace eduhub.docs
{
        public class Account
        {
        
            public string Id { get; private set; }
            public string Username { get; private set; }
            public string Password { get; private set; }
            public string Role { get; private set; }

            private Account(string id, string username,
                            string password, string role)
            {
                Id = id;
                Username = username;
                Password = password;
                Role = role;
            }

            public static Account Create(string id, string username,
                                         string password, string role)
            {
                if (string.IsNullOrWhiteSpace(id) ||
                    string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(role))
                    throw new ArgumentException("Thông tin tài khoản không hợp lệ.");

                return new Account(id, username, password, role);
            }
        }
    }