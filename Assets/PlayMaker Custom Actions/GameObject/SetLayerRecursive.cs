// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Sets the layer and the layer of its children too")]
	public class SetLayerRecursive : FsmStateAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;
		
		[UIHint(UIHint.Layer)]
		public int layer;
		
		public bool children;


		public override void Reset()
		{
			gameObject = null;
			layer = 0;
			children = false;
		}

				
		public override void OnEnter()
		{
			DOSetLayer();	
		}
		
		public void DOSetLayer()
		{
			GameObject go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go == null) return;
				go.layer = layer;
			
			if (children)
			{
				foreach (Transform trans in go.GetComponentsInChildren<Transform>(true))
		        {
		
		            trans.gameObject.layer = layer;
		
		        }
			}
			Finish();
		}
		


	}
}