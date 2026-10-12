using System;
using System.Collections.Generic;
using System.Text;

namespace eduhub.docs
{
    public class MedicalRecord
    {
          public string Id { get; private set; }
            public string PatientId { get; private set; }
            public string Diagnosis { get; private set; }
            public string Treatment { get; private set; }

            private MedicalRecord(string id, string patientId,
                                  string diagnosis, string treatment)
            {
                Id = id;
                PatientId = patientId;
                Diagnosis = diagnosis;
                Treatment = treatment;
            }

            public static MedicalRecord Create(string id, string patientId,
                                               string diagnosis, string treatment)
            {
                if (string.IsNullOrWhiteSpace(id) ||
                    string.IsNullOrWhiteSpace(patientId) ||
                    string.IsNullOrWhiteSpace(diagnosis) ||
                    string.IsNullOrWhiteSpace(treatment))
                    throw new ArgumentException("Thông tin hồ sơ không hợp lệ.");

                return new MedicalRecord(id, patientId, diagnosis, treatment);
            }
        }
    }
