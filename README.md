# SimpleTranslation

[![License: CC0-1.0](https://img.shields.io/badge/License-CC0%201.0-lightgrey.svg)](LICENSE)  

A minimal, lightweight C# library for simple runtime string translation / localization tasks.  

## Table of Contents

- [Features](#features)  
- [Getting Started](#getting-started)  
  - [Requirements](#requirements)  
  - [Installation](#installation)  
- [Usage](#usage)  
  - [Basic Example](#basic-example)  
  - [API Overview](#api-overview)  
- [Architecture & Design](#architecture--design)  
- [Contributing](#contributing)  
- [License](#license)  

---

## Features

- Easy to integrate — just include the library in your project  
- Runtime translation lookup  
- Support for mapping “translation keys” to translated strings  
- Simple API to get translated text, manage fallback, etc.  
- Light on dependencies  

---

## Getting Started

### Requirements

- .NET / C# (any version compatible with your target platform)  
- No external dependencies (apart from standard .NET)  

### Installation

You can either:

1. Copy the `.cs` files from this repository (e.g. `SimpleTranslation.cs`, `SimpleTranslationButton.cs`, `SimpleTranslationManager.cs`, `SimpleTranslationText.cs`) into your project.  
2. Or include this project as a submodule / reference it as a project reference in your solution.  

---

## Usage

### Basic Example

Here’s an illustrative usage example:

```csharp
using SimpleTranslation;

class Program
{
    static void Main(string[] args)
    {
        var manager = new SimpleTranslationManager();
        manager.AddTranslation("hello", "de", "Hallo");
        manager.AddTranslation("hello", "en", "Hello");
        manager.AddTranslation("farewell", "de", "Auf Wiedersehen");
        manager.AddTranslation("farewell", "en", "Goodbye");

        manager.CurrentLanguage = "de";

        Console.WriteLine(manager.Translate("hello"));      // prints “Hallo”
        Console.WriteLine(manager.Translate("farewell"));   // prints “Auf Wiedersehen”

        manager.CurrentLanguage = "en";
        Console.WriteLine(manager.Translate("hello"));      // prints “Hello”
    }
}
