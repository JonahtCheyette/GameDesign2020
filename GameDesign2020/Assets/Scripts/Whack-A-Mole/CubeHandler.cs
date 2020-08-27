using UnityEngine;

public class CubeHandler : MonoBehaviour {
    [HideInInspector]
    public GameObject[] cubes;
    [HideInInspector]
    public Bounds[] cubeBounds;

    public int seed = 0;

    System.Random rand;

    void Start() {
        cubes = new GameObject[gameObject.transform.childCount];
        cubeBounds = new Bounds[gameObject.transform.childCount];
        for (int i = 0; i < gameObject.transform.childCount; i++) {
            cubes[i] = gameObject.transform.GetChild(i).gameObject;
            cubes[i].SetActive(false);
            cubeBounds[i] = new Bounds(cubes[i].transform.position, cubes[i].transform.localScale);
        }
        rand = new System.Random(seed);
    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < cubes.Length; i++) {
            if(rand.Next(0, 600) < 1) {
                cubes[i].SetActive(true);
            }
        }
    }
}
