using Exiled;
using Exiled.API;
using Exiled.Permissions;
using Exiled.Permissions.Extensions;
using Exiled.Permissions.Features;
using CommandSystem;
using System.Collections.Generic;
using System;


[CommandHandler(typeof(RemoteAdminCommandHandler))]
public class HeliCommand : ICommand
{
    public string Command { get; } = "heli";
    public string[] Aliases { get; } = new string[] { };
    public string Description { get; } = "This comand will summon the NTF Helicopter";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        if (RoundSummary.RoundInProgress())
        {
            if (!sender.CheckPermission("srv.heli"))
            {
                response = "You do not have permissions to use this command!";
                return false;
            }
            else
                {
                    response = "The MTF helicopter is on it's way.";
                    Exiled.API.Features.Respawn.SummonNtfChopper();
                    return true;
                }
            }
            else
            {
            response = "You must first start the round!";
                return false;
            }
        }
    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
public class CarCommand : ICommand
{
    public string Command { get; } = "car";
    public string[] Aliases { get; } = new string[] { };
    public string Description { get; } = "This command will summon the CI Van";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        if (RoundSummary.RoundInProgress())
        {
            if (!sender.CheckPermission("srv.car"))
            {
                response = "You do not have permissions to use this command!";
                return false;
            }
            else
            {
                response = "The CI car is on it's way!";
                Exiled.API.Features.Respawn.SummonChaosInsurgencyVan();
                return true;
            }
        }
        else
        {
            response = "You must first start the round!";
            return false;
        }
    }
}