# Parallel Pooler - WinForms Application Example & Test

[![Latest Stable Version](https://img.shields.io/badge/Stable-v2.3.0-brightgreen.svg?style=plastic)](https://github.com/parallel-pooler/pooler/releases)
[![License](https://img.shields.io/badge/Licence-BSD-brightgreen.svg?style=plastic)](https://raw.githubusercontent.com/parallel-pooler/pooler/master/LICENSE)
![.NET Version](https://img.shields.io/badge/.NET->=4.0-brightgreen.svg?style=plastic)

Windows Forms application test to measure threads limits, job counts, pausing miliseconds for optimal CPU load for your tasks.

## How to
- Clone or download project
- Open in Visual Studio and update Pooler NuGet package
- Open source file /Main/TestJob.cs and edit method `public void TestJob (Pooler.Base pool)`
    - replace demo code to find prime numbers with our task execution
- Run application and try to find optimal values for setting up your thread pool created with Pooler

## Printscreen
![Printscreen](https://raw.githubusercontent.com/parallel-pooler/winforms-application-test/master/gfx/printscreen.png)
