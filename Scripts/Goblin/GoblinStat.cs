using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinStat : CharacterStat
{
    public GoblinStatData stat;

    public void Awake()
    {
        Hp = stat.hp;
        MoveSpeed = stat.MoveSpeed;
        TurnSpeed = stat.TurnSpeed;
        AttackRange = stat.AttackRange;
    }
}
