// (c) Copyright HutongGames, LLC 2010-2012. All rights reserved.

using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Stop Recording sound from a microphone device")]
	public class MicrophoneStopRecording : FsmStateAction
	{

		[Tooltip("The name of the device. Passing null or an empty string will pick the default device. Get device names using the action MicrophoneGetDeviceById for example")]
		public FsmString deviceName;
		
		
		public override void Reset()
		{
			deviceName = "";			
		}

		public override void OnEnter()
		{
			Microphone.End(deviceName.Value);
		}
	}
}