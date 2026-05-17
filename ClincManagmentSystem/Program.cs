using System;

namespace ClincManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Region 1 — System Storage: all variable declarations 

            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;

            // Patient 
            string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;
            string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;
            string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;
            int patientCount = 0;

            // Doctor 
            string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;
            string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;
            int doctorCount = 0;

            // Appointment 
            string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status = ""; bool a1Active = false;
            string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status = ""; bool a2Active = false;
            string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status = ""; bool a3Active = false;
            int appointmentCount = 0;

            // ── REGION 2: Main Menu ───
            while (true)
            {
                Console.Clear();

                Console.WriteLine("=====CLINIC MANAGEMENT SYSTEM=====");
                Console.WriteLine("1) Patient Management");
                Console.WriteLine("2) Doctor Management  ");
                Console.WriteLine("3) Appointment Management ");
                Console.WriteLine("0) Exit");
                Console.Write("Enter your choice: ");

                int mainMenu = int.Parse(Console.ReadLine());

                switch (mainMenu)
                {
                    case 1:// for patients
                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("===== PATIENT MANAGEMENT=====");
                            Console.WriteLine("1) Add New Patient  ");
                            Console.WriteLine("2) Display All Patients  ");
                            Console.WriteLine("3) Update Patient Phone");
                            Console.WriteLine("4) Delete Patient   ");
                            Console.WriteLine("0) Back to Main Menu ");

                            Console.Write("Enter your choice: ");

                            int patientChoice = int.Parse(Console.ReadLine());

                            switch (patientChoice)
                            {
                                case 1:
                                    // Add new patient 
                                    if (patientCount == MAX_PATIENTS)
                                    {
                                        Console.WriteLine("Clinic is full. Cannot add more patients.");
                                    }
                                    else
                                    {
                                        Console.Write("Enter patient name: ");
                                        string name = Console.ReadLine();

                                        // name of patient
                                        if (name == "")
                                        {
                                            Console.WriteLine("Patient name cannot be empty.");
                                        }
                                        else
                                        {
                                            //age of patient
                                            Console.Write("Enter patient age: ");
                                            int age = int.Parse(Console.ReadLine());

                                            if (age < 1 || age > 120)
                                            {
                                                Console.WriteLine("Invalid age.");
                                            }
                                            else
                                            //phone of patient
                                            {
                                                Console.Write("Enter patient phone: ");
                                                string phone = Console.ReadLine();

                                                if (!p1Active)
                                                {
                                                    p1Name = name;
                                                    p1Age = age;
                                                    p1Phone = phone;
                                                    p1Active = true;
                                                }
                                                else if (!p2Active)
                                                {
                                                    p2Name = name;
                                                    p2Age = age;
                                                    p2Phone = phone;
                                                    p2Active = true;
                                                }
                                                else if (!p3Active)
                                                {
                                                    p3Name = name;
                                                    p3Age = age;
                                                    p3Phone = phone;
                                                    p3Active = true;
                                                }

                                                patientCount++;
                                                Console.WriteLine("Patient added successfully.");
                                            }
                                        }
                                    }

                                    Console.WriteLine("Press Enter to continue");
                                    Console.ReadLine();
                                    break;

                                case 2:
                                    // Display all patients 
                                    if (patientCount == 0)
                                    {
                                        Console.WriteLine("No patients registered.");
                                    }
                                    else
                                    {
                                        int displayNum = 1;

                                        Console.WriteLine("===PATIENTS===");

                                        if (p1Active)
                                        {
                                            Console.WriteLine("Patient #" + displayNum);
                                            Console.WriteLine("Name  : " + p1Name);
                                            Console.WriteLine("Age   : " + p1Age);
                                            Console.WriteLine("Phone : " + p1Phone);

                                            displayNum++;
                                        }

                                        if (p2Active)
                                        {
                                            Console.WriteLine("Patient #" + displayNum);
                                            Console.WriteLine("Name  : " + p2Name);
                                            Console.WriteLine("Age   : " + p2Age);
                                            Console.WriteLine("Phone : " + p2Phone);

                                            displayNum++;
                                        }

                                        if (p3Active)
                                        {
                                            Console.WriteLine("Patient #" + displayNum);
                                            Console.WriteLine("Name  : " + p3Name);
                                            Console.WriteLine("Age   : " + p3Age);
                                            Console.WriteLine("Phone : " + p3Phone);

                                            displayNum++;
                                        }
                                    }

                                    Console.WriteLine("Press Enter to continue");
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    // Update patient phone 
                                    Console.Write("Enter patient name: ");
                                    string updatePatientName = Console.ReadLine();

                                    if (p1Active && p1Name == updatePatientName)
                                    {
                                        Console.Write("Enter new phone: ");
                                        p1Phone = Console.ReadLine();
                                        Console.WriteLine("Updated.");
                                    }
                                    else if (p2Active && p2Name == updatePatientName)
                                    {
                                        Console.Write("Enter new phone: ");
                                        p2Phone = Console.ReadLine();
                                        Console.WriteLine("Updated.");
                                    }
                                    else if (p3Active && p3Name == updatePatientName)
                                    {
                                        Console.Write("Enter new phone: ");
                                        p3Phone = Console.ReadLine();
                                        Console.WriteLine("Updated.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;

                                case 4:
                                    // Delete patient operation
                                    Console.Write("Enter patient name: ");
                                    string deletePatientName = Console.ReadLine();

                                    if (p1Active && p1Name == deletePatientName)
                                    {
                                        p1Name = "";
                                        p1Age = 0;
                                        p1Phone = "";
                                        p1Active = false;
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else if (p2Active && p2Name == deletePatientName)
                                    {
                                        p2Name = "";
                                        p2Age = 0;
                                        p2Phone = "";
                                        p2Active = false;
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else if (p3Active && p3Name == deletePatientName)
                                    {
                                        p3Name = "";
                                        p3Age = 0;
                                        p3Phone = "";
                                        p3Active = false;
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;

                                case 0:
                                    break;

                                default:
                                    Console.WriteLine("Invalid patient menu choice.");
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;
                            }

                            if (patientChoice == 0)
                            {
                                break;
                            }
                        }

                        break;

                    //doctor
                    case 2:
                        // ── REGION 3: Doctor  ───────────────────────────


                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("    =====DOCTOR MANAGEMENT====        ");
                            Console.WriteLine("1) Add New Doctor                    ");
                            Console.WriteLine("2) Display All Doctors               ");
                            Console.WriteLine("3)pdate Consultation Fee            ");
                            Console.WriteLine("4)Delete Doctor                     ");
                            Console.WriteLine("0)Back to Main Menu                 ");
                            Console.Write("Enter your choice: ");

                            int doctorChoice = int.Parse(Console.ReadLine());

                            switch (doctorChoice)
                            {
                                // ── REGION 4: Doctor Operations ──────────────
                                case 1:
                                    // Add new doctor 
                                    if (doctorCount == MAX_DOCTORS)
                                    {
                                        Console.WriteLine("No available doctor slots.");
                                    }
                                    else
                                    {
                                        Console.Write("Enter doctor name: ");
                                        string name = Console.ReadLine();

                                        Console.Write("Enter specialization: ");
                                        string spec = Console.ReadLine();

                                        if (name == "" || spec == "")
                                        {
                                            Console.WriteLine("Doctor name and specialization cannot be empty.");
                                        }
                                        else
                                        {
                                            Console.Write("Enter consultation fee: ");
                                            double fee = Convert.ToDouble(Console.ReadLine());

                                            if (fee < 0)
                                            {
                                                Console.WriteLine("Invalid fee.");
                                            }
                                            else
                                            {
                                                if (!d1Active)
                                                {
                                                    d1Name = name;
                                                    d1Spec = spec;
                                                    d1Fee = fee;
                                                    d1Active = true;
                                                }
                                                else if (!d2Active)
                                                {
                                                    d2Name = name;
                                                    d2Spec = spec;
                                                    d2Fee = fee;
                                                    d2Active = true;
                                                }

                                                doctorCount++;
                                                Console.WriteLine("Doctor added successfully.");
                                            }
                                        }
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;

                                case 2:
                                    // Display all doctors o
                                    if (doctorCount == 0)
                                    {
                                        Console.WriteLine("No doctors registered.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("DOCTORS");

                                        if (d1Active)
                                        {
                                            Console.WriteLine("Doctor #1");
                                            Console.WriteLine("Name           : " + d1Name);
                                            Console.WriteLine("Specialization : " + d1Spec);
                                            Console.WriteLine("Fee            : " + d1Fee);
                                        }

                                        if (d2Active)
                                        {
                                            Console.WriteLine("Doctor #2");
                                            Console.WriteLine("Name           : " + d2Name);
                                            Console.WriteLine("Specialization : " + d2Spec);
                                            Console.WriteLine("Fee            : " + d2Fee);
                                        }
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    // Update doctor consultation fee 
                                    Console.Write("Enter doctor name: ");
                                    string updateDoctorName = Console.ReadLine();

                                    if (d1Active && d1Name == updateDoctorName)
                                    {
                                        Console.Write("Enter new fee: ");
                                        double newFee = Convert.ToDouble(Console.ReadLine());

                                        if (newFee < 0)
                                        {
                                            Console.WriteLine("Invalid fee.");
                                        }
                                        else
                                        {
                                            d1Fee = newFee;
                                            Console.WriteLine("Fee updated.");
                                        }
                                    }
                                    else if (d2Active && d2Name == updateDoctorName)
                                    {
                                        Console.Write("Enter new fee: ");
                                        double newFee = Convert.ToDouble(Console.ReadLine());

                                        if (newFee < 0)
                                        {
                                            Console.WriteLine("Invalid fee.");
                                        }
                                        else
                                        {
                                            d2Fee = newFee;
                                            Console.WriteLine("Fee updated.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Doctor not found.");
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;


                                // Delete doctor operation

                                case 4:
                                    Console.Write("Enter doctor name: ");
                                    string deleteDoctorName = Console.ReadLine();

                                    if (d1Active && d1Name == deleteDoctorName)
                                    {
                                        d1Name = "";
                                        d1Spec = "";
                                        d1Fee = 0;
                                        d1Active = false;
                                        doctorCount--;
                                        Console.WriteLine("Doctor removed.");
                                    }
                                    else if (d2Active && d2Name == deleteDoctorName)
                                    {
                                        d2Name = "";
                                        d2Spec = "";
                                        d2Fee = 0;
                                        d2Active = false;
                                        doctorCount--;
                                        Console.WriteLine("Doctor removed.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Doctor not found.");
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;

                                case 0:
                                    break;

                                default:
                                    Console.WriteLine("Invalid doctor menu choice.");
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;
                            }

                            if (doctorChoice == 0)
                            {
                                break;
                            }
                        }

                        break;

                    // ── REGION 3: Appointment  ──────────────────────
                    case 3:

                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("     =====APPOINTMENT MANAGEMENT===== ");
                            Console.WriteLine(" 1) Book New Appointment              ");
                            Console.WriteLine(" 2) Display All Appointments          ");
                            Console.WriteLine(" 3) Update Appointment Status         ");
                            Console.WriteLine(" 4) Cancel Appointment                ");
                            Console.WriteLine(" 0) Back to Main Menu                 ");
                            Console.WriteLine("");
                            Console.Write("Enter your choice: ");

                            int appointmentChoice = int.Parse(Console.ReadLine());

                            switch (appointmentChoice)
                            {
                                // ── REGION 4: Appointment  ─────────
                                case 1:
                                    // Book new appointment operation
                                    if (appointmentCount == MAX_APPOINTMENTS)
                                    {
                                        Console.WriteLine("No available appointment slots.");
                                    }
                                    else if (patientCount == 0 || doctorCount == 0)
                                    {
                                        Console.WriteLine("Please add patients and doctors first.");
                                    }
                                    else
                                    {
                                        string chosenPatient = "";
                                        string chosenDoctor = "";

                                        Console.WriteLine("Choose patient:");
                                        if (p1Active) { Console.WriteLine("1. " + p1Name); }
                                        if (p2Active) { Console.WriteLine("2. " + p2Name); }
                                        if (p3Active) { Console.WriteLine("3. " + p3Name); }

                                        Console.Write("Enter patient slot number: ");
                                        int patientSlot = Convert.ToInt32(Console.ReadLine());

                                        if (patientSlot == 1 && p1Active)
                                        {
                                            chosenPatient = p1Name;
                                        }
                                        else if (patientSlot == 2 && p2Active)
                                        {
                                            chosenPatient = p2Name;
                                        }
                                        else if (patientSlot == 3 && p3Active)
                                        {
                                            chosenPatient = p3Name;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid patient slot.");
                                        }

                                        if (chosenPatient != "")
                                        {
                                            Console.WriteLine("Choose doctor:");
                                            if (d1Active) { Console.WriteLine("1. " + d1Name); }
                                            if (d2Active) { Console.WriteLine("2. " + d2Name); }

                                            Console.Write("Enter doctor slot number: ");
                                            int doctorSlot = int.Parse(Console.ReadLine());

                                            if (doctorSlot == 1 && d1Active)
                                            {
                                                chosenDoctor = d1Name;
                                            }
                                            else if (doctorSlot == 2 && d2Active)
                                            {
                                                chosenDoctor = d2Name;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid doctor slot.");
                                            }

                                            if (chosenDoctor != "")
                                            {
                                                Console.Write("Enter appointment date DD/MM/YYYY: ");
                                                string date = Console.ReadLine();

                                                if (a1Active && a1Patient == chosenPatient && a1Doctor == chosenDoctor && a1Date == date)
                                                {
                                                    Console.WriteLine("Duplicate appointment.");
                                                }
                                                else if (a2Active && a2Patient == chosenPatient && a2Doctor == chosenDoctor && a2Date == date)
                                                {
                                                    Console.WriteLine("Duplicate appointment.");
                                                }
                                                else if (a3Active && a3Patient == chosenPatient && a3Doctor == chosenDoctor && a3Date == date)
                                                {
                                                    Console.WriteLine("Duplicate appointment.");
                                                }
                                                else
                                                {
                                                    if (!a1Active)
                                                    {
                                                        a1Patient = chosenPatient;
                                                        a1Doctor = chosenDoctor;
                                                        a1Date = date;
                                                        a1Status = "Scheduled";
                                                        a1Active = true;
                                                    }
                                                    else if (!a2Active)
                                                    {
                                                        a2Patient = chosenPatient;
                                                        a2Doctor = chosenDoctor;
                                                        a2Date = date;
                                                        a2Status = "Scheduled";
                                                        a2Active = true;
                                                    }
                                                    else if (!a3Active)
                                                    {
                                                        a3Patient = chosenPatient;
                                                        a3Doctor = chosenDoctor;
                                                        a3Date = date;
                                                        a3Status = "Scheduled";
                                                        a3Active = true;
                                                    }

                                                    appointmentCount++;
                                                    Console.WriteLine("Appointment booked.");
                                                }
                                            }
                                        }
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;

                                case 2:
                                    // Display all appointments 
                                    if (appointmentCount == 0)
                                    {
                                        Console.WriteLine("No appointments booked.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("APPOINTMENTS");

                                        if (a1Active)
                                        {
                                            Console.WriteLine("Appointment #1");
                                            Console.WriteLine("Patient : " + a1Patient);
                                            Console.WriteLine("Doctor  : " + a1Doctor);
                                            Console.WriteLine("Date    : " + a1Date);
                                            Console.WriteLine("Status  : " + a1Status);
                                        }

                                        if (a2Active)
                                        {
                                            Console.WriteLine("Appointment #2");
                                            Console.WriteLine("Patient : " + a2Patient);
                                            Console.WriteLine("Doctor  : " + a2Doctor);
                                            Console.WriteLine("Date    : " + a2Date);
                                            Console.WriteLine("Status  : " + a2Status);
                                        }

                                        if (a3Active)
                                        {
                                            Console.WriteLine("Appointment #3");
                                            Console.WriteLine("Patient : " + a3Patient);
                                            Console.WriteLine("Doctor  : " + a3Doctor);
                                            Console.WriteLine("Date    : " + a3Date);
                                            Console.WriteLine("Status  : " + a3Status);
                                        }
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    // Update appointment status
                                    if (appointmentCount == 0)
                                    {
                                        Console.WriteLine("No appointments booked.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Active appointments:");
                                        if (a1Active) { Console.WriteLine("1. " + a1Patient + " with " + a1Doctor + " on " + a1Date); }
                                        if (a2Active) { Console.WriteLine("2. " + a2Patient + " with " + a2Doctor + " on " + a2Date); }
                                        if (a3Active) { Console.WriteLine("3. " + a3Patient + " with " + a3Doctor + " on " + a3Date); }

                                        Console.Write("Enter appointment slot number: ");
                                        int slot = int.Parse(Console.ReadLine());

                                        if (slot == 1 && a1Active)
                                        {
                                            Console.WriteLine("1. Scheduled");
                                            Console.WriteLine("2. Completed");
                                            Console.WriteLine("3. Cancelled");
                                            Console.Write("Choose status: ");
                                            int statusChoice = int.Parse(Console.ReadLine());

                                            switch (statusChoice)
                                            {
                                                case 1:
                                                    a1Status = "Scheduled";
                                                    Console.WriteLine("Status updated.");
                                                    break;
                                                case 2:
                                                    a1Status = "Completed";
                                                    Console.WriteLine("Status updated.");
                                                    break;
                                                case 3:
                                                    a1Status = "Cancelled";
                                                    Console.WriteLine("Status updated.");
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid status choice.");
                                                    break;
                                            }
                                        }
                                        else if (slot == 2 && a2Active)
                                        {
                                            Console.WriteLine("1. Scheduled");
                                            Console.WriteLine("2. Completed");
                                            Console.WriteLine("3. Cancelled");
                                            Console.Write("Choose status: ");
                                            int statusChoice = int.Parse(Console.ReadLine());

                                            switch (statusChoice)
                                            {
                                                case 1:
                                                    a2Status = "Scheduled";
                                                    Console.WriteLine("Status updated.");
                                                    break;
                                                case 2:
                                                    a2Status = "Completed";
                                                    Console.WriteLine("Status updated.");
                                                    break;
                                                case 3:
                                                    a2Status = "Cancelled";
                                                    Console.WriteLine("Status updated.");
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid status choice.");
                                                    break;
                                            }
                                        }
                                        else if (slot == 3 && a3Active)
                                        {
                                            Console.WriteLine("1. Scheduled");
                                            Console.WriteLine("2. Completed");
                                            Console.WriteLine("3. Cancelled");
                                            Console.Write("Choose status: ");
                                            int statusChoice = int.Parse(Console.ReadLine());

                                            switch (statusChoice)
                                            {
                                                case 1:
                                                    a3Status = "Scheduled";
                                                    Console.WriteLine("Status updated.");
                                                    break;
                                                case 2:
                                                    a3Status = "Completed";
                                                    Console.WriteLine("Status updated.");
                                                    break;
                                                case 3:
                                                    a3Status = "Cancelled";
                                                    Console.WriteLine("Status updated.");
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid status choice.");
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid slot.");
                                        }
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;

                                case 4:
                                    // Cancel appointment 
                                    Console.Write("Enter patient name: ");
                                    string cancelPatientName = Console.ReadLine();

                                    Console.Write("Enter appointment date DD/MM/YYYY: ");
                                    string cancelDate = Console.ReadLine();

                                    if (a1Active && a1Patient == cancelPatientName && a1Date == cancelDate)
                                    {
                                        a1Status = "Cancelled";
                                        Console.WriteLine("Appointment cancelled.");
                                    }
                                    else if (a2Active && a2Patient == cancelPatientName && a2Date == cancelDate)
                                    {
                                        a2Status = "Cancelled";
                                        Console.WriteLine("Appointment cancelled.");
                                    }
                                    else if (a3Active && a3Patient == cancelPatientName && a3Date == cancelDate)
                                    {
                                        a3Status = "Cancelled";
                                        Console.WriteLine("Appointment cancelled.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Appointment not found.");
                                    }

                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;

                                case 0:
                                    break;

                                default:
                                    Console.WriteLine("Invalid appointment menu choice.");
                                    Console.WriteLine("Press Enter to continue...");
                                    Console.ReadLine();
                                    break;
                            }

                            if (appointmentChoice == 0)
                            {
                                break;
                            }
                        }

                        break;



                }
            }
        }
    }
}