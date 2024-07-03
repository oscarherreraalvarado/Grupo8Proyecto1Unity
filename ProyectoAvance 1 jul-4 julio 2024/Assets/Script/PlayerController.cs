using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalmove;
    private float verticalmove;
    public CharacterController player;

    public float playerspeed;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
      horizontalmove = Input.GetAxis("Horizontal");
      verticalmove = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        player.Move(new Vector3(horizontalmove,0,verticalmove)* playerspeed * Time.deltaTime); 
    }
}
