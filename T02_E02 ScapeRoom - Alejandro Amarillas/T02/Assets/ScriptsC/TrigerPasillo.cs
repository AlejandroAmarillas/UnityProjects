using UnityEngine;
using System.Collections;
//Creamos la clase para el Triger del pasillo
public class TrigerPasillo : MonoBehaviour {
	//Declaramos la variable Transporte (el objeto que queremos transportar)
	[SerializeField]
	private GameObject Transporte;
	//Game Object al que queremos transportar al objeto.
	[SerializeField]
	private GameObject Destino;
	//Declaramos la variable Teleport a la que asignaremos las coordenadas 
	//del lugar del destino(GameObject Destino)
	[SerializeField]
	private Vector3 Teleport;

	void Start(){
		//A la variable Teleport le asignamos las coordenadas del game Object de destino
		Teleport = Destino.transform.position;

		}

	void OnTriggerEnter(Collider co){
		//Una vez entremos en el Triger, asignamos al personaje las coordenadas del destino
		Transporte.transform.position = Teleport;

	}
}
