using System;
using System.Collections.Generic;
using System.Text;

namespace eduhub.docs;

public class Patient
{
  
    
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }

        private Patient(string id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public static Patient Create(string id, string name, string phone)
        {
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Thông tin bệnh nhân không hợp lệ.");

            return new Patient(id, name, phone);
        }
    }
