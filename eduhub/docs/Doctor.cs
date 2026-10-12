using System;
using System.Collections.Generic;
using System.Text;

namespace eduhub.docs;

public class Doctor
{
  
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Specialty { get; private set; }

        private Doctor(string id, string name, string specialty)
        {
            Id = id;
            Name = name;
            Specialty = specialty;
        }

        public static Doctor Create(string id, string name, string specialty)
        {
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(specialty))
                throw new ArgumentException("Thông tin bác sĩ không hợp lệ.");

            return new Doctor(id, name, specialty);
        }
    }
