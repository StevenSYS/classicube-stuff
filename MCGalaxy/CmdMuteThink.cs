using System;
using MCGalaxy;
using MCGalaxy.Events;

public class CmdMuteThink : Command {
	public override string name { get { return "MuteThink"; } }
	public override string shortcut { get { return "MT"; } }
	public override string type { get { return "other"; } }
	public override bool museumUsable { get { return true; } }
	public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

	public override void Use(Player p, string message) {
                TimeSpan duration = new TimeSpan(0, 0, 10);
                ModAction action = new ModAction(p.name, p, ModActionType.Muted, p.ColoredName + "%f typed /MuteThink so " + p.pronouns.Subject + " can think.", duration);
                OnModActionEvent.Call(action);
	}

	public override void Help(Player p) {
		p.Message("&T/MuteThink");
		p.Message("&HMutes you for 10 seconds so you can think");
	}
}