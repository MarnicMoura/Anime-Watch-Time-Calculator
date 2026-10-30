# Anime Calculator

A console-based application for calculating and organizing anime watch times.

Anime Calculator started as a small Python script and gradually evolved through several C# implementations. The goal is to make it easy to calculate how long an anime takes to watch, including its sequels and spin-offs.

## Project History

The project has gone through four main versions:

### 1. Anime Calculator — Python Version

The original implementation, written in Python.

**Features:**
- Accepts an anime title, episode count, and average episode duration.
- Calculates the estimated total watch time in hours.
- Optionally includes sequels and spin-offs in the calculation.
- Saves the results to a text file (`anime.txt`).

**Limitations:**
- Only handles one anime per run.
- Does not record sequel or spin-off titles.
- Reuses the same output filename, overwriting previous results.
- Has no input validation or persistent anime library.

### 2. Anime Calculator — C# Version 1.0

The first C# rewrite of the original Python program.

**Improvements:**
- Supports entering multiple anime during one session.
- Records sequel and spin-off titles separately.
- Calculates combined episode counts and watch times.
- Saves individual text reports for each anime.
- Includes helper methods for collecting user input.

This version expanded on the original script and established the foundation for the later C# console application.

### 3. Anime Calculator — Abandoned App

An experimental Windows Forms implementation built with C# and .NET Framework 4.7.2.

The intention was to move the calculator from the console into a graphical desktop application.

**Features and experiments:**
- Windows Forms interface.
- Input fields for anime titles, episode counts, and episode durations.
- Separate dialog for entering sequel information.
- Displays anime in a list sorted by watch time.

**Status:** Abandoned.

The application never reached feature parity with the console versions. Saving and loading anime data was not implemented, and sequel calculations were not fully integrated with their parent anime.

### 4. Anime Calculator — C# Console Version

The most complete implementation and the foundation for future development.

**Features:**
- Enter multiple anime in one session.
- Record anime titles, episode counts, and average episode durations.
- Include any number of sequels and spin-offs, each with its own details.
- Calculate combined episode counts and watch times.
- Generate individual text reports for each anime.
- Sort the session's anime list by total watch time.
- Automatically open the output folder when finished.

This version returned to the console-based approach, focusing on functionality rather than a graphical interface.

## Future Development

The project is being revisited with the intention of improving its structure, functionality, and maintainability.

Potential improvements include:
- Better input validation.
- Persistent storage for anime calculations.
- The ability to view, edit, and remove saved entries.
- Improved organization of sequels and spin-offs.
- More flexible sorting and searching.
- A cleaner, more maintainable codebase.

The application will remain a console program. Future development will use Visual Studio Code rather than Visual Studio.

## Technologies

- C#
- .NET
- Python (original implementation)
- Git

---

*This project is a personal programming project that has evolved through experimentation and multiple rewrites.*