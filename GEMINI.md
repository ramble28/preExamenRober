# GEMINI.md - preExamenRober

## Project Overview
**preExamenRober** is a C# Windows Forms application built on .NET Framework 4.7.2. It serves as a student enrollment management system for workshops.

- **Architecture:** Monolithic WinForms application.
- **Data Persistence:** Uses flat text files (`Alumnos.txt`, `Talleres.txt`, `Inscripciones.txt`) for simple data storage.
- **Namespaces:** 
    - `preExamenRober`: Main application and UI logic.
    - `simulacroExamen`: Core data models.

## Key Components
- **Models (`simulacroExamen`):**
  - `Alumno.cs`: Represents a student (DPI, Name, Address).
  - `Taller.cs`: Represents a workshop (Code, Name, Cost).
  - `Inscripcion.cs`: Links a student to a workshop with a date.
  - `Reporte.cs`: Helper class for displaying enrollment data in the UI.
- **UI (`preExamenRober`):**
  - `Form1.cs`: Main form handling data loading from files, user input for enrollment, and reporting (including sorting).

## Building and Running
### Prerequisites
- Windows OS.
- Visual Studio (2019 or later recommended) or MSBuild.
- .NET Framework 4.7.2.

### Build Commands
To build the project using MSBuild:
```powershell
msbuild preExamenRober.csproj /p:Configuration=Debug
```

### Running the Application
The executable will be located in the output directory after a successful build:
```powershell
.\bin\Debug\preExamenRober.exe
```

## Development Conventions
- **Language:** C# 7.3 or higher.
- **Naming:** 
    - Classes and Properties: PascalCase (e.g., `NombreTaller`).
    - Private Fields: camelCase (e.g., `nombretaller`).
- **Data Handling:** Data is read on initialization and written upon specific user actions (like clicking the "Ingreso" button).
- **Namespaces:** Note the discrepancy between the project root (`preExamenRober`) and the models (`simulacroExamen`). New models should likely stay within `simulacroExamen` to maintain consistency.
- **UI Interaction:** Logic for data manipulation is currently tightly coupled with the UI in `Form1.cs`.

## TODO / Known Issues
- [ ] Add error handling for missing text files (`Alumnos.txt`, `Talleres.txt`).
- [ ] Implement data validation for user inputs in `Form1`.
- [ ] Consider refactoring data access logic out of the Form class into a dedicated service or repository.
