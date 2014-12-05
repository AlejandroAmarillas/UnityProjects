using UnityEngine;
using System.Collections;

public class RecogerLlave : MonoBehaviour {
	[SerializeField]
	private GameObject Llave;
	

	void OnTriggerEnter(Collider co){
		Debug.Log(co.gameObject.name);
		if (co.gameObject.name == "Pj") {
			co.gameObject.GetComponent<Almacenamiento>().Llave = true;
			Destroy (Llave);
				}
	}
	 
}
