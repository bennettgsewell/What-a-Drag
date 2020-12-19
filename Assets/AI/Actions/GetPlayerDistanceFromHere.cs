using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class GetPlayerDistanceFromHere : RAINAction
{
	public override void Start(RAIN.Core.AI ai)
	{
		base.Start(ai);
	}
	
	public override ActionResult Execute(RAIN.Core.AI ai)
	{
		ai.WorkingMemory.SetItem("playerDistanceFromHere", WhatADragGame.playerDistanceFromHere(ai.Body.transform.position));
		return ActionResult.SUCCESS;
	}
	
	public override void Stop(RAIN.Core.AI ai)
	{
		base.Stop(ai);
	}
}