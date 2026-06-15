# C# Programming Assessment Project

## Overview

This repository contains solutions for a C# Programming Assessment consisting of both Console Applications and Windows Forms Applications. The project demonstrates object-oriented programming, input validation, data processing, user interaction, and graphical user interface development using C# and .NET.

The assessment is divided into two sections:

* Section A: Short Answer Questions
* Section B: Long Answer Questions

## Technologies Used

* C#
* .NET Framework / .NET
* Windows Forms
* Visual Studio
* Object-Oriented Programming (OOP)

---

# SECTION A: Short Answer Questions

## Question 1: Student Marks Calculator (Console Application)

### Description

A console application that captures a student's name and three subject marks, validates the inputs, calculates totals and averages, and determines whether the student passes or fails.

### Features

* Student name input
* Three subject mark inputs
* Numeric validation for marks
* Total mark calculation
* Average mark calculation
* Pass/Fail determination

### Business Rule

* Average ≥ 50 = PASS
* Average < 50 = FAIL

---

## Question 2: ATM Withdrawal System (Console Application)

### Description

A simple ATM simulation that allows a user to perform a withdrawal transaction and view the updated account balance.

### Features

* Account balance display
* Withdrawal amount input
* Balance validation
* Updated balance calculation
* Transaction timestamp display
* Transaction summary output

---

## Question 3: Programming Language Manager (Windows Forms Application)

### Description

A Windows Forms application used to manage a list of programming languages.

### Features

* Add programming languages
* Prevent empty entries
* Prevent duplicate entries
* Remove selected language
* Display date and time when languages are added
* Interactive graphical user interface

---

# SECTION B: Long Answer Questions

## Question 1: Emfuleni Municipality Service Management System (Console Application)

### Description

A municipal service management system that allows the municipality to capture resident information, record service requests, calculate urgency scores, and process requests based on priority and severity.

### Classes Implemented

#### Resident Class

Stores:

* Resident Name
* Address
* Account Number
* Monthly Utility Usage

#### ServiceRequest Class

Stores:

* Request Type
* Priority Level
* Severity Level
* Estimated Resolution Time

#### UtilitiesManager Class

Responsible for:

* Urgency Score Calculation
* Request Processing
* Service Report Generation
* Summary Report Generation

### Features

* Resident registration
* Service request management
* Urgency score calculation
* Request queue processing
* Service reports
* Resolved request tracking
* Highest urgency request identification

---

## Question 2: Home Affairs Digital Identity Processor (Windows Forms Application)

### Description

A Windows Forms application used to create and validate digital citizen profiles based on South African identification numbers.

### Classes Implemented

#### CitizenProfile Class

Properties:

* FullName
* IDNumber
* Age
* CitizenshipStatus

### Features

* Name input
* South African ID number validation
* Citizenship status selection
* Age calculation from ID number
* Profile generation
* Validation reporting
* Processing timestamp display

### Validation Rules

* ID number must contain exactly 13 digits
* ID number must be numeric
* Age must be successfully calculated from the ID number

---

# Learning Outcomes

This project demonstrates:

* C# Programming
* Object-Oriented Programming
* Console Application Development
* Windows Forms Development
* Input Validation
* Data Processing
* Class Design
* Problem Solving
* Software Development Principles
* User Interface Design

---

# Author

Mokgadi Rasetsoke

Software Engineering Student
