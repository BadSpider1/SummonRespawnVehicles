using Exiled;
using Exiled.API;
using CommandSystem;
using System.Collections.Generic;
using System;


[CommandHandler(typeof(RemoteAdminCommandHandler))]
public class HeliCommand : ICommand
{
    public string Command { get; } = "heli";
    public string[] Aliases { get; } = new string[] {  };
    public string Description { get; } = "This comand will summon the NTF Helicopter";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        response = "The MTF helicopter is on it's way.";
        Exiled.API.Features.Respawn.SummonNtfChopper();
        return true;
    }
}

[CommandHandler(typeof(RemoteAdminCommandHandler))]
public class CarCommand : ICommand
{
    public string Command { get; } = "car";
    public string[] Aliases { get; } = new string[] {  };
    public string Description { get; } = "This command will summon the CI Van";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        response = "The CI Car is on it's way.";
        Exiled.API.Features.Respawn.SummonChaosInsurgencyVan();
        return true;
    }
}