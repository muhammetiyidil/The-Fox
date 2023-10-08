using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public AudioSource jumpSound;
	public AudioClip jumpClip;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	public TextMeshProUGUI winText;
	public GameObject WinBtn;

    private void Start()
    {
        jumpSound.clip = jumpClip;
    }

    // Update is called once per frame
    void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		
		

		if (Input.GetButtonDown("Jump"))
		{
			jumpSound.Play();
			jump = true;
            animator.SetBool("IsJumping", jump);
        }

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
			animator.SetBool("IsCrouching", crouch);
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
            animator.SetBool("IsCrouching", crouch);
        }
	}

	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.CompareTag("FinishPlain"))
		{
			 winText.gameObject.SetActive(true);
			WinBtn.gameObject.SetActive(true);
		}
    }
}
