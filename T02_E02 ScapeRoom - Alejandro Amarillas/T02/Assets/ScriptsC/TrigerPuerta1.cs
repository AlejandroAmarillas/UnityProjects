using UnityEngine;
using System.Collections;

public class TrigerPuerta1 : MonoBehaviour {
	//Declaramos el game object para una de las compuertas, una variable del tipo animacion 
	//y otra booleana para saber cuando esta abierta la puerta.
	[SerializeField]
	private GameObject Puerta1;
	private Animation AnimacionPuerta;
	public bool Pabierta=false;



	void Start () {
		//A AnimacionPuerta le asiganmos el componente de animacion del gameObject Puerta1
		AnimacionPuerta = Puerta1.GetComponent<Animation> ();
	}
	
	void OnTriggerEnter(Collider co){
		//comprobamos que el gameobject que este en el triger sea el Pj y tenga la llave
		if (co.gameObject.GetComponent<Almacenamiento>().Llave && co.name == "Pj") {
					//ejecutamos al animaciond e abrir la puerta 1 y ponemos a true la booleana Pabierta.
					AnimacionPuerta.Play ("abrirP1");
					Pabierta = true;
				} else {
				
				Debug.Log("Es necesario obtener la llave que abre esta puerta");
				}



		}
	void OnTriggerExit(Collider co){
		//si salimos del triger y al puerta esta abierta, que ejecute la animacion de cerrar.
		if (Pabierta == true) {
			AnimacionPuerta.Play ("cerrarP1");
			Pabierta = false;
		}

	}
	
}
