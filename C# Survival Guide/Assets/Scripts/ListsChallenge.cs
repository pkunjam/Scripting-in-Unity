using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsChallenge : MonoBehaviour {

    public List<GameObject> gObjects;
    public List<GameObject> ObjectsCreated;

    bool validity = true;

	void Update ()
    {
        if (ObjectsCreated.Count >= 10)
        {
            validity = false;

            foreach (var go in ObjectsCreated)
            {
                go.GetComponent<MeshRenderer>().material.color = Color.green;
            }

            ObjectsCreated.Clear();
        }

		if(Input.GetKeyDown(KeyCode.Space) && validity)
        {
            Vector3 RandomPosition = new Vector3 (Random.Range(-10, 10), Random.Range(-10, 10), 0);
            GameObject RandomObject = gObjects[Random.Range(0, gObjects.Count-1)];

            ObjectsCreated.Add(Instantiate(RandomObject, RandomPosition, Quaternion.identity));
        }
	}
}
