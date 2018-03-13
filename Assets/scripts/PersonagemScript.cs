using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemScript : MonoBehaviour {


	public float velocidade;
	public GameObject personagem;
	Animation anim;
	Vector3 novaPosicao;



	void Start () {

		// captura a posicao o personagem
		novaPosicao = transform.position;
		anim = personagem.GetComponent<Animation> ();
	
		//Define a animação inicial o personagem
		anim.CrossFade("idle");

	}
	
	// Update is called once per frame
	void Update () {

		// touch ou clique do mouse
		if (Input.GetButton ("Fire1")) {

			// transfoma o toque na tela em uma coordenada 3d
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			//obtem a nova posicao

			if (Physics.Raycast (ray, out hit)) {
				novaPosicao = hit.point;
			}

			// move o personagem
			transform.position = Vector3.MoveTowards (transform.position,
				novaPosicao, velocidade * Time.deltaTime);
			transform.LookAt (hit.point);

			anim.CrossFade ("run");
		} else {
			//animacao e idle
			anim.CrossFade ("idle");
		}
}
}
