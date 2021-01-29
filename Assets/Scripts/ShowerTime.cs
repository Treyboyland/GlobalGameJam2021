using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerTime : MonoBehaviour
{
    [SerializeField]
    float timeInShower = 0;

    [SerializeField]
    ItemSO self = null;

    [SerializeField]
    ItemSO clothes = null;

    [SerializeField]
    ItemSO mask = null;

    [SerializeField]
    ItemStateSO wetState = null;

    [SerializeField]
    Player player = null;

    [SerializeField]
    GameEvent playerWetEvent = null;

    [SerializeField]
    GameEvent maskWetEvent = null;

    [SerializeField]
    GameEvent clothesWet = null;

    [SerializeField]
    bool inShower = false;

    public bool InShower { get { return inShower; } set { inShower = value; } }

    float currentTime = 0;

    bool eventFired = false;

    // Update is called once per frame
    void Update()
    {
        if (InShower)
        {
            currentTime += Time.deltaTime;
            if (currentTime > timeInShower && !eventFired)
            {
                eventFired = true;
                player.ChangeItemState(self, wetState);
                player.ChangeItemState(clothes, wetState);
                player.ChangeItemState(mask, wetState);
                if (player.HasItem(clothes))
                {
                    clothesWet.Invoke();
                }
                if (player.HasItem(mask))
                {
                    maskWetEvent.Invoke();
                }
                playerWetEvent.Invoke();
            }
        }
    }
}
