﻿using Spectre.Console;

namespace TCSA.OOP.LibraryManagementSystem.Controllers;

internal abstract class BaseController
{
    protected void DisplayMessage(string message, string color = "yellow")
    {
        AnsiConsole.MarkupLine($"[{color}]{message}[/]");
    }

    protected bool ConfirmDeletion(string itemName)
    {
        var confirm = AnsiConsole.Confirm($"Are you sure you want to delte [red]{itemName}[/]?");
        return confirm;
    }
}
