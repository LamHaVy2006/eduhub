using System;
using System.Collections.Generic;
using System.Text;

namespace eduhub.docs;

public class Appointment
{
    
        public string Id { get; private set; }
        public string PatientId { get; private set; }
        public string DoctorId { get; private set; }
        public DateTime Time { get; private set; }

        private Appointment(string id, string patientId,
                            string doctorId, DateTime time)
        {
            Id = id;
            PatientId = patientId;
            DoctorId = doctorId;
            Time = time;
        }

        public static Appointment Create(string id, string patientId,
                                         string doctorId, DateTime time)
        {
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(patientId) ||
                string.IsNullOrWhiteSpace(doctorId))
                throw new ArgumentException("Thông tin lịch hẹn không hợp lệ.");

            if (time <= DateTime.Now)
                throw new ArgumentException("Thời gian phải ở tương lai.");

            return new Appointment(id, patientId, doctorId, time);
        }
    }
