﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinATTACK : GoblinFSMState {

    public override void BeginState()
    {
        base.BeginState();
    }

    public override void EndState()
    {
        base.EndState();
    }

    private void Update()
    {
        if (Vector3.Distance(_manager.PlayerTransform.position, transform.position) >= _manager.Stat.AttackRange)
        {
            _manager.SetState(GoblinState.CHASE);
            return;
        }

    }
}
