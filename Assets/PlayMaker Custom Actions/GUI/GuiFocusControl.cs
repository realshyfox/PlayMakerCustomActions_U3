// (c) Copyright HutongGames, LLC 2010-2014. All rights reserved.
/*--- __ECO_ACTION__ ---*/

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Move keyboard focus to a named control.")]
	public class GuiFocusControl: FsmStateAction
	{
		[RequiredField]
		[Tooltip("The the name of the control to focus")]		
		public FsmString controlName;
		
		//public bool OnlyForce
		public override void Reset()
		{
			controlName = "control 1";
		}
		
		public override void OnGUI()
		{
			
			if (GUI.GetNameOfFocusedControl() == string.Empty)
			{
				GUI.FocusControl(controlName.Value);
			}
		}
	}
}