using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] section;
    int secNumber;
    public float zPos = 49;
    float position;
    bool cflag = false;
    public float timeforspawn = 10f;

    void Start()
    {
        position = zPos;
    }
    void Update()
    {
        if (cflag == false)
        {
            cflag = true;
            StartCoroutine(GenerateSection());

        }
    }

    List<int> usedValues = new List<int>();
    public int UniqueRandomInt(int min, int max)
    {
        int val = Random.Range(min, max);
        while (usedValues.Contains(val))
        {
            val = Random.Range(min, max);
        }
        return val;
    }

    IEnumerator GenerateSection()
    {
        secNumber = UniqueRandomInt(0, section.Length);
        Instantiate(section[secNumber], new Vector3(0, 0, position), Quaternion.identity);
        yield return new WaitForSeconds(timeforspawn);
        position += zPos;
        cflag = false;
    }

        
}
