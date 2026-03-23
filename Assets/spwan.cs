using UnityEngine;

public class spwan : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate=2;
    private float time=0;
    public float heightOffSet = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(pipe,transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnrate)
        {
            time += Time.deltaTime;
        }
        else
        {
            sapwning();
            time = 0;
        }
        
    }

    void sapwning()
    {
        float lowestpoint = transform.position.y - heightOffSet;
        float highestpoint = transform.position.y+ heightOffSet;
        Instantiate(pipe ,new Vector3(transform.position.x ,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }

}
