using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float YToKill = -10;

    void Update()
    {
        if (player.transform.position.y < YToKill)
        {
            SceneManager.LoadScene(1);
        }
    }
}
