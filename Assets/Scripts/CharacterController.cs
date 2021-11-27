using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
        private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
         anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
   public void PlayBuenosDias(){
       anim.Play("dias");
   }

   public void PlayHola(){
       anim.Play("hola");
   }
}
