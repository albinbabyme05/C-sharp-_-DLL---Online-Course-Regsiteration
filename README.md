# 📘 Online Course Registration System (C# + DLL-Based)

This is a basic **Object-Oriented Programming (OOP)** project built in **C#** using **Class Libraries (DLL)** and a **Console Application**.

The project demonstrates key OOP concepts such as:

- **Inheritance**
- **Abstraction**
- **Encapsulation**
- **Polymorphism**
- Use a **DLL (Class Library)** to organize code


---

## ✅ Features


  - Guest User can register only for FreeCourses
  - Registered User can register for both types and pay from wallet

- **Registration Rules**
  - Guest users can't register for paid courses
  - Registered users must have sufficient balance to register for paid courses
  - Success/failure messages shown for registration attempts

---

## 🛠 Project Structure

```
/OnlineCourseApp
│
├── CourseLibrary           # Class Library (DLL)
│   ├── Models              # Course classes
│   │   ├── Course.cs
│   │   ├── FreeCourse.cs
│   │   └── PaidCourse.cs
│   │
│   ├── Services            # CourseManager (stores course list)
│   │   └── CourseManager.cs
│   │
│   └── Users               # User classes
│       ├── User.cs
│       ├── GuestUser.cs
│       └── RegisteredUser.cs
│
└── CourseApp               # Console app that uses DLL
    └── Program.cs
```
## 🚀 GUI
![1](https://github.com/user-attachments/assets/597d6fb6-9b43-4fc4-a794-e8d2e59f3364)
![2](https://github.com/user-attachments/assets/137e2710-5e3e-4165-bbb6-54073447a738)


---

## 🚀 How to Run

1. Open the solution in Visual Studio
2. Build the solution to compile the DLL
3. Set `CourseApp` as the startup project
4. Run the app and view output in the terminal

---


