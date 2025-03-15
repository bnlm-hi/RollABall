using UnityEngine;

public class Clone : MonoBehaviour
{
    GameObject mother;
    // Exposes a  float array in the inspector, which you can edit there.
    GameObject[] Clones;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mother = GameObject.Find("PickUp");
        Clones = new GameObject[10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int k = i * 2 + j;
                Clones[k] = GameObject.Instantiate(mother);
                Clones[k].transform.position = new Vector3(j, 2, i);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
