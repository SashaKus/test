using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExperienceBar : ABar
{
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    private Player player;

    public override void SetLocalParams()
    {
        player = GameManager.player.GetComponent<Player>();
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }

    public override float UpdateCount()
    {
        return player.experience / player.requiredExperience;
    }
}
