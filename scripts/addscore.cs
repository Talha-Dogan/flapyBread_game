using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addscore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Score.score++;
    }
}
