using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class MyTimer : RAINAction
{
	private float startingTime;
	
    public override void Start(RAIN.Core.AI ai)
    {
    	if(!ai.WorkingMemory.ItemExists("timer"))
			ai.WorkingMemory.SetItem("timer", ai.Time);
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		if(ai.WorkingMemory.GetItem<float>("timer")+6f < ai.Time)
 	    	return ActionResult.SUCCESS;
 	    else
			return ActionResult.RUNNING;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}