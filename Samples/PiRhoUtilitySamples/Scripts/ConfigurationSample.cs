﻿using UnityEngine;

namespace PiRhoSoft.Utilities
{
	[AddComponentMenu("PiRho Utilities/Configuration")]
	public class ConfigurationSample : MonoBehaviour
	{
		[Multiline]
		public string MultilineText;

		[ReadOnly]
		public string ReadOnly = "Disabled control";

		[Stretch]
		public string Stretch;

		[Multiline]
		[Stretch]
		public string MultilineStretch;

		[Placeholder("placeholder")]
		public string Placeholder;

		[ChangeTrigger(nameof(Changed))]
		[Placeholder("validates on enter")]
		[Delay]
		public string DelayValidation;
		private void Changed() => Debug.Log("Changed", this);

		[NoLabel]
		public string NoLabel = "I don't have a label";

		[CustomLabel("Show/Hide")]
		public bool Toggle;

		public int ConditionalInt;
	}
}