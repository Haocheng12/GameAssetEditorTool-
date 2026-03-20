Game Asset Editor Tool (C# / .NET)
Overview

This project is a simple desktop tool developed using C# and .NET (WinForms) for creating, editing, and managing game asset data. It is designed to simulate an internal development tool used in game production pipelines, with a focus on usability and efficient content iteration.

Features

Load and save asset data from JSON files

View and edit asset properties (Name, Type, Value, Description)

Add new assets and delete existing ones

Input validation to prevent invalid data

Real-time updates through a user-friendly interface

Technologies Used

C#

.NET (WinForms)

JSON serialization (System.Text.Json)

Project Structure

Form1.cs → Main UI and tool logic

GameItem.cs → Data model for assets

items.json → Sample asset data file

How to Run

Open the solution file (.sln) in Visual Studio

Build the project

Run the application

Click Load to load sample data

Select an item to edit its properties

Use Apply to update, Save to persist changes

Purpose

The goal of this project is to demonstrate:

Tools programming skills

UI development using .NET

Data-driven workflow design

Consideration for usability and iteration speed
