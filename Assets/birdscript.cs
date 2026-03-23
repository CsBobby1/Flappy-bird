using Unity.VisualScripting;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody1;
    public float flapstrength;
    public logicScript logic;
    private bool birdisalive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space) == true || Input.GetMouseButtonDown(0)) && birdisalive)
        {
            myrigidbody1.linearVelocity = Vector2.up * flapstrength;
            logic.loadScreen();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisalive = false;
    }
}
