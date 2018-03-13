using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerarAboboras : MonoBehaviour {

	public float limiteEsquerdo, limiteDireito, limiteFrontal, limiteTraseiro;
	public float frequencia;
	public GameObject aboboaPrefab;


	// Use this for initialization
	IEnumerator Start () {

		yield return new WaitForSeconds(Random.Range (0.5f, frequencia));
		Vector3 posicao;
		posicao.x = Random.Range (limiteEsquerdo, limiteDireito);
		posicao.y = transform.position.y;
		posicao.z = Random.Range (limiteFrontal, limiteTraseiro);
		Instantiate (aboboaPrefab, posicao, transform.rotation);
		StartCoroutine (Start ());

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
