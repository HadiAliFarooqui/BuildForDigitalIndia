# BuildForDigitalIndia

## Things to download

**1.Unity Software**

**2.Visual studio(with C# platform)**

**3.Python 3.6**

*install ppz module in python*

**4.Crazytalk8** 



## Description of each file

Goto:

```VisualChatbot/Assets/Scripts```

You will get to see 2 files with ```.cs``` extension

**Players.cs**

  This file is basically responsible to handle and manage all the functionalities of the 3D visual image, which is later used as a User interface that allows users to communicate with the visual chatbot. This file is also used to create audios for the visual chatbot.
  
**GameManager2.cs**

  This file helps us to create an input text in which user can give their inputs, which later is sent to the server and then the entire process takes place which will be explained later


**Then Goto:**

```VisualChatbot/Assets/PythonFiles```

You will see a file named server

Run this file.

**This file is our server, here the chatbot is placed where in all the requests from user are taken into consideration and the server processes these requests and sends the desired output to the UI and this UI will gives a response to the user**

**Then Goto:**

```VisualChatbot/Assets/NetMQExample```

You will see three files which are

*1.RunAbleThreads.cs*

**This file is basically used to run process synchronously and so as to create an operative communication between the client and the server**


*2.HelloClient.cs*

**This file handles all the features of client**


*3.HelloRequest.cs*
**This file is used to send the request of client to the server *(it acts as a messenger/transporter between client and server which are developed using Python)*  **



