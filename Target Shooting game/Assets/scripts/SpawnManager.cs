using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public GameObject obj;
    private Vector3 spawnVector;
    public float xRangeStart=-45;
    public float xRangeEnd=45;
    public float zRangeStart=-45;
    public float zRangeEnd=45;
    private float startDelay = 0f;
    public float spawnInterval = 0.5f;
    private void Awake()
    {
        instance = this;


    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Spawn()
    {
            spawnVector = new Vector3(Random.Range(xRangeStart, xRangeEnd), 0, Random.Range(zRangeStart, zRangeEnd));
            Instantiate(obj, spawnVector, obj.transform.rotation);
    }
}