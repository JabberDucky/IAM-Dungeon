# IAM Dungeon Learning Journal

## Project Purpose

Build an IAM-themed game while learning:

* Git
* GitHub
* C#
* .NET
* APIs
* JSON
* SQL

The goal is to understand every line of code written, commit progress frequently, and create a portfolio that demonstrates continuous learning and growth.

---

# Week 1 - C# Foundations

## Learning Objectives

* Understand variables and common C# data types
* Declare and initialize variables
* Write arithmetic expressions
* Use comparison operators
* Use logical operators
* Control program flow with if/else statements
* Use switch expressions
* Use loops
* Create and call methods
* Use parameters and return values
* Use the Visual Studio debugger
* Read and interpret compiler errors
* Read and interpret runtime exceptions

---

## Progress

### Environment Setup

Completed:

* [x] Installed Git
* [x] Installed Visual Studio Community
* [x] Installed Visual Studio Code
* [x] Installed .NET SDK
* [x] Created GitHub repository
* [x] Cloned repository locally
* [x] Configured Git username and email

---

## Commands Learned

### Git

```powershell
git --version
git config --list
git clone <repository-url>
git status
```

---

## Notes

This repository will be built incrementally with a Git commit after every meaningful milestone.

Every commit should represent a specific concept learned or feature completed.

The objective is not just to build a game but to understand the reasoning behind every line of code and every development tool used throughout the project.


### Milestone: Adventurer Registration

#### Concepts Learned
- Variable declaration
- Data types (`string`, `int`)
- User input using `Console.ReadLine()`
- Safe integer conversion using `int.TryParse()`

#### What Was Built
Created the Village Registry onboarding process that collects:
- Adventurer name
- Adventurer age
- Adventurer class

The system stores the information in variables and displays a formatted Adventurer Profile.

#### Why It Matters
Most applications collect information from users and store it in variables for later processing. Learning how to capture, store, and display data is a foundational programming skill that will be used throughout IAM Dungeon.

#### Challenges Encountered
- Learned that `int.Parse()` can crash the application when invalid input is entered.
- Replaced `int.Parse()` with `int.TryParse()` to safely handle user input.

#### Git Commit(s)
- declare adventurer variables before assignment
- add safe parsing for adventurer age input

### Milestone: Registration Validation

#### Concepts Learned

* `if` statements
* `if/else` statements
* Comparison operators (`>=`)
* Creating methods
* Calling methods
* Passing parameters to methods

#### What Was Built

Implemented a registration validation system for the Knights of Identity.
After an adventurer completes registration, the system evaluates whether they are eligible to join the Knights of Identity based on their age.
The access validation logic was moved into a dedicated `CheckWinters()` method, making the code more organized and reusable.

#### Why It Matters

Programs often need to make decisions based on data provided by users.
This milestone introduced the concept of authorization logic, where access is granted or denied based on predefined rules.
Moving the validation logic into a method also demonstrated how software can separate responsibilities and avoid repeating code.

#### Challenges Encountered

* Learned the difference between placing logic directly inside `Main()` and moving logic into a reusable method.
* Learned how parameters allow methods to work with data collected elsewhere in the program.
* Learned that comparison operators evaluate to either `true` or `false`, which can then drive program decisions.

#### Git Commit(s)

* add age-based access validation for Knights of Identity
* move access validation into reusable method
