using System;
using Dalamud.Plugin;
using Dalamud.Game.ClientState.Actors.Types;
using Dalamud.Game.ClientState.Actors.Types.NonPlayer;
using Dalamud.Game.ClientState.Structs;

namespace DeepDungeonDex
{
	public class TargetData
	{
		public static int NameID { get; set; }
		public static string Name { get; set; }
		plublic static StatusEffect[] StatusEffects;

		public bool IsValidTarget(Actor target)
		{
			if (target is BattleNpc bnpc)
			{
				Name = bnpc.Name;
				NameID = bnpc.NameId;
				StatusEffects = bnpc.StatusEffects;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
