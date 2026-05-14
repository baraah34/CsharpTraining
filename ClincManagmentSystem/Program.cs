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
                        break; 
                    //appointment
                    case 3:
                        break;



                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid main menu choice.");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                   
                }
            }
        }
    }
}