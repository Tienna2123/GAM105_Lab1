using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoController : MonoBehaviour
{
    AudioSource _do, _re, _mi, _fa, _son, _la, _si;
    // Start is called before the first frame update
    void Start()
    {
        _do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("Mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("Fa").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("Son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("La").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("Si").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(message: "Press A");
            _do.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(message: "Press S");
            _re.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(message: "Press D");
            _mi.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(message: "Press F");
            _fa.Play();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(message: "Press G");
            _son.Play();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log(message: "Press H");
            _la.Play();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log(message: "Press J");
            _si.Play();
        }

    }
}
