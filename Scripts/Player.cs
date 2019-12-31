using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private Animator myAnimator;
	
	private bool talk;
	
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }
	
	void FixedUpdate()
	{
		HandleAnimations();
	}
	
	private void HandleAnimations()
	{
		if(talk)
		{
			myAnimator.SetTrigger("Talking");
		}
	}
	
	private void HandleInput()
	{
		if(Input.GetKeyDown(KeyCode.LeftShift))
		{
			talk = true;
		}	//myAnimator.Play("talk");
	}
	
	
}