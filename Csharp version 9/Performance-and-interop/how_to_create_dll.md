Creating a DLL (Dynamic Link Library) with C code in Visual Studio involves a few steps.
  
This DLL can then be used in other applications, including those written in C#. Here's how to create a DLL with the provided C code:

**Step 1: Install Visual Studio**

Ensure you have Visual Studio installed with the Desktop development with C++ workload. 

This workload includes the tools needed to compile C and C++ code.

**Step 2: Create a New Project**

Open Visual Studio and choose "Create a new project."
  
In the project template selection window, select "Library" under C++ (even though we're writing C code, C++ projects are compatible and provide the correct project setup for creating DLLs).

Choose the "Windows Dynamic-Link Library (DLL)" template and click Next.

Enter your project name (e.g., "ExampleDLL") and choose a suitable location for your project. Click Create.

**Step 3: Add Your C Code**

Once your project is created, Visual Studio will have generated some files for you. Find the file named dllmain.cpp in the Solution Explorer pane.

You can either modify dllmain.cpp or add a new item to the project. To add a new C file, right-click on the project in Solution Explorer, select Add -> New Item, choose "C++ File (.cpp)",

name it (e.g., example.c), and click Add. Despite the extension, you can write C code in this file.

In your new C file (example.c), add the provided C code:

```
#include "pch.h"

__declspec(dllexport) int add(int a, int b) {
    return a + b;
}
```

**VERY IMPORTANT**:

Ensure your project properties are set for C compilation. You can check or change this by going to the project's **Properties -> C/C++ -> Advanced -> Compile As**,

and select Compile as **C Code (/TC)**.
