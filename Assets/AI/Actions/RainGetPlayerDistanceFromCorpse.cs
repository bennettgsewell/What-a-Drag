using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class RainGetPlayerDistanceFromCorpse : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		//if(!ai.WorkingMemory.ItemExists("playerCorpseDistance"))
		ai.WorkingMemory.SetItem("playerCorpseDistance", WhatADragGame.playerDistanceFromCorpse());
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}