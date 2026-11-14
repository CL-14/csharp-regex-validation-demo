# C# Regex Validation & Unit Testing Demo

A structured .NET solution designed to explore regular expression (Regex) patterns and test-driven validation logic using xUnit.

## Key Components & Architecture
* **`RegexDemo.Domain`:** Contains `RegexHelperService`, providing static methods for common validations (digits, lowercase letters, capitalization, custom patterns, and postal codes like Irish Eircodes).
* **`RegexDemo.Tests`:** A comprehensive xUnit test suite utilizing `[Theory]` and `[InlineData]` to thoroughly test edge cases for each regex pattern.
* **`RegexDemo.app`:** A simple console application runner displaying app metadata and details.

## Tech
* Language: C# (.NET Core / Console Application)
* Testing Framework: xUnit
