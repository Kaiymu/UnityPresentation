using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    private Animator _myAnimator;
    private void Start()
    {
        _myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _myAnimator.SetTrigger("GoLeftRight");
        } else if (Input.GetKeyDown(KeyCode.Z))
        {
            _myAnimator.SetTrigger("GoTopBottom");
        }
    }
}
