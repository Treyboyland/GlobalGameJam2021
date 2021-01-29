using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCorrectClothes : MonoBehaviour
{
    [SerializeField]
    LaundryTime time = null;

    [SerializeField]
    GameObject mask = null;

    [SerializeField]
    GameObject clothes = null;

    public void ShowClothes()
    {
        mask.SetActive(time.ShouldSpawnMask);
        clothes.SetActive(time.ShouldSpawnClothes);
    }
}
