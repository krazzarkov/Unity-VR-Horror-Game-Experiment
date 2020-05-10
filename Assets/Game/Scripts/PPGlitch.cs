using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPGlitch : MonoBehaviour
{
    public GameObject slender;
    private Animator animator;
    public float timeNotLooking = 0;
    private bool isLooking;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Vector3.Distance(slender.transform.position, transform.position);
        float angle = Vector3.Angle(transform.forward, slender.transform.position - transform.position);

        if (angle < 50 && distance < 15)
        {
            animator.SetBool("buzz", true);
            timeNotLooking = 0;
        }

        else
        {
            animator.SetBool("buzz", false);
            isLooking = false;
            timeNotLooking += Time.deltaTime;
        }
    }
}
