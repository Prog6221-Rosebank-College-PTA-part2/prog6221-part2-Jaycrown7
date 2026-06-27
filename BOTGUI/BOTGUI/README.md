 Cybersecurity Awareness Chatbot

 Student Information

Student Name: Tselapedi Kgaugelo

Module:Programming 6221 (POE)

Project:Cybersecurity Awareness Chatbot (Part 3)


Project Overview

This project is a Cybersecurity Awareness Chatbot developed using C# Windows Forms. The chatbot educates users about cybersecurity while providing additional interactive features such as task management, quizzes, and activity logging.

The application was developed as part of the Programming POE and demonstrates object-oriented programming, database integration, GUI development, and basic Natural Language Processing (NLP).



# Features

## Chatbot
- Cybersecurity awareness responses
- Keyword recognition
- Follow-up conversation
- Sentiment detection
- Favourite topic memory
- Random cybersecurity tips

## Task Assistant
- Add cybersecurity tasks
- View tasks
- Delete tasks
- Mark tasks as completed
- Set reminder dates
- Stores tasks in a MySQL database

## Cybersecurity Quiz
- 12 cybersecurity questions
- Multiple Choice questions
- True/False questions
- Immediate feedback
- Score tracking
- Final performance message

## NLP Simulation
The chatbot recognises different ways users ask for commands using keyword detection.

Examples:

- Play quiz
- Test me
- Show activity
- View tasks
- Remind me to update my password

## Activity Log
The chatbot records important user actions including:

- Task creation
- Task completion
- Task deletion
- Quiz started
- Quiz completed
- NLP recognised commands


# Technologies Used

- C#
- Windows Forms
- .NET Framework
- MySQL
- MySQL Connector/NET
- Visual Studio 2022
- Git
- GitHub



# Project Structure


BOTGUI
│
├── Models
│   ├── TaskItem.cs
│   └── QuizQuestion.cs
│
├── Services
│   ├── Database.cs
│   ├── TaskManager.cs
│   ├── QuizManager.cs
│   └── ActivityLogger.cs
│
├── Form1.cs
└── Program.cs




# Installation

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Install MySQL Server.
4. Create the database named **CyberBotDB**.
5. Create the required **tasks** table.
6. Update the database connection string if necessary.
7. Build and run the project.


# Database

Database Name:

```
CyberBotDB
```

Table:

```
tasks
```

---

# GitHub Workflow

This project was managed using Git and GitHub.

Development included:

- Multiple commits
- Version releases
- README documentation

---

# Future Improvements

- Email reminders
- User authentication
- Advanced NLP
- AI-powered chatbot responses
- Charts and cybersecurity statistics

---

# Author

Tselapedi Kgaugelo

Programming POE

