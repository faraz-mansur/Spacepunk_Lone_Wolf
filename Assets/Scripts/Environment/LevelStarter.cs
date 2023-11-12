// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LevelStarter : MonoBehaviour
// {
//     public GameObject countdown3;
//     public GameObject countdown2;
//     public GameObject countdown1;
//     public GameObject countdownGo;

//     // Start is called before the first frame update
//     void Start()
//     {
//         StartCoroutine(CountSequence()); 
//     }

//     IEnumerator CountSequence()
//     {
//         yield return new WaitForSeconds(1);
//         countdown3.SetActive(true);
//         yield return new WaitForSeconds(1);
//         countdown2.SetActive(true);
//         yield return new WaitForSeconds(1);
//         countdown1.SetActive(true);
//         yield return new WaitForSeconds(1);
//         countdownGo.SetActive(true);
//         PlayerMove.canMove = true;
//     }

// }
