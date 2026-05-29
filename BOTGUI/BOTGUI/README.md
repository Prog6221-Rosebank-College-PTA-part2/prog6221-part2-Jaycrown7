Cybersecurity Awareness Bot

 Overview

The Cybersecurity Awareness Bot is a GUI-based chatbot application developed using C# and Windows Forms.

The purpose of the application is to educate users about cybersecurity awareness by providing tips and guidance on topics such as:

* Password safety
* Phishing attacks
* Online scams
* Privacy protection

The chatbot interacts with users through a graphical user interface and provides dynamic cybersecurity responses.



Features

GUI Interface

* User-friendly graphical interface
* Cybersecurity-themed design
* Interactive chat area
* Simple and responsive layout

 Voice Greeting

* Plays a WAV greeting audio when the application starts
* Implemented using the SoundPlayer class from System.Media

 Keyword Recognition

The chatbot recognises cybersecurity keywords such as:

* password
* phishing
* scam
* privacy

 Random Responses

* Uses arrays and the Random class
* Provides different responses for the same topic to make conversations more interactive

 Memory and Recall

* Remembers the user’s favourite cybersecurity topic
* Uses stored information to personalise responses

 Sentiment Detection

The chatbot detects emotions such as:

* worried
* frustrated
* curious

The chatbot then adjusts its responses accordingly.

 Follow-up Conversation

* Supports follow-up interaction such as:

  * “tell me more”
  * “another tip”
* Continues discussing the current topic without restarting the conversation

 Error Handling

* Prevents crashes from invalid input
* Displays default responses for unknown input



 Technologies Used

* C#
* Windows Forms
* .NET Framework
* Visual Studio



 How to Run the Application

1. Open the project in Visual Studio
2. Ensure the WAV file is inside the `assets` folder
3. Build the solution
4. Run the application



Project Structure


BOTGUI
│
├── assets
│   └── greeting.wav
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
└── README.md

 Example User Inputs


password
phishing
privacy
scam
i like phishing
tell me more
another tip
i am worried about scams
purpose


 Learning Outcomes

This project helped improve understanding of:

* GUI development
* Event-driven programming
* Arrays and randomisation
* Methods and classes
* Object-Oriented Programming
* User interaction design
* Error handling

 Author

Developed by:
Tselapedi Kgaugelo



 Conclusion

The Cybersecurity Awareness Bot successfully demonstrates the use of C# and Windows Forms to create an interactive cybersecurity education application.

The chatbot provides users with cybersecurity awareness tips while implementing advanced features such as:

* dynamic responses
* memory and recall
* sentiment detection
* follow-up conversation flow
* and voice greeting
