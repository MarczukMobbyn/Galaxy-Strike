using NUnit.Framework;
using UnityEngine;

public class PlayerHelper : MonoBehaviour
{
    [SerializeField] GameObject[] laserList;
    void ChangeLaserState()
    {
        foreach(GameObject laser in laserList)
        {
            if (laser != null)
            {
                laser.SetActive(!laser.activeSelf);
            }
        }
    }
}
