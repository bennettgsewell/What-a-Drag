using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class RecordLastPlayerLocation : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
    	Vector3 v = GameObject.FindGameObjectWithTag("Player").transform.position;
		v = new Vector3(v.x,v.y,v.z);
		ai.WorkingMemory.SetItem("lastLocationOfPlayer", v);
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}