using UnityEngine;
using System.Collections;

public class TrigerPuerta2 : MonoBehaviour {
	//Declaramos el game object para una de las compuertas, una variable del tipo animacion 
	//y otra booleana para saber cuando esta abierta la puerta.
	[SerializeField]
	private GameObject Puerta;
	private Animation AnimacionPuerta;
	private bool Pabierta =false;
	
	void Start () {
		//A AnimacionPuerta le asiganmos el componente de animacion del gameObject Puerta2
		AnimacionPuerta = Puerta.GetComponent<Animation> ();
	}
	
	void OnTriggerEnter(Collider co){
		//comprobamos que el gameobject que este en el triger sea el Pj y tenga la llave
		if (co.gameObject.GetComponent<Almacenamiento> ().Llave && co.name == "Pj") {
			//ejecutamos al animaciond e abrir la puerta 2 y ponemos a true la booleana Pabierta.
			AnimacionPuerta.Play ("abrirP2");
			Pabierta = true;
		} else {
			

		}
	}

	void OnTriggerExit(Collider co){
		//si salimos del triger y al puerta esta abierta, que ejecute la animacion de cerrar.
		if (Pabierta == true) {
			AnimacionPuerta.Play ("cerrarP2");
			Pabierta=false;
		}
	}
	
}
