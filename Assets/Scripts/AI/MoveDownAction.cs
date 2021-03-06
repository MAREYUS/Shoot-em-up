﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/MoveDown")]
public class MoveDownAction : Action {

    public float speed = 1;

    public override void Act(StateController controller)
    {
        MoveDown(controller);
    }

    private void MoveDown(StateController controller)
    {
        //controller.navMeshAgent.Move(new Vector3(0,0,-1 * speed));
        controller.navMeshAgent.destination = new Vector3(controller.transform.position.x, 0, -5);
        controller.navMeshAgent.velocity = controller.navMeshAgent.transform.forward * speed;
        controller.navMeshAgent.isStopped = false;
    }

}
